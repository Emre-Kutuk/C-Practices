using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class BookStore
    {
        public List<BookStoreItem> bookStoreItems = new List<BookStoreItem>();

        public void Add(BookStoreItem bookStoreItem)
        {
            bookStoreItems.Add(bookStoreItem);
        }

        public void PrintCompleteStock()
        {
            double total = 0;

            foreach(BookStoreItem item in bookStoreItems)
            {
                total += item.price;
            }

            Console.WriteLine("Total sales price : " + total.ToString("00.00"));
        }

        public void PrintEveryBookStoreItem()
        {
            foreach (BookStoreItem item in bookStoreItems)
            {
                item.Print();
            }
        }
    }
}
