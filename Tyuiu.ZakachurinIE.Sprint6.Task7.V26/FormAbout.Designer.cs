namespace Tyuiu.ZakachurinIE.Sprint6.Task7.V26
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonOK_ZIE = new Button();
            textBoxInfo_ZIE = new TextBox();
            pictureBoxAvatar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // buttonOK_ZIE
            // 
            buttonOK_ZIE.Location = new Point(361, 214);
            buttonOK_ZIE.Name = "buttonOK_ZIE";
            buttonOK_ZIE.Size = new Size(75, 23);
            buttonOK_ZIE.TabIndex = 5;
            buttonOK_ZIE.Text = "OK";
            buttonOK_ZIE.UseVisualStyleBackColor = true;
            buttonOK_ZIE.Click += buttonOK_ZIE_Click;
            // 
            // textBoxInfo_ZIE
            // 
            textBoxInfo_ZIE.Location = new Point(192, 12);
            textBoxInfo_ZIE.Multiline = true;
            textBoxInfo_ZIE.Name = "textBoxInfo_ZIE";
            textBoxInfo_ZIE.ReadOnly = true;
            textBoxInfo_ZIE.Size = new Size(244, 225);
            textBoxInfo_ZIE.TabIndex = 4;
            textBoxInfo_ZIE.Text = resources.GetString("textBoxInfo_ZIE.Text");
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Image = Properties.Resources.photo_2025_11_02_22_17_34;
            pictureBoxAvatar.Location = new Point(12, 12);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(174, 227);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar.TabIndex = 3;
            pictureBoxAvatar.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 249);
            Controls.Add(buttonOK_ZIE);
            Controls.Add(textBoxInfo_ZIE);
            Controls.Add(pictureBoxAvatar);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK_ZIE;
        private TextBox textBoxInfo_ZIE;
        private PictureBox pictureBoxAvatar;
    }
}