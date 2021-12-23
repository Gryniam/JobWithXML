
namespace Library
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headPanel = new System.Windows.Forms.Panel();
            this.settingLabel = new System.Windows.Forms.Label();
            this.HideForm = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.allbookspage = new System.Windows.Forms.TabPage();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.parametrLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.attrComboBox = new System.Windows.Forms.ComboBox();
            this.BookInfoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenBookButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.booksPanel = new System.Windows.Forms.Panel();
            this.allbooksGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.usersTable = new System.Windows.Forms.DataGridView();
            this.openMyBookButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.underHeadpanel = new System.Windows.Forms.Panel();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.headPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.allbookspage.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.BookInfoPanel.SuspendLayout();
            this.booksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allbooksGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            this.panel3.SuspendLayout();
            this.underHeadpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.headPanel.Controls.Add(this.settingLabel);
            this.headPanel.Controls.Add(this.HideForm);
            this.headPanel.Controls.Add(this.closeForm);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(1000, 40);
            this.headPanel.TabIndex = 1;
            this.headPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headPanel_MouseDown);
            this.headPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headPanel_MouseMove);
            // 
            // settingLabel
            // 
            this.settingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.settingLabel.AutoSize = true;
            this.settingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingLabel.Location = new System.Drawing.Point(12, 6);
            this.settingLabel.Name = "settingLabel";
            this.settingLabel.Size = new System.Drawing.Size(27, 31);
            this.settingLabel.TabIndex = 4;
            this.settingLabel.Text = "S";
            this.settingLabel.Click += new System.EventHandler(this.settingLabel_Click);
            this.settingLabel.MouseEnter += new System.EventHandler(this.settingLabel_MouseEnter);
            this.settingLabel.MouseLeave += new System.EventHandler(this.settingLabel_MouseLeave);
            // 
            // HideForm
            // 
            this.HideForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.HideForm.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Bold);
            this.HideForm.Location = new System.Drawing.Point(924, 0);
            this.HideForm.Name = "HideForm";
            this.HideForm.Size = new System.Drawing.Size(38, 40);
            this.HideForm.TabIndex = 3;
            this.HideForm.Text = "—";
            this.HideForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HideForm.Click += new System.EventHandler(this.HideForm_Click);
            // 
            // closeForm
            // 
            this.closeForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeForm.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Bold);
            this.closeForm.Location = new System.Drawing.Point(962, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(38, 40);
            this.closeForm.TabIndex = 2;
            this.closeForm.Text = "X";
            this.closeForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.allbookspage);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(0, 84);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1000, 566);
            this.tabControl.TabIndex = 2;
            // 
            // allbookspage
            // 
            this.allbookspage.BackColor = System.Drawing.Color.Azure;
            this.allbookspage.Controls.Add(this.infoPanel);
            this.allbookspage.Controls.Add(this.booksPanel);
            this.allbookspage.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allbookspage.Location = new System.Drawing.Point(4, 4);
            this.allbookspage.Name = "allbookspage";
            this.allbookspage.Padding = new System.Windows.Forms.Padding(3);
            this.allbookspage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.allbookspage.Size = new System.Drawing.Size(992, 540);
            this.allbookspage.TabIndex = 0;
            this.allbookspage.Text = "КНИГИ";
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.searchPanel);
            this.infoPanel.Controls.Add(this.BookInfoPanel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.infoPanel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPanel.Location = new System.Drawing.Point(779, 3);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(210, 534);
            this.infoPanel.TabIndex = 1;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.updateButton);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Controls.Add(this.valueLabel);
            this.searchPanel.Controls.Add(this.parametrLabel);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.valueBox);
            this.searchPanel.Controls.Add(this.attrComboBox);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchPanel.Location = new System.Drawing.Point(0, 266);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(208, 266);
            this.searchPanel.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(0, 0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(208, 46);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Оновити";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пошук";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(4, 191);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(75, 16);
            this.valueLabel.TabIndex = 5;
            this.valueLabel.Text = "Значення:";
            // 
            // parametrLabel
            // 
            this.parametrLabel.AutoSize = true;
            this.parametrLabel.Location = new System.Drawing.Point(2, 166);
            this.parametrLabel.Name = "parametrLabel";
            this.parametrLabel.Size = new System.Drawing.Size(77, 16);
            this.parametrLabel.TabIndex = 4;
            this.parametrLabel.Text = "Параметр:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(0, 224);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(208, 42);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Пошук";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // valueBox
            // 
            this.valueBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valueBox.Location = new System.Drawing.Point(3, 124);
            this.valueBox.Multiline = true;
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(201, 23);
            this.valueBox.TabIndex = 1;
            // 
            // attrComboBox
            // 
            this.attrComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.attrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attrComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attrComboBox.FormattingEnabled = true;
            this.attrComboBox.Items.AddRange(new object[] {
            "Назва",
            "Рік",
            "Автор",
            "Жанр"});
            this.attrComboBox.Location = new System.Drawing.Point(3, 94);
            this.attrComboBox.Name = "attrComboBox";
            this.attrComboBox.Size = new System.Drawing.Size(201, 24);
            this.attrComboBox.TabIndex = 0;
            // 
            // BookInfoPanel
            // 
            this.BookInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookInfoPanel.Controls.Add(this.label1);
            this.BookInfoPanel.Controls.Add(this.OpenBookButton);
            this.BookInfoPanel.Controls.Add(this.button1);
            this.BookInfoPanel.Controls.Add(this.GenreLabel);
            this.BookInfoPanel.Controls.Add(this.AuthorLabel);
            this.BookInfoPanel.Controls.Add(this.YearLabel);
            this.BookInfoPanel.Location = new System.Drawing.Point(5, 3);
            this.BookInfoPanel.Name = "BookInfoPanel";
            this.BookInfoPanel.Size = new System.Drawing.Size(200, 244);
            this.BookInfoPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Інформація";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenBookButton
            // 
            this.OpenBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.OpenBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenBookButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OpenBookButton.FlatAppearance.BorderSize = 0;
            this.OpenBookButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.OpenBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBookButton.Location = new System.Drawing.Point(0, 160);
            this.OpenBookButton.Name = "OpenBookButton";
            this.OpenBookButton.Size = new System.Drawing.Size(200, 42);
            this.OpenBookButton.TabIndex = 2;
            this.OpenBookButton.Text = "Відкрити книгу";
            this.OpenBookButton.UseVisualStyleBackColor = false;
            this.OpenBookButton.Click += new System.EventHandler(this.OpenBookButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Додати в бібліотеку";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GenreLabel
            // 
            this.GenreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(14, 124);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(45, 16);
            this.GenreLabel.TabIndex = 3;
            this.GenreLabel.Text = "Жанр";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(14, 35);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(51, 16);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Автор:";
            // 
            // YearLabel
            // 
            this.YearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(14, 79);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(31, 16);
            this.YearLabel.TabIndex = 1;
            this.YearLabel.Text = "Рік:";
            // 
            // booksPanel
            // 
            this.booksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksPanel.Controls.Add(this.allbooksGrid);
            this.booksPanel.Location = new System.Drawing.Point(3, 3);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Size = new System.Drawing.Size(770, 534);
            this.booksPanel.TabIndex = 0;
            // 
            // allbooksGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.allbooksGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.allbooksGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allbooksGrid.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allbooksGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.allbooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allbooksGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.allbooksGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allbooksGrid.Location = new System.Drawing.Point(0, 0);
            this.allbooksGrid.MultiSelect = false;
            this.allbooksGrid.Name = "allbooksGrid";
            this.allbooksGrid.ReadOnly = true;
            this.allbooksGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.allbooksGrid.Size = new System.Drawing.Size(770, 534);
            this.allbooksGrid.TabIndex = 0;
            this.allbooksGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allbooksGrid_CellContentClick);
            this.allbooksGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.allbooksGrid_CellMouseClick);
            this.allbooksGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.allbooksGrid_CellValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "МОЇ КНИГИ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.usersTable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.openMyBookButton);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(986, 534);
            this.splitContainer1.SplitterDistance = 769;
            this.splitContainer1.TabIndex = 0;
            // 
            // usersTable
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.usersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.usersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersTable.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.usersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.usersTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersTable.Location = new System.Drawing.Point(0, 0);
            this.usersTable.MultiSelect = false;
            this.usersTable.Name = "usersTable";
            this.usersTable.ReadOnly = true;
            this.usersTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.usersTable.Size = new System.Drawing.Size(769, 534);
            this.usersTable.TabIndex = 1;
            this.usersTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.usersTable_CellMouseClick);
            // 
            // openMyBookButton
            // 
            this.openMyBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.openMyBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openMyBookButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openMyBookButton.FlatAppearance.BorderSize = 0;
            this.openMyBookButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.openMyBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openMyBookButton.Location = new System.Drawing.Point(0, 89);
            this.openMyBookButton.Name = "openMyBookButton";
            this.openMyBookButton.Size = new System.Drawing.Size(213, 87);
            this.openMyBookButton.TabIndex = 5;
            this.openMyBookButton.Text = "Відкрити книгу";
            this.openMyBookButton.UseVisualStyleBackColor = false;
            this.openMyBookButton.Click += new System.EventHandler(this.openMyBookButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 89);
            this.panel3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 86);
            this.button2.TabIndex = 3;
            this.button2.Text = "Видалити книгу";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // underHeadpanel
            // 
            this.underHeadpanel.BackColor = System.Drawing.Color.Azure;
            this.underHeadpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.underHeadpanel.Controls.Add(this.weatherLabel);
            this.underHeadpanel.Controls.Add(this.UserLabel);
            this.underHeadpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.underHeadpanel.Location = new System.Drawing.Point(0, 40);
            this.underHeadpanel.Name = "underHeadpanel";
            this.underHeadpanel.Size = new System.Drawing.Size(1000, 43);
            this.underHeadpanel.TabIndex = 3;
            // 
            // weatherLabel
            // 
            this.weatherLabel.AutoSize = true;
            this.weatherLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weatherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weatherLabel.Location = new System.Drawing.Point(14, 14);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(70, 16);
            this.weatherLabel.TabIndex = 1;
            this.weatherLabel.Text = "Weather:";
            this.weatherLabel.Click += new System.EventHandler(this.weatherLabel_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel.Location = new System.Drawing.Point(844, 14);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(0, 16);
            this.UserLabel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.underHeadpanel);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.allbookspage.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.BookInfoPanel.ResumeLayout(false);
            this.BookInfoPanel.PerformLayout();
            this.booksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allbooksGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.underHeadpanel.ResumeLayout(false);
            this.underHeadpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Label closeForm;
        private System.Windows.Forms.Label HideForm;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage allbookspage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel booksPanel;
        private System.Windows.Forms.Panel underHeadpanel;
        private System.Windows.Forms.DataGridView allbooksGrid;
        private System.Windows.Forms.Panel BookInfoPanel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenBookButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView usersTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label parametrLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.ComboBox attrComboBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openMyBookButton;
        private System.Windows.Forms.Label settingLabel;
        private System.Windows.Forms.Label weatherLabel;
    }
}

