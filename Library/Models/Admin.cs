using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Admin
    {
        string AdminUserName;
        string Password;
        public Admin(string usname, string pas)
        {
            this.AdminUserName = usname;
            this.Password = pas;
        }
        public string getName() { return this.AdminUserName; }
        public void setName(string name) { this.AdminUserName = name; }
        public string getPassword() { return this.Password; }
        public void setPassword(string Apas){ this.Password = Apas; }
    }
}
