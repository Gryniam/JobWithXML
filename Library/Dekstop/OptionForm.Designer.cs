
namespace Library
{
    partial class OptionForm
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
            this.PathToUsersBox = new System.Windows.Forms.TextBox();
            this.PathToAdminsBox = new System.Windows.Forms.TextBox();
            this.PathToBooksBox = new System.Windows.Forms.TextBox();
            this.PathToUsersLabel = new System.Windows.Forms.Label();
            this.PathToAdminsLabel = new System.Windows.Forms.Label();
            this.PathToBooksLabel = new System.Windows.Forms.Label();
            this.AdminsButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.BooksButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.ExitOptionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathToUsersBox
            // 
            this.PathToUsersBox.BackColor = System.Drawing.SystemColors.Info;
            this.PathToUsersBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PathToUsersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathToUsersBox.Location = new System.Drawing.Point(94, 15);
            this.PathToUsersBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PathToUsersBox.Multiline = true;
            this.PathToUsersBox.Name = "PathToUsersBox";
            this.PathToUsersBox.ReadOnly = true;
            this.PathToUsersBox.Size = new System.Drawing.Size(212, 28);
            this.PathToUsersBox.TabIndex = 0;
            // 
            // PathToAdminsBox
            // 
            this.PathToAdminsBox.BackColor = System.Drawing.SystemColors.Info;
            this.PathToAdminsBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PathToAdminsBox.Location = new System.Drawing.Point(94, 73);
            this.PathToAdminsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PathToAdminsBox.Multiline = true;
            this.PathToAdminsBox.Name = "PathToAdminsBox";
            this.PathToAdminsBox.ReadOnly = true;
            this.PathToAdminsBox.Size = new System.Drawing.Size(214, 28);
            this.PathToAdminsBox.TabIndex = 1;
            // 
            // PathToBooksBox
            // 
            this.PathToBooksBox.BackColor = System.Drawing.SystemColors.Info;
            this.PathToBooksBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PathToBooksBox.Location = new System.Drawing.Point(94, 128);
            this.PathToBooksBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PathToBooksBox.Multiline = true;
            this.PathToBooksBox.Name = "PathToBooksBox";
            this.PathToBooksBox.ReadOnly = true;
            this.PathToBooksBox.Size = new System.Drawing.Size(214, 28);
            this.PathToBooksBox.TabIndex = 2;
            // 
            // PathToUsersLabel
            // 
            this.PathToUsersLabel.AutoSize = true;
            this.PathToUsersLabel.Location = new System.Drawing.Point(9, 19);
            this.PathToUsersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PathToUsersLabel.Name = "PathToUsersLabel";
            this.PathToUsersLabel.Size = new System.Drawing.Size(71, 13);
            this.PathToUsersLabel.TabIndex = 3;
            this.PathToUsersLabel.Text = "Path to Users";
            // 
            // PathToAdminsLabel
            // 
            this.PathToAdminsLabel.AutoSize = true;
            this.PathToAdminsLabel.Location = new System.Drawing.Point(9, 77);
            this.PathToAdminsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PathToAdminsLabel.Name = "PathToAdminsLabel";
            this.PathToAdminsLabel.Size = new System.Drawing.Size(78, 13);
            this.PathToAdminsLabel.TabIndex = 4;
            this.PathToAdminsLabel.Text = "Path to Admins";
            // 
            // PathToBooksLabel
            // 
            this.PathToBooksLabel.AutoSize = true;
            this.PathToBooksLabel.Location = new System.Drawing.Point(9, 136);
            this.PathToBooksLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PathToBooksLabel.Name = "PathToBooksLabel";
            this.PathToBooksLabel.Size = new System.Drawing.Size(74, 13);
            this.PathToBooksLabel.TabIndex = 5;
            this.PathToBooksLabel.Text = "Path to Books";
            // 
            // AdminsButton
            // 
            this.AdminsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminsButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.AdminsButton.FlatAppearance.BorderSize = 0;
            this.AdminsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.AdminsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.AdminsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminsButton.Location = new System.Drawing.Point(313, 73);
            this.AdminsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminsButton.Name = "AdminsButton";
            this.AdminsButton.Size = new System.Drawing.Size(22, 27);
            this.AdminsButton.TabIndex = 7;
            this.AdminsButton.Text = "C";
            this.AdminsButton.UseVisualStyleBackColor = true;
            this.AdminsButton.Click += new System.EventHandler(this.AdminsButton_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsersButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.UsersButton.FlatAppearance.BorderSize = 0;
            this.UsersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.UsersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersButton.Location = new System.Drawing.Point(313, 15);
            this.UsersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(22, 27);
            this.UsersButton.TabIndex = 8;
            this.UsersButton.Text = "C";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // BooksButton
            // 
            this.BooksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BooksButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.BooksButton.FlatAppearance.BorderSize = 0;
            this.BooksButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BooksButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BooksButton.Location = new System.Drawing.Point(313, 128);
            this.BooksButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Size = new System.Drawing.Size(22, 27);
            this.BooksButton.TabIndex = 9;
            this.BooksButton.Text = "C";
            this.BooksButton.UseVisualStyleBackColor = true;
            this.BooksButton.Click += new System.EventHandler(this.BooksButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PathToUsersBox);
            this.panel1.Controls.Add(this.BooksButton);
            this.panel1.Controls.Add(this.PathToAdminsBox);
            this.panel1.Controls.Add(this.UsersButton);
            this.panel1.Controls.Add(this.PathToBooksBox);
            this.panel1.Controls.Add(this.AdminsButton);
            this.panel1.Controls.Add(this.PathToUsersLabel);
            this.panel1.Controls.Add(this.PathToBooksLabel);
            this.panel1.Controls.Add(this.PathToAdminsLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 194);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.ExitLabel);
            this.panel2.Controls.Add(this.ExitOptionLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 29);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExitLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.ExitLabel.Location = new System.Drawing.Point(0, 0);
            this.ExitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(50, 29);
            this.ExitLabel.TabIndex = 1;
            this.ExitLabel.Text = "Exit";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // ExitOptionLabel
            // 
            this.ExitOptionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitOptionLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitOptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitOptionLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitOptionLabel.Location = new System.Drawing.Point(630, 0);
            this.ExitOptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExitOptionLabel.Name = "ExitOptionLabel";
            this.ExitOptionLabel.Size = new System.Drawing.Size(34, 29);
            this.ExitOptionLabel.TabIndex = 0;
            this.ExitOptionLabel.Text = "X";
            this.ExitOptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitOptionLabel.Click += new System.EventHandler(this.ExitOptionLabel_Click);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 223);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OptionForm";
            this.Text = "OptionForm";
            this.Load += new System.EventHandler(this.OptionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PathToUsersBox;
        private System.Windows.Forms.TextBox PathToAdminsBox;
        private System.Windows.Forms.TextBox PathToBooksBox;
        private System.Windows.Forms.Label PathToUsersLabel;
        private System.Windows.Forms.Label PathToAdminsLabel;
        private System.Windows.Forms.Label PathToBooksLabel;
        private System.Windows.Forms.Button AdminsButton;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button BooksButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ExitOptionLabel;
        private System.Windows.Forms.Label ExitLabel;
    }
}