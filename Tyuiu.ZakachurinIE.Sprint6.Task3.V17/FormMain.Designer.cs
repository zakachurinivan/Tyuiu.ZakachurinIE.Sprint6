namespace Tyuiu.ZakachurinIE.Sprint6.Task3.V17
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
            groupBoxTask_ZIE = new GroupBox();
            dataGridViewResult_ZIE = new DataGridView();
            textBoxTask_ZIE = new TextBox();
            groupBoxResult_ZIE = new GroupBox();
            textBoxResult_ZIE = new TextBox();
            textBoxOutPut_ZIE = new TextBox();
            buttonHelp_ZIE = new Button();
            buttonDone_ZIE = new Button();
            groupBoxTask_ZIE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ZIE).BeginInit();
            groupBoxResult_ZIE.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_ZIE
            // 
            groupBoxTask_ZIE.Controls.Add(dataGridViewResult_ZIE);
            groupBoxTask_ZIE.Controls.Add(textBoxTask_ZIE);
            groupBoxTask_ZIE.Location = new Point(12, 12);
            groupBoxTask_ZIE.Name = "groupBoxTask_ZIE";
            groupBoxTask_ZIE.Size = new Size(564, 426);
            groupBoxTask_ZIE.TabIndex = 0;
            groupBoxTask_ZIE.TabStop = false;
            groupBoxTask_ZIE.Text = "Условие";
            // 
            // dataGridViewResult_ZIE
            // 
            dataGridViewResult_ZIE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_ZIE.Location = new Point(345, 22);
            dataGridViewResult_ZIE.Name = "dataGridViewResult_ZIE";
            dataGridViewResult_ZIE.Size = new Size(213, 398);
            dataGridViewResult_ZIE.TabIndex = 1;
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
            // groupBoxResult_ZIE
            // 
            groupBoxResult_ZIE.Controls.Add(textBoxResult_ZIE);
            groupBoxResult_ZIE.Controls.Add(textBoxOutPut_ZIE);
            groupBoxResult_ZIE.Location = new Point(582, 12);
            groupBoxResult_ZIE.Name = "groupBoxResult_ZIE";
            groupBoxResult_ZIE.Size = new Size(211, 378);
            groupBoxResult_ZIE.TabIndex = 1;
            groupBoxResult_ZIE.TabStop = false;
            groupBoxResult_ZIE.Text = "Вывод данных";
            // 
            // textBoxResult_ZIE
            // 
            textBoxResult_ZIE.Location = new Point(15, 52);
            textBoxResult_ZIE.Multiline = true;
            textBoxResult_ZIE.Name = "textBoxResult_ZIE";
            textBoxResult_ZIE.Size = new Size(190, 311);
            textBoxResult_ZIE.TabIndex = 1;
            // 
            // textBoxOutPut_ZIE
            // 
            textBoxOutPut_ZIE.BorderStyle = BorderStyle.None;
            textBoxOutPut_ZIE.Location = new Point(14, 23);
            textBoxOutPut_ZIE.Name = "textBoxOutPut_ZIE";
            textBoxOutPut_ZIE.ReadOnly = true;
            textBoxOutPut_ZIE.Size = new Size(100, 16);
            textBoxOutPut_ZIE.TabIndex = 0;
            textBoxOutPut_ZIE.Text = "Результат:";
            // 
            // buttonHelp_ZIE
            // 
            buttonHelp_ZIE.Location = new Point(582, 415);
            buttonHelp_ZIE.Name = "buttonHelp_ZIE";
            buttonHelp_ZIE.Size = new Size(34, 23);
            buttonHelp_ZIE.TabIndex = 2;
            buttonHelp_ZIE.Text = "?";
            buttonHelp_ZIE.UseVisualStyleBackColor = true;
            buttonHelp_ZIE.Click += buttonHelp_CLick;
            // 
            // buttonDone_ZIE
            // 
            buttonDone_ZIE.Location = new Point(641, 415);
            buttonDone_ZIE.Name = "buttonDone_ZIE";
            buttonDone_ZIE.Size = new Size(147, 23);
            buttonDone_ZIE.TabIndex = 3;
            buttonDone_ZIE.Text = "Выполнить";
            buttonDone_ZIE.UseVisualStyleBackColor = true;
            buttonDone_ZIE.Click += buttoneDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_ZIE);
            Controls.Add(buttonHelp_ZIE);
            Controls.Add(groupBoxResult_ZIE);
            Controls.Add(groupBoxTask_ZIE);
            Name = "FormMain";
            Text = "Спринт 6 Таск 3 Вариант 17 Закачурин И.Е.";
            Load += FormMain_Load;
            groupBoxTask_ZIE.ResumeLayout(false);
            groupBoxTask_ZIE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ZIE).EndInit();
            groupBoxResult_ZIE.ResumeLayout(false);
            groupBoxResult_ZIE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_ZIE;
        private GroupBox groupBoxResult_ZIE;
        private TextBox textBoxTask_ZIE;
        private DataGridView dataGridViewResult_ZIE;
        private Button buttonHelp_ZIE;
        private Button buttonDone_ZIE;
        private TextBox textBoxResult_ZIE;
        private TextBox textBoxOutPut_ZIE;
    }
}
