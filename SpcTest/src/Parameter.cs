using System;
using System.Collections.Generic;

namespace SpcTest.src
{
    internal class Parameter
    {
        // 控制图参数

        // spc 的样品组数建议为 5
        // 子组大小 n == 2 至 n == 25
        public Dictionary<string, double> n2;

        public Dictionary<string, double> n3;
        public Dictionary<string, double> n4;
        public Dictionary<string, double> n5;
        public Dictionary<string, double> n6;
        public Dictionary<string, double> n7;
        public Dictionary<string, double> n8;
        public Dictionary<string, double> n9;
        public Dictionary<string, double> n10;
        public Dictionary<string, double> n11;
        public Dictionary<string, double> n12;
        public Dictionary<string, double> n13;
        public Dictionary<string, double> n14;
        public Dictionary<string, double> n15;
        public Dictionary<string, double> n16;
        public Dictionary<string, double> n17;
        public Dictionary<string, double> n18;
        public Dictionary<string, double> n19;
        public Dictionary<string, double> n20;
        public Dictionary<string, double> n21;
        public Dictionary<string, double> n22;
        public Dictionary<string, double> n23;
        public Dictionary<string, double> n24;
        public Dictionary<string, double> n25;

        public Dictionary<string, double>[] controlChartDictionaries;

