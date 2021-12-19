using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            PathToUsersBox.Text = Program.PathToUsers;
            PathToAdminsBox.Text = Program.PathToAdmins;
            PathToBooksBox.Text = Program.PathToBooks;
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv files (*.csv)|*.csv";
            openFileDialog.FilterIndex = 2;
            
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Parse.CheckUserDocument(openFileDialog.FileName))
                {
                    Program.PathToUsers = openFileDialog.FileName;
                    PathToUsersBox.Text = openFileDialog.FileName;
                    Parse.SetXMLData(Program.PathToProperities, "pathToUsers", openFileDialog.FileName);
                }
                else
                {

                    DialogResult dialog = MessageBox.Show("Вибраний файл не є файлом з користувачами, згенерувати?", "Error", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        FileGenerator.Users(Program.wanted_path + "\\Resources\\Users.csv");
                        Parse.SetXMLData(Program.PathToProperities, "pathToUsers", Program.PathToUsers);
                        PathToUsersBox.Text = Program.PathToUsers;
                    }
                }
            }
        }
        private void BooksButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "xml files (*.xml)|*.xml";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(Parse.CheckBookXML(openFileDialog.FileName, "book"))
                {
                    Program.PathToBooks = openFileDialog.FileName;
                    PathToBooksBox.Text = openFileDialog.FileName;
                    Parse.SetXMLData(Program.PathToProperities, "pathToBooks", openFileDialog.FileName);
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Вибраний файл не є файлом з книгами, згенерувати?", "Error", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        FileGenerator.Books(Program.wanted_path + "\\Resources\\Books.xml");
                        Parse.SetXMLData(Program.PathToProperities, "pathToBooks", Program.PathToBooks);
                        PathToBooksBox.Text = Program.PathToBooks;
                    }
                }
            }
        }

        private void AdminsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "xlxs files (*.xlsx)|*.xlsx";
            openFileDialog.FilterIndex = 2;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Parse.ExcelValid(openFileDialog.FileName))
                {
                    Program.PathToAdmins = openFileDialog.FileName;
                    PathToAdminsBox.Text = openFileDialog.FileName;
                    Parse.SetXMLData(Program.PathToProperities, "pathToAdmins", openFileDialog.FileName);
                }
                else
                {
                   DialogResult dialog = MessageBox.Show("Вибраний файл не є файлом з адміністраторами, згенерувати?","Error",MessageBoxButtons.YesNo);
                    if(dialog == DialogResult.Yes)
                    {
                        FileGenerator.Admins(Program.wanted_path + "\\Resources\\Admins.xlsx");
                        Parse.SetXMLData(Program.PathToProperities, "pathToAdmins", Program.PathToAdmins);
                        PathToAdminsBox.Text = Program.PathToAdmins;
                    }
                }
            }
        }


        Point lastpoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void ExitOptionLabel_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Hide();
            l.Show();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
