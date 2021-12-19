using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User
    {
        string UserName;
        string Mail;
        string Password;
        public User(string N, string M, string P)
        {
            this.UserName = N;
            this.Mail = M;
            this.Password = P;
            
        }
        public string getName(){return this.UserName;}
        public void setName(string name) {this.UserName = name;}
        public string getMail(){return this.Mail;}
        public void setMail(string mail){this.Mail = mail;}
        public string getPassword()
        {return this.Password;}
        public void setPassword(string pass)
        {this.Password = pass;}
    }
}
