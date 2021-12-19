using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        string NameBook;
        int YearBook;
        string Author;
        string Genre;
        string Path;
        
        public Book(string N, int Y, string A, string G, string path)
        {
            this.NameBook = N;
            this.YearBook = Y;
            this.Author = A;
            this.Genre = G;
            this.Path = path;
        }
        public string getName() { return this.NameBook; }
        public void setName(string name) { this.NameBook = name; }
        public int getYearBook() { return this.YearBook; }
        public void setYearBook(int year) { this.YearBook = year; }
        public string getAuthor() { return this.Author; }
        public void setAuthor(string auth) { this.Author = auth; }
        public string getGenre() { return this.Genre; }
        public void setGenre(string g) { this.Genre = g; }
        public string getPath() { return this.Path; }
        public void setPath(string p) { this.Path = p; }

    }
}
