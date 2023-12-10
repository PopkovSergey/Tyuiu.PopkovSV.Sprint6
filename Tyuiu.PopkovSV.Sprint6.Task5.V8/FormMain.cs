using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.PopkovSV.Sprint6.Task5.V8.Lib;
namespace Tyuiu.PopkovSV.Sprint6.Task5.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\Zverek\source\repos\Tyuiu.PopkovSV.Sprint6\InPutFileTask5V8.txt";
        private void buttonDone_PSV_Click(object sender, EventArgs e)
        {
            dataGridViewInput_PSV.ColumnCount = 2;
            dataGridViewInput_PSV.Columns[0].Width = 20;
            dataGridViewInput_PSV.Columns[1].Width = 50;

            this.chartResult_PSV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_PSV.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_PSV.Series[0].Points.Clear();

            double[] numArray = new double[ds.len];
            numArray = ds.LoadFromDataFile(path);
            for (int i = 0; i < numArray.Length; i++)
            {
                dataGridViewInput_PSV.Rows.Add(Convert.ToString(i), Convert.ToString(numArray[i]));
                chartResult_PSV.Series[0].Points.AddXY(i, numArray[i]);
            }
        }

        private void buttonHelp_PSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСТНБ-23-1 Попков С.В.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_PSV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonDone_PSV_Click_1(object sender, EventArgs e)
        {
            dataGridViewInput_PSV.ColumnCount = 2;
            dataGridViewInput_PSV.Columns[0].Width = 20;
            dataGridViewInput_PSV.Columns[1].Width = 50;

            this.chartResult_PSV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_PSV.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_PSV.Series[0].Points.Clear();

            double[] numArray = new double[ds.len];
            numArray = ds.LoadFromDataFile(path);
            for (int i = 0; i < numArray.Length; i++)
            {
                dataGridViewInput_PSV.Rows.Add(Convert.ToString(i), Convert.ToString(numArray[i]));
                chartResult_PSV.Series[0].Points.AddXY(i, numArray[i]);
            }
        }

        private void buttonOpen_PSV_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_PSV_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСТНБ-23-1 Попков С.В.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}