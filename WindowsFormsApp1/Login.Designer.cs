namespace WindowsFormsApp1
{
    partial class Login
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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.ultraPictureBox2 = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
            this.ultraPictureBox1 = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
            this.ultraFormattedLinkLabel2 = new Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel();
            this.ultraFormattedLinkLabel1 = new Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel();
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ultraButton3 = new Infragistics.Win.Misc.UltraButton();
            this.ultraTextEditor1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditor2 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraFormattedLinkLabel3 = new Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor2)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraPictureBox2
            // 
            this.ultraPictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ultraPictureBox2.BackColorInternal = System.Drawing.SystemColors.ActiveCaption;
            this.ultraPictureBox2.BorderShadowColor = System.Drawing.Color.Empty;
            this.ultraPictureBox2.Location = new System.Drawing.Point(290, 117);
            this.ultraPictureBox2.Name = "ultraPictureBox2";
            this.ultraPictureBox2.Size = new System.Drawing.Size(33, 31);
            this.ultraPictureBox2.TabIndex = 13;
            // 
            // ultraPictureBox1
            // 
            this.ultraPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ultraPictureBox1.BackColorInternal = System.Drawing.SystemColors.ActiveCaption;
            this.ultraPictureBox1.BorderShadowColor = System.Drawing.Color.Empty;
            this.ultraPictureBox1.Location = new System.Drawing.Point(290, 216);
            this.ultraPictureBox1.Name = "ultraPictureBox1";
            this.ultraPictureBox1.Size = new System.Drawing.Size(33, 31);
            this.ultraPictureBox1.TabIndex = 12;
            // 
            // ultraFormattedLinkLabel2
            // 
            this.ultraFormattedLinkLabel2.Location = new System.Drawing.Point(325, 221);
            this.ultraFormattedLinkLabel2.Name = "ultraFormattedLinkLabel2";
            this.ultraFormattedLinkLabel2.Size = new System.Drawing.Size(157, 23);
            this.ultraFormattedLinkLabel2.TabIndex = 10;
            this.ultraFormattedLinkLabel2.TabStop = true;
            this.ultraFormattedLinkLabel2.Value = "Password";
            // 
            // ultraFormattedLinkLabel1
            // 
            this.ultraFormattedLinkLabel1.Location = new System.Drawing.Point(325, 125);
            this.ultraFormattedLinkLabel1.Name = "ultraFormattedLinkLabel1";
            this.ultraFormattedLinkLabel1.Size = new System.Drawing.Size(157, 23);
            this.ultraFormattedLinkLabel1.TabIndex = 8;
            this.ultraFormattedLinkLabel1.TabStop = true;
            this.ultraFormattedLinkLabel1.Value = "User Name";
            // 
            // ultraButton1
            // 
            this.ultraButton1.Location = new System.Drawing.Point(325, 295);
            this.ultraButton1.Name = "ultraButton1";
            this.ultraButton1.Size = new System.Drawing.Size(144, 39);
            this.ultraButton1.TabIndex = 7;
            this.ultraButton1.Text = "Log In";
            this.ultraButton1.Click += new System.EventHandler(this.ultraButton1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(342, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "Log In";
            // 
            // ultraButton3
            // 
            this.ultraButton3.Location = new System.Drawing.Point(337, 341);
            this.ultraButton3.Margin = new System.Windows.Forms.Padding(4);
            this.ultraButton3.Name = "ultraButton3";
            this.ultraButton3.Size = new System.Drawing.Size(122, 28);
            this.ultraButton3.TabIndex = 15;
            this.ultraButton3.Text = "Sign up";
            this.ultraButton3.Click += new System.EventHandler(this.ultraButton3_Click);
            // 
            // ultraTextEditor1
            // 
            this.ultraTextEditor1.Location = new System.Drawing.Point(290, 154);
            this.ultraTextEditor1.Name = "ultraTextEditor1";
            this.ultraTextEditor1.Size = new System.Drawing.Size(212, 21);
            this.ultraTextEditor1.TabIndex = 17;
            this.ultraTextEditor1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ultraTextEditor1_KeyDown);
            // 
            // ultraTextEditor2
            // 
            this.ultraTextEditor2.Location = new System.Drawing.Point(290, 250);
            this.ultraTextEditor2.Name = "ultraTextEditor2";
            this.ultraTextEditor2.PasswordChar = '*';
            this.ultraTextEditor2.Size = new System.Drawing.Size(212, 21);
            this.ultraTextEditor2.TabIndex = 18;
            this.ultraTextEditor2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ultraTextEditor2_KeyDown);
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Location = new System.Drawing.Point(290, 394);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel1.TabIndex = 19;
            this.ultraLabel1.Text = "Forgot password ? ";
            // 
            // ultraFormattedLinkLabel3
            // 
            appearance2.ForeColor = System.Drawing.Color.Blue;
            this.ultraFormattedLinkLabel3.Appearance = appearance2;
            this.ultraFormattedLinkLabel3.Location = new System.Drawing.Point(396, 394);
            this.ultraFormattedLinkLabel3.Name = "ultraFormattedLinkLabel3";
            this.ultraFormattedLinkLabel3.Size = new System.Drawing.Size(130, 23);
            this.ultraFormattedLinkLabel3.TabIndex = 20;
            this.ultraFormattedLinkLabel3.TabStop = true;
            this.ultraFormattedLinkLabel3.Value = "Clicked Here";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ultraFormattedLinkLabel3);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.ultraTextEditor2);
            this.Controls.Add(this.ultraTextEditor1);
            this.Controls.Add(this.ultraButton3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ultraPictureBox2);
            this.Controls.Add(this.ultraPictureBox1);
            this.Controls.Add(this.ultraFormattedLinkLabel2);
            this.Controls.Add(this.ultraFormattedLinkLabel1);
            this.Controls.Add(this.ultraButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraPictureBox ultraPictureBox2;
        private Infragistics.Win.UltraWinEditors.UltraPictureBox ultraPictureBox1;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel ultraFormattedLinkLabel2;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel ultraFormattedLinkLabel1;
        private Infragistics.Win.Misc.UltraButton ultraButton1;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.Misc.UltraButton ultraButton3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel ultraFormattedLinkLabel3;
    }
}