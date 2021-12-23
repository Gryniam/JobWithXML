
namespace Library
{
    partial class RegForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkPostLabel = new System.Windows.Forms.Label();
            this.checkBoxesLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.regPassBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.postLabel = new System.Windows.Forms.Label();
            this.regPostBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.regLoginBox = new System.Windows.Forms.TextBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(463, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 56);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegForm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegForm_MouseMove);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(58, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Реєстрація";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 666);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkPostLabel);
            this.panel3.Controls.Add(this.checkBoxesLabel);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.passLabel);
            this.panel3.Controls.Add(this.regPassBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.postLabel);
            this.panel3.Controls.Add(this.regPostBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.loginLabel);
            this.panel3.Controls.Add(this.regLoginBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 559);
            this.panel3.TabIndex = 3;
            // 
            // checkPostLabel
            // 
            this.checkPostLabel.AutoSize = true;
            this.checkPostLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkPostLabel.ForeColor = System.Drawing.Color.Red;
            this.checkPostLabel.Location = new System.Drawing.Point(44, 498);
            this.checkPostLabel.Name = "checkPostLabel";
            this.checkPostLabel.Size = new System.Drawing.Size(168, 17);
            this.checkPostLabel.TabIndex = 10;
            this.checkPostLabel.Text = "Пошта введена коректно";
            // 
            // checkBoxesLabel
            // 
            this.checkBoxesLabel.AutoSize = true;
            this.checkBoxesLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxesLabel.ForeColor = System.Drawing.Color.Red;
            this.checkBoxesLabel.Location = new System.Drawing.Point(324, 498);
            this.checkBoxesLabel.Name = "checkBoxesLabel";
            this.checkBoxesLabel.Size = new System.Drawing.Size(128, 17);
            this.checkBoxesLabel.TabIndex = 9;
            this.checkBoxesLabel.Text = "Всі поля заповнені";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(44, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Пароль";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(44, 422);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(415, 13);
            this.passLabel.TabIndex = 7;
            this.passLabel.Text = "____________________________________________________________________";
            this.passLabel.Click += new System.EventHandler(this.passLabel_Click);
            // 
            // regPassBox
            // 
            this.regPassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.regPassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regPassBox.Location = new System.Drawing.Point(47, 381);
            this.regPassBox.Multiline = true;
            this.regPassBox.Name = "regPassBox";
            this.regPassBox.Size = new System.Drawing.Size(405, 54);
            this.regPassBox.TabIndex = 6;
            this.regPassBox.TextChanged += new System.EventHandler(this.regPassBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(44, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Пошта";
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.postLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postLabel.Location = new System.Drawing.Point(44, 267);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(415, 13);
            this.postLabel.TabIndex = 4;
            this.postLabel.Text = "____________________________________________________________________";
            this.postLabel.Click += new System.EventHandler(this.postLabel_Click);
            // 
            // regPostBox
            // 
            this.regPostBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.regPostBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regPostBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regPostBox.Location = new System.Drawing.Point(47, 226);
            this.regPostBox.Multiline = true;
            this.regPostBox.Name = "regPostBox";
            this.regPostBox.Size = new System.Drawing.Size(405, 54);
            this.regPostBox.TabIndex = 3;
            this.regPostBox.TextChanged += new System.EventHandler(this.regPostBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(44, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Логін";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(44, 120);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(415, 13);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "____________________________________________________________________";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // regLoginBox
            // 
            this.regLoginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.regLoginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regLoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLoginBox.Location = new System.Drawing.Point(47, 79);
            this.regLoginBox.Multiline = true;
            this.regLoginBox.Name = "regLoginBox";
            this.regLoginBox.Size = new System.Drawing.Size(405, 54);
            this.regLoginBox.TabIndex = 0;
            this.regLoginBox.TextChanged += new System.EventHandler(this.regLoginBox_TextChanged);
            // 
            // RegButton
            // 
            this.RegButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RegButton.FlatAppearance.BorderSize = 0;
            this.RegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegButton.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButton.Location = new System.Drawing.Point(0, 719);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(503, 77);
            this.RegButton.TabIndex = 4;
            this.RegButton.Text = "Зареєструватись";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(503, 796);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox regLoginBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox regPassBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.TextBox regPostBox;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Label checkPostLabel;
        private System.Windows.Forms.Label checkBoxesLabel;
    }
}