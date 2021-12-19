using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Library
{
    public partial class SettingsPanel : Form
    {
        public SettingsPanel()
        {
            InitializeComponent();
        }


        public static Color color = Program.color;
        public static int width = Program.Width;
        public static int height = Program.Height;
        public static int confirmpass = 0;

        private void SettingsPanel_Load(object sender, EventArgs e)
        {
            if(width == 1000 && height == 650)
            {
                radioFirst.Checked = true;
            }
            if (width == 1000 && height == 1000)
            {
                radioSecond.Checked = true;
            }
            if (width == 1280 && height == 720)
            {
                radioThird.Checked = true;
            }
            DeleteButton.Enabled = false;
        }

        private void closeSettings_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Width = Convert.ToInt32(Parse.GetXMLData(Program.PathToProperities, "Width"));
            f.Height = Convert.ToInt32(Parse.GetXMLData(Program.PathToProperities, "Height"));
            f.Show();
            this.Close();
        }



        private void AzureButton_Click(object sender, EventArgs e)
        {
            color = Color.Azure;
        }

        private void BrownButton_Click(object sender, EventArgs e)
        {
            color = Color.Black;
        }

        private void PaleGoldenrodButton_Click(object sender, EventArgs e)
        {
            color = Color.PaleGoldenrod;
        }

        private void changeSettingsButton_Click(object sender, EventArgs e)
        {
            Program.color = color;
            if(Program.color == Color.Azure)
            {
                Parse.SetXMLData(Program.PathToProperities, "BackgroundColor", "Azure");
            }
            if (Program.color == Color.Black)
            {
                Parse.SetXMLData(Program.PathToProperities, "BackgroundColor", "Black");
            }
            if (Program.color == Color.PaleGoldenrod)
            {
                Parse.SetXMLData(Program.PathToProperities, "BackgroundColor", "PaleGoldenrod");
            }

            Program.Width = width;
            Program.Height = height;

            Parse.SetXMLData(Program.PathToProperities, "Width", Program.Width.ToString());
            Parse.SetXMLData(Program.PathToProperities, "Height", Program.Height.ToString());

            Form1 f = new Form1();
            f.Width = Convert.ToInt32(Parse.GetXMLData(Program.PathToProperities, "Width"));
            f.Height = Convert.ToInt32(Parse.GetXMLData(Program.PathToProperities, "Height"));
            f.Show();
            this.Close();


        }

        private void radioFirst_CheckedChanged(object sender, EventArgs e)
        {
            width = 1000;
            height = 650;
        }

        private void radioSecond_CheckedChanged(object sender, EventArgs e)
        {
            width = 1000;
            height = 1000;
        }

        private void radioThird_CheckedChanged(object sender, EventArgs e)
        {
            width = 1280;
            height = 720;
        }


        Point lastpoint;
        private void SettingsPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void SettingsPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if(this.Height < 400)
            {
                this.Height = 630;
                return;
            }

            if (this.Height > 400)
            {
                this.Height = 385;
                return;
            }
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            if(mailbox.Text != "" && passwordbox.Text != "")
            {
                List<User> users = Parse.GetUsersToListFromCSV(Program.PathToUsers);
                string pass = Parse.GetUserData(Program.EnteredUserLogin, users, "password");
                string mail = Parse.GetUserData(Program.EnteredUserLogin, users, "mail");
                if (pass == passwordbox.Text && mail == mailbox.Text)
                {
                    try
                    {
                        Random rand = new Random();
                        int t = rand.Next();
                        confirmpass = t;
                        MailAddress from = new MailAddress("hrynkiv.vladyslav@comp-sc.if.ua");
                        MailAddress to = new MailAddress(mailbox.Text);
                        

                        MailMessage m = new MailMessage(from, to);
                        m.Subject = "Confirm deleting";
                        m.Body = t.ToString();
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                        smtp.Credentials = new NetworkCredential("hrynkiv.vladyslav@comp-sc.if.ua", "compsc098");
                        smtp.EnableSsl = true;
                        smtp.Send(m);
                        MessageBox.Show("Код підтвердження надіслано на вашу пошту");
                    }
                    catch (Exception)
                    {
                       
                    }

                }
                else
                {
                    MessageBox.Show("Пароль або пошта введені невірно");
                }
            }
        }

        private void codeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(codeBox.Text) == confirmpass)
                {
                    DeleteButton.Enabled = true;
                }
                else
                {
                    DeleteButton.Enabled = false;
                }
            }
            catch (Exception)
            {

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ви впевнені, що бажаєте видалити аккаунт, програма буде завершена", "?????", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Parse.RemoveUserFromCSV(Program.EnteredUserLogin, Program.PathToUsers);
                Parse.RemoveUserFromXml(Program.EnteredUserLogin, Program.PathToUsersBooks);
                Application.Exit();
            }
        }
    }
}
