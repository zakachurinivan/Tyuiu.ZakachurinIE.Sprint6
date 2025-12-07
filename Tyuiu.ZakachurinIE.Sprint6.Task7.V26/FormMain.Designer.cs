namespace Tyuiu.ZakachurinIE.Sprint6.Task7.V26
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_ZIE = new Panel();
            buttonHelp_ZIE = new Button();
            buttonSave_ZIE = new Button();
            buttonDone_ZIE = new Button();
            buttonOpen_ZIE = new Button();
            panelTask_ZIE = new Panel();
            groupBoxTask_ZIE = new GroupBox();
            textBoxTask_ZIE = new TextBox();
            panelInputOutput_ZIE = new Panel();
            groupBoxOut_ZIE = new GroupBox();
            dataGridViewOutput_ZIE = new DataGridView();
            groupBoxIn_ZIE = new GroupBox();
            dataGridViewInput_ZIE = new DataGridView();
            openFileDialogTask_ZIE = new OpenFileDialog();
            toolTipInfo_ZIE = new ToolTip(components);
            saveFileDialogTask_ZIE = new SaveFileDialog();
            panelButtons_ZIE.SuspendLayout();
            panelTask_ZIE.SuspendLayout();
            groupBoxTask_ZIE.SuspendLayout();
            panelInputOutput_ZIE.SuspendLayout();
            groupBoxOut_ZIE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_ZIE).BeginInit();
            groupBoxIn_ZIE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_ZIE).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_ZIE
            // 
            panelButtons_ZIE.Controls.Add(buttonHelp_ZIE);
            panelButtons_ZIE.Controls.Add(buttonSave_ZIE);
            panelButtons_ZIE.Controls.Add(buttonDone_ZIE);
            panelButtons_ZIE.Controls.Add(buttonOpen_ZIE);
            panelButtons_ZIE.Dock = DockStyle.Top;
            panelButtons_ZIE.Location = new Point(0, 0);
            panelButtons_ZIE.Name = "panelButtons_ZIE";
            panelButtons_ZIE.Size = new Size(800, 100);
            panelButtons_ZIE.TabIndex = 0;
            // 
            // buttonHelp_ZIE
            // 
            buttonHelp_ZIE.Image = Properties.Resources.help;
            buttonHelp_ZIE.Location = new Point(683, 3);
            buttonHelp_ZIE.Name = "buttonHelp_ZIE";
            buttonHelp_ZIE.Size = new Size(75, 91);
            buttonHelp_ZIE.TabIndex = 0;
            toolTipInfo_ZIE.SetToolTip(buttonHelp_ZIE, "О программе\r\n");
            buttonHelp_ZIE.UseVisualStyleBackColor = true;
            buttonHelp_ZIE.Click += buttonHelp_Click;
            // 
            // buttonSave_ZIE
            // 
            buttonSave_ZIE.Enabled = false;
            buttonSave_ZIE.Image = Properties.Resources.page_save;
            buttonSave_ZIE.Location = new Point(254, 3);
            buttonSave_ZIE.Name = "buttonSave_ZIE";
            buttonSave_ZIE.Size = new Size(75, 91);
            buttonSave_ZIE.TabIndex = 0;
            toolTipInfo_ZIE.SetToolTip(buttonSave_ZIE, "Сохранить файл\r\n");
            buttonSave_ZIE.UseVisualStyleBackColor = true;
            buttonSave_ZIE.Click += buttonSaveFile_Click;
            // 
            // buttonDone_ZIE
            // 
            buttonDone_ZIE.Enabled = false;
            buttonDone_ZIE.Image = Properties.Resources.accept;
            buttonDone_ZIE.Location = new Point(146, 3);
            buttonDone_ZIE.Name = "buttonDone_ZIE";
            buttonDone_ZIE.Size = new Size(75, 91);
            buttonDone_ZIE.TabIndex = 0;
            toolTipInfo_ZIE.SetToolTip(buttonDone_ZIE, "Выполнить программу\r\n");
            buttonDone_ZIE.UseVisualStyleBackColor = true;
            buttonDone_ZIE.Click += buttonDone_Click;
            // 
            // buttonOpen_ZIE
            // 
            buttonOpen_ZIE.Image = Properties.Resources.add;
            buttonOpen_ZIE.Location = new Point(35, 3);
            buttonOpen_ZIE.Name = "buttonOpen_ZIE";
            buttonOpen_ZIE.Size = new Size(75, 91);
            buttonOpen_ZIE.TabIndex = 0;
            toolTipInfo_ZIE.SetToolTip(buttonOpen_ZIE, "Открыть файл\r\n");
            buttonOpen_ZIE.UseVisualStyleBackColor = true;
            buttonOpen_ZIE.Click += buttonOpen_ZIE_Click;
            // 
            // panelTask_ZIE
            // 
            panelTask_ZIE.Controls.Add(groupBoxTask_ZIE);
            panelTask_ZIE.Dock = DockStyle.Fill;
            panelTask_ZIE.Location = new Point(0, 100);
            panelTask_ZIE.Name = "panelTask_ZIE";
            panelTask_ZIE.Size = new Size(800, 349);
            panelTask_ZIE.TabIndex = 0;
            // 
            // groupBoxTask_ZIE
            // 
            groupBoxTask_ZIE.Controls.Add(textBoxTask_ZIE);
            groupBoxTask_ZIE.Location = new Point(5, 6);
            groupBoxTask_ZIE.Name = "groupBoxTask_ZIE";
            groupBoxTask_ZIE.Size = new Size(792, 238);
            groupBoxTask_ZIE.TabIndex = 0;
            groupBoxTask_ZIE.TabStop = false;
            groupBoxTask_ZIE.Text = "Условие";
            // 
            // textBoxTask_ZIE
            // 
            textBoxTask_ZIE.BorderStyle = BorderStyle.None;
            textBoxTask_ZIE.Location = new Point(7, 21);
            textBoxTask_ZIE.Multiline = true;
            textBoxTask_ZIE.Name = "textBoxTask_ZIE";
            textBoxTask_ZIE.ReadOnly = true;
            textBoxTask_ZIE.Size = new Size(546, 120);
            textBoxTask_ZIE.TabIndex = 0;
            textBoxTask_ZIE.Text = resources.GetString("textBoxTask_ZIE.Text");
            // 
            // panelInputOutput_ZIE
            // 
            panelInputOutput_ZIE.Controls.Add(groupBoxOut_ZIE);
            panelInputOutput_ZIE.Controls.Add(groupBoxIn_ZIE);
            panelInputOutput_ZIE.Dock = DockStyle.Bottom;
            panelInputOutput_ZIE.Location = new Point(0, 263);
            panelInputOutput_ZIE.Name = "panelInputOutput_ZIE";
            panelInputOutput_ZIE.Size = new Size(800, 186);
            panelInputOutput_ZIE.TabIndex = 0;
            // 
            // groupBoxOut_ZIE
            // 
            groupBoxOut_ZIE.Controls.Add(dataGridViewOutput_ZIE);
            groupBoxOut_ZIE.Location = new Point(369, 11);
            groupBoxOut_ZIE.Name = "groupBoxOut_ZIE";
            groupBoxOut_ZIE.Size = new Size(357, 175);
            groupBoxOut_ZIE.TabIndex = 0;
            groupBoxOut_ZIE.TabStop = false;
            groupBoxOut_ZIE.Text = "Вывод:";
            // 
            // dataGridViewOutput_ZIE
            // 
            dataGridViewOutput_ZIE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_ZIE.Location = new Point(6, 19);
            dataGridViewOutput_ZIE.Name = "dataGridViewOutput_ZIE";
            dataGridViewOutput_ZIE.Size = new Size(334, 150);
            dataGridViewOutput_ZIE.TabIndex = 3;
            // 
            // groupBoxIn_ZIE
            // 
            groupBoxIn_ZIE.Controls.Add(dataGridViewInput_ZIE);
            groupBoxIn_ZIE.Location = new Point(6, 8);
            groupBoxIn_ZIE.Name = "groupBoxIn_ZIE";
            groupBoxIn_ZIE.Size = new Size(357, 175);
            groupBoxIn_ZIE.TabIndex = 0;
            groupBoxIn_ZIE.TabStop = false;
            groupBoxIn_ZIE.Text = "Ввод:";
            // 
            // dataGridViewInput_ZIE
            // 
            dataGridViewInput_ZIE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_ZIE.Location = new Point(6, 19);
            dataGridViewInput_ZIE.Name = "dataGridViewInput_ZIE";
            dataGridViewInput_ZIE.Size = new Size(345, 150);
            dataGridViewInput_ZIE.TabIndex = 2;
            // 
            // openFileDialogTask_ZIE
            // 
            openFileDialogTask_ZIE.FileName = "openFileDialogTask_ZIE";
            // 
            // toolTipInfo_ZIE
            // 
            toolTipInfo_ZIE.IsBalloon = true;
            toolTipInfo_ZIE.ToolTipIcon = ToolTipIcon.Info;
            toolTipInfo_ZIE.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(panelInputOutput_ZIE);
            Controls.Add(panelTask_ZIE);
            Controls.Add(panelButtons_ZIE);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 Таск 7 Вариант 26 Закачурин И.Е.";
            panelButtons_ZIE.ResumeLayout(false);
            panelTask_ZIE.ResumeLayout(false);
            groupBoxTask_ZIE.ResumeLayout(false);
            groupBoxTask_ZIE.PerformLayout();
            panelInputOutput_ZIE.ResumeLayout(false);
            groupBoxOut_ZIE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_ZIE).EndInit();
            groupBoxIn_ZIE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_ZIE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons_ZIE;
        private Panel panelTask_ZIE;
        private Panel panelInputOutput_ZIE;
        private Button buttonHelp_ZIE;
        private Button buttonSave_ZIE;
        private Button buttonDone_ZIE;
        private Button buttonOpen_ZIE;
        private GroupBox groupBoxTask_ZIE;
        private TextBox textBoxTask_ZIE;
        private GroupBox groupBoxOut_ZIE;
        private DataGridView dataGridViewOutput_ZIE;
        private GroupBox groupBoxIn_ZIE;
        private DataGridView dataGridViewInput_ZIE;
        private ToolTip toolTipInfo_ZIE;
        private OpenFileDialog openFileDialogTask_ZIE;
        private SaveFileDialog saveFileDialogTask_ZIE;
    }
}
