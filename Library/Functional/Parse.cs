using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Xml;
using System.Net;
using Library.Classes;
using Newtonsoft.Json;

namespace Library
{
    class Parse
    {
        //Тут ЦСВ
        #region
        //Отримування юзерів в ліст
        public static List<User> GetUsersToListFromCSV(string path)
        {
            List<User> users = new List<User>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] row = new string[3];
                        row = line.Split(',');
                        User user = new User(row[0], row[1], row[2]);
                        users.Add(user);
                    }

                }
                return users;
            }
        }
        //Отримую пошту або пароль юзера
        public static string GetUserData(string UserName, List<User> users, string what)
        {
            switch (what)
            {
                case "mail":
                    {
                        foreach (var user in users)
                        {
                            if (UserName == user.getName())
                            {
                                return user.getMail();
                            }
                        }
                        return null;
                    }
                case "password":
                    {
                        foreach (var user in users)
                        {
                            if (UserName == user.getName())
                            {
                                return user.getPassword();
                            }
                        }
                        return null;
                    }
                default:
                    return null;
            }
            
        }
        //Видалення юзера з файлу
        public static void RemoveUserFromCSV(string UserName, string Path)
        {
            List<User> user = GetUsersToListFromCSV(Path);

            var UserToRemove = user.Single(r => r.getName() == UserName);
            if (UserToRemove != null)
            {
                user.Remove(UserToRemove);
            }
            AddUsersToCSVFromList(user, Path);
            
        }
        //Перезапис юзерів з ліста в цсв
        public static void AddUsersToCSVFromList(List<User> users, string Path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Path, false, System.Text.Encoding.Default))
                {
                    StringBuilder st = new StringBuilder();
                    foreach (var user in users)
                    {
                        st.Append(user.getName() + "," + user.getMail() + "," + user.getPassword() + "\n");
                    }
                    sw.Write(st.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //Додавання окремо юзера в csv
        public static void AddUserToCSV(ref TextBox nameBox, ref TextBox mailBox, ref TextBox passBox, string Path)
        {
            try
            {
                User user = new User(nameBox.Text, mailBox.Text, passBox.Text);
                using (StreamWriter st = new StreamWriter(Path, true, System.Text.Encoding.Default))
                {
                    st.Write(user.getName() + "," + user.getMail() + "," + user.getPassword() + "\n");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //Перевірка файлу з юзерами на валідність
        public static bool CheckUserDocument(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line == null)
                    {
                        return true;
                    }
                    string[] row = line.Split(',');
                    if (row.Length == 3)
                    {
                        return true;
                    }
                    else { return false; }
                }
            }
            return false;
        }
        #endregion 


        //Тут ексель
        #region
        //Перевірка ексель файлу на валідність
        public static bool ExcelValid(string Path)
        {
            object readOnly = true;
            object SaveChanges = false;
            object MissingObj = System.Reflection.Missing.Value;
            Excel.Application app = new Excel.Application();
            Excel.Workbooks workbooks = null;
            Excel.Workbook workbook = null;
            Excel.Sheets sheets = null;
            try
            {
                workbooks = app.Workbooks;
                workbook = workbooks.Open(Path, MissingObj, readOnly, MissingObj, MissingObj,
                                            MissingObj, MissingObj, MissingObj, MissingObj, MissingObj,
                                            MissingObj, MissingObj, MissingObj, MissingObj, MissingObj);
                sheets = workbook.Sheets;
                foreach (Excel.Worksheet worksheet in sheets)
                {
                    Excel.Range UsedRange = worksheet.UsedRange;
                    Excel.Range urRows = UsedRange.Rows;
                    Excel.Range urColums = UsedRange.Columns;
                    int RowsCount = urRows.Count;
                    int ColumnsCount = urColums.Count;
                    if (ColumnsCount == 2)
                    {
                        Excel.Range CellRange = UsedRange.Cells[1, 1];
                        string CellText = (CellRange == null || CellRange.Value2 == null) ? null :
                                    (CellRange as Excel.Range).Value2.ToString();

                        Excel.Range CellRange2 = UsedRange.Cells[1, 2];
                        string CellText2 = (CellRange2 == null || CellRange2.Value2 == null) ? null :
                                    (CellRange2 as Excel.Range).Value2.ToString();

                        if (CellText != null && CellText2 != null)
                        {
                            return true;
                        }

                    }

                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        //Отримання адмінів з екселю
        public static void AdminsFromExcel(List<Admin> admin, string Path)
        {
            object readOnly = true;
            object SaveChanges = false;
            object MissingObj = System.Reflection.Missing.Value;

            Excel.Application app = new Excel.Application();
            Excel.Workbooks workbooks = null;
            Excel.Workbook workbook = null;
            Excel.Sheets sheets = null;
            try
            {
                workbooks = app.Workbooks;
                workbook = workbooks.Open(Path, MissingObj, readOnly, MissingObj, MissingObj,
                                            MissingObj, MissingObj, MissingObj, MissingObj, MissingObj,
                                            MissingObj, MissingObj, MissingObj, MissingObj, MissingObj);
                sheets = workbook.Sheets;
                foreach (Excel.Worksheet worksheet in sheets)
                {
                    //Діапазон використаних клітинок
                    Excel.Range UsedRange = worksheet.UsedRange;
                    //Рядки які використ
                    Excel.Range urRows = UsedRange.Rows;
                    //Стовбці які використ
                    Excel.Range urColums = UsedRange.Columns;

                    int RowsCount = urRows.Count;
                    int ColumnsCount = urColums.Count;
                    for (int i = 1; i <= RowsCount; i++)
                    {
                        Admin adminn = new Admin(null, null);
                        admin.Add(adminn);
                        for (int j = 1; j <= ColumnsCount; j++)
                        {

                            Excel.Range CellRange = UsedRange.Cells[i, j];
                            string CellText = (CellRange == null || CellRange.Value2 == null) ? null :
                                    (CellRange as Excel.Range).Value2.ToString();
                            if (CellText != null && j == 1)
                            {
                                admin[i - 1].setName(CellText);
                            }
                            if (CellText != null && j == 2)
                            {
                                admin[i - 1].setPassword(CellText);
                            }
                        }
                    }
                    if (urRows != null) Marshal.ReleaseComObject(urRows);
                    if (urColums != null) Marshal.ReleaseComObject(urColums);
                    if (UsedRange != null) Marshal.ReleaseComObject(UsedRange);
                    if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (sheets != null) Marshal.ReleaseComObject(sheets);
                if (workbook != null)
                {
                    workbook.Close(SaveChanges);
                    Marshal.ReleaseComObject(workbook);
                    workbook = null;
                }

                if (workbooks != null)
                {
                    workbooks.Close();
                    Marshal.ReleaseComObject(workbooks);
                    workbooks = null;
                }
                if (app != null)
                {
                    app.Quit();
                    Marshal.ReleaseComObject(app);
                    app = null;
                }
                
            }
        }
        #endregion

        //Тут ХМЛ
        #region
        //Отримування даних з ХМЛ
        public static string GetXMLData(string Path, string attribute)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == attribute)
                {
                    return xnode.InnerText;
                    // return childnode.InnerText;
                }
            }
            return null;
        }
        //Запис даних в ХМЛ
        public static void SetXMLData(string Path, string attribute, string Data)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == attribute)
                {
                    xnode.InnerText = Data;
                    //childnode.InnerText = Data;
                }

            }
            xDoc.Save(Path);
        }
        //Перевірка ХМЛ файлу на наявність піднода
        public static bool CheckXML(string Path, string attribute)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(Path);
                XmlElement xRoot = xDoc.DocumentElement;
                foreach (XmlNode xnode in xRoot)
                {
                    if (xnode.Name == attribute)
                    {
                        return true;
                    }

                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

        }
        //Перевірка файлу з книгами на наявність нода
        public static bool CheckBookXML(string Path, string attribute)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(Path);
                XmlElement xRoot = xDoc.DocumentElement;
                foreach (XmlNode xnode in xRoot)
                {
                    if (xnode.ParentNode.Name == attribute)
                    {
                        return true;
                    }

                }
                return false;
            }
            catch (Exception e)
            {

                return false;
            }

        }
        //Зчитування книг з ХМЛ
        public static List<Book> BooksFromXML(string Path)
        {
            List<Book> books = new List<Book>();
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(Path);
                XmlElement xRoot = xDoc.DocumentElement;
                foreach (XmlNode xnode in xRoot)
                {
                    Book b = new Book(null, 0, null, null, null);
                    if (xnode.Attributes.Count > 0)
                    {
                        XmlNode attr = xnode.Attributes.GetNamedItem("name");
                        if (attr != null)
                        {
                            //b.namebook = attr.Value;
                            b.setName(attr.Value);
                        }
                        else
                        {
                            //namebook = "Unknown";
                            b.setName("Unknown");
                        }
                    }
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "year")
                        {
                            //year = Convert.ToInt32(childnode.InnerText);
                            b.setYearBook(Convert.ToInt32(childnode.InnerText));
                        }
                        if (childnode.Name == "author")
                        {
                            // author = childnode.InnerText;
                            b.setAuthor(childnode.InnerText);
                        }
                        if (childnode.Name == "genre")
                        {
                            // genre = childnode.InnerText;
                            b.setGenre(childnode.InnerText);
                        }
                        if (childnode.Name == "path")
                        {
                            // pathtobook = childnode.InnerText;
                            b.setPath(childnode.InnerText);
                        }
                    }
                    // Book b = new Book(namebook, year, author, genre, pathtobook);
                    books.Add(b);
                }
                return books;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        //Тут чучуть складніше зчитування
        public static Userbooks ReadFromUsersBooks(string Path)
        {
            try
            {
                List<Book> books = new List<Book>();
                Userbooks user = new Userbooks();
                user.getName = Program.EnteredUserLogin;

                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(Path);
                XmlElement xRoot = xDoc.DocumentElement;
                foreach(XmlNode xnode in xRoot)
                {
                    string t = xnode.Attributes.GetNamedItem("name").Value;
                    if(Program.EnteredUserLogin == t)
                    {
                        foreach(XmlNode book in xnode)
                        {
                            Book b = new Book(null, 0, null, null, null);
                            if (book.Attributes.Count > 0)
                            {
                                XmlNode attr = book.Attributes.GetNamedItem("name");
                                if(attr != null)
                                {
                                    b.setName(attr.Value);
                                }
                                else
                                {
                                    b.setName("Unknown");
                                }
                                foreach(XmlNode childnode in book.ChildNodes)
                                {
                                    if(childnode.Name == "year")
                                    {
                                        b.setYearBook(Convert.ToInt32(childnode.InnerText));
                                    }
                                    if (childnode.Name == "author")
                                    {
                                        b.setAuthor(childnode.InnerText);
                                    }
                                    if (childnode.Name == "genre")
                                    {   
                                        b.setGenre(childnode.InnerText);
                                    }
                                    if (childnode.Name == "path")
                                    {   
                                        b.setPath(childnode.InnerText);
                                    }
                                }
                            }
                            books.Add(b);

                        }
                    }
                }
                user.getList = books;
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }
        //Додаю юзера в ХМЛ файл
        public static void AddUserIfNotExisting(string Path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            if (!UserExist(xRoot))
            {
                XmlElement userElement = xDoc.CreateElement("User");
                XmlAttribute nameAttr = xDoc.CreateAttribute("name");
                XmlText nameText = xDoc.CreateTextNode(Program.EnteredUserLogin);
                nameAttr.AppendChild(nameText);
                userElement.Attributes.Append(nameAttr);
                xRoot.AppendChild(userElement);
                xDoc.Save(Path);
            }

        }
        static bool UserExist(XmlElement xRoot)
        {
            foreach(XmlNode xnode in xRoot)
            {
                if(Program.EnteredUserLogin == xnode.Attributes.GetNamedItem("name").Value)
                {
                    return true;
                }
            }
            return false;
        }

        //Видаляю юзера з хмл файлу
        public static void RemoveUserFromXml(string UserName, string Path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach(XmlNode user in xRoot)
            {
                if (UserName == user.Attributes.GetNamedItem("name").Value)
                {
                    xRoot.RemoveChild(user);
                }
            }
            xDoc.Save(Path);
        }

        public static void AddBookToXML(Book book, string Path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement root = xDoc.DocumentElement;

            XmlElement bookElement = xDoc.CreateElement("book");
            XmlAttribute bookAttr = xDoc.CreateAttribute("name");
            XmlText bookName = xDoc.CreateTextNode(book.getName());

            XmlElement yearElement = xDoc.CreateElement("year");
            XmlElement authorElement = xDoc.CreateElement("author");
            XmlElement genreElement = xDoc.CreateElement("genre");
            XmlElement pathElement = xDoc.CreateElement("path");

            XmlText yearText = xDoc.CreateTextNode(book.getYearBook().ToString());
            XmlText authorText = xDoc.CreateTextNode(book.getAuthor());
            XmlText genreText = xDoc.CreateTextNode(book.getGenre());
            XmlText pathText = xDoc.CreateTextNode(book.getPath());

            bookAttr.AppendChild(bookName);
            yearElement.AppendChild(yearText);
            authorElement.AppendChild(authorText);
            genreElement.AppendChild(genreText);
            pathElement.AppendChild(pathText);

            bookElement.Attributes.Append(bookAttr);
            bookElement.AppendChild(yearElement);
            bookElement.AppendChild(authorElement);
            bookElement.AppendChild(genreElement);
            bookElement.AppendChild(pathElement);
            root.AppendChild(bookElement);
            xDoc.Save(Path);
        }

        public static void DeleteBookFromXML(string BookName, string Path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement root = xDoc.DocumentElement;
            foreach(XmlNode xnode in root)
            {
                string t = xnode.Attributes["name"].Value;
                if (BookName == t)
                {
                    root.RemoveChild(xnode);
                }
            }
            xDoc.Save(Path);
        }

        public static void DeleteBookFromUsersBooks(string BookName, string Path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach(XmlNode xnode in xRoot)
            {
                foreach (XmlNode booknode in xnode)
                {
                    string t = booknode.Attributes.GetNamedItem("name").Value;
                    if(BookName == t)
                    {
                        xnode.RemoveChild(booknode);
                    }
                }
            }
            xDoc.Save(Path);
        }
        #endregion



        public static string GetWeather()
        {
            try
            {
                string url = "http://api.openweathermap.org/data/2.5/weather?q=Ivano-Frankivsk&units=metric&appid=d5757b415990193c8251446c3ae98e07";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string response;
                using (StreamReader stream = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    response = stream.ReadToEnd();
                }
                Root root = JsonConvert.DeserializeObject<Root>(response);

                return root.name + ", " + root.weather[0].main + ", " + root.main.temp+"C";
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return "No internet connection";
            }
           
        }
    }
}
