
namespace Tyuiu.ZakachurinIE.Sprint6.Task2.V4
{
    partial class FormMainTask_ZIE
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_ZIE = new GroupBox();
            textBoxTask_ZIE = new TextBox();
            groupBoxInput_ZIE = new GroupBox();
            textBoxInputStop_ZIE = new TextBox();
            textBoxInputStart_ZIE = new TextBox();
            textBoxStop_ZIE = new TextBox();
            textBoxStart_ZIE = new TextBox();
            groupBoxOutPut_ZIE = new GroupBox();
            dataGridViewFunction_ZIE = new DataGridView();
            ColumnX = new DataGridViewTextBoxColumn();
            ColumnF = new DataGridViewTextBoxColumn();
            chartResult_ZIE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxOut_ZIE = new TextBox();
            buttonHelp_ZIE = new Button();
            buttonDone_ZIE = new Button();
            groupBoxTask_ZIE.SuspendLayout();
            groupBoxInput_ZIE.SuspendLayout();
            groupBoxOutPut_ZIE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_ZIE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_ZIE).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_ZIE
            // 
            groupBoxTask_ZIE.Controls.Add(textBoxTask_ZIE);
            groupBoxTask_ZIE.Location = new Point(6, 5);
            groupBoxTask_ZIE.Name = "groupBoxTask_ZIE";
            groupBoxTask_ZIE.Size = new Size(532, 340);
            groupBoxTask_ZIE.TabIndex = 0;
            groupBoxTask_ZIE.TabStop = false;
            groupBoxTask_ZIE.Text = "Условие";
            // 
            // textBoxTask_ZIE
            // 
            textBoxTask_ZIE.BackColor = SystemColors.Menu;
            textBoxTask_ZIE.BorderStyle = BorderStyle.None;
            textBoxTask_ZIE.Location = new Point(6, 22);
            textBoxTask_ZIE.Multiline = true;
            textBoxTask_ZIE.Name = "textBoxTask_ZIE";
            textBoxTask_ZIE.ReadOnly = true;
            textBoxTask_ZIE.Size = new Size(375, 37);
            textBoxTask_ZIE.TabIndex = 0;
            textBoxTask_ZIE.Text = "Протабулировать функцию на заданном диапазоне\r\nРезультат вывести в DataGridView и построить график функции\r\n";
            // 
            // groupBoxInput_ZIE
            // 
            groupBoxInput_ZIE.Controls.Add(textBoxInputStop_ZIE);
            groupBoxInput_ZIE.Controls.Add(textBoxInputStart_ZIE);
            groupBoxInput_ZIE.Controls.Add(textBoxStop_ZIE);
            groupBoxInput_ZIE.Controls.Add(textBoxStart_ZIE);
            groupBoxInput_ZIE.Location = new Point(6, 351);
            groupBoxInput_ZIE.Name = "groupBoxInput_ZIE";
            groupBoxInput_ZIE.Size = new Size(392, 87);
            groupBoxInput_ZIE.TabIndex = 1;
            groupBoxInput_ZIE.TabStop = false;
            groupBoxInput_ZIE.Text = "Ввод данных";
            // 
            // textBoxInputStop_ZIE
            // 
            textBoxInputStop_ZIE.Location = new Point(188, 52);
            textBoxInputStop_ZIE.Name = "textBoxInputStop_ZIE";
            textBoxInputStop_ZIE.Size = new Size(100, 23);
            textBoxInputStop_ZIE.TabIndex = 3;
            // 
            // textBoxInputStart_ZIE
            // 
            textBoxInputStart_ZIE.Location = new Point(10, 52);
            textBoxInputStart_ZIE.Name = "textBoxInputStart_ZIE";
            textBoxInputStart_ZIE.Size = new Size(100, 23);
            textBoxInputStart_ZIE.TabIndex = 2;
            // 
            // textBoxStop_ZIE
            // 
            textBoxStop_ZIE.BorderStyle = BorderStyle.None;
            textBoxStop_ZIE.Location = new Point(188, 20);
            textBoxStop_ZIE.Name = "textBoxStop_ZIE";
            textBoxStop_ZIE.ReadOnly = true;
            textBoxStop_ZIE.Size = new Size(100, 16);
            textBoxStop_ZIE.TabIndex = 1;
            textBoxStop_ZIE.Text = "Конец шага:";
            // 
            // textBoxStart_ZIE
            // 
            textBoxStart_ZIE.BorderStyle = BorderStyle.None;
            textBoxStart_ZIE.Location = new Point(10, 21);
            textBoxStart_ZIE.Name = "textBoxStart_ZIE";
            textBoxStart_ZIE.ReadOnly = true;
            textBoxStart_ZIE.Size = new Size(100, 16);
            textBoxStart_ZIE.TabIndex = 0;
            textBoxStart_ZIE.Text = "Старт шага:";
            // 
            // groupBoxOutPut_ZIE
            // 
            groupBoxOutPut_ZIE.Controls.Add(dataGridViewFunction_ZIE);
            groupBoxOutPut_ZIE.Controls.Add(chartResult_ZIE);
            groupBoxOutPut_ZIE.Controls.Add(textBoxOut_ZIE);
            groupBoxOutPut_ZIE.Location = new Point(544, 12);
            groupBoxOutPut_ZIE.Name = "groupBoxOutPut_ZIE";
            groupBoxOutPut_ZIE.Size = new Size(494, 426);
            groupBoxOutPut_ZIE.TabIndex = 2;
            groupBoxOutPut_ZIE.TabStop = false;
            groupBoxOutPut_ZIE.Text = "Вывод данных";
            // 
            // dataGridViewFunction_ZIE
            // 
            dataGridViewFunction_ZIE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_ZIE.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnF });
            dataGridViewFunction_ZIE.Location = new Point(15, 48);
            dataGridViewFunction_ZIE.Name = "dataGridViewFunction_ZIE";
            dataGridViewFunction_ZIE.ReadOnly = true;
            dataGridViewFunction_ZIE.RowHeadersVisible = false;
            dataGridViewFunction_ZIE.Size = new Size(123, 366);
            dataGridViewFunction_ZIE.TabIndex = 3;
            // 
            // ColumnX
            // 
            ColumnX.HeaderText = "X";
            ColumnX.Name = "ColumnX";
            ColumnX.ReadOnly = true;
            ColumnX.Width = 50;
            // 
            // ColumnF
            // 
            ColumnF.HeaderText = "F(x)";
            ColumnF.Name = "ColumnF";
            ColumnF.ReadOnly = true;
            ColumnF.Width = 50;
            // 
            // chartResult_ZIE
            // 
            chartArea2.Name = "ChartArea1";
            chartResult_ZIE.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartResult_ZIE.Legends.Add(legend2);
            chartResult_ZIE.Location = new Point(159, 48);
            chartResult_ZIE.Name = "chartResult_ZIE";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartResult_ZIE.Series.Add(series2);
            chartResult_ZIE.Size = new Size(317, 366);
            chartResult_ZIE.TabIndex = 2;
            chartResult_ZIE.Text = "chart1";
            // 
            // textBoxOut_ZIE
            // 
            textBoxOut_ZIE.BorderStyle = BorderStyle.None;
            textBoxOut_ZIE.Location = new Point(15, 22);
            textBoxOut_ZIE.Name = "textBoxOut_ZIE";
            textBoxOut_ZIE.ReadOnly = true;
            textBoxOut_ZIE.Size = new Size(154, 16);
            textBoxOut_ZIE.TabIndex = 0;
            textBoxOut_ZIE.Text = "Результат:";
            // 
            // buttonHelp_ZIE
            // 
            buttonHelp_ZIE.Location = new Point(404, 397);
            buttonHelp_ZIE.Name = "buttonHelp_ZIE";
            buttonHelp_ZIE.Size = new Size(38, 41);
            buttonHelp_ZIE.TabIndex = 3;
            buttonHelp_ZIE.Text = "?";
            buttonHelp_ZIE.UseVisualStyleBackColor = true;
            buttonHelp_ZIE.Click += buttonHelp_CLick;
            // 
            // buttonDone_ZIE
            // 
            buttonDone_ZIE.Location = new Point(448, 351);
            buttonDone_ZIE.Name = "buttonDone_ZIE";
            buttonDone_ZIE.Size = new Size(90, 87);
            buttonDone_ZIE.TabIndex = 4;
            buttonDone_ZIE.Text = "Выполнить";
            buttonDone_ZIE.UseVisualStyleBackColor = true;
            buttonDone_ZIE.Click += buttonDone_ZIE_Click;
            // 
            // FormMainTask_ZIE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 450);
            Controls.Add(buttonDone_ZIE);
            Controls.Add(buttonHelp_ZIE);
            Controls.Add(groupBoxOutPut_ZIE);
            Controls.Add(groupBoxInput_ZIE);
            Controls.Add(groupBoxTask_ZIE);
            Name = "FormMainTask_ZIE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 4 | Закачурин И.Е";
            groupBoxTask_ZIE.ResumeLayout(false);
            groupBoxTask_ZIE.PerformLayout();
            groupBoxInput_ZIE.ResumeLayout(false);
            groupBoxInput_ZIE.PerformLayout();
            groupBoxOutPut_ZIE.ResumeLayout(false);
            groupBoxOutPut_ZIE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_ZIE).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_ZIE).EndInit();
            ResumeLayout(false);
        }

        private void buttoneDone_ZIE_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonHelp_ZIE_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBoxTask_ZIE;
        private TextBox textBoxTask_ZIE;
        private GroupBox groupBoxInput_ZIE;
        private GroupBox groupBoxOutPut_ZIE;
        private Button buttonHelp_ZIE;
        private Button buttonDone_ZIE;
        private TextBox textBoxInputStart_ZIE;
        private TextBox textBoxStop_ZIE;
        private TextBox textBoxStart_ZIE;
        private TextBox textBoxInputStop_ZIE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_ZIE;
        private TextBox textBoxOut_ZIE;
        private DataGridView dataGridViewFunction_ZIE;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnF;
    }
}
