using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Linq;

namespace Library
{
    class DataGrid
    {

        public static void ShowBooks(ref DataGridView data)
        {

            List<Book> books = Parse.BooksFromXML(Program.PathToBooks);
            if (books.Count > 0)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Назва книги", typeof(string));
                //table.Columns.Add("Автор", typeof(string));
                //table.Columns.Add("Жанр", typeof(string));
                //table.Columns.Add("Рік", typeof(int));

                foreach (var b in books)
                {
                    table.Rows.Add(b.getName()/*, b.getAuthor(), b.getGenre(), b.getYearBook()*/);
                }
                data.DataSource = table;
            }
        }
        public static void ShowUsersBooks(ref DataGridView grid, Userbooks user)
        {
            if (user.getList.Count > 0)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Назва книги", typeof(string));
                table.Columns.Add("Рік", typeof(int));
                table.Columns.Add("Автор");
                table.Columns.Add("Жанр");
                foreach (var b in user.getList)
                {
                    table.Rows.Add(b.getName(), b.getYearBook(), b.getAuthor(), b.getGenre());
                }
                grid.DataSource = table;
            }
            else
            {
                DataTable table = new DataTable();
                table.Columns.Add("Назва книги", typeof(string));
                table.Columns.Add("Рік", typeof(int));
                table.Columns.Add("Автор");
                table.Columns.Add("Жанр");

                grid.DataSource = table;
                //try
                //{
                //    grid.Rows.RemoveAt(0);
                //}
                //catch (Exception)
                //{

                //}

            }
        }
        public static void ShowBooksForAdmin(ref DataGridView data)
        {
            List<Book> books = Parse.BooksFromXML(Program.PathToBooks);
            if (books.Count > 0)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Назва книги");
                table.Columns.Add("Рік", typeof(int));
                table.Columns.Add("Автор");
                table.Columns.Add("Жанр");
                table.Columns.Add("Шлях");
                foreach (var b in books)
                {
                    table.Rows.Add(b.getName(), b.getYearBook(), b.getAuthor(), b.getGenre(), b.getPath());
                }
                data.DataSource = table;
            }
        }
        public static void ShowUsersForAdmin(ref DataGridView data, List<User> users)
        {
            if(users.Count > 0)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Логін");
                table.Columns.Add("Пошта");
                table.Columns.Add("Пароль");
                foreach(var b in users)
                {
                    table.Rows.Add(b.getName(), b.getMail(), b.getPassword());
                }
                data.DataSource = table;
            }
        }
        public static string GetInfoForABook(string nameOfBook, string Param)
        {

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Program.PathToBooks);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                string t = xnode.Attributes["name"].Value;
                if (nameOfBook == t)
                {
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == Param)
                        {
                            return childnode.InnerText;
                        }
                    }
                }

            }
            return "Інформація відсутня";
        }
        public static void ChangeValue(ref DataGridView table, string Path, string name, int i)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                string t = xnode.Attributes.GetNamedItem("name").Value;
                if (name == t)
                {
                    xnode.Attributes["name"].Value = table[0, i].Value.ToString(); 
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "year")
                        {
                            childnode.InnerText = table[1, i].Value.ToString();
                        }
                        if (childnode.Name == "author")
                        {
                            childnode.InnerText = table[2, i].Value.ToString();
                        }
                        if (childnode.Name == "genre")
                        {
                            childnode.InnerText = table[3, i].Value.ToString();
                        }
                        if (childnode.Name == "path")
                        {
                            childnode.InnerText = table[4, i].Value.ToString();
                        }
                    }
                }
            }
            xDoc.Save(Path);

        }
        public static void ChangeBookInfoInUser(ref DataGridView table, string Path, string nameBook, int i)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach(XmlNode xnode in xRoot)
            {
                foreach (XmlNode booknode in xnode)
                {
                    string t = booknode.Attributes.GetNamedItem("name").Value;
                    if (nameBook == t)
                    {
                        booknode.Attributes["name"].Value = table[0, i].Value.ToString();
                        foreach (XmlNode childnode in booknode.ChildNodes)
                        {
                            if (childnode.Name == "year")
                            {
                                childnode.InnerText = table[1, i].Value.ToString();
                            }
                            if (childnode.Name == "author")
                            {
                                childnode.InnerText = table[2, i].Value.ToString();
                            }
                            if (childnode.Name == "genre")
                            {
                                childnode.InnerText = table[3, i].Value.ToString();
                            }
                            if (childnode.Name == "path")
                            {
                                childnode.InnerText = table[4, i].Value.ToString();
                            }
                        }

                    }
                }
            }
            xDoc.Save(Path);
        }
        public static void RemoveBookFromUser(string BookName, string Path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode users in xRoot)
            {
                if (Program.EnteredUserLogin == users.Attributes.GetNamedItem("name").Value)
                {
                    foreach (XmlNode book in users)
                    {
                        string t = book.Attributes["name"].Value;
                        if (t == BookName)
                        {
                            users.RemoveChild(book);
                        }
                    }
                }
            }
            xDoc.Save(Path);
        }
        public static void AddBookToUser(string BookName, string Path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode users in xRoot)
            {
                if (Program.EnteredUserLogin == users.Attributes.GetNamedItem("name").Value)
                {
                    if (!BookExist(BookName, users))
                    {
                        XmlElement book = xDoc.CreateElement("Book");
                        XmlAttribute nameBook = xDoc.CreateAttribute("name");
                        XmlText nameText = xDoc.CreateTextNode(BookName);

                        XmlElement yearElement = xDoc.CreateElement("year");
                        XmlElement authorElement = xDoc.CreateElement("author");
                        XmlElement genreElement = xDoc.CreateElement("genre");
                        XmlElement pathElement = xDoc.CreateElement("path");

                        XmlText yearText = xDoc.CreateTextNode(GetInfoForABook(BookName, "year"));
                        XmlText authorText = xDoc.CreateTextNode(GetInfoForABook(BookName, "author"));
                        XmlText genreText = xDoc.CreateTextNode(GetInfoForABook(BookName, "genre"));
                        XmlText pathText = xDoc.CreateTextNode(GetInfoForABook(BookName, "path"));

                        yearElement.AppendChild(yearText);
                        authorElement.AppendChild(authorText);
                        genreElement.AppendChild(genreText);
                        pathElement.AppendChild(pathText);

                        nameBook.AppendChild(nameText);
                        book.Attributes.Append(nameBook);
                        book.AppendChild(yearElement);
                        book.AppendChild(authorElement);
                        book.AppendChild(genreElement);
                        book.AppendChild(pathElement);
                        users.AppendChild(book);
                        xDoc.Save(Path);
                    }
                }
            }
        }
        static bool BookExist(string BookName, XmlNode xmlNode)
        {
            foreach (XmlNode x in xmlNode)
            {
                if (x.Attributes.Count > 0)
                {
                    XmlNode attr = x.Attributes.GetNamedItem("name");
                    if (attr.Value == BookName)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
       
        public static void SearchBookResult(ref DataGridView grid, string Parametr, string Value)
        {
            List<Book> books = Parse.BooksFromXML(Program.PathToBooks);
            if (books.Count > 0)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Назва книги", typeof(string));

                switch (Parametr)
                {
                    case "Назва":
                        foreach (var b in books)
                        {
                                if(b.getName().ToLower().Contains(Value.ToLower()))
                                table.Rows.Add(b.getName());   
                        }
                        grid.DataSource = table;
                        break;
                    case "Рік":
                        {
                            foreach (var b in books)
                            {
                                if (b.getYearBook() == Convert.ToInt32(Value))
                                {
                                    table.Rows.Add(b.getName());
                                }
                            }
                            grid.DataSource = table;
                            break;
                        }
                    case "Автор":
                        {
                            foreach (var b in books)
                            {
                                if (b.getAuthor() == Value)
                                {
                                    table.Rows.Add(b.getName());
                                }
                            }
                            grid.DataSource = table;
                            break;
                        }
                    case "Жанр":
                        {
                            foreach (var b in books)
                            {
                                if (b.getGenre() == Value)
                                {
                                    table.Rows.Add(b.getName());
                                }
                            }
                            grid.DataSource = table;
                            break;
                        }
                        
                }

            }
        }
    }
}
