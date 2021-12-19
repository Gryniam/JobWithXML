
namespace Library.Dekstop
{
    partial class AdminPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.adminControl = new System.Windows.Forms.TabControl();
            this.bookAdmin = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.allBooksAdminGrid = new System.Windows.Forms.DataGridView();
            this.addBookPanel = new System.Windows.Forms.Panel();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addBookButton = new System.Windows.Forms.Button();
            this.genreBookBox = new System.Windows.Forms.TextBox();
            this.authorBookBox = new System.Windows.Forms.TextBox();
            this.yearBookBox = new System.Windows.Forms.TextBox();
            this.nameBookBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.allUsersGrid = new System.Windows.Forms.DataGridView();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.adminControl.SuspendLayout();
            this.bookAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allBooksAdminGrid)).BeginInit();
            this.addBookPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allUsersGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafik)).BeginInit();
            this.SuspendLayout();
            // 
            // adminControl
            // 
            this.adminControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.adminControl.Controls.Add(this.bookAdmin);
            this.adminControl.Controls.Add(this.tabPage2);
            this.adminControl.Controls.Add(this.tabPage1);
            this.adminControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminControl.Location = new System.Drawing.Point(0, 0);
            this.adminControl.Multiline = true;
            this.adminControl.Name = "adminControl";
            this.adminControl.SelectedIndex = 0;
            this.adminControl.Size = new System.Drawing.Size(906, 578);
            this.adminControl.TabIndex = 0;
            // 
            // bookAdmin
            // 
            this.bookAdmin.Controls.Add(this.splitContainer1);
            this.bookAdmin.Location = new System.Drawing.Point(23, 4);
            this.bookAdmin.Name = "bookAdmin";
            this.bookAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.bookAdmin.Size = new System.Drawing.Size(879, 570);
            this.bookAdmin.TabIndex = 0;
            this.bookAdmin.Text = "КНИГИ";
            this.bookAdmin.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.allBooksAdminGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel2.Controls.Add(this.addBookPanel);
            this.splitContainer1.Size = new System.Drawing.Size(873, 564);
            this.splitContainer1.SplitterDistance = 398;
            this.splitContainer1.TabIndex = 0;
            // 
            // allBooksAdminGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.allBooksAdminGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.allBooksAdminGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allBooksAdminGrid.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allBooksAdminGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.allBooksAdminGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allBooksAdminGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.allBooksAdminGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allBooksAdminGrid.Location = new System.Drawing.Point(0, 0);
            this.allBooksAdminGrid.MultiSelect = false;
            this.allBooksAdminGrid.Name = "allBooksAdminGrid";
            this.allBooksAdminGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.allBooksAdminGrid.Size = new System.Drawing.Size(873, 398);
            this.allBooksAdminGrid.TabIndex = 1;
            this.allBooksAdminGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.allBooksAdminGrid_CellMouseClick);
            this.allBooksAdminGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.allBooksAdminGrid_CellValueChanged);
            // 
            // addBookPanel
            // 
            this.addBookPanel.Controls.Add(this.deleteBookButton);
            this.addBookPanel.Controls.Add(this.label4);
            this.addBookPanel.Controls.Add(this.label3);
            this.addBookPanel.Controls.Add(this.label2);
            this.addBookPanel.Controls.Add(this.label1);
            this.addBookPanel.Controls.Add(this.addBookButton);
            this.addBookPanel.Controls.Add(this.genreBookBox);
            this.addBookPanel.Controls.Add(this.authorBookBox);
            this.addBookPanel.Controls.Add(this.yearBookBox);
            this.addBookPanel.Controls.Add(this.nameBookBox);
            this.addBookPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.addBookPanel.Location = new System.Drawing.Point(0, 0);
            this.addBookPanel.Name = "addBookPanel";
            this.addBookPanel.Size = new System.Drawing.Size(442, 162);
            this.addBookPanel.TabIndex = 0;
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteBookButton.Location = new System.Drawing.Point(334, 75);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(89, 35);
            this.deleteBookButton.TabIndex = 9;
            this.deleteBookButton.Text = "Видалити книгу";
            this.deleteBookButton.UseVisualStyleBackColor = true;
            this.deleteBookButton.Click += new System.EventHandler(this.deleteBookButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Жанр книги";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Автор книги";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Рік видання";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Назва книги";
            // 
            // addBookButton
            // 
            this.addBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBookButton.Location = new System.Drawing.Point(334, 118);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(89, 35);
            this.addBookButton.TabIndex = 4;
            this.addBookButton.Text = "Додати книгу";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // genreBookBox
            // 
            this.genreBookBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.genreBookBox.Location = new System.Drawing.Point(106, 133);
            this.genreBookBox.Name = "genreBookBox";
            this.genreBookBox.Size = new System.Drawing.Size(159, 20);
            this.genreBookBox.TabIndex = 3;
            // 
            // authorBookBox
            // 
            this.authorBookBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.authorBookBox.Location = new System.Drawing.Point(106, 94);
            this.authorBookBox.Name = "authorBookBox";
            this.authorBookBox.Size = new System.Drawing.Size(159, 20);
            this.authorBookBox.TabIndex = 2;
            // 
            // yearBookBox
            // 
            this.yearBookBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.yearBookBox.Location = new System.Drawing.Point(106, 53);
            this.yearBookBox.Name = "yearBookBox";
            this.yearBookBox.Size = new System.Drawing.Size(159, 20);
            this.yearBookBox.TabIndex = 1;
            // 
            // nameBookBox
            // 
            this.nameBookBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nameBookBox.Location = new System.Drawing.Point(106, 12);
            this.nameBookBox.Name = "nameBookBox";
            this.nameBookBox.Size = new System.Drawing.Size(159, 20);
            this.nameBookBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(879, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "КОРИСТУВАЧІ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.allUsersGrid);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer2.Panel2.Controls.Add(this.deleteUserButton);
            this.splitContainer2.Panel2.Controls.Add(this.userLabel);
            this.splitContainer2.Size = new System.Drawing.Size(873, 564);
            this.splitContainer2.SplitterDistance = 667;
            this.splitContainer2.TabIndex = 0;
            // 
            // allUsersGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.allUsersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.allUsersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allUsersGrid.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allUsersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.allUsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allUsersGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.allUsersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allUsersGrid.Location = new System.Drawing.Point(0, 0);
            this.allUsersGrid.MultiSelect = false;
            this.allUsersGrid.Name = "allUsersGrid";
            this.allUsersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.allUsersGrid.Size = new System.Drawing.Size(667, 564);
            this.allUsersGrid.TabIndex = 2;
            this.allUsersGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.allUsersGrid_CellMouseClick);
            this.allUsersGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.allUsersGrid_CellValueChanged);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteUserButton.Location = new System.Drawing.Point(18, 59);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(89, 35);
            this.deleteUserButton.TabIndex = 5;
            this.deleteUserButton.Text = "Видалити коритувача";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(15, 20);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(37, 16);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "User:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grafik);
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(879, 570);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "ГРАФІК";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grafik
            // 
            chartArea1.Name = "ChartArea1";
            this.grafik.ChartAreas.Add(chartArea1);
            this.grafik.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.grafik.Legends.Add(legend1);
            this.grafik.Location = new System.Drawing.Point(0, 0);
            this.grafik.Name = "grafik";
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Кількість книг певного року";
            this.grafik.Series.Add(series1);
            this.grafik.Size = new System.Drawing.Size(879, 570);
            this.grafik.TabIndex = 0;
            this.grafik.Text = "grafik";
            this.grafik.Click += new System.EventHandler(this.grafik_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 578);
            this.Controls.Add(this.adminControl);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPanel_FormClosed);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.adminControl.ResumeLayout(false);
            this.bookAdmin.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allBooksAdminGrid)).EndInit();
            this.addBookPanel.ResumeLayout(false);
            this.addBookPanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allUsersGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminControl;
        private System.Windows.Forms.TabPage bookAdmin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView allBooksAdminGrid;
        private System.Windows.Forms.Panel addBookPanel;
        private System.Windows.Forms.TextBox nameBookBox;
        private System.Windows.Forms.TextBox genreBookBox;
        private System.Windows.Forms.TextBox authorBookBox;
        private System.Windows.Forms.TextBox yearBookBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView allUsersGrid;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafik;
    }
}