namespace Tyuiu.ZakachurinIE.Sprint6.Task1.V5
{
    partial class FormMain_ZIE
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
            groupBoxTask_ZIE = new GroupBox();
            textBoxTask_ZIE = new TextBox();
            groupBoxInput_ZIE = new GroupBox();
            textBoxTaskInf2_ZIE = new TextBox();
            textBoxTaskInf_ZIE = new TextBox();
            textBoxInputSTP_ZIE = new TextBox();
            textBoxInputSRT_ZIE = new TextBox();
            groupBoxOutPut_ZIE = new GroupBox();
            textBoxResult_ZIE = new TextBox();
            buttonDone_ZIE = new Button();
            buttonHelp_ZIE = new Button();
            groupBoxTask_ZIE.SuspendLayout();
            groupBoxInput_ZIE.SuspendLayout();
            groupBoxOutPut_ZIE.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_ZIE
            // 
            groupBoxTask_ZIE.Controls.Add(textBoxTask_ZIE);
            groupBoxTask_ZIE.Location = new Point(8, 6);
            groupBoxTask_ZIE.Name = "groupBoxTask_ZIE";
            groupBoxTask_ZIE.Size = new Size(512, 302);
            groupBoxTask_ZIE.TabIndex = 0;
            groupBoxTask_ZIE.TabStop = false;
            groupBoxTask_ZIE.Text = "Условие";
            // 
            // textBoxTask_ZIE
            // 
            textBoxTask_ZIE.BorderStyle = BorderStyle.None;
            textBoxTask_ZIE.Location = new Point(13, 26);
            textBoxTask_ZIE.Multiline = true;
            textBoxTask_ZIE.Name = "textBoxTask_ZIE";
            textBoxTask_ZIE.ReadOnly = true;
            textBoxTask_ZIE.Size = new Size(296, 43);
            textBoxTask_ZIE.TabIndex = 0;
            textBoxTask_ZIE.Text = "Протабулировать функцию sin(x) + cos(2x)/2 + 1.5x\r\nРезультат вывести в виде таблицы\r\n";
            // 
            // groupBoxInput_ZIE
            // 
            groupBoxInput_ZIE.Controls.Add(textBoxTaskInf2_ZIE);
            groupBoxInput_ZIE.Controls.Add(textBoxTaskInf_ZIE);
            groupBoxInput_ZIE.Controls.Add(textBoxInputSTP_ZIE);
            groupBoxInput_ZIE.Controls.Add(textBoxInputSRT_ZIE);
            groupBoxInput_ZIE.Location = new Point(9, 315);
            groupBoxInput_ZIE.Name = "groupBoxInput_ZIE";
            groupBoxInput_ZIE.Size = new Size(339, 123);
            groupBoxInput_ZIE.TabIndex = 1;
            groupBoxInput_ZIE.TabStop = false;
            groupBoxInput_ZIE.Text = "Ввод данных";
            // 
            // textBoxTaskInf2_ZIE
            // 
            textBoxTaskInf2_ZIE.BorderStyle = BorderStyle.None;
            textBoxTaskInf2_ZIE.Location = new Point(179, 58);
            textBoxTaskInf2_ZIE.Name = "textBoxTaskInf2_ZIE";
            textBoxTaskInf2_ZIE.ReadOnly = true;
            textBoxTaskInf2_ZIE.Size = new Size(100, 16);
            textBoxTaskInf2_ZIE.TabIndex = 3;
            textBoxTaskInf2_ZIE.Text = "Конец шага:";
            // 
            // textBoxTaskInf_ZIE
            // 
            textBoxTaskInf_ZIE.BorderStyle = BorderStyle.None;
            textBoxTaskInf_ZIE.Location = new Point(15, 56);
            textBoxTaskInf_ZIE.Name = "textBoxTaskInf_ZIE";
            textBoxTaskInf_ZIE.ReadOnly = true;
            textBoxTaskInf_ZIE.Size = new Size(100, 16);
            textBoxTaskInf_ZIE.TabIndex = 2;
            textBoxTaskInf_ZIE.Text = "Старт шага:";
            // 
            // textBoxInputSTP_ZIE
            // 
            textBoxInputSTP_ZIE.Location = new Point(178, 87);
            textBoxInputSTP_ZIE.Name = "textBoxInputSTP_ZIE";
            textBoxInputSTP_ZIE.Size = new Size(100, 23);
            textBoxInputSTP_ZIE.TabIndex = 1;
            textBoxInputSTP_ZIE.Text = "5";
            // 
            // textBoxInputSRT_ZIE
            // 
            textBoxInputSRT_ZIE.Location = new Point(14, 86);
            textBoxInputSRT_ZIE.Name = "textBoxInputSRT_ZIE";
            textBoxInputSRT_ZIE.Size = new Size(100, 23);
            textBoxInputSRT_ZIE.TabIndex = 0;
            textBoxInputSRT_ZIE.Text = "-5";
            // 
            // groupBoxOutPut_ZIE
            // 
            groupBoxOutPut_ZIE.Controls.Add(textBoxResult_ZIE);
            groupBoxOutPut_ZIE.Location = new Point(536, 12);
            groupBoxOutPut_ZIE.Name = "groupBoxOutPut_ZIE";
            groupBoxOutPut_ZIE.Size = new Size(252, 426);
            groupBoxOutPut_ZIE.TabIndex = 2;
            groupBoxOutPut_ZIE.TabStop = false;
            groupBoxOutPut_ZIE.Text = "Вывод данных";
            // 
            // textBoxResult_ZIE
            // 
            textBoxResult_ZIE.Location = new Point(6, 29);
            textBoxResult_ZIE.Multiline = true;
            textBoxResult_ZIE.Name = "textBoxResult_ZIE";
            textBoxResult_ZIE.ReadOnly = true;
            textBoxResult_ZIE.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ZIE.Size = new Size(240, 383);
            textBoxResult_ZIE.TabIndex = 0;
            // 
            // buttonDone_ZIE
            // 
            buttonDone_ZIE.BackColor = Color.Chartreuse;
            buttonDone_ZIE.Location = new Point(435, 315);
            buttonDone_ZIE.Name = "buttonDone_ZIE";
            buttonDone_ZIE.Size = new Size(85, 123);
            buttonDone_ZIE.TabIndex = 3;
            buttonDone_ZIE.Text = "Выполнить";
            buttonDone_ZIE.UseVisualStyleBackColor = false;
            buttonDone_ZIE.Click += buttonDone_CLick;
            // 
            // buttonHelp_ZIE
            // 
            buttonHelp_ZIE.BackColor = Color.FromArgb(128, 64, 64);
            buttonHelp_ZIE.Location = new Point(354, 373);
            buttonHelp_ZIE.Name = "buttonHelp_ZIE";
            buttonHelp_ZIE.Size = new Size(75, 65);
            buttonHelp_ZIE.TabIndex = 4;
            buttonHelp_ZIE.Text = "Справка";
            buttonHelp_ZIE.UseVisualStyleBackColor = false;
            buttonHelp_ZIE.Click += buttonHelp_CLick;
            // 
            // FormMain_ZIE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_ZIE);
            Controls.Add(buttonDone_ZIE);
            Controls.Add(groupBoxOutPut_ZIE);
            Controls.Add(groupBoxInput_ZIE);
            Controls.Add(groupBoxTask_ZIE);
            Name = "FormMain_ZIE";
            Text = "Спринт 6 | Таск 1 | Вариант 5 | Закачурин И. Е. ";
            Load += Form1_Load;
            groupBoxTask_ZIE.ResumeLayout(false);
            groupBoxTask_ZIE.PerformLayout();
            groupBoxInput_ZIE.ResumeLayout(false);
            groupBoxInput_ZIE.PerformLayout();
            groupBoxOutPut_ZIE.ResumeLayout(false);
            groupBoxOutPut_ZIE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_ZIE;
        private GroupBox groupBoxInput_ZIE;
        private GroupBox groupBoxOutPut_ZIE;
        private TextBox textBoxTask_ZIE;
        private TextBox textBoxTaskInf2_ZIE;
        private TextBox textBoxTaskInf_ZIE;
        private TextBox textBoxInputSTP_ZIE;
        private TextBox textBoxInputSRT_ZIE;
        private TextBox textBoxResult_ZIE;
        private Button buttonDone_ZIE;
        private Button buttonHelp_ZIE;
    }
}
