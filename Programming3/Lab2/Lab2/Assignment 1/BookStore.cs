using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class BookStore
    {
        public List<Book> books = new List<Book>();

        public void Add(Book book)
        {
            books.Add(book);
        }

        public void PrintCompleteStock()
        {
            double total = 0;

            foreach(Book b in books)
            {
                total += b.price;
            }

            Console.WriteLine("Total sales price : " + total.ToString("00.00"));
        }

        public void PrintEveryBook()
        {
            foreach (Book b in books)
            {
                b.Print();
            }
        }
    }
}
