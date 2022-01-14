using Library.Dekstop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginForm : Form
    {
        public static bool DbConnected = false;
        public LoginForm()
        {
            InitializeComponent();

        }
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

            if(DbConnected == true)
            {
                serverButton.Enabled = true;
                ConnectButton.Enabled = false;
                ChangeXMLButton.Enabled = true;
            }
            else
            {
                serverButton.Enabled = false;
                ConnectButton.Enabled = true;
                ChangeXMLButton.Enabled = false;
            }
            if(!(File.Exists(Program.wanted_path + "\\Properities.xml")))
            {
                FileGenerator.Properties(Program.wanted_path + "\\Properities.xml");
            }
            checkConnecting();
            

        }

        #region
        void checkConnecting()
        {
            if (Parse.GetXMLData(Program.PathToProperities, "pathToUsers")=="" || !DbConnected)
            {
                loginpanel.Hide();
            }
            else
            {
                loginpanel.Show();
            }
        }
        #endregion

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (!DbConnected)
            {
                if (File.Exists(Program.PathToProperities))
                {
                    if (Parse.CheckXML(Program.PathToProperities, "pathToUsers"))
                    {
                        AddData();
                        if (NoData())
                        {
                            OptionForm optionForm = new OptionForm();
                            optionForm.Show();
                            optionForm.Hide();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Welcome");
                            if (!Directory.Exists(Program.wanted_path + "\\Resources\\Books"))
                            {
                                Directory.CreateDirectory(Program.wanted_path + "\\Resources\\Books");
                            }
                        }

                        DbConnected = true;
                        ConnectButton.Enabled = false;
                        ChangeXMLButton.Enabled = true;
                        serverButton.Enabled = true;
                        checkConnecting();
                    }

                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Файл Properities не знайдений, згенерувати?", "Error", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        FileGenerator.Properties(Program.wanted_path + "\\Properities.xml");
                    }
                }
            }
        }
        public void CheckExisting()
        {
            try
            {
                if (!(Directory.Exists(Program.wanted_path + "\\Resouces")))
                {
                    Directory.CreateDirectory(Program.wanted_path + "\\Resources");
                }
                if (!(File.Exists(Parse.GetXMLData(Program.PathToProperities, "pathToUsers"))))
                {
                    FileGenerator.Users(Program.wanted_path + "\\Resources\\Users.csv");
                    Parse.SetXMLData(Program.PathToProperities, "pathToUsers", Program.PathToUsers);
                }
                if (!(File.Exists(Parse.GetXMLData(Program.PathToProperities, "pathToAdmins"))))
                {
                    FileGenerator.Admins(Program.wanted_path + "\\Resources\\Admins.xlsx");
                    Parse.SetXMLData(Program.PathToProperities, "pathToAdmins", Program.PathToAdmins);
                }
                if (!(File.Exists(Parse.GetXMLData(Program.PathToProperities, "pathToBooks"))))
                {
                    FileGenerator.Books(Program.wanted_path + "\\Resources\\Books.xml");
                    Parse.SetXMLData(Program.PathToProperities, "pathToBooks", Program.PathToBooks);
                }
                if (!(File.Exists(Parse.GetXMLData(Program.PathToProperities, "pathToUsersBooks"))))
                {
                    FileGenerator.UsersBooks(Program.wanted_path + "\\Resources\\UsersBooks.xml");
                    Parse.SetXMLData(Program.PathToProperities, "pathToUsersBooks", Program.PathToUsersBooks);
                }
            }
            catch(Exception e)
            {

            }
        }
        
        public void AddData()
        {
            Program.PathToUsers = Parse.GetXMLData(Program.PathToProperities, "pathToUsers");
            Program.PathToAdmins = Parse.GetXMLData(Program.PathToProperities, "pathToAdmins");
            Program.PathToBooks = Parse.GetXMLData(Program.PathToProperities, "pathToBooks");
            Program.PathToUsersBooks = Parse.GetXMLData(Program.PathToProperities, "pathToUsersBooks");
            Program.color = Color.FromName(Parse.GetXMLData(Program.PathToProperities, "BackgroundColor"));
            Program.Width = Convert.ToInt32(Parse.GetXMLData(Program.PathToProperities, "Width"));
            Program.Height = Convert.ToInt32(Parse.GetXMLData(Program.PathToProperities, "Height"));
            CheckExisting();
            if (NoData())
            {
                OptionForm optionForm = new OptionForm();
                this.Hide();
                optionForm.Show();
            }
            else
            {
                ConnectButton.Enabled = false; 
                DbConnected = true;
                checkConnecting();
            }
        }
        public bool NoData()
        {
            if(Program.PathToUsers == "" || Program.PathToAdmins == "" || Program.PathToBooks == "")
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ChangeXMLButton_Click(object sender, EventArgs e)
        {
            OptionForm oForm = new OptionForm();
            this.Hide();
            oForm.Show();
        }

        
        private void LoginForm_Activated(object sender, EventArgs e)
        {
            checkConnecting();
        }

        private void HideLoginLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseLoginLabel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ви бажаєте вийти?","Ар ю шу?",MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        Point lastpoint;
        private void LoginHeadPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void LoginHeadPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }



        private void label5_Click(object sender, EventArgs e)
        {
            passwordBox.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            loginBox.Focus();
        }

        private void gotoregistration_Click(object sender, EventArgs e)
        {
            RegForm r = new RegForm();
            this.Hide();
            r.Show();
        }

        private void inAccountButton_Click(object sender, EventArgs e)
        {
            if(loginBox.Text != "" && passwordBox.Text != "")
            {
                suchUser();
            }
            
        }
        void suchUser()
        {
            string pass = userSearched();
            if (pass!=null)
            {
               if(pass == passwordBox.Text)
                {
                    MessageBox.Show("Entered");
                    Program.EnteredUserLogin = loginBox.Text;
                    Form1 f = new Form1();
                    f.Height = Program.Height;
                    f.Width = Program.Width;
                    f.BackColor = Program.color;
                    
                    this.Hide();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Пароль не правильний.");
                    passwordBox.Text = "";
                }
            }
        }
        string userSearched()
        {
            List<User> users = Parse.GetUsersToListFromCSV(Program.PathToUsers);
            foreach(var u in users)
            {
                if(u.getName() == loginBox.Text)
                {
                    return u.getPassword();
                }
            }
            MessageBox.Show("Користувача не знайдено");
            loginBox.Text = "";
            passwordBox.Text = "";
            return null;
        }

        private void openAdminButton_MouseEnter(object sender, EventArgs e)
        {
            openAdminButton.Text = "Open as Admin";
        }

        private void openAdminButton_MouseLeave(object sender, EventArgs e)
        {
            openAdminButton.Text = "Open";
        }

        private void openAdminButton_Click(object sender, EventArgs e)
        {
            if (DbConnected)
            {
                LoginAsAdmin l = new LoginAsAdmin();
                l.Show();
                this.Hide();
            }
        }

        private void serverButton_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            try
            {
                client.DownloadFile(Program.BooksLink, Program.PathToBooks);
                client.DownloadFile(Program.UsersLink, Program.PathToUsers);
                client.DownloadFile(Program.UsersBooksLink, Program.PathToUsersBooks);
            }
            catch(Exception)
            {

            }
            serverButton.Enabled = false;
        }

        private void GitLinkLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Gryniam");
        }

        private void InstagramLinkLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/gryniam/?hl=ru");
        }

        private void AboutAuthoLabel_Click(object sender, EventArgs e)
        {
            if(AuthorPanel.Visible == false)
            {
                AuthorPanel.Visible = true;
            }
            else
            {
                AuthorPanel.Visible = false;
            }
        }
    }
}
