
namespace Library
{
    partial class SettingsPanel
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
            this.closeSettings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioThird = new System.Windows.Forms.RadioButton();
            this.radioSecond = new System.Windows.Forms.RadioButton();
            this.radioFirst = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PaleGoldenrodButton = new System.Windows.Forms.Button();
            this.BrownButton = new System.Windows.Forms.Button();
            this.AzureButton = new System.Windows.Forms.Button();
            this.changeSettingsButton = new System.Windows.Forms.Button();
            this.mailbox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.confirmPassLabel = new System.Windows.Forms.Label();
            this.sendMailButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeSettings
            // 
            this.closeSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeSettings.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Bold);
            this.closeSettings.Location = new System.Drawing.Point(192, 0);
            this.closeSettings.Name = "closeSettings";
            this.closeSettings.Size = new System.Drawing.Size(38, 40);
            this.closeSettings.TabIndex = 3;
            this.closeSettings.Text = "X";
            this.closeSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeSettings.Click += new System.EventHandler(this.closeSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resolution";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.radioThird);
            this.panel1.Controls.Add(this.radioSecond);
            this.panel1.Controls.Add(this.radioFirst);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 140);
            this.panel1.TabIndex = 5;
            // 
            // radioThird
            // 
            this.radioThird.AutoSize = true;
            this.radioThird.BackColor = System.Drawing.Color.White;
            this.radioThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioThird.Location = new System.Drawing.Point(19, 104);
            this.radioThird.Name = "radioThird";
            this.radioThird.Size = new System.Drawing.Size(81, 20);
            this.radioThird.TabIndex = 2;
            this.radioThird.TabStop = true;
            this.radioThird.Text = "1080х720";
            this.radioThird.UseVisualStyleBackColor = false;
            this.radioThird.CheckedChanged += new System.EventHandler(this.radioThird_CheckedChanged);
            // 
            // radioSecond
            // 
            this.radioSecond.AutoSize = true;
            this.radioSecond.BackColor = System.Drawing.Color.White;
            this.radioSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioSecond.Location = new System.Drawing.Point(19, 61);
            this.radioSecond.Name = "radioSecond";
            this.radioSecond.Size = new System.Drawing.Size(88, 20);
            this.radioSecond.TabIndex = 1;
            this.radioSecond.TabStop = true;
            this.radioSecond.Text = "1000х1000";
            this.radioSecond.UseVisualStyleBackColor = false;
            this.radioSecond.CheckedChanged += new System.EventHandler(this.radioSecond_CheckedChanged);
            // 
            // radioFirst
            // 
            this.radioFirst.AutoSize = true;
            this.radioFirst.BackColor = System.Drawing.Color.White;
            this.radioFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioFirst.Location = new System.Drawing.Point(19, 20);
            this.radioFirst.Name = "radioFirst";
            this.radioFirst.Size = new System.Drawing.Size(81, 20);
            this.radioFirst.TabIndex = 0;
            this.radioFirst.TabStop = true;
            this.radioFirst.Text = "1000х650";
            this.radioFirst.UseVisualStyleBackColor = false;
            this.radioFirst.CheckedChanged += new System.EventHandler(this.radioFirst_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Background color";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.PaleGoldenrodButton);
            this.panel2.Controls.Add(this.BrownButton);
            this.panel2.Controls.Add(this.AzureButton);
            this.panel2.Location = new System.Drawing.Point(12, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 50);
            this.panel2.TabIndex = 7;
            // 
            // PaleGoldenrodButton
            // 
            this.PaleGoldenrodButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.PaleGoldenrodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaleGoldenrodButton.Location = new System.Drawing.Point(158, 3);
            this.PaleGoldenrodButton.Name = "PaleGoldenrodButton";
            this.PaleGoldenrodButton.Size = new System.Drawing.Size(52, 44);
            this.PaleGoldenrodButton.TabIndex = 2;
            this.PaleGoldenrodButton.UseVisualStyleBackColor = false;
            this.PaleGoldenrodButton.Click += new System.EventHandler(this.PaleGoldenrodButton_Click);
            // 
            // BrownButton
            // 
            this.BrownButton.BackColor = System.Drawing.Color.Black;
            this.BrownButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BrownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrownButton.Location = new System.Drawing.Point(78, 3);
            this.BrownButton.Name = "BrownButton";
            this.BrownButton.Size = new System.Drawing.Size(52, 44);
            this.BrownButton.TabIndex = 1;
            this.BrownButton.UseVisualStyleBackColor = false;
            this.BrownButton.Click += new System.EventHandler(this.BrownButton_Click);
            // 
            // AzureButton
            // 
            this.AzureButton.BackColor = System.Drawing.Color.Azure;
            this.AzureButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AzureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AzureButton.Location = new System.Drawing.Point(3, 3);
            this.AzureButton.Name = "AzureButton";
            this.AzureButton.Size = new System.Drawing.Size(52, 44);
            this.AzureButton.TabIndex = 0;
            this.AzureButton.UseVisualStyleBackColor = false;
            this.AzureButton.Click += new System.EventHandler(this.AzureButton_Click);
            // 
            // changeSettingsButton
            // 
            this.changeSettingsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.changeSettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.changeSettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.changeSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeSettingsButton.Location = new System.Drawing.Point(120, 316);
            this.changeSettingsButton.Name = "changeSettingsButton";
            this.changeSettingsButton.Size = new System.Drawing.Size(105, 32);
            this.changeSettingsButton.TabIndex = 8;
            this.changeSettingsButton.Text = "Change";
            this.changeSettingsButton.UseVisualStyleBackColor = false;
            this.changeSettingsButton.Click += new System.EventHandler(this.changeSettingsButton_Click);
            // 
            // mailbox
            // 
            this.mailbox.Location = new System.Drawing.Point(12, 414);
            this.mailbox.Name = "mailbox";
            this.mailbox.Size = new System.Drawing.Size(145, 20);
            this.mailbox.TabIndex = 9;
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(12, 460);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(145, 20);
            this.passwordbox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password";
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(12, 555);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(145, 20);
            this.codeBox.TabIndex = 13;
            this.codeBox.TextChanged += new System.EventHandler(this.codeBox_TextChanged);
            // 
            // confirmPassLabel
            // 
            this.confirmPassLabel.AutoSize = true;
            this.confirmPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPassLabel.Location = new System.Drawing.Point(13, 527);
            this.confirmPassLabel.Name = "confirmPassLabel";
            this.confirmPassLabel.Size = new System.Drawing.Size(99, 16);
            this.confirmPassLabel.TabIndex = 14;
            this.confirmPassLabel.Text = "Confirm code";
            // 
            // sendMailButton
            // 
            this.sendMailButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sendMailButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.sendMailButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sendMailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendMailButton.Location = new System.Drawing.Point(12, 486);
            this.sendMailButton.Name = "sendMailButton";
            this.sendMailButton.Size = new System.Drawing.Size(105, 32);
            this.sendMailButton.TabIndex = 15;
            this.sendMailButton.Text = "Send Mail";
            this.sendMailButton.UseVisualStyleBackColor = false;
            this.sendMailButton.Click += new System.EventHandler(this.sendMailButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(12, 581);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(105, 32);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButton.Location = new System.Drawing.Point(7, 358);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(60, 21);
            this.menuButton.TabIndex = 17;
            this.menuButton.Text = "===";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(233, 390);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.sendMailButton);
            this.Controls.Add(this.confirmPassLabel);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.mailbox);
            this.Controls.Add(this.changeSettingsButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsPanel";
            this.Text = "SettingsPanel";
            this.Load += new System.EventHandler(this.SettingsPanel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingsPanel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsPanel_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioFirst;
        private System.Windows.Forms.RadioButton radioThird;
        private System.Windows.Forms.RadioButton radioSecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PaleGoldenrodButton;
        private System.Windows.Forms.Button BrownButton;
        private System.Windows.Forms.Button AzureButton;
        private System.Windows.Forms.Button changeSettingsButton;
        private System.Windows.Forms.TextBox mailbox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Label confirmPassLabel;
        private System.Windows.Forms.Button sendMailButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button menuButton;
    }
}