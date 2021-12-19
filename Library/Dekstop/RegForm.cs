using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Library
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        #region
        Point lastpoint;
        private void RegForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y
;            }
        }

        private void RegForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm l = new LoginForm();
            l.Show();
        }


        private void loginLabel_Click(object sender, EventArgs e)
        {
            regLoginBox.Focus();
        }

        private void postLabel_Click(object sender, EventArgs e)
        {
            regPostBox.Focus();
        }

        private void passLabel_Click(object sender, EventArgs e)
        {
            regPassBox.Focus();
        }
        #endregion

        private void RegButton_Click(object sender, EventArgs e)
        {
            if(AllBoxesAreFilled() && PostAreCorrect())
            {
                if (NoSuchUser())
                {
                    Parse.AddUserToCSV(ref regLoginBox,ref regPostBox,ref regPassBox, Program.PathToUsers);
                    LoginForm logform = new LoginForm();
                    MessageBox.Show("Користувача " + regLoginBox.Text + " зареєстровано");
                    this.Hide();
                    logform.Show();


                }
            }
        }
        //Перевірка чи всі клітинки заповнені
        bool AllBoxesAreFilled()
        {
            if(regLoginBox.Text != "" && regPostBox.Text != "" && regPassBox.Text != "")
            {
                checkBoxesLabel.ForeColor = Color.Black;
                return true;
            }
            else
            {
                checkBoxesLabel.ForeColor = Color.Red;
                return false;
            }
        }
        //Перевірка, чи пошта введена вірно
        bool PostAreCorrect()
        {
            string pattern2 = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            if (Regex.IsMatch(regPostBox.Text, pattern2, RegexOptions.IgnoreCase))
            {
                checkPostLabel.ForeColor = Color.Black;
                return true;

            }
            else
            {
                checkPostLabel.ForeColor = Color.Red;
                return false;
            }
        }
        //Перевірка, чи юзер з таким логіном або поштою вже існує
        bool NoSuchUser()
        {
            List<User> users = Parse.GetUsersToListFromCSV(Program.PathToUsers);
            string username = regLoginBox.Text;
            string post = regPostBox.Text;
            if (users != null)
            {
                foreach (var us in users)
                {
                    if (us.getName() == username)
                    {
                        MessageBox.Show("Користувач з іменем " + username + " вже існує");
                        return false;
                    }
                    if (us.getMail() == post)
                    {
                        MessageBox.Show("Користувач з поштою " + post + " вже існує");
                        return false;
                    }
                }
            }
            return true;
        }

        private void regLoginBox_TextChanged(object sender, EventArgs e)
        {
            AllBoxesAreFilled();
            PostAreCorrect();
        }

        private void regPostBox_TextChanged(object sender, EventArgs e)
        {
            AllBoxesAreFilled();
            PostAreCorrect();
        }

        private void regPassBox_TextChanged(object sender, EventArgs e)
        {
            AllBoxesAreFilled();
            PostAreCorrect();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            AllBoxesAreFilled();
            PostAreCorrect();
            NoSuchUser();
        }
    }
}
