namespace Tyuiu.ZakachurinIE.Sprint6.Task4.V2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
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
            textBoxResult_ZIE = new TextBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxOut_ZIE = new TextBox();
            buttonDone_ZIE = new Button();
            buttonSave_ZIE = new Button();
            buttonHelp_ZIE = new Button();
            groupBoxTask_ZIE.SuspendLayout();
            groupBoxInput_ZIE.SuspendLayout();
            groupBoxOutPut_ZIE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_ZIE
            // 
            groupBoxTask_ZIE.Controls.Add(textBoxTask_ZIE);
            groupBoxTask_ZIE.Location = new Point(12, 12);
            groupBoxTask_ZIE.Name = "groupBoxTask_ZIE";
            groupBoxTask_ZIE.Size = new Size(357, 225);
            groupBoxTask_ZIE.TabIndex = 1;
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
            textBoxTask_ZIE.Size = new Size(349, 263);
            textBoxTask_ZIE.TabIndex = 0;
            textBoxTask_ZIE.Text = resources.GetString("textBoxTask_ZIE.Text");
            // 
            // groupBoxInput_ZIE
            // 
            groupBoxInput_ZIE.Controls.Add(textBoxInputStop_ZIE);
            groupBoxInput_ZIE.Controls.Add(textBoxInputStart_ZIE);
            groupBoxInput_ZIE.Controls.Add(textBoxStop_ZIE);
            groupBoxInput_ZIE.Controls.Add(textBoxStart_ZIE);
            groupBoxInput_ZIE.Location = new Point(375, 25);
            groupBoxInput_ZIE.Name = "groupBoxInput_ZIE";
            groupBoxInput_ZIE.Size = new Size(392, 87);
            groupBoxInput_ZIE.TabIndex = 2;
            groupBoxInput_ZIE.TabStop = false;
            groupBoxInput_ZIE.Text = "Ввод данных";
            // 
            // textBoxInputStop_ZIE
            // 
            textBoxInputStop_ZIE.Location = new Point(188, 52);
            textBoxInputStop_ZIE.Name = "textBoxInputStop_ZIE";
            textBoxInputStop_ZIE.Size = new Size(100, 23);
            textBoxInputStop_ZIE.TabIndex = 3;
            textBoxInputStop_ZIE.Text = "5";
            // 
            // textBoxInputStart_ZIE
            // 
            textBoxInputStart_ZIE.Location = new Point(10, 52);
            textBoxInputStart_ZIE.Name = "textBoxInputStart_ZIE";
            textBoxInputStart_ZIE.Size = new Size(100, 23);
            textBoxInputStart_ZIE.TabIndex = 2;
            textBoxInputStart_ZIE.Text = "-5";
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
            groupBoxOutPut_ZIE.Controls.Add(textBoxResult_ZIE);
            groupBoxOutPut_ZIE.Controls.Add(chartFunction);
            groupBoxOutPut_ZIE.Controls.Add(textBoxOut_ZIE);
            groupBoxOutPut_ZIE.Location = new Point(12, 243);
            groupBoxOutPut_ZIE.Name = "groupBoxOutPut_ZIE";
            groupBoxOutPut_ZIE.Size = new Size(999, 345);
            groupBoxOutPut_ZIE.TabIndex = 3;
            groupBoxOutPut_ZIE.TabStop = false;
            groupBoxOutPut_ZIE.Text = "Вывод данных";
            // 
            // textBoxResult_ZIE
            // 
            textBoxResult_ZIE.Location = new Point(15, 44);
            textBoxResult_ZIE.Multiline = true;
            textBoxResult_ZIE.Name = "textBoxResult_ZIE";
            textBoxResult_ZIE.ReadOnly = true;
            textBoxResult_ZIE.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ZIE.Size = new Size(315, 295);
            textBoxResult_ZIE.TabIndex = 5;
            // 
            // chartFunction
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction.Legends.Add(legend2);
            chartFunction.Location = new Point(351, 39);
            chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction.Series.Add(series2);
            chartFunction.Size = new Size(615, 300);
            chartFunction.TabIndex = 4;
            chartFunction.Text = "chart1";
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
            // buttonDone_ZIE
            // 
            buttonDone_ZIE.Location = new Point(747, 160);
            buttonDone_ZIE.Name = "buttonDone_ZIE";
            buttonDone_ZIE.Size = new Size(79, 69);
            buttonDone_ZIE.TabIndex = 4;
            buttonDone_ZIE.Text = "Выполнить";
            buttonDone_ZIE.UseVisualStyleBackColor = true;
            buttonDone_ZIE.Click += buttonDone_click;
            // 
            // buttonSave_ZIE
            // 
            buttonSave_ZIE.Location = new Point(857, 160);
            buttonSave_ZIE.Name = "buttonSave_ZIE";
            buttonSave_ZIE.Size = new Size(75, 69);
            buttonSave_ZIE.TabIndex = 5;
            buttonSave_ZIE.Text = "Сохранить";
            buttonSave_ZIE.UseVisualStyleBackColor = true;
            buttonSave_ZIE.Click += buttonSave_Click;
            // 
            // buttonHelp_ZIE
            // 
            buttonHelp_ZIE.Location = new Point(903, 30);
            buttonHelp_ZIE.Name = "buttonHelp_ZIE";
            buttonHelp_ZIE.Size = new Size(29, 23);
            buttonHelp_ZIE.TabIndex = 6;
            buttonHelp_ZIE.Text = "?";
            buttonHelp_ZIE.UseVisualStyleBackColor = true;
            buttonHelp_ZIE.Click += buttonHelp_CLick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 600);
            Controls.Add(buttonHelp_ZIE);
            Controls.Add(buttonSave_ZIE);
            Controls.Add(buttonDone_ZIE);
            Controls.Add(groupBoxOutPut_ZIE);
            Controls.Add(groupBoxInput_ZIE);
            Controls.Add(groupBoxTask_ZIE);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 Таск 4 Вариант 2 Закачурин И.Е.";
            groupBoxTask_ZIE.ResumeLayout(false);
            groupBoxTask_ZIE.PerformLayout();
            groupBoxInput_ZIE.ResumeLayout(false);
            groupBoxInput_ZIE.PerformLayout();
            groupBoxOutPut_ZIE.ResumeLayout(false);
            groupBoxOutPut_ZIE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_ZIE;
        private TextBox textBoxTask_ZIE;
        private GroupBox groupBoxInput_ZIE;
        private TextBox textBoxInputStop_ZIE;
        private TextBox textBoxInputStart_ZIE;
        private TextBox textBoxStop_ZIE;
        private TextBox textBoxStart_ZIE;
        private GroupBox groupBoxOutPut_ZIE;
        private TextBox textBoxOut_ZIE;
        private TextBox textBoxResult_ZIE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Button buttonDone_ZIE;
        private Button buttonSave_ZIE;
        private Button buttonHelp_ZIE;
    }
}
