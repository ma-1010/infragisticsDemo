﻿namespace WindowsFormsApp1
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
            this.ultraPictureBox2 = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
            this.ultraPictureBox1 = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
            this.ultraFormattedLinkLabel2 = new Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel();
            this.ultraFormattedLinkLabel1 = new Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel();
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ultraButton3 = new Infragistics.Win.Misc.UltraButton();
            this.ultraTextEditor1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditor2 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(368, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 34);
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
            // 
            // ultraTextEditor2
            // 
            this.ultraTextEditor2.Location = new System.Drawing.Point(290, 250);
            this.ultraTextEditor2.Name = "ultraTextEditor2";
            this.ultraTextEditor2.PasswordChar = '*';
            this.ultraTextEditor2.Size = new System.Drawing.Size(212, 21);
            this.ultraTextEditor2.TabIndex = 18;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.RightToLeftLayout = true;
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
    }
}