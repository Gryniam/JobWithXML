using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Dekstop
{
    public partial class LoginAsAdmin : Form
    {
        List<Admin> admins = new List<Admin>();
        public LoginAsAdmin()
        {
            InitializeComponent();
        }

        Point lastpoint;
        private void LoginAsAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void LoginAsAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void LoginAsAdmin_Load(object sender, EventArgs e)
        {
            Parse.AdminsFromExcel(admins, Program.PathToAdmins);
        }

        private void openAdminButton_Click(object sender, EventArgs e)
        {
            if(loginBox.Text!= "" && passwordBox.Text != "")
            {
                foreach(var a in admins)
                {
                    if(a.getName() == loginBox.Text && a.getPassword() == passwordBox.Text)
                    {
                        AdminPanel adminPanel = new AdminPanel();
                        adminPanel.Show();
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("Введені дані не вірні");
            }
        }

        private void closeAdminLabel_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Close();
        }
    }
}
