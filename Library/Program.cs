using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Library
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
        public static string PathToUsers = null;
        public static string PathToAdmins = null;
        public static string PathToBooks = null;
        public static string PathToUsersBooks = null;
        public static int Width = 1000;
        public static int Height = 1000;
        public static Color color = Color.Aquamarine;
        public static string wanted_path = Application.StartupPath;
        public static string PathToProperities = wanted_path+"\\Properities.xml";


        public static string BooksLink = "";
        public static string UsersLink = "";
        public static string UsersBooksLink = "";


        public static string EnteredUserLogin = null;
        public static string EnteredUserMail = null;
    }
}