        public Parameter()
        {
            controlChartDictionaries = new Dictionary<string, double>[26]; // 0, 1 都没有数据，因此要有 27 个才能保证数组不越界

            n2 = SetParameters(new double[] { 2.121, 1.880, 2.659, 0.7979, 1.2533, 0, 3.267, 0, 2.606, 1.128, 0.8865, 0.853, 0, 3.686, 0, 3.267, 1.000, 1.880 }, 2);
            n3 = SetParameters(new double[] { 1.732, 1.024, 1.954, 0.8862, 1.1284, 0, 2.568, 0, 2.276, 1.693, 0.5907, 0.888, 0, 4.358, 0, 2.574, 1.160, 1.187 }, 3);
            n4 = SetParameters(new double[] { 1.500, 0.729, 1.628, 0.9213, 1.0854, 0, 2.266, 0, 2.089, 2.059, 0.4857, 0.880, 0, 4.698, 0, 2.574, 1.160, 1.187 }, 4);
            n5 = SetParameters(new double[] { 1.342, 0.577, 1.427, 0.9400, 1.0638, 0, 2.089, 0, 1.964, 2.326, 0.4299, 0.864, 0, 4.919, 0, 2.114, 1.198, 0.691 }, 5);
            n6 = SetParameters(new double[] { 1.225, 0.483, 1.287, 0.9515, 1.0510, 0.030, 1.970, 0.029, 1.874, 2.534, 0.3946, 0.848, 0, 5.078, 0, 2.004, 1.135, 0.548 }, 6);
            n7 = SetParameters(new double[] { 1.134, 0.419, 1.182, 0.9594, 1.0423, 0.118, 1.882, 0.113, 1.806, 2.704, 0.3698, 0.833, 0.204, 5.204, 0.076, 1.924, 1.214, 0.509 }, 7);
            n8 = SetParameters(new double[] { 1.061, 0.373, 1.099, 0.9650, 1.0363, 0.185, 1.815, 0.179, 1.751, 2.847, 0.3512, 0.820, 0.388, 5.306, 0.136, 1.864, 1.160, 0.433 }, 8);
            n9 = SetParameters(new double[] { 1.000, 0.337, 1.032, 0.9693, 1.0317, 0.239, 1.761, 0.232, 1.707, 2.970, 0.3367, 0.808, 0.547, 5.393, 0.184, 1.816, 1.223, 0.412 }, 9);
            n10 = SetParameters(new double[] { 0.949, 0.308, 0.975, 0.9727, 1.0281, 0.284, 1.716, 0.276, 1.669, 3.078, 0.3249, 0.797, 0.687, 5.469, 0.223, 1.777, 1.176, 0.362 }, 10);
            n11 = SetParameters(new double[] { 0.905, 0.285, 0.927, 0.9754, 1.0252, 0.321, 1.679, 0.313, 1.637, 3.173, 0.3152, 0.787, 0.811, 5.535, 0.256, 1.744, -1, -1 }, 11);
            n12 = SetParameters(new double[] { 0.866, 0.266, 0.886, 0.9776, 1.0229, 0.354, 1.646, 0.346, 1.610, 3.258, 0.3069, 0.778, 0.922, 5.594, 0.283, 1.717, -1, -1 }, 12);
            n13 = SetParameters(new double[] { 0.832, 0.249, 0.850, 0.9794, 1.0210, 0.382, 1.162, 0.374, 1.585, 3.336, 0.2998, 0.770, 1.025, 5.647, 0.307, 1.693, -1, -1 }, 13);
            n14 = SetParameters(new double[] { 0.802, 0.235, 0.817, 0.9810, 1.0194, 0.406, 1.594, 0.399, 1.563, 3.407, 0.2935, 0.763, 1.118, 5.696, 0.328, 1.672, -1, -1 }, 14);
            n15 = SetParameters(new double[] { 0.775, 0.223, 0.789, 0.9823, 1.0180, 0.428, 1.572, 0.421, 1.544, 3.472, 0.2880, 0.756, 1.203, 5.741, 0.347, 1.653, -1, -1 }, 15);
            n16 = SetParameters(new double[] { 0.750, 0.212, 0.763, 0.9835, 1.0618, 0.448, 1.552, 0.440, 1.526, 3.532, 0.2831, 0.750, 1.282, 5.782, 0.363, 1.637, -1, -1 }, 16);
            n17 = SetParameters(new double[] { 0.728, 0.203, 0.739, 0.9845, 1.0157, 0.466, 1.534, 0.458, 1.511, 3.588, 0.2787, 0.744, 1.356, 5.820, 0.378, 1.622, -1, -1 }, 17);
            n18 = SetParameters(new double[] { 0.707, 0.194, 0.718, 0.9854, 1.0148, 0.482, 1.518, 0.475, 1.496, 3.640, 0.2747, 0.739, 1.424, 5.856, 0.391, 1.608, -1, -1 }, 18);
            n19 = SetParameters(new double[] { 0.688, 0.187, 0.698, 0.9862, 1.0140, 0.497, 1.503, 0.490, 1.483, 3.698, 0.2711, 0.734, 1.487, 5.891, 0.403, 1.597, -1, -1 }, 19);
            n20 = SetParameters(new double[] { 0.671, 0.180, 0.680, 0.9869, 1.0133, 0.510, 1.490, 0.504, 1.470, 3.735, 0.2677, 0.729, 1.549, 5.921, 0.415, 1.585, -1, -1 }, 20);
            n21 = SetParameters(new double[] { 0.655, 0.173, 0.663, 0.9876, 1.0126, 0.523, 1.477, 0.516, 1.459, 3.778, 0.2647, 0.724, 1.605, 5.951, 0.425, 1.575, -1, -1 }, 21);
            n22 = SetParameters(new double[] { 0.640, 0.167, 0.647, 0.9882, 1.0119, 0.534, 1.466, 0.528, 1.448, 3.819, 0.2618, 0.720, 1.659, 5.979, 0.434, 1.566, -1, -1 }, 22);
            n23 = SetParameters(new double[] { 0.626, 0.162, 0.633, 0.9887, 1.0114, 0.545, 1.455, 0.539, 1.438, 3.858, 0.2592, 0.716, 1.710, 6.006, 0.443, 1.557, -1, -1 }, 23);
            n24 = SetParameters(new double[] { 0.612, 0.157, 0.619, 0.9892, 1.0109, 0.555, 1.445, 0.549, 1.429, 3.895, 0.2567, 0.712, 1.759, 6.031, 0.451, 1.548, -1, -1 }, 24);
            n25 = SetParameters(new double[] { 0.600, 0.153, 0.606, 0.9896, 1.0105, 0.565, 1.435, 0.559, 1.420, 3.931, 0.2544, 0.708, 1.806, 6.056, 0.459, 1.541, -1, -1 }, 25);
        }

        public Dictionary<string, double> SetParameters(double[] digitArray, int number)
        {
            string[] pArray = { "A", "A2", "A3", "C4", "1/C4", "B3", "B4", "B5", "B6", "d2", "1/d2", "d3", "D1", "D2", "D3", "D4", "m3", "m3A2" };
            var dic = new Dictionary<string, double>();
            var i = 0;

            foreach (var item in pArray)
            {
                dic.Add(item, digitArray[i]);
                i++;
            }

            controlChartDictionaries[number] = dic;
            return dic;
        }

        public void ToString(Dictionary<string, double> n)
        {
            foreach (var kvp in n)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
    }
}