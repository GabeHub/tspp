using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Library
    {
        private List<Book> catalog;
        public Library()
        {
            catalog = new List<Book>();
        }

        public void Add(Book book)
        {
            catalog.Add(book);
        }
        public void Remove(int num)
        {
            catalog.RemoveAt(num);
        }
        public void Check()
        {
            foreach (Book book in catalog)
                Console.WriteLine(book.Author + "| " + book.Title + "| " + book.Level + "| " + book.Date);
        }
    }
}
