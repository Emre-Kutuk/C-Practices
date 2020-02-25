using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Book : BookStoreItem
    {
        public string author;
        
        public Book()
        { }
        
        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public override void Print()
        {
            Console.WriteLine("[BOOK] '{0}' by {1}, {2}", title, author, price.ToString("0.00"));
        }
    }
}
