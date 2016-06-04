using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.Author = "aa";
            b.Title = "bb";
            b.Level = 10;
            b.Date = "01.01.16";
            Book b1 = new Book();
            b1.Author = "a1";
            b1.Title = "b1";
            b1.Level = 11;
            b1.Date = "12.03.16";
            Book b2 = new Book();
            b2.Author = "a2";
            b2.Title = "b2";
            b2.Level = 12;
            b2.Date = "21.10.16";
            Library l = new Library();
            l.Add(b);
            l.Add(b1);
            l.Add(b2);
            l.Check();
            Console.Read();
        }

    }

    public class Client
    {
        private string name;
        private int number;
        private string birthday;
        private List<Book> list;
        private int level;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public Client()
        {
            list = new List<Book>();
        }
        private void CheckList()
        {
            
        }

    }
    public class Librarian
    {
        private string[] readers;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    public class Manager
    {
        private string name;
        private string[] employees;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    public class Head
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}

