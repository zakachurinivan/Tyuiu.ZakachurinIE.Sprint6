
namespace Tyuiu.ZakachurinIE.Sprint6.Task0.V17
{
    partial class Formmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formmain));
            groupBoxTask_ZIE = new GroupBox();
            pictureBoxFormula_ZIE = new PictureBox();
            textBoxTask_ZIE = new TextBox();
            groupBoxInput_ZIE = new GroupBox();
            textBoxVarA_ZIE = new TextBox();
            textBoxA_ZIE = new TextBox();
            groupBoxOutput_ZIE = new GroupBox();
            buttonHelp_ZIE = new Button();
            buttonDone_ZIE = new Button();
            textBoxResult_ZIE = new TextBox();
            textBoxOutPut_ZIE = new TextBox();
            groupBoxTask_ZIE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_ZIE).BeginInit();
            groupBoxInput_ZIE.SuspendLayout();
            groupBoxOutput_ZIE.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_ZIE
            // 
            groupBoxTask_ZIE.Controls.Add(pictureBoxFormula_ZIE);
            groupBoxTask_ZIE.Controls.Add(textBoxTask_ZIE);
            groupBoxTask_ZIE.Location = new Point(12, 12);
            groupBoxTask_ZIE.Name = "groupBoxTask_ZIE";
            groupBoxTask_ZIE.Size = new Size(776, 257);
            groupBoxTask_ZIE.TabIndex = 0;
            groupBoxTask_ZIE.TabStop = false;
            groupBoxTask_ZIE.Text = "Условие";
            groupBoxTask_ZIE.Enter += groupBox1_Enter;
            // 
            // pictureBoxFormula_ZIE
            // 
            pictureBoxFormula_ZIE.Image = (Image)resources.GetObject("pictureBoxFormula_ZIE.Image");
            pictureBoxFormula_ZIE.Location = new Point(640, 22);
            pictureBoxFormula_ZIE.Name = "pictureBoxFormula_ZIE";
            pictureBoxFormula_ZIE.Size = new Size(72, 53);
            pictureBoxFormula_ZIE.TabIndex = 1;
            pictureBoxFormula_ZIE.TabStop = false;
            // 
            // textBoxTask_ZIE
            // 
            textBoxTask_ZIE.BorderStyle = BorderStyle.None;
            textBoxTask_ZIE.Location = new Point(15, 22);
            textBoxTask_ZIE.Multiline = true;
            textBoxTask_ZIE.Name = "textBoxTask_ZIE";
            textBoxTask_ZIE.ReadOnly = true;
            textBoxTask_ZIE.Size = new Size(214, 23);
            textBoxTask_ZIE.TabIndex = 0;
            textBoxTask_ZIE.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInput_ZIE
            // 
            groupBoxInput_ZIE.Controls.Add(textBoxVarA_ZIE);
            groupBoxInput_ZIE.Controls.Add(textBoxA_ZIE);
            groupBoxInput_ZIE.Location = new Point(12, 275);
            groupBoxInput_ZIE.Name = "groupBoxInput_ZIE";
            groupBoxInput_ZIE.Size = new Size(523, 163);
            groupBoxInput_ZIE.TabIndex = 1;
            groupBoxInput_ZIE.TabStop = false;
            groupBoxInput_ZIE.Text = "Ввод данных";
            // 
            // textBoxVarA_ZIE
            // 
            textBoxVarA_ZIE.Location = new Point(208, 97);
            textBoxVarA_ZIE.Name = "textBoxVarA_ZIE";
            textBoxVarA_ZIE.Size = new Size(102, 23);
            textBoxVarA_ZIE.TabIndex = 1;
            textBoxVarA_ZIE.KeyPress += textBoxVarA_ZIE_KeyPress;
            // 
            // textBoxA_ZIE
            // 
            textBoxA_ZIE.BorderStyle = BorderStyle.None;
            textBoxA_ZIE.Location = new Point(208, 45);
            textBoxA_ZIE.Name = "textBoxA_ZIE";
            textBoxA_ZIE.ReadOnly = true;
            textBoxA_ZIE.Size = new Size(102, 16);
            textBoxA_ZIE.TabIndex = 0;
            textBoxA_ZIE.Text = "Переменная X:";
            // 
            // groupBoxOutput_ZIE
            // 
            groupBoxOutput_ZIE.Controls.Add(buttonHelp_ZIE);
            groupBoxOutput_ZIE.Controls.Add(buttonDone_ZIE);
            groupBoxOutput_ZIE.Controls.Add(textBoxResult_ZIE);
            groupBoxOutput_ZIE.Controls.Add(textBoxOutPut_ZIE);
            groupBoxOutput_ZIE.Location = new Point(545, 284);
            groupBoxOutput_ZIE.Name = "groupBoxOutput_ZIE";
            groupBoxOutput_ZIE.Size = new Size(243, 154);
            groupBoxOutput_ZIE.TabIndex = 2;
            groupBoxOutput_ZIE.TabStop = false;
            groupBoxOutput_ZIE.Text = "Вывод данных";
            // 
            // buttonHelp_ZIE
            // 
            buttonHelp_ZIE.FlatStyle = FlatStyle.Flat;
            buttonHelp_ZIE.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonHelp_ZIE.ForeColor = SystemColors.MenuHighlight;
            buttonHelp_ZIE.Location = new Point(86, 118);
            buttonHelp_ZIE.Name = "buttonHelp_ZIE";
            buttonHelp_ZIE.Size = new Size(28, 23);
            buttonHelp_ZIE.TabIndex = 3;
            buttonHelp_ZIE.Text = "?";
            buttonHelp_ZIE.UseVisualStyleBackColor = true;
            buttonHelp_ZIE.Click += buttonHelp_ZIE_Click;
            // 
            // buttonDone_ZIE
            // 
            buttonDone_ZIE.Location = new Point(135, 110);
            buttonDone_ZIE.Name = "buttonDone_ZIE";
            buttonDone_ZIE.Size = new Size(102, 38);
            buttonDone_ZIE.TabIndex = 2;
            buttonDone_ZIE.Text = "Выполнить";
            buttonDone_ZIE.UseVisualStyleBackColor = true;
            buttonDone_ZIE.Click += buttonDone_ZIE_Click;
            // 
            // textBoxResult_ZIE
            // 
            textBoxResult_ZIE.Location = new Point(14, 88);
            textBoxResult_ZIE.Name = "textBoxResult_ZIE";
            textBoxResult_ZIE.ReadOnly = true;
            textBoxResult_ZIE.Size = new Size(100, 23);
            textBoxResult_ZIE.TabIndex = 1;
            textBoxResult_ZIE.TextChanged += buttonDone_ZIE_Click;
            // 
            // textBoxOutPut_ZIE
            // 
            textBoxOutPut_ZIE.BorderStyle = BorderStyle.None;
            textBoxOutPut_ZIE.Location = new Point(14, 36);
            textBoxOutPut_ZIE.Name = "textBoxOutPut_ZIE";
            textBoxOutPut_ZIE.ReadOnly = true;
            textBoxOutPut_ZIE.Size = new Size(100, 16);
            textBoxOutPut_ZIE.TabIndex = 0;
            textBoxOutPut_ZIE.Text = "Результат:";
            // 
            // Formmain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutput_ZIE);
            Controls.Add(groupBoxInput_ZIE);
            Controls.Add(groupBoxTask_ZIE);
            Name = "Formmain";
            Text = "Спринт 6 | Таск 0 | Вариант 17 | Закачурин И.Е";
            Load += FormMain_Load;
            groupBoxTask_ZIE.ResumeLayout(false);
            groupBoxTask_ZIE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_ZIE).EndInit();
            groupBoxInput_ZIE.ResumeLayout(false);
            groupBoxInput_ZIE.PerformLayout();
            groupBoxOutput_ZIE.ResumeLayout(false);
            groupBoxOutput_ZIE.PerformLayout();
            ResumeLayout(false);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private GroupBox groupBoxTask_ZIE;
        private PictureBox pictureBoxFormula_ZIE;
        private TextBox textBoxTask_ZIE;
        private GroupBox groupBoxInput_ZIE;
        private GroupBox groupBoxOutput_ZIE;
        private TextBox textBoxVarA_ZIE;
        private TextBox textBoxA_ZIE;
        private TextBox textBoxOutPut_ZIE;
        private Button buttonHelp_ZIE;
        private Button buttonDone_ZIE;
        private TextBox textBoxResult_ZIE;
    }
}
