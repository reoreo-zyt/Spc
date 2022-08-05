using MathNet.Numerics.Statistics;
using SpcTest.src;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpcTest
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class Form1 : Form
    {
        #region 属性

        private readonly string path = Environment.CurrentDirectory + "\\src\\Echarts";
        private Parameter parameter;
        private DataTable dt;

        // 计量型参数
        private double Maximum;
        private double Minimum;
        private double Range;
        private double MoveRanges;
        private double StandardDeviation;
        // 上下规格线
        private double LSL;
        private double USL;

        private double CP;
        private double Cmk;
        private double Cr;
        private double Cpl;
        private double Cpu;
        private double Cpk;
        private double M;
        private double K;

        // 均值
        private double mean;
        // 均值数组
        private double[] means;
        // 均值平均
        private double meansAverage;

        // 标准差
        private double standardDeviation;
        // 标准差数组
        private double[] standardDeviations;
        // 标准差平均
        private double standardDeviationsAverage;

        // 极差
        private double range;
        // 极差数组
        private double[] ranges;
        // 极差平均
        private double rangesAverage;

        // 移动极差
        private double moveRange;
        // 移动极差数组
        private double[] moveRanges;
        // 移动极差平均
        private double moveRangesAverage;

        // 单值
        private double singleValue;
        // 单值数组
        private double[] singleValues;
        // 单值平均
        private double singleValueAverage;

        // 中位数
        private double middle;
        // 中位数数组
        private double[] middles;
        // 中位数平均
        private double middlesAverage;

        // 标准差上下限值
        private double UCLStandardDeviation;
        private double CLStandardDeviation;
        private double LCLStandardDeviation;

        // Xbar-S 均值图上下限值
        private double UCLMeanS;
        private double CLMeanS;
        private double LCLMeanS;

        // 极差上下限值
        private double UCLRange;
        private double CLRange;
        private double LCLRange;

        // Xbar-R 均值图上下限值
        private double UCLMeanR;
        private double CLMeanR;
        private double LCLMeanR;

        // X-R 中位数图上下限值
        private double UCLMiddle;
        private double CLMiddle;
        private double LCLMiddle;

        // X-MR 单值-移动极差图上下控制限
        private double UCLSingleValue;
        private double CLSingleValue;
        private double LCLSingleValue;

        private double UCLMoveRange;
        private double CLMoveRange;
        private double LCLMoveRange;

        // 组数，默认为 5 组（国标推荐样本量为4或5。）
        private int calcNum = 5;

        #endregion 属性

        public Form1()
        {
            parameter = new Parameter();
            InitializeComponent();
            InitializeEcharts();
            GetAllHtmlFile();
            LoadData();
            CalcData(calcNum);
        }

        public void InitializeEcharts()
        {
            webBrowserEchart.AllowWebBrowserDrop = false;
            webBrowserEchart.IsWebBrowserContextMenuEnabled = false;
            webBrowserEchart.WebBrowserShortcutsEnabled = false;
            webBrowserEchart.ScriptErrorsSuppressed = true;
            webBrowserEchart.ObjectForScripting = this;
        }

        private void GetAllHtmlFile()
        {
            string[] paths = Directory.GetFiles(path);
            foreach (string item in paths)
            {
                string extension = Path.GetExtension(item).ToLower();
                if (extension == ".html")
                {
                    SelectChartMode.Items.Add(Path.GetFileName(item).Replace(".html", ""));
                }
            }

            if (SelectChartMode.Items.Count > 0)
            {
                SelectChartMode.SelectedIndex = 0;
                webBrowserEchart.Url = new Uri(path + "\\" + SelectChartMode.Text.Trim() + ".html");
            }
        }

        private void LoadData()
        {
            // TODO: 从文件夹中读取文件数据
            CSVHelper.ReadCSV("./src/data/20220728233651_1_s.csv", out dt);

            // 绑定数据源
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            showDataGrid.DataSource = bs;
        }

        // spc 计算公式: https://max.book118.com/html/2018/0816/8075132041001120.shtm
        private void CalcData(int calcNum)
        {
            // 均值数组
            means = new double[calcNum];
            // 标准差数组
            standardDeviations = new double[calcNum];
            // 极差数组
            ranges = new double[calcNum];
            // 中位数数组
            middles = new double[calcNum];
            // 移动极差数组
            moveRanges = new double[calcNum];
            // 单值数组
            singleValues = new double[calcNum];

            var j = 0;
            // 计算均值和标准差，然后汇总到数组中
            // 保留最新（即最后面的） 25 组数据（假如 calcNum 为 25）
            double[] maxArray = new double[calcNum];
            double[] minArray = new double[calcNum];

            for (int i = dt.Rows.Count - calcNum; i < dt.Rows.Count; i++)
            {
                // 处理数组，保留分区 1-11 部分，将 object 数组转化为 double 数组
                double[] calcData = ConvertToDouble(i);

                // 计算这一行的均值, 标准差, 极差, 中位数, 单值
                mean = calcData.Mean();
                standardDeviation = calcData.StandardDeviation();
                range = calcData.Max() - calcData.Min();
                middle = calcData.Median();
                singleValue = mean; // 过程均值（单值读数之和除以读数的个数，按常规记为X）

                // 计算最大值、最小值
                var max = calcData.Max();
                var min = calcData.Min();

                // 计算移动极差（移动极差就是行的后一个值减去前一个值）
                for (int k = 0; k < calcData.Length - 1; k++)
                {
                    moveRange = calcData[k + 1] - calcData[k];
                }

                // 添加进数组
                means[j] = mean;
                standardDeviations[j] = standardDeviation;
                ranges[j] = range;
                middles[j] = middle;
                moveRanges[j] = moveRange;
                singleValues[j] = singleValue;
                maxArray[j] = max;
                minArray[j] = min;

                j++;
            }

            meansAverage = means.Mean();
            standardDeviationsAverage = standardDeviations.Mean();
            rangesAverage = ranges.Mean();
            middlesAverage = middles.Mean();
            moveRangesAverage = moveRanges.Mean();
            singleValueAverage = meansAverage;

            Maximum = maxArray.Max();
            Minimum = minArray.Min();
            Range = Maximum - Minimum;
            MoveRanges = moveRangesAverage;
            StandardDeviation = standardDeviationsAverage;
            CP = Math.Abs(USL - LSL) / (6 * StandardDeviation);
            Cmk = Math.Abs(USL - LSL) / (8 * StandardDeviation);
            Cr = (6 * StandardDeviation) / Math.Abs(USL - LSL);
            Cpl = Math.Abs(meansAverage - LSL) / (3 * StandardDeviation);
            Cpu = Math.Abs(USL - meansAverage) / (3 * StandardDeviation);
            Cpk = Math.Min(Cpl, Cpu);
            M = (USL + LSL) / 2;
            K = (Math.Abs(M - meansAverage)) / ((USL - LSL) / 2 );

            // 关于控制图系数:https://www.docin.com/p-1218248225.html

            // x-bar-S 图(均值-标准差图)
            // 计算公式:https://www.docin.com/p-189629227.html
            // 计算标准差图控制限，子组为选择的 calcNum
            UCLStandardDeviation = parameter.controlChartDictionaries[calcNum]["B4"] * standardDeviationsAverage;
            CLStandardDeviation = standardDeviationsAverage;
            LCLStandardDeviation = parameter.controlChartDictionaries[calcNum]["B3"] * standardDeviationsAverage;

            // 计算均值图控制限
            UCLMeanS = meansAverage + parameter.controlChartDictionaries[calcNum]["A3"] * standardDeviationsAverage;
            CLMeanS = meansAverage;
            LCLMeanS = meansAverage - parameter.controlChartDictionaries[calcNum]["A3"] * standardDeviationsAverage;

            // x-bar-R 图(均值-极差图)
            // 计算公式:https://www.docin.com/p-1813885527.html
            // 计算极差图控制限
            UCLRange = parameter.controlChartDictionaries[calcNum]["D4"] * rangesAverage;
            CLRange = rangesAverage;
            LCLRange = parameter.controlChartDictionaries[calcNum]["D3"] * rangesAverage;

            // 计算均值图控制限
            UCLMeanR = meansAverage + (parameter.controlChartDictionaries[calcNum]["A2"] * rangesAverage);
            CLMeanR = meansAverage;
            LCLMeanR = meansAverage - (parameter.controlChartDictionaries[calcNum]["A2"] * rangesAverage);

            // x-R 图（中位数-极差图）
            // 计算公式:https://baike.baidu.com/item/%E4%B8%AD%E4%BD%8D%E6%95%B0-%E6%9E%81%E5%B7%AE%E6%8E%A7%E5%88%B6%E5%9B%BE/22681846
            // 计算中位数控制限
            UCLMiddle = middlesAverage + parameter.controlChartDictionaries[calcNum]["m3A2"] * rangesAverage;
            CLMiddle = middlesAverage;
            LCLMiddle = middlesAverage - parameter.controlChartDictionaries[calcNum]["m3A2"] * rangesAverage;

            // x-MR 图（单值-移动极差图）
            // 计算公式:https://www.infinityqs.cn/Resources/SPC/1125.html
            // 计算移动极差图控制限
            UCLMoveRange = parameter.controlChartDictionaries[calcNum]["D4"] * moveRangesAverage;
            CLMoveRange = moveRangesAverage;
            LCLMoveRange = parameter.controlChartDictionaries[calcNum]["D3"] * moveRangesAverage;
            // 计算单值图控制限
            // TODO:
            UCLSingleValue = singleValueAverage + parameter.controlChartDictionaries[calcNum]["A2"] * moveRangesAverage;
            CLSingleValue = singleValueAverage;
            LCLSingleValue = singleValueAverage - parameter.controlChartDictionaries[calcNum]["A2"] * moveRangesAverage;

            GetInput();
        }

        public void GetInput()
        {
            meanInput.Text = Convert.ToString(meansAverage);
            meanInput.Enabled = false;

            inputMaximum.Text = Convert.ToString(Maximum);
            inputMaximum.Enabled = false;

            inputMinutes.Text = Convert.ToString(Minimum);
            inputMinutes.Enabled = false;

            inputRange.Text = Convert.ToString(Range);
            inputRange.Enabled = false;

            inputMoveRange.Text = Convert.ToString(MoveRanges);
            inputMoveRange.Enabled = false;

            inputStandradDiv.Text = Convert.ToString(StandardDeviation);
            inputStandradDiv.Enabled = false;

            inputCp.Text = Convert.ToString(CP);
            inputCp.Enabled = false;

            inputCmk.Text = Convert.ToString(Cmk);
            inputCmk.Enabled = false;

            inputCr.Text = Convert.ToString(Cr);
            inputCr.Enabled = false;

            inputCpl.Text = Convert.ToString(Cpl);
            inputCpl.Enabled = false;

            inputCpu.Text = Convert.ToString(Cpu);
            inputCpu.Enabled = false;

            inputCpk.Text = Convert.ToString(Cpk);
            inputCpk.Enabled = false;

            inputK.Text = Convert.ToString(K);
            inputK.Enabled = false;
        }

        // 使用 window.external.方法的方式调用此处的 C# 函数
        // 对于变量，可以简单地返回，GetData
        // 对于数组，可以先拼接成字符串返回，再在html页面通过 split() 拼接为数组。GetArrayData
        public double GetData(string name)
        {
            switch (name)
            {
                case "UCLStandardDeviation":
                    return UCLStandardDeviation;

                case "CLStandardDeviation":
                    return CLStandardDeviation;

                case "LCLStandardDeviation":
                    return LCLStandardDeviation;

                case "UCLMeanS":
                    return UCLMeanS;

                case "CLMeanS":
                    return CLMeanS;

                case "LCLMeanS":
                    return LCLMeanS;

                case "LCLRange":
                    return LCLRange;

                case "CLRange":
                    return CLRange;

                case "UCLRange":
                    return UCLRange;

                case "UCLMeanR":
                    return UCLMeanR;

                case "CLMeanR":
                    return CLMeanR;

                case "LCLMeanR":
                    return LCLMeanR;

                case "UCLMiddle":
                    return UCLMiddle;

                case "CLMiddle":
                    return CLMiddle;

                case "LCLMiddle":
                    return LCLMiddle;

                case "UCLMoveRange":
                    return UCLMoveRange;

                case "CLMoveRange":
                    return CLMoveRange;

                case "LCLMoveRange":
                    return LCLMoveRange;

                case "UCLSingleValue":
                    return UCLSingleValue;

                case "CLSingleValue":
                    return CLSingleValue;

                case "LCLSingleValue":
                    return LCLSingleValue;

                case "calcNum":
                    return calcNum;

                default:
                    break;
            }

            return -1;
        }

        public string GetArrayData(string name, int range)
        {
            switch (name)
            {
                // 返回 1 - range 的 double 类型数组
                case "serialX":
                    return string.Join(";", Enumerable.Range(1, range).Select(x => Convert.ToDouble(x)).ToArray());
                case "means":
                    return string.Join(";", means);
                case "standardDeviations":
                    return string.Join(";", standardDeviations);
                case "ranges":
                    return string.Join(";", ranges);
                case "middles":
                    return string.Join(";", middles);
                case "singleValues":
                    return string.Join(";", singleValues);
                case "moveRanges":
                    return string.Join(";", moveRanges);
                default:
                    break;
            }

            return string.Join(";", "-1");
        }

        // 将 datatable 的 object[] 转化为 double[]
        private double[] ConvertToDouble(int index)
        {
            // 保留分区1-11列的数据
            double[] calcTemp = new double[11];
            object[] calcData = dt.Rows[index].ItemArray.Skip(3).Take(11).ToArray();

            for (int i = 0; i < calcData.Length; i++)
            {
                calcTemp[i] = Convert.ToDouble(calcData[i]);
            }

            return calcTemp;
        }

        private void SelectChartMode_Click(object sender, EventArgs e)
        {
            // SelectChartMode.Items.Clear();
            // this.GetAllHtmlFile();
        }

        private void SelectChartMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowserEchart.Url = new Uri(path + "\\" + SelectChartMode.Text.Trim() + ".html");
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
        }

        private void measureListNums_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcNum = Convert.ToInt32(measureListNums.Items[measureListNums.SelectedIndex].ToString());
            CalcData(calcNum);
            webBrowserEchart.Url = new Uri(path + "\\" + SelectChartMode.Text.Trim() + ".html");
        }

        private void inputUSL_TextChanged(object sender, EventArgs e)
        {
            USL = Convert.ToDouble(inputUSL.Text);
            calcInput();
        }

        private void inputLSL_TextChanged(object sender, EventArgs e)
        {
            LSL = Convert.ToDouble(inputLSL.Text);
            calcInput();
        }

        private void calcInput()
        {
            CP = Math.Abs(USL - LSL) / (6 * StandardDeviation);
            Cmk = Math.Abs(USL - LSL) / (8 * StandardDeviation);
            Cr = (6 * StandardDeviation) / Math.Abs(USL - LSL);
            Cpl = Math.Abs(meansAverage - LSL) / (3 * StandardDeviation);
            Cpu = Math.Abs(USL - meansAverage) / (3 * StandardDeviation);
            Cpk = Math.Min(Cpl, Cpu);
            K = (Math.Abs(M - meansAverage)) / ((USL - LSL) / 2);

            GetInput();
        }
    }
}