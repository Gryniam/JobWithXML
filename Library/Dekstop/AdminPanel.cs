using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Dekstop
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        public static string CellBookName = null;
        public static string CellBookPath = null;

        public static string CellUserName = null;

        public static List<User> users = Parse.GetUsersToListFromCSV(Program.PathToUsers);

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            DataGrid.ShowBooksForAdmin(ref allBooksAdminGrid);
            DataGrid.ShowUsersForAdmin(ref allUsersGrid, users);
            allBooksAdminGrid.AllowUserToAddRows = false;
            allUsersGrid.AllowUserToAddRows = false;
        }
        
        private void allBooksAdminGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = e.RowIndex;
            int j = e.ColumnIndex;
            try
            {
                CellBookName = allBooksAdminGrid[0, i].Value.ToString();
                CellBookPath = allBooksAdminGrid[4, i].Value.ToString();
                if (j == 4)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "docx files (*.docx)|*.docx";
                    openFileDialog.FilterIndex = 2;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = openFileDialog.FileName;
                        string newpath = Program.wanted_path + "\\Resources\\Books\\" + CellBookName + ".docx";
                        FileInfo oldfile = new FileInfo(CellBookPath);
                        if (oldfile.Exists)
                        {
                            oldfile.Delete();
                        }
                        FileInfo file = new FileInfo(path);
                        if (file.Exists)
                        {
                            file.CopyTo(newpath, true);
                            allBooksAdminGrid[4, i].Value = newpath;
                            DataGrid.ChangeValue(ref allBooksAdminGrid, Program.PathToBooks, CellBookName, i);
                            DataGrid.ChangeBookInfoInUser(ref allBooksAdminGrid, Program.PathToUsersBooks, CellBookName, i);
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void allBooksAdminGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            int j = e.ColumnIndex;
            if(j == 0)
            {
                if (!CopyExist(allBooksAdminGrid[0, i].Value.ToString()))
                {
                    if (Int32.TryParse(allBooksAdminGrid[1, i].Value.ToString(), out int r))
                    {
                        DataGrid.ChangeValue(ref allBooksAdminGrid, Program.PathToBooks, CellBookName, i);
                        DataGrid.ChangeBookInfoInUser(ref allBooksAdminGrid, Program.PathToUsersBooks, CellBookName, i);
                        allBooksAdminGrid.Refresh();
                    }
                    else
                    {
                        DataGrid.ShowBooksForAdmin(ref allBooksAdminGrid);
                    }
                }
                else
                {
                    allBooksAdminGrid[0, i].Value = CellBookName;
                }
            }
            if(j != 0)
            {
                if (Int32.TryParse(allBooksAdminGrid[1, i].Value.ToString(), out int r))
                {
                    DataGrid.ChangeValue(ref allBooksAdminGrid, Program.PathToBooks, CellBookName, i);
                    DataGrid.ChangeBookInfoInUser(ref allBooksAdminGrid, Program.PathToUsersBooks, CellBookName, i);
                    allBooksAdminGrid.Refresh();
                }
                else
                {
                    DataGrid.ShowBooksForAdmin(ref allBooksAdminGrid);
                }
            }
            //if (!CopyExist(allBooksAdminGrid[0, i].Value.ToString()))
            //{
            //    if (Int32.TryParse(allBooksAdminGrid[1, i].Value.ToString(), out int r))
            //    {
            //        DataGrid.ChangeValue(ref allBooksAdminGrid, Program.PathToBooks, CellBookName, i);
            //        DataGrid.ChangeBookInfoInUser(ref allBooksAdminGrid, Program.PathToUsersBooks, CellBookName, i);
            //        allBooksAdminGrid.Refresh();
            //    }
            //    else
            //    {
            //        DataGrid.ShowBooksForAdmin(ref allBooksAdminGrid);
            //    }
            //}
            //else
            //{
            //    allBooksAdminGrid[0, i].Value = CellBookName;
            //}
            
        }
        bool CopyExist(string one)
        {
            for(int i = 0; i<allBooksAdminGrid.Rows.Count; i++)
            {
                if(one == allBooksAdminGrid[0, i].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }


        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
          
            if (AllColumnsFilled())
            {
                if (Int32.TryParse(yearBookBox.Text, out int k))
                {
                    if (!BookExist())
                    {
                        OpenFileDialog openFileDialog = new OpenFileDialog();
                        openFileDialog.Filter = "docx files (*.docx)|*.docx";
                        openFileDialog.FilterIndex = 2;
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string path = openFileDialog.FileName;
                            string newpath = Program.wanted_path + "\\Resources\\Books\\" + nameBookBox.Text + ".docx";

                            FileInfo file = new FileInfo(path);
                            if (file.Exists)
                            {
                                file.CopyTo(newpath, true);
                                Book book = new Book(nameBookBox.Text, Convert.ToInt32(yearBookBox.Text), authorBookBox.Text, genreBookBox.Text, newpath);
                                Parse.AddBookToXML(book, Program.PathToBooks);
                                DataGrid.ShowBooksForAdmin(ref allBooksAdminGrid);
                                MessageBox.Show("Книгу \"" + nameBookBox.Text + "\" було додано");
                                nameBookBox.Text = "";
                                yearBookBox.Text = "";
                                authorBookBox.Text = "";
                                genreBookBox.Text = "";
                            }
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Дата введена некорректно");
                }

            }

            bool BookExist()
            {
                List<Book> books = Parse.BooksFromXML(Program.PathToBooks);
                foreach (var b in books)
                {
                    if (b.getName() == nameBookBox.Text)
                    {
                        MessageBox.Show("Така книга вже існує");
                        return true;
                    }
                }
                
                return false;
            }
            bool AllColumnsFilled()
            {
                if (nameBookBox.Text != "" && yearBookBox.Text != "" && authorBookBox.Text != "" && genreBookBox.Text != "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Не всі поля заповнені");
                    return false;
                }
            }


        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            if(CellBookName != null)
            {
                DialogResult dialog = MessageBox.Show("Ви впевнені, що бажаєте видалити книгу \"" + CellBookName + "\"?", "А ю шур?", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        FileInfo oldfile = new FileInfo(CellBookPath);
                        if (oldfile.Exists)
                        {
                            oldfile.Delete();
                        }
                        Parse.DeleteBookFromXML(CellBookName, Program.PathToBooks);
                        Parse.DeleteBookFromUsersBooks(CellBookName, Program.PathToUsersBooks);
                        DataGrid.ShowBooksForAdmin(ref allBooksAdminGrid);

                        CellBookName = null;
                    }catch(Exception)
                    {

                    }
                    
                }
            }
        }

        private void allUsersGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = e.RowIndex;
            
            try
            {
                CellUserName = allUsersGrid[0, i].Value.ToString();
                userLabel.Text = "User: " + CellUserName;
            }
            catch (Exception) { }
            
        }

        private void allUsersGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            int j = e.ColumnIndex;
            if(j == 0)
            {
                if (!CopyExistUser(allUsersGrid[0, i].Value.ToString()))
                {
                    changeUsersList(users, ref allUsersGrid, i);
                    DataGrid.ShowUsersForAdmin(ref allUsersGrid, users);
                }
                else
                {
                    allUsersGrid[0, i].Value = CellUserName;

                }
            }
            if (j != 0)
            {
                users = Parse.GetUsersToListFromCSV(Program.PathToUsers);
                changeUsersList(users, ref allUsersGrid, i);
                DataGrid.ShowUsersForAdmin(ref allUsersGrid, users);
            }
            
        }
        bool CopyExistUser(string one)
        {
            for (int i = 0; i < allUsersGrid.Rows.Count; i++)
            {
                if (one == allUsersGrid[0, i].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        void changeUsersList(List<User> users, ref DataGridView dataGrid, int i)
        {
            foreach(var us in users)
            {
                if(us.getName() == CellUserName)
                {
                    us.setName(dataGrid[0, i].Value.ToString());
                    us.setMail(dataGrid[1, i].Value.ToString());
                    us.setPassword(dataGrid[2, i].Value.ToString());
                }
            }
            Parse.AddUsersToCSVFromList(users, Program.PathToUsers);
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if(CellUserName != null)
            {
                Parse.RemoveUserFromCSV(CellUserName, Program.PathToUsers);
                Parse.RemoveUserFromXml(CellUserName, Program.PathToUsersBooks);
                CellUserName = null;
                users = Parse.GetUsersToListFromCSV(Program.PathToUsers);
                DataGrid.ShowUsersForAdmin(ref allUsersGrid, users);
                userLabel.Text = "User: ";
            }
        }

        private void grafik_Click(object sender, EventArgs e)
        {
            grafik.Series[0].Points.Clear();
            List<Book> books = Parse.BooksFromXML(Program.PathToBooks);
            List<Dictionary> counts = new List<Dictionary>();

            foreach(var b in books)
            {
                if(!BookExistInList(b.getYearBook(), counts))
                {
                    counts.Add(new Dictionary() { Year = b.getYearBook(), Count = 0 });
                }
            }
            foreach(var b in books)
            {
                IncrementDictionaryValue(b.getYearBook(), counts);
            }
            var sorted = from c in counts orderby c.Year select c;
            foreach(var c in sorted)
            {
                grafik.Series[0].Points.AddXY(c.Year, c.Count);
            }
            
        }
        public bool BookExistInList(int year, List<Dictionary> dic)
        {
            foreach(var b in dic)
            {
                if (year == b.Year) {
                    return true;
                } ;
            }
            return false;
        }
        
        public void IncrementDictionaryValue(int year, List<Dictionary> list)
        {
            foreach(var l in list)
            {
                if(l.Year == year)
                {
                    l.Count++;
                }
            }
        }
        public class Dictionary
        {
            public int Year { get; set; }
            public int Count { get; set; }
        }
    }
}
