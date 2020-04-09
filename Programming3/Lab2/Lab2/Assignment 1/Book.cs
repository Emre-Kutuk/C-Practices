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
        
        public Book(string title, string author, double price) : base(title,price)
        {
            this.author = author;   
        }

        public override void Print()
        {
            Console.WriteLine("[BOOK] '{0}' by {1}, {2}", title, author, price.ToString("0.00"));
        }
    }
}
