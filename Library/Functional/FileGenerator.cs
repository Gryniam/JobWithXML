using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Library
{
    class FileGenerator
    {
        public static void Properities(string Path)
        {

            try
            {
                var myFile = File.Create(Path);
                myFile.Close();
                XmlDocument xm = new XmlDocument();
                XmlDeclaration xmDec = xm.CreateXmlDeclaration("1.0", "utf-8", null);

                xm.AppendChild(xmDec);
                XmlElement properities = xm.CreateElement("properities");
                xm.AppendChild(properities);

                XmlElement width = xm.CreateElement("Width");
                XmlElement height = xm.CreateElement("Height");
                XmlElement backColor = xm.CreateElement("BackgroundColor");
                XmlElement pathToUsers = xm.CreateElement("pathToUsers");
                XmlElement pathToAdmins = xm.CreateElement("pathToAdmins");
                XmlElement pathToBooks = xm.CreateElement("pathToBooks");
                XmlElement pathToUsersBooks = xm.CreateElement("pathToUsersBooks");

                properities.AppendChild(width);
                properities.AppendChild(height);
                properities.AppendChild(backColor);
                properities.AppendChild(pathToUsers);
                properities.AppendChild(pathToAdmins);
                properities.AppendChild(pathToBooks);
                properities.AppendChild(pathToUsersBooks);
                xm.Save(Path);

                Parse.SetXMLData(Path, "Width", "1000");
                Parse.SetXMLData(Path, "Height", "650");
                Parse.SetXMLData(Path, "BackgroundColor", "Azure");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }
        public static void Admins(string Path)
        {
            try
            {
                
                if (!(File.Exists(Path)))
                {
                    Excel.Application app = new Excel.Application();
                    Excel.Workbook workbook;
                    Excel.Worksheet worksheet;
                    object misValue = System.Reflection.Missing.Value;
                    workbook = app.Workbooks.Add(misValue);
                    worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                    worksheet.Cells[1, 1] = "admin";
                    worksheet.Cells[1, 2] = "1234";
                    workbook.SaveAs(Path, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, misValue,
                     misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    workbook.Close(true, Type.Missing, Type.Missing);
                    app.Quit();
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(worksheet);
                    Marshal.ReleaseComObject(app);
                    Program.PathToAdmins = Path;
                }
                else
                {
                    Program.PathToAdmins = Path;
                }
                
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public static void Users(string Path)
        {
            if (!(File.Exists(Path)))
            {
                using(var sw = new StreamWriter(Path, false, Encoding.Default))
                {
                    sw.WriteLine();
                }
                Program.PathToUsers = Path;
            }
            else
            {
                Program.PathToUsers = Path;
            }
        }
        public static void Books(string Path)
        {
            try
            {
                var myFile = File.Create(Path);
                myFile.Close();
                XmlDocument xm = new XmlDocument();
                XmlDeclaration xmDec = xm.CreateXmlDeclaration("1.0", "utf-8", null);

                xm.AppendChild(xmDec);
                XmlElement books = xm.CreateElement("books");
                xm.AppendChild(books);
                xm.Save(Path);
                Program.PathToBooks = Path;
            }
            catch(Exception e)
            {

            }
        }
        public static void UsersBooks(string Path)
        {
            try
            {
                var myFile = File.Create(Path);
                myFile.Close();
                XmlDocument xm = new XmlDocument();
                XmlDeclaration xmDec = xm.CreateXmlDeclaration("1.0", "utf-8", null);

                xm.AppendChild(xmDec);
                XmlElement usbooks = xm.CreateElement("usersbooks");
                xm.AppendChild(usbooks);
                xm.Save(Path);
                Program.PathToUsersBooks = Path;
            }
            catch (Exception)
            {
                
            }
        }

        
    }
}
