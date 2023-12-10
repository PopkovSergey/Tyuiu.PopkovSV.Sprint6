
namespace Tyuiu.PopkovSV.Sprint6.Task5.V8
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_PSV = new System.Windows.Forms.Panel();
            this.buttonHelp_PSV = new System.Windows.Forms.Button();
            this.buttonOpen_PSV = new System.Windows.Forms.Button();
            this.buttonDone_PSV = new System.Windows.Forms.Button();
            this.groupBoxTask_PSV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PSV = new System.Windows.Forms.TextBox();
            this.panelLeft_PSV = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_PSV = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput_PSV = new System.Windows.Forms.DataGridView();
            this.panelFill_PSV = new System.Windows.Forms.Panel();
            this.chartResult_PSV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelTop_PSV.SuspendLayout();
            this.groupBoxTask_PSV.SuspendLayout();
            this.panelLeft_PSV.SuspendLayout();
            this.groupBoxOutPut_PSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_PSV)).BeginInit();
            this.panelFill_PSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_PSV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_PSV
            // 
            this.panelTop_PSV.Controls.Add(this.buttonHelp_PSV);
            this.panelTop_PSV.Controls.Add(this.buttonOpen_PSV);
            this.panelTop_PSV.Controls.Add(this.buttonDone_PSV);
            this.panelTop_PSV.Controls.Add(this.groupBoxTask_PSV);
            this.panelTop_PSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_PSV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_PSV.Name = "panelTop_PSV";
            this.panelTop_PSV.Size = new System.Drawing.Size(837, 65);
            this.panelTop_PSV.TabIndex = 0;
            // 
            // buttonHelp_PSV
            // 
            this.buttonHelp_PSV.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonHelp_PSV.Location = new System.Drawing.Point(713, 12);
            this.buttonHelp_PSV.Name = "buttonHelp_PSV";
            this.buttonHelp_PSV.Size = new System.Drawing.Size(75, 47);
            this.buttonHelp_PSV.TabIndex = 3;
            this.buttonHelp_PSV.Text = "Справка";
            this.buttonHelp_PSV.UseVisualStyleBackColor = false;
            this.buttonHelp_PSV.Click += new System.EventHandler(this.buttonHelp_PSV_Click_1);
            // 
            // buttonOpen_PSV
            // 
            this.buttonOpen_PSV.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpen_PSV.Location = new System.Drawing.Point(615, 12);
            this.buttonOpen_PSV.Name = "buttonOpen_PSV";
            this.buttonOpen_PSV.Size = new System.Drawing.Size(75, 47);
            this.buttonOpen_PSV.TabIndex = 2;
            this.buttonOpen_PSV.Text = "Открыть файл";
            this.buttonOpen_PSV.UseVisualStyleBackColor = false;
            this.buttonOpen_PSV.Click += new System.EventHandler(this.buttonOpen_PSV_Click_1);
            // 
            // buttonDone_PSV
            // 
            this.buttonDone_PSV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PSV.Location = new System.Drawing.Point(516, 12);
            this.buttonDone_PSV.Name = "buttonDone_PSV";
            this.buttonDone_PSV.Size = new System.Drawing.Size(75, 47);
            this.buttonDone_PSV.TabIndex = 1;
            this.buttonDone_PSV.Text = "Выполнить";
            this.buttonDone_PSV.UseVisualStyleBackColor = false;
            this.buttonDone_PSV.Click += new System.EventHandler(this.buttonDone_PSV_Click_1);
            // 
            // groupBoxTask_PSV
            // 
            this.groupBoxTask_PSV.Controls.Add(this.textBoxTask_PSV);
            this.groupBoxTask_PSV.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_PSV.Name = "groupBoxTask_PSV";
            this.groupBoxTask_PSV.Size = new System.Drawing.Size(507, 62);
            this.groupBoxTask_PSV.TabIndex = 0;
            this.groupBoxTask_PSV.TabStop = false;
            this.groupBoxTask_PSV.Text = "Условие:";
            // 
            // textBoxTask_PSV
            // 
            this.textBoxTask_PSV.Location = new System.Drawing.Point(0, 19);
            this.textBoxTask_PSV.Multiline = true;
            this.textBoxTask_PSV.Name = "textBoxTask_PSV";
            this.textBoxTask_PSV.Size = new System.Drawing.Size(501, 37);
            this.textBoxTask_PSV.TabIndex = 0;
            this.textBoxTask_PSV.Text = "Прочитать данные из файла InPutFileTask5V8.txt. Вывести в dataGridView. Дан списо" +
    "к из чисел. Вывести все числа, меньше 0. Построить диаграмму по этим значениям.";
            // 
            // panelLeft_PSV
            // 
            this.panelLeft_PSV.Controls.Add(this.groupBoxOutPut_PSV);
            this.panelLeft_PSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_PSV.Location = new System.Drawing.Point(0, 65);
            this.panelLeft_PSV.Name = "panelLeft_PSV";
            this.panelLeft_PSV.Size = new System.Drawing.Size(262, 411);
            this.panelLeft_PSV.TabIndex = 0;
            // 
            // groupBoxOutPut_PSV
            // 
            this.groupBoxOutPut_PSV.Controls.Add(this.dataGridViewInput_PSV);
            this.groupBoxOutPut_PSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_PSV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_PSV.Name = "groupBoxOutPut_PSV";
            this.groupBoxOutPut_PSV.Size = new System.Drawing.Size(262, 411);
            this.groupBoxOutPut_PSV.TabIndex = 0;
            this.groupBoxOutPut_PSV.TabStop = false;
            this.groupBoxOutPut_PSV.Text = "Вывод данных:";
            // 
            // dataGridViewInput_PSV
            // 
            this.dataGridViewInput_PSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_PSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInput_PSV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInput_PSV.Name = "dataGridViewInput_PSV";
            this.dataGridViewInput_PSV.Size = new System.Drawing.Size(256, 392);
            this.dataGridViewInput_PSV.TabIndex = 1;
            // 
            // panelFill_PSV
            // 
            this.panelFill_PSV.BackColor = System.Drawing.SystemColors.Control;
            this.panelFill_PSV.Controls.Add(this.chartResult_PSV);
            this.panelFill_PSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_PSV.Location = new System.Drawing.Point(262, 65);
            this.panelFill_PSV.Name = "panelFill_PSV";
            this.panelFill_PSV.Size = new System.Drawing.Size(575, 411);
            this.panelFill_PSV.TabIndex = 0;
            // 
            // chartResult_PSV
            // 
            chartArea4.Name = "ChartArea1";
            this.chartResult_PSV.ChartAreas.Add(chartArea4);
            this.chartResult_PSV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartResult_PSV.Legends.Add(legend4);
            this.chartResult_PSV.Location = new System.Drawing.Point(0, 0);
            this.chartResult_PSV.Name = "chartResult_PSV";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartResult_PSV.Series.Add(series4);
            this.chartResult_PSV.Size = new System.Drawing.Size(575, 411);
            this.chartResult_PSV.TabIndex = 0;
            this.chartResult_PSV.Text = "chart1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(262, 65);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 411);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 476);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelFill_PSV);
            this.Controls.Add(this.panelLeft_PSV);
            this.Controls.Add(this.panelTop_PSV);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 8 | Попков С. В.";
            this.panelTop_PSV.ResumeLayout(false);
            this.groupBoxTask_PSV.ResumeLayout(false);
            this.groupBoxTask_PSV.PerformLayout();
            this.panelLeft_PSV.ResumeLayout(false);
            this.groupBoxOutPut_PSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_PSV)).EndInit();
            this.panelFill_PSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_PSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_PSV;
        private System.Windows.Forms.Panel panelLeft_PSV;
        private System.Windows.Forms.Panel panelFill_PSV;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBoxTask_PSV;
        private System.Windows.Forms.TextBox textBoxTask_PSV;
        private System.Windows.Forms.Button buttonDone_PSV;
        private System.Windows.Forms.Button buttonHelp_PSV;
        private System.Windows.Forms.Button buttonOpen_PSV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_PSV;
        private System.Windows.Forms.DataGridView dataGridViewInput_PSV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_PSV;
    }
}

