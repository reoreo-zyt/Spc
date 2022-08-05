
namespace SpcTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowserEchart = new System.Windows.Forms.WebBrowser();
            this.SelectChartMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.showDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.measureListNums = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.meanInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputMaximum = new System.Windows.Forms.TextBox();
            this.inputMinutes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inputRange = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputMoveRange = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inputStandradDiv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.inputUSL = new System.Windows.Forms.TextBox();
            this.inputLSL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.inputCp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.inputCmk = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.inputCr = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.inputCpl = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.inputCpu = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.inputCpk = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.inputK = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowserEchart
            // 
            this.webBrowserEchart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowserEchart.Location = new System.Drawing.Point(3, 6);
            this.webBrowserEchart.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserEchart.Name = "webBrowserEchart";
            this.webBrowserEchart.Size = new System.Drawing.Size(1890, 654);
            this.webBrowserEchart.TabIndex = 0;
            this.webBrowserEchart.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // SelectChartMode
            // 
            this.SelectChartMode.FormattingEnabled = true;
            this.SelectChartMode.Location = new System.Drawing.Point(138, 56);
            this.SelectChartMode.Name = "SelectChartMode";
            this.SelectChartMode.Size = new System.Drawing.Size(189, 23);
            this.SelectChartMode.TabIndex = 1;
            this.SelectChartMode.SelectedIndexChanged += new System.EventHandler(this.SelectChartMode_SelectedIndexChanged);
            this.SelectChartMode.Click += new System.EventHandler(this.SelectChartMode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "统计图表方法";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 146);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1904, 692);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.showDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1896, 663);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "展示数据";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // showDataGrid
            // 
            this.showDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showDataGrid.Location = new System.Drawing.Point(0, 0);
            this.showDataGrid.Name = "showDataGrid";
            this.showDataGrid.RowHeadersWidth = 51;
            this.showDataGrid.RowTemplate.Height = 27;
            this.showDataGrid.Size = new System.Drawing.Size(1896, 663);
            this.showDataGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowserEchart);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1896, 663);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "spc 统计分析";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(15, 12);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(108, 31);
            this.loadDataButton.TabIndex = 5;
            this.loadDataButton.Text = "载入数据";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "样品组数";
            // 
            // measureListNums
            // 
            this.measureListNums.FormattingEnabled = true;
            this.measureListNums.ItemHeight = 15;
            this.measureListNums.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.measureListNums.Location = new System.Drawing.Point(138, 95);
            this.measureListNums.Name = "measureListNums";
            this.measureListNums.Size = new System.Drawing.Size(189, 34);
            this.measureListNums.TabIndex = 8;
            this.measureListNums.SelectedIndexChanged += new System.EventHandler(this.measureListNums_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "均值";
            // 
            // meanInput
            // 
            this.meanInput.Location = new System.Drawing.Point(434, 49);
            this.meanInput.Name = "meanInput";
            this.meanInput.Size = new System.Drawing.Size(100, 25);
            this.meanInput.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "最大值";
            // 
            // inputMaximum
            // 
            this.inputMaximum.Location = new System.Drawing.Point(434, 84);
            this.inputMaximum.Name = "inputMaximum";
            this.inputMaximum.Size = new System.Drawing.Size(100, 25);
            this.inputMaximum.TabIndex = 12;
            // 
            // inputMinutes
            // 
            this.inputMinutes.Location = new System.Drawing.Point(434, 115);
            this.inputMinutes.Name = "inputMinutes";
            this.inputMinutes.Size = new System.Drawing.Size(100, 25);
            this.inputMinutes.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "最小值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(569, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "极差";
            // 
            // inputRange
            // 
            this.inputRange.Location = new System.Drawing.Point(643, 49);
            this.inputRange.Name = "inputRange";
            this.inputRange.Size = new System.Drawing.Size(100, 25);
            this.inputRange.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "移动极差";
            // 
            // inputMoveRange
            // 
            this.inputMoveRange.Location = new System.Drawing.Point(643, 84);
            this.inputMoveRange.Name = "inputMoveRange";
            this.inputMoveRange.Size = new System.Drawing.Size(100, 25);
            this.inputMoveRange.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(569, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "标准差";
            // 
            // inputStandradDiv
            // 
            this.inputStandradDiv.Location = new System.Drawing.Point(643, 122);
            this.inputStandradDiv.Name = "inputStandradDiv";
            this.inputStandradDiv.Size = new System.Drawing.Size(100, 25);
            this.inputStandradDiv.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(773, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "USL";
            // 
            // inputUSL
            // 
            this.inputUSL.Location = new System.Drawing.Point(810, 46);
            this.inputUSL.Name = "inputUSL";
            this.inputUSL.Size = new System.Drawing.Size(100, 25);
            this.inputUSL.TabIndex = 22;
            this.inputUSL.TextChanged += new System.EventHandler(this.inputUSL_TextChanged);
            // 
            // inputLSL
            // 
            this.inputLSL.Location = new System.Drawing.Point(810, 84);
            this.inputLSL.Name = "inputLSL";
            this.inputLSL.Size = new System.Drawing.Size(100, 25);
            this.inputLSL.TabIndex = 23;
            this.inputLSL.TextChanged += new System.EventHandler(this.inputLSL_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(773, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "LSL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(773, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Cp";
            // 
            // inputCp
            // 
            this.inputCp.Location = new System.Drawing.Point(810, 125);
            this.inputCp.Name = "inputCp";
            this.inputCp.Size = new System.Drawing.Size(100, 25);
            this.inputCp.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(941, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Cmk";
            // 
            // inputCmk
            // 
            this.inputCmk.Location = new System.Drawing.Point(994, 41);
            this.inputCmk.Name = "inputCmk";
            this.inputCmk.Size = new System.Drawing.Size(100, 25);
            this.inputCmk.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(944, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 15);
            this.label14.TabIndex = 29;
            this.label14.Text = "Cr";
            // 
            // inputCr
            // 
            this.inputCr.Location = new System.Drawing.Point(994, 83);
            this.inputCr.Name = "inputCr";
            this.inputCr.Size = new System.Drawing.Size(100, 25);
            this.inputCr.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(941, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 15);
            this.label15.TabIndex = 31;
            this.label15.Text = "cpl";
            // 
            // inputCpl
            // 
            this.inputCpl.Location = new System.Drawing.Point(994, 128);
            this.inputCpl.Name = "inputCpl";
            this.inputCpl.Size = new System.Drawing.Size(100, 25);
            this.inputCpl.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1119, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 15);
            this.label16.TabIndex = 33;
            this.label16.Text = "Cpu";
            // 
            // inputCpu
            // 
            this.inputCpu.Location = new System.Drawing.Point(1166, 41);
            this.inputCpu.Name = "inputCpu";
            this.inputCpu.Size = new System.Drawing.Size(100, 25);
            this.inputCpu.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1122, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 15);
            this.label17.TabIndex = 35;
            this.label17.Text = "Cpk";
            // 
            // inputCpk
            // 
            this.inputCpk.Location = new System.Drawing.Point(1166, 83);
            this.inputCpk.Name = "inputCpk";
            this.inputCpk.Size = new System.Drawing.Size(100, 25);
            this.inputCpk.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1125, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 15);
            this.label18.TabIndex = 37;
            this.label18.Text = "k";
            // 
            // inputK
            // 
            this.inputK.Location = new System.Drawing.Point(1166, 127);
            this.inputK.Name = "inputK";
            this.inputK.Size = new System.Drawing.Size(100, 25);
            this.inputK.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1902, 636);
            this.Controls.Add(this.inputK);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.inputCpk);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.inputCpu);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.inputCpl);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.inputCr);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.inputCmk);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.inputCp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.inputLSL);
            this.Controls.Add(this.inputUSL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.inputStandradDiv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.inputMoveRange);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inputRange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputMinutes);
            this.Controls.Add(this.inputMaximum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.meanInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.measureListNums);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loadDataButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectChartMode);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserEchart;
        private System.Windows.Forms.ComboBox SelectChartMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView showDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox measureListNums;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox meanInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputMaximum;
        private System.Windows.Forms.TextBox inputMinutes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputRange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputMoveRange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inputStandradDiv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inputUSL;
        private System.Windows.Forms.TextBox inputLSL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox inputCp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox inputCmk;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox inputCr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox inputCpl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox inputCpu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox inputCpk;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox inputK;
    }
}

