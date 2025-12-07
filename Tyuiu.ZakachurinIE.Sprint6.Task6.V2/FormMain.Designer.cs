
namespace Tyuiu.ZakachurinIE.Sprint6.Task6.V2
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
            buttonDone_ZIE = new Button();
            buttonOpen_ZIE = new Button();
            panelTask_ZIE = new Panel();
            groupBoxTask_ZIE = new GroupBox();
            textBoxTask_ZIE = new TextBox();
            panelInput_ZIE = new Panel();
            groupBoxIn_ZIE = new GroupBox();
            textBoxInput_ZIE = new TextBox();
            panelOutPut_ZIE = new Panel();
            groupBoxOut_ZIE = new GroupBox();
            textBoxOutPut_ZIE = new TextBox();
            openFileDialogTak_ZIE = new OpenFileDialog();
            toolTipTask_ZIE = new ToolTip(components);
            panelButtons_ZIE.SuspendLayout();
            panelTask_ZIE.SuspendLayout();
            groupBoxTask_ZIE.SuspendLayout();
            panelInput_ZIE.SuspendLayout();
            groupBoxIn_ZIE.SuspendLayout();
            panelOutPut_ZIE.SuspendLayout();
            groupBoxOut_ZIE.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons_ZIE
            // 
            panelButtons_ZIE.AutoSize = true;
            panelButtons_ZIE.BorderStyle = BorderStyle.FixedSingle;
            panelButtons_ZIE.Controls.Add(buttonHelp_ZIE);
            panelButtons_ZIE.Controls.Add(buttonDone_ZIE);
            panelButtons_ZIE.Controls.Add(buttonOpen_ZIE);
            panelButtons_ZIE.Dock = DockStyle.Top;
            panelButtons_ZIE.Location = new Point(0, 0);
            panelButtons_ZIE.Name = "panelButtons_ZIE";
            panelButtons_ZIE.Size = new Size(1001, 87);
            panelButtons_ZIE.TabIndex = 0;
            // 
            // buttonHelp_ZIE
            // 
            buttonHelp_ZIE.Image = (Image)resources.GetObject("buttonHelp_ZIE.Image");
            buttonHelp_ZIE.Location = new Point(672, 3);
            buttonHelp_ZIE.Name = "buttonHelp_ZIE";
            buttonHelp_ZIE.Size = new Size(119, 79);
            buttonHelp_ZIE.TabIndex = 2;
            toolTipTask_ZIE.SetToolTip(buttonHelp_ZIE, "Сведения о программе\r\n");
            buttonHelp_ZIE.UseVisualStyleBackColor = true;
            
            buttonHelp_ZIE.Click += buttonHelp_Click;
            // 
            // buttonDone_ZIE
            // 
            buttonDone_ZIE.Image = (Image)resources.GetObject("buttonDone_ZIE.Image");
            buttonDone_ZIE.Location = new Point(110, 3);
            buttonDone_ZIE.Name = "buttonDone_ZIE";
            buttonDone_ZIE.Size = new Size(97, 79);
            buttonDone_ZIE.TabIndex = 1;
            toolTipTask_ZIE.SetToolTip(buttonDone_ZIE, "Выполнить программу\r\n");
            buttonDone_ZIE.UseVisualStyleBackColor = true;
            buttonDone_ZIE.Click += buttonDone_Click;
            // 
            // buttonOpen_ZIE
            // 
            buttonOpen_ZIE.Image = (Image)resources.GetObject("buttonOpen_ZIE.Image");
            buttonOpen_ZIE.Location = new Point(3, 3);
            buttonOpen_ZIE.Name = "buttonOpen_ZIE";
            buttonOpen_ZIE.Size = new Size(101, 79);
            buttonOpen_ZIE.TabIndex = 0;
            toolTipTask_ZIE.SetToolTip(buttonOpen_ZIE, "Выберите нужный файл для обработки\r\n");
            buttonOpen_ZIE.UseVisualStyleBackColor = true;
            buttonOpen_ZIE.Click += buttonOpen_ZIE_Click;
            // 
            // panelTask_ZIE
            // 
            panelTask_ZIE.Controls.Add(groupBoxTask_ZIE);
            panelTask_ZIE.Dock = DockStyle.Fill;
            panelTask_ZIE.Location = new Point(0, 87);
            panelTask_ZIE.Name = "panelTask_ZIE";
            panelTask_ZIE.Size = new Size(1001, 524);
            panelTask_ZIE.TabIndex = 1;
            
            // 
            // groupBoxTask_ZIE
            // 
            groupBoxTask_ZIE.Controls.Add(textBoxTask_ZIE);
            groupBoxTask_ZIE.Location = new Point(3, 3);
            groupBoxTask_ZIE.Name = "groupBoxTask_ZIE";
            groupBoxTask_ZIE.Size = new Size(576, 91);
            groupBoxTask_ZIE.TabIndex = 0;
            groupBoxTask_ZIE.TabStop = false;
            groupBoxTask_ZIE.Text = "Условие";
            // 
            // textBoxTask_ZIE
            // 
            textBoxTask_ZIE.BorderStyle = BorderStyle.None;
            textBoxTask_ZIE.Location = new Point(0, 15);
            textBoxTask_ZIE.Multiline = true;
            textBoxTask_ZIE.Name = "textBoxTask_ZIE";
            textBoxTask_ZIE.ReadOnly = true;
            textBoxTask_ZIE.Size = new Size(564, 70);
            textBoxTask_ZIE.TabIndex = 0;
            textBoxTask_ZIE.Text = resources.GetString("textBoxTask_ZIE.Text");
            // 
            // panelInput_ZIE
            // 
            panelInput_ZIE.AutoSize = true;
            panelInput_ZIE.Controls.Add(groupBoxIn_ZIE);
            panelInput_ZIE.Dock = DockStyle.Bottom;
            panelInput_ZIE.Location = new Point(0, 358);
            panelInput_ZIE.Name = "panelInput_ZIE";
            panelInput_ZIE.Size = new Size(1001, 253);
            panelInput_ZIE.TabIndex = 2;
            // 
            // groupBoxIn_ZIE
            // 
            groupBoxIn_ZIE.Controls.Add(textBoxInput_ZIE);
            groupBoxIn_ZIE.Location = new Point(0, 3);
            groupBoxIn_ZIE.Name = "groupBoxIn_ZIE";
            groupBoxIn_ZIE.Size = new Size(391, 247);
            groupBoxIn_ZIE.TabIndex = 0;
            groupBoxIn_ZIE.TabStop = false;
            groupBoxIn_ZIE.Text = "Ввод :";
            // 
            // textBoxInput_ZIE
            // 
            textBoxInput_ZIE.Location = new Point(6, 22);
            textBoxInput_ZIE.Multiline = true;
            textBoxInput_ZIE.Name = "textBoxInput_ZIE";
            textBoxInput_ZIE.ReadOnly = true;
            textBoxInput_ZIE.ScrollBars = ScrollBars.Vertical;
            textBoxInput_ZIE.Size = new Size(379, 218);
            textBoxInput_ZIE.TabIndex = 0;
            // 
            // panelOutPut_ZIE
            // 
            panelOutPut_ZIE.AutoSize = true;
            panelOutPut_ZIE.Controls.Add(groupBoxOut_ZIE);
            panelOutPut_ZIE.Dock = DockStyle.Right;
            panelOutPut_ZIE.Location = new Point(603, 87);
            panelOutPut_ZIE.Name = "panelOutPut_ZIE";
            panelOutPut_ZIE.Size = new Size(398, 271);
            panelOutPut_ZIE.TabIndex = 3;
            // 
            // groupBoxOut_ZIE
            // 
            groupBoxOut_ZIE.Controls.Add(textBoxOutPut_ZIE);
            groupBoxOut_ZIE.Location = new Point(3, 3);
            groupBoxOut_ZIE.Name = "groupBoxOut_ZIE";
            groupBoxOut_ZIE.Size = new Size(392, 247);
            groupBoxOut_ZIE.TabIndex = 1;
            groupBoxOut_ZIE.TabStop = false;
            groupBoxOut_ZIE.Text = "Вывод :";
            // 
            // textBoxOutPut_ZIE
            // 
            textBoxOutPut_ZIE.Location = new Point(6, 29);
            textBoxOutPut_ZIE.Multiline = true;
            textBoxOutPut_ZIE.Name = "textBoxOutPut_ZIE";
            textBoxOutPut_ZIE.ReadOnly = true;
            textBoxOutPut_ZIE.ScrollBars = ScrollBars.Vertical;
            textBoxOutPut_ZIE.Size = new Size(370, 218);
            textBoxOutPut_ZIE.TabIndex = 1;
            // 
            // openFileDialogTak_ZIE
            // 
            openFileDialogTak_ZIE.FileName = "openFileDialogTask_ZIE";
            // 
            // toolTipTask_ZIE
            // 
            toolTipTask_ZIE.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask_ZIE.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1001, 611);
            Controls.Add(panelOutPut_ZIE);
            Controls.Add(panelInput_ZIE);
            Controls.Add(panelTask_ZIE);
            Controls.Add(panelButtons_ZIE);
            MinimumSize = new Size(600, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 Таск 6 Вариант 2 Закачурин И.Е.";
            Load += FormMain_Load;
            panelButtons_ZIE.ResumeLayout(false);
            panelTask_ZIE.ResumeLayout(false);
            groupBoxTask_ZIE.ResumeLayout(false);
            groupBoxTask_ZIE.PerformLayout();
            panelInput_ZIE.ResumeLayout(false);
            groupBoxIn_ZIE.ResumeLayout(false);
            groupBoxIn_ZIE.PerformLayout();
            panelOutPut_ZIE.ResumeLayout(false);
            groupBoxOut_ZIE.ResumeLayout(false);
            groupBoxOut_ZIE.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        

        

        

        

        private void FormMain_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelButtons_ZIE;
        private Button buttonDone_ZIE;
        private Button buttonOpen_ZIE;
        private Button buttonHelp_ZIE;
        private Panel panelTask_ZIE;
        private GroupBox groupBoxTask_ZIE;
        private TextBox textBoxTask_ZIE;
        private Panel panelInput_ZIE;
        private GroupBox groupBoxIn_ZIE;
        private Panel panelOutPut_ZIE;
        private GroupBox groupBoxOut_ZIE;
        private TextBox textBoxInput_ZIE;
        private TextBox textBoxOutPut_ZIE;
        private ToolTip toolTipTask_ZIE;
        private OpenFileDialog openFileDialogTak_ZIE;
    }
}
