using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Userbooks
    {
        string Username;
        List<Book> list = null;

        public string getName
        {
            get
            { return Username; }
            set{ Username = value; }
        }
        public List<Book> getList
        {
            get { return list; }
            set { list = value; }
        }

    }
}
