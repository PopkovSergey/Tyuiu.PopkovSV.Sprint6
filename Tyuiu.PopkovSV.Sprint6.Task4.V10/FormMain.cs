using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PopkovSV.Sprint6.Task4.V10.Lib;
using System.IO;

namespace Tyuiu.PopkovSV.Sprint6.Task4.V10
{
    public partial class FormMain_PSV : Form
    {
        public FormMain_PSV()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_PSV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V10.txt";
                File.WriteAllText(path, textBoxOutPut_PSV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно! \nОткрыть его в блокноте?",
                    "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartResult_PSV_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_PSV_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonHelp_PSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студент группы ИСТНБ-23-1 Попков Сергей Вадимович",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_PSV_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void panelData_PSV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDone_PSV_Click_1(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_PSV.Text);
                int stopStep = Convert.ToInt32(textBoxStop_PSV.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] res = new double[len];
                res = ds.GetMassFunction(startStep, stopStep);
                this.chartResult_PSV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_PSV.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxOutPut_PSV.Text = "";
                chartResult_PSV.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartResult_PSV.Series[0].Points.AddXY(startStep, res[i]);
                    textBoxOutPut_PSV.AppendText(res[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_PSV_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V10.txt";
                File.WriteAllText(path, textBoxOutPut_PSV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно! \nОткрыть его в блокноте?",
                    "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PSV_Click_1(object sender, EventArgs e)
        {
             MessageBox.Show("Таск 4 выполнила студент группы ИСТНБ-23-1 Попков Сергей Вадимович",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
