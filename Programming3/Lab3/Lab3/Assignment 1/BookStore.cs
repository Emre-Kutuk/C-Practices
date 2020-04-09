using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class BookStore
    {
        private List<BookStoreItem> books = new List<BookStoreItem>();

        public void Add(BookStoreItem book)
        {
            books.Add(book);
        }

        public void PrintCompleteStock()
        {
            double total = 0;

            foreach (BookStoreItem b in books)
            {
                total += b.TotalPrice;
            }

            Console.WriteLine("Total sales price : " + total.ToString("00.00"));
        }

        public void PrintEveryBook()
        {
            foreach (BookStoreItem b in books)
            {
                b.Print();
            }
        }
    }
}
