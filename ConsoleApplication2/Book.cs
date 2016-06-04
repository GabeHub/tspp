using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Book
    {
        private string author;
        private string title;
        private int level;
        private string date;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
