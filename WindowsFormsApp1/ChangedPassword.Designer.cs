namespace WindowsFormsApp1
{
    partial class ChangedPassword
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
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditor2 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditor1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditor3 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditor4 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor4)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraButton1
            // 
            this.ultraButton1.Location = new System.Drawing.Point(135, 298);
            this.ultraButton1.Name = "ultraButton1";
            this.ultraButton1.Size = new System.Drawing.Size(114, 54);
            this.ultraButton1.TabIndex = 0;
            this.ultraButton1.Text = "Change";
            this.ultraButton1.Click += new System.EventHandler(this.ultraButton1_Click);
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Location = new System.Drawing.Point(85, 61);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(118, 29);
            this.ultraLabel1.TabIndex = 1;
            this.ultraLabel1.Text = "Username";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Location = new System.Drawing.Point(53, 122);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(118, 29);
            this.ultraLabel2.TabIndex = 2;
            this.ultraLabel2.Text = "Curent password";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Location = new System.Drawing.Point(83, 185);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(118, 29);
            this.ultraLabel3.TabIndex = 4;
            this.ultraLabel3.Text = "Password";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.Location = new System.Drawing.Point(42, 243);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(118, 29);
            this.ultraLabel4.TabIndex = 3;
            this.ultraLabel4.Text = "Comfirm password";
            // 
            // ultraTextEditor2
            // 
            this.ultraTextEditor2.Location = new System.Drawing.Point(148, 182);
            this.ultraTextEditor2.Name = "ultraTextEditor2";
            this.ultraTextEditor2.PasswordChar = '*';
            this.ultraTextEditor2.Size = new System.Drawing.Size(118, 21);
            this.ultraTextEditor2.TabIndex = 8;
            // 
            // ultraTextEditor1
            // 
            this.ultraTextEditor1.Location = new System.Drawing.Point(148, 239);
            this.ultraTextEditor1.Name = "ultraTextEditor1";
            this.ultraTextEditor1.PasswordChar = '*';
            this.ultraTextEditor1.Size = new System.Drawing.Size(118, 21);
            this.ultraTextEditor1.TabIndex = 7;
            // 
            // ultraTextEditor3
            // 
            this.ultraTextEditor3.Location = new System.Drawing.Point(148, 119);
            this.ultraTextEditor3.Name = "ultraTextEditor3";
            this.ultraTextEditor3.PasswordChar = '*';
            this.ultraTextEditor3.Size = new System.Drawing.Size(118, 21);
            this.ultraTextEditor3.TabIndex = 10;
            // 
            // ultraTextEditor4
            // 
            this.ultraTextEditor4.Location = new System.Drawing.Point(148, 59);
            this.ultraTextEditor4.Name = "ultraTextEditor4";
            this.ultraTextEditor4.Size = new System.Drawing.Size(118, 21);
            this.ultraTextEditor4.TabIndex = 9;
            // 
            // ChangedPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 387);
            this.Controls.Add(this.ultraTextEditor3);
            this.Controls.Add(this.ultraTextEditor4);
            this.Controls.Add(this.ultraTextEditor2);
            this.Controls.Add(this.ultraTextEditor1);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.ultraLabel4);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.ultraButton1);
            this.Name = "ChangedPassword";
            this.Text = "ChangedPassword";
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraButton ultraButton1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor4;
    }
}