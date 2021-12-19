
namespace Library.Dekstop
{
    partial class LoginAsAdmin
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
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.openAdminButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.closeAdminLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(50, 56);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(257, 20);
            this.loginBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(50, 114);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(257, 20);
            this.passwordBox.TabIndex = 1;
            // 
            // openAdminButton
            // 
            this.openAdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openAdminButton.Location = new System.Drawing.Point(341, 161);
            this.openAdminButton.Name = "openAdminButton";
            this.openAdminButton.Size = new System.Drawing.Size(88, 32);
            this.openAdminButton.TabIndex = 2;
            this.openAdminButton.Text = "Open";
            this.openAdminButton.UseVisualStyleBackColor = true;
            this.openAdminButton.Click += new System.EventHandler(this.openAdminButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // closeAdminLabel
            // 
            this.closeAdminLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAdminLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAdminLabel.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Bold);
            this.closeAdminLabel.Location = new System.Drawing.Point(397, 9);
            this.closeAdminLabel.Name = "closeAdminLabel";
            this.closeAdminLabel.Size = new System.Drawing.Size(32, 40);
            this.closeAdminLabel.TabIndex = 6;
            this.closeAdminLabel.Text = "X";
            this.closeAdminLabel.Click += new System.EventHandler(this.closeAdminLabel_Click);
            // 
            // LoginAsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 205);
            this.Controls.Add(this.closeAdminLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openAdminButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginAsAdmin";
            this.Text = "LoginAsAdmin";
            this.Load += new System.EventHandler(this.LoginAsAdmin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginAsAdmin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginAsAdmin_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button openAdminButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label closeAdminLabel;
    }
}