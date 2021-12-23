using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public static string CellName = null;
        public static string choosesPass = null;

        public static string UserCellName = null;
        public static string UserCellPass = null;

        public static List<User> myUsers = new List<User>();
        static List<Admin> admins = new List<Admin>();
        Userbooks user = Parse.ReadFromUsersBooks(Program.PathToUsersBooks);
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeColorsOfForm();
            this.BackColor = Program.color;
            notifyIcon1.BalloonTipTitle = "Library";
            notifyIcon1.BalloonTipText = "Hided";
            notifyIcon1.Text = "Library";

            UserLabel.Text = Program.EnteredUserLogin;

            allbooksGrid.AllowUserToAddRows = false;
            usersTable.AllowUserToAddRows = false;
            DataGrid.ShowBooks(ref allbooksGrid);
            DataGrid.ShowUsersBooks(ref usersTable, user);

            Parse.AddUserIfNotExisting(Program.PathToUsersBooks);

        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region
        private void closeForm_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ви бажаєте вийти?", "Ар ю шу?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        
        private void HideForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastpoint;
        private void headPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void headPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
        #endregion
       
        private void allbooksGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;
            //if(Int32.TryParse(allbooksGrid[1,i].Value.ToString(), out int r))
            //{
            //    DataGrid.ChangeValue(ref allbooksGrid, Program.PathToBooks, CellName, i);
            //    allbooksGrid.Refresh();
            //}
            //else
            //{
            //    DataGrid.ShowBooksForAdmin(ref allbooksGrid);
            //}
        }
        private void allbooksGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int i = e.RowIndex;
            //try
            //{
            //    CellName = allbooksGrid[0, i].Value.ToString();
            //}
            //catch(Exception) { }
            try
            {
                CellName = allbooksGrid[0, e.RowIndex].Value.ToString();
                YearLabel.Text = "Рік: " + DataGrid.GetInfoForABook(CellName, "year");
                GenreLabel.Text = "Жанр: " + DataGrid.GetInfoForABook(CellName, "genre");
                AuthorLabel.Text = "Автор: " + DataGrid.GetInfoForABook(CellName, "author");
                choosesPass = DataGrid.GetInfoForABook(CellName, "path");
            }
            catch (Exception)
            {

            }
        }

        private void OpenBookButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(choosesPass))
            {
                Process.Start(choosesPass);
                
            }
            else
            {
                MessageBox.Show("Книга відсутня");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CellName != null)
            {
                DataGrid.AddBookToUser(CellName, Program.PathToUsersBooks);
                user = Parse.ReadFromUsersBooks(Program.PathToUsersBooks);
                DataGrid.ShowUsersBooks(ref usersTable, user);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Видалити книгу?", "?", MessageBoxButtons.YesNo);
            if(d == DialogResult.Yes)
            {
                if (UserCellName != null)
                {
                    DataGrid.RemoveBookFromUser(UserCellName, Program.PathToUsersBooks);
                    user = Parse.ReadFromUsersBooks(Program.PathToUsersBooks);
                    DataGrid.ShowUsersBooks(ref usersTable, user);
                   
                }
                
            }
        }

        private void usersTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                UserCellName = usersTable[0, e.RowIndex].Value.ToString();
                UserCellPass = DataGrid.GetInfoForABook(UserCellName, "path");
            }
            catch (Exception)
            {

            }
           
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(attrComboBox.Text != "" && valueBox.Text != "")
            {
                parametrLabel.Text = "Параметр: "+ attrComboBox.Text;
                valueLabel.Text = "Значення: "+valueBox.Text;
                if (attrComboBox.Text == "Рік")
                {
                    if (Int32.TryParse(valueBox.Text, out int k))
                    {
                        DataGrid.SearchBookResult(ref allbooksGrid, attrComboBox.Text, valueBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Дата введена некорректно");
                    }
                }
                else
                {
                    DataGrid.SearchBookResult(ref allbooksGrid, attrComboBox.Text, valueBox.Text);
                }
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            attrComboBox.Text = "";
            valueBox.Text = "";
            parametrLabel.Text = "Параметр:";
            valueLabel.Text = "Значення:";
            DataGrid.ShowBooks(ref allbooksGrid);
        }

        private void openMyBookButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(UserCellPass))
            {
                Process.Start(UserCellPass);

            }
            else
            {
                MessageBox.Show("Книга відсутня");
            }
        }

        private void settingLabel_MouseEnter(object sender, EventArgs e)
        {
            settingLabel.Text = "Settings";
        }

        private void settingLabel_MouseLeave(object sender, EventArgs e)
        {
            settingLabel.Text = "S";
        }

        private void settingLabel_Click(object sender, EventArgs e)
        {
            SettingsPanel panel = new SettingsPanel();
            this.Hide();
            panel.Show();
        }


        void ChangeColorsOfForm()
        {
            foreach(Control panel in this.Controls)
            {
                if(panel is Panel)
                {
                    panel.BackColor = Program.color;
                }
            }
            foreach (Control panel in tabControl.Controls)
            {
                if (panel is Panel)
                {
                    panel.BackColor = Program.color;
                }
            }


            if (Program.color == Color.Black)
            {
                foreach (Control label in BookInfoPanel.Controls)
                {
                    if (label is Label)
                    {
                        label.ForeColor = Color.White;
                    }
                }
                foreach (Control label in searchPanel.Controls)
                {
                    if (label is Label)
                    {
                        label.ForeColor = Color.White;
                    }
                }
                foreach (Control label in underHeadpanel.Controls)
                {
                    if (label is Label)
                    {
                        label.ForeColor = Color.White;
                    }
                }
            }
            else
            {
                foreach (Control label in BookInfoPanel.Controls)
                {
                    if (label is Label)
                    {
                        label.ForeColor = Color.Black;
                    }
                }
                foreach (Control label in searchPanel.Controls)
                {
                    if (label is Label)
                    {
                        label.ForeColor = Color.Black;
                    }
                }
                foreach (Control label in underHeadpanel.Controls)
                {
                    if (label is Label)
                    {
                        label.ForeColor = Color.Black;
                    }
                }
            }
            headPanel.BackColor = Color.FromArgb(153, 176, 255);
        }

        private void weatherLabel_Click(object sender, EventArgs e)
        {
            weatherLabel.Text = "Weather: "+Parse.GetWeather();
        }

        private void allbooksGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
