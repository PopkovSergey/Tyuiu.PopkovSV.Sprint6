
namespace Tyuiu.PopkovSV.Sprint6.Task4.V10
{
    partial class FormMain_PSV
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_PSV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PSV = new System.Windows.Forms.TextBox();
            this.groupBoxInput_PSV = new System.Windows.Forms.GroupBox();
            this.textBoxStop_PSV = new System.Windows.Forms.TextBox();
            this.textBoxStart_PSV = new System.Windows.Forms.TextBox();
            this.labelStop_PSV = new System.Windows.Forms.Label();
            this.labelStart_PSV = new System.Windows.Forms.Label();
            this.buttonDone_PSV = new System.Windows.Forms.Button();
            this.buttonSave_PSV = new System.Windows.Forms.Button();
            this.buttonHelp_PSV = new System.Windows.Forms.Button();
            this.groupBoxOutPut_PSV = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_PSV = new System.Windows.Forms.TextBox();
            this.chartResult_PSV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_PSV = new System.Windows.Forms.Panel();
            this.panelLeft_PSV = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFill_PSV = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.groupBoxTask_PSV.SuspendLayout();
            this.groupBoxInput_PSV.SuspendLayout();
            this.groupBoxOutPut_PSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_PSV)).BeginInit();
            this.panelLeft_PSV.SuspendLayout();
            this.panelFill_PSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_PSV
            // 
            this.groupBoxTask_PSV.Controls.Add(this.textBoxTask_PSV);
            this.groupBoxTask_PSV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_PSV.Name = "groupBoxTask_PSV";
            this.groupBoxTask_PSV.Size = new System.Drawing.Size(320, 82);
            this.groupBoxTask_PSV.TabIndex = 0;
            this.groupBoxTask_PSV.TabStop = false;
            this.groupBoxTask_PSV.Text = "Условие";
            // 
            // textBoxTask_PSV
            // 
            this.textBoxTask_PSV.Location = new System.Drawing.Point(0, 19);
            this.textBoxTask_PSV.Multiline = true;
            this.textBoxTask_PSV.Name = "textBoxTask_PSV";
            this.textBoxTask_PSV.Size = new System.Drawing.Size(320, 63);
            this.textBoxTask_PSV.TabIndex = 0;
            this.textBoxTask_PSV.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5. Результат вывести в tex" +
    "tBox. Построить  график функции и сохранить файл OutPutFile Task.txt по нажатию " +
    "кнопки.";
            // 
            // groupBoxInput_PSV
            // 
            this.groupBoxInput_PSV.Controls.Add(this.textBoxStop_PSV);
            this.groupBoxInput_PSV.Controls.Add(this.textBoxStart_PSV);
            this.groupBoxInput_PSV.Controls.Add(this.labelStop_PSV);
            this.groupBoxInput_PSV.Controls.Add(this.labelStart_PSV);
            this.groupBoxInput_PSV.Location = new System.Drawing.Point(326, 0);
            this.groupBoxInput_PSV.Name = "groupBoxInput_PSV";
            this.groupBoxInput_PSV.Size = new System.Drawing.Size(219, 82);
            this.groupBoxInput_PSV.TabIndex = 1;
            this.groupBoxInput_PSV.TabStop = false;
            this.groupBoxInput_PSV.Text = "Ввод данных";
            // 
            // textBoxStop_PSV
            // 
            this.textBoxStop_PSV.Location = new System.Drawing.Point(112, 41);
            this.textBoxStop_PSV.Name = "textBoxStop_PSV";
            this.textBoxStop_PSV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_PSV.TabIndex = 0;
            this.textBoxStop_PSV.Text = "5";
            // 
            // textBoxStart_PSV
            // 
            this.textBoxStart_PSV.Location = new System.Drawing.Point(6, 41);
            this.textBoxStart_PSV.Name = "textBoxStart_PSV";
            this.textBoxStart_PSV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_PSV.TabIndex = 1;
            this.textBoxStart_PSV.Text = "-5";
            // 
            // labelStop_PSV
            // 
            this.labelStop_PSV.AutoSize = true;
            this.labelStop_PSV.Location = new System.Drawing.Point(109, 19);
            this.labelStop_PSV.Name = "labelStop_PSV";
            this.labelStop_PSV.Size = new System.Drawing.Size(69, 13);
            this.labelStop_PSV.TabIndex = 1;
            this.labelStop_PSV.Text = "Конец шага:";
            // 
            // labelStart_PSV
            // 
            this.labelStart_PSV.AutoSize = true;
            this.labelStart_PSV.Location = new System.Drawing.Point(3, 16);
            this.labelStart_PSV.Name = "labelStart_PSV";
            this.labelStart_PSV.Size = new System.Drawing.Size(67, 13);
            this.labelStart_PSV.TabIndex = 0;
            this.labelStart_PSV.Text = "Старт шага:";
            // 
            // buttonDone_PSV
            // 
            this.buttonDone_PSV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PSV.Location = new System.Drawing.Point(551, 12);
            this.buttonDone_PSV.Name = "buttonDone_PSV";
            this.buttonDone_PSV.Size = new System.Drawing.Size(75, 63);
            this.buttonDone_PSV.TabIndex = 3;
            this.buttonDone_PSV.Text = "Выполить";
            this.buttonDone_PSV.UseVisualStyleBackColor = false;
            this.buttonDone_PSV.Click += new System.EventHandler(this.buttonDone_PSV_Click_1);
            // 
            // buttonSave_PSV
            // 
            this.buttonSave_PSV.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_PSV.Location = new System.Drawing.Point(632, 12);
            this.buttonSave_PSV.Name = "buttonSave_PSV";
            this.buttonSave_PSV.Size = new System.Drawing.Size(75, 63);
            this.buttonSave_PSV.TabIndex = 4;
            this.buttonSave_PSV.Text = "Сохранить";
            this.buttonSave_PSV.UseVisualStyleBackColor = false;
            this.buttonSave_PSV.Click += new System.EventHandler(this.buttonSave_PSV_Click_1);
            // 
            // buttonHelp_PSV
            // 
            this.buttonHelp_PSV.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_PSV.Location = new System.Drawing.Point(713, 12);
            this.buttonHelp_PSV.Name = "buttonHelp_PSV";
            this.buttonHelp_PSV.Size = new System.Drawing.Size(75, 63);
            this.buttonHelp_PSV.TabIndex = 5;
            this.buttonHelp_PSV.Text = "Справка";
            this.buttonHelp_PSV.UseVisualStyleBackColor = false;
            this.buttonHelp_PSV.Click += new System.EventHandler(this.buttonHelp_PSV_Click_1);
            // 
            // groupBoxOutPut_PSV
            // 
            this.groupBoxOutPut_PSV.Controls.Add(this.textBoxOutPut_PSV);
            this.groupBoxOutPut_PSV.Controls.Add(this.panelLeft_PSV);
            this.groupBoxOutPut_PSV.Location = new System.Drawing.Point(0, 88);
            this.groupBoxOutPut_PSV.Name = "groupBoxOutPut_PSV";
            this.groupBoxOutPut_PSV.Size = new System.Drawing.Size(200, 361);
            this.groupBoxOutPut_PSV.TabIndex = 6;
            this.groupBoxOutPut_PSV.TabStop = false;
            this.groupBoxOutPut_PSV.Text = "Вывод:";
            // 
            // textBoxOutPut_PSV
            // 
            this.textBoxOutPut_PSV.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutPut_PSV.Multiline = true;
            this.textBoxOutPut_PSV.Name = "textBoxOutPut_PSV";
            this.textBoxOutPut_PSV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_PSV.Size = new System.Drawing.Size(191, 339);
            this.textBoxOutPut_PSV.TabIndex = 0;
            // 
            // chartResult_PSV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_PSV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResult_PSV.Legends.Add(legend1);
            this.chartResult_PSV.Location = new System.Drawing.Point(206, 88);
            this.chartResult_PSV.Name = "chartResult_PSV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_PSV.Series.Add(series1);
            this.chartResult_PSV.Size = new System.Drawing.Size(582, 355);
            this.chartResult_PSV.TabIndex = 1;
            this.chartResult_PSV.Text = "График функции";
            // 
            // panelTop_PSV
            // 
            this.panelTop_PSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_PSV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_PSV.Name = "panelTop_PSV";
            this.panelTop_PSV.Size = new System.Drawing.Size(800, 82);
            this.panelTop_PSV.TabIndex = 7;
            // 
            // panelLeft_PSV
            // 
            this.panelLeft_PSV.Controls.Add(this.panel1);
            this.panelLeft_PSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_PSV.Location = new System.Drawing.Point(3, 16);
            this.panelLeft_PSV.Name = "panelLeft_PSV";
            this.panelLeft_PSV.Size = new System.Drawing.Size(200, 342);
            this.panelLeft_PSV.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panelFill_PSV
            // 
            this.panelFill_PSV.Controls.Add(this.splitter4);
            this.panelFill_PSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_PSV.Location = new System.Drawing.Point(0, 0);
            this.panelFill_PSV.Name = "panelFill_PSV";
            this.panelFill_PSV.Size = new System.Drawing.Size(800, 450);
            this.panelFill_PSV.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 82);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 368);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 82);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 368);
            this.splitter2.TabIndex = 9;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(6, 82);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 368);
            this.splitter3.TabIndex = 10;
            this.splitter3.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(0, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(3, 450);
            this.splitter4.TabIndex = 0;
            this.splitter4.TabStop = false;
            // 
            // FormMain_PSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.chartResult_PSV);
            this.Controls.Add(this.groupBoxOutPut_PSV);
            this.Controls.Add(this.buttonHelp_PSV);
            this.Controls.Add(this.buttonSave_PSV);
            this.Controls.Add(this.buttonDone_PSV);
            this.Controls.Add(this.groupBoxInput_PSV);
            this.Controls.Add(this.groupBoxTask_PSV);
            this.Controls.Add(this.panelTop_PSV);
            this.Controls.Add(this.panelFill_PSV);
            this.Name = "FormMain_PSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 10 | Попков С. В.";
            this.groupBoxTask_PSV.ResumeLayout(false);
            this.groupBoxTask_PSV.PerformLayout();
            this.groupBoxInput_PSV.ResumeLayout(false);
            this.groupBoxInput_PSV.PerformLayout();
            this.groupBoxOutPut_PSV.ResumeLayout(false);
            this.groupBoxOutPut_PSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_PSV)).EndInit();
            this.panelLeft_PSV.ResumeLayout(false);
            this.panelFill_PSV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PSV;
        private System.Windows.Forms.TextBox textBoxTask_PSV;
        private System.Windows.Forms.GroupBox groupBoxInput_PSV;
        private System.Windows.Forms.TextBox textBoxStop_PSV;
        private System.Windows.Forms.TextBox textBoxStart_PSV;
        private System.Windows.Forms.Label labelStop_PSV;
        private System.Windows.Forms.Label labelStart_PSV;
        private System.Windows.Forms.Button buttonDone_PSV;
        private System.Windows.Forms.Button buttonSave_PSV;
        private System.Windows.Forms.Button buttonHelp_PSV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_PSV;
        private System.Windows.Forms.TextBox textBoxOutPut_PSV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_PSV;
        private System.Windows.Forms.Panel panelLeft_PSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTop_PSV;
        private System.Windows.Forms.Panel panelFill_PSV;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
    }
}

