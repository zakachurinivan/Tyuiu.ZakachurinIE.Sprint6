namespace Tyuiu.ZakachurinIE.Sprint6.Task5.V21
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonHelp_ZIE = new Button();
            buttonOpen_ZIE = new Button();
            buttonDone_ZIE = new Button();
            groupBoxOutPut_ZIE = new GroupBox();
            dataGridViewResult_ZIE = new DataGridView();
            chartFunction_ZIE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxOut_ZIE = new TextBox();
            groupBoxInput_ZIE = new GroupBox();
            groupBoxTask_ZIE = new GroupBox();
            textBoxTask_ZIE = new TextBox();
            groupBoxOutPut_ZIE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ZIE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ZIE).BeginInit();
            groupBoxTask_ZIE.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelp_ZIE
            // 
            buttonHelp_ZIE.Location = new Point(918, 44);
            buttonHelp_ZIE.Name = "buttonHelp_ZIE";
            buttonHelp_ZIE.Size = new Size(29, 23);
            buttonHelp_ZIE.TabIndex = 12;
            buttonHelp_ZIE.Text = "?";
            buttonHelp_ZIE.UseVisualStyleBackColor = true;
            buttonHelp_ZIE.Click += buttonHelp_CLick;
            // 
            // buttonOpen_ZIE
            // 
            buttonOpen_ZIE.Location = new Point(872, 174);
            buttonOpen_ZIE.Name = "buttonOpen_ZIE";
            buttonOpen_ZIE.Size = new Size(75, 69);
            buttonOpen_ZIE.TabIndex = 11;
            buttonOpen_ZIE.Text = "Сохранить";
            buttonOpen_ZIE.UseVisualStyleBackColor = true;
            buttonOpen_ZIE.Click += buttonOpen_CLick;
            // 
            // buttonDone_ZIE
            // 
            buttonDone_ZIE.Location = new Point(762, 174);
            buttonDone_ZIE.Name = "buttonDone_ZIE";
            buttonDone_ZIE.Size = new Size(79, 69);
            buttonDone_ZIE.TabIndex = 10;
            buttonDone_ZIE.Text = "Выполнить";
            buttonDone_ZIE.UseVisualStyleBackColor = true;
            buttonDone_ZIE.Click += buttoneDone_Click;
            // 
            // groupBoxOutPut_ZIE
            // 
            groupBoxOutPut_ZIE.Controls.Add(dataGridViewResult_ZIE);
            groupBoxOutPut_ZIE.Controls.Add(chartFunction_ZIE);
            groupBoxOutPut_ZIE.Controls.Add(textBoxOut_ZIE);
            groupBoxOutPut_ZIE.Location = new Point(27, 257);
            groupBoxOutPut_ZIE.Name = "groupBoxOutPut_ZIE";
            groupBoxOutPut_ZIE.Size = new Size(999, 345);
            groupBoxOutPut_ZIE.TabIndex = 9;
            groupBoxOutPut_ZIE.TabStop = false;
            groupBoxOutPut_ZIE.Text = "Вывод данных";
            // 
            // dataGridViewResult_ZIE
            // 
            dataGridViewResult_ZIE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_ZIE.Location = new Point(15, 54);
            dataGridViewResult_ZIE.Name = "dataGridViewResult_ZIE";
            dataGridViewResult_ZIE.Size = new Size(240, 150);
            dataGridViewResult_ZIE.TabIndex = 7;
            // 
            // chartFunction_ZIE
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_ZIE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_ZIE.Legends.Add(legend1);
            chartFunction_ZIE.Location = new Point(363, 44);
            chartFunction_ZIE.Name = "chartFunction_ZIE";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_ZIE.Series.Add(series1);
            chartFunction_ZIE.Size = new Size(300, 300);
            chartFunction_ZIE.TabIndex = 6;
            chartFunction_ZIE.Text = "chart1";
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
            // groupBoxInput_ZIE
            // 
            groupBoxInput_ZIE.Location = new Point(390, 39);
            groupBoxInput_ZIE.Name = "groupBoxInput_ZIE";
            groupBoxInput_ZIE.Size = new Size(582, 222);
            groupBoxInput_ZIE.TabIndex = 8;
            groupBoxInput_ZIE.TabStop = false;
            groupBoxInput_ZIE.Text = "Ввод данных";
            // 
            // groupBoxTask_ZIE
            // 
            groupBoxTask_ZIE.Controls.Add(textBoxTask_ZIE);
            groupBoxTask_ZIE.Location = new Point(27, 26);
            groupBoxTask_ZIE.Name = "groupBoxTask_ZIE";
            groupBoxTask_ZIE.Size = new Size(357, 225);
            groupBoxTask_ZIE.TabIndex = 7;
            groupBoxTask_ZIE.TabStop = false;
            groupBoxTask_ZIE.Text = "Условие";
            // 
            // textBoxTask_ZIE
            // 
            textBoxTask_ZIE.BorderStyle = BorderStyle.None;
            textBoxTask_ZIE.Location = new Point(6, 22);
            textBoxTask_ZIE.Multiline = true;
            textBoxTask_ZIE.Name = "textBoxTask_ZIE";
            textBoxTask_ZIE.ReadOnly = true;
            textBoxTask_ZIE.Size = new Size(349, 197);
            textBoxTask_ZIE.TabIndex = 0;
            textBoxTask_ZIE.Text = resources.GetString("textBoxTask_ZIE.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 628);
            Controls.Add(buttonHelp_ZIE);
            Controls.Add(buttonOpen_ZIE);
            Controls.Add(buttonDone_ZIE);
            Controls.Add(groupBoxOutPut_ZIE);
            Controls.Add(groupBoxInput_ZIE);
            Controls.Add(groupBoxTask_ZIE);
            Name = "FormMain";
            Text = "Спринт 6 Таск 5 Вариант 21 Закачурин И.Е.";
            groupBoxOutPut_ZIE.ResumeLayout(false);
            groupBoxOutPut_ZIE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ZIE).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ZIE).EndInit();
            groupBoxTask_ZIE.ResumeLayout(false);
            groupBoxTask_ZIE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp_ZIE;
        private Button buttonOpen_ZIE;
        private Button buttonDone_ZIE;
        private GroupBox groupBoxOutPut_ZIE;
        private TextBox textBoxOut_ZIE;
        private GroupBox groupBoxInput_ZIE;
        private GroupBox groupBoxTask_ZIE;
        private TextBox textBoxTask_ZIE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZIE;
        private DataGridView dataGridViewResult_ZIE;
    }
}
