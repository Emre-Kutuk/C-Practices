using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class BookStoreItem
    {
        public string title;
        public double price;

        public virtual void Print()
        {
            Console.WriteLine("[-] '{0}' {1}", title, price.ToString("0.00"));
        }

        public BookStoreItem(string title, double price)
        {
            this.title = title;
            this.price = price;
        }
    }
}
