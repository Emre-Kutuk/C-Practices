using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Book : BookStoreItem
    {
        private string author;

        public string Author {
            get { return author; }
            private set { author = value;}
        }

        public Book(string title, string author, double price, double count) : base(title, price,count)
        {
            this.Author = author;
        }

        public override void Print()
        {
            Console.WriteLine("[BOOK] '{0}' by {1}, {2} ({3}x)", Title, Author, Price.ToString("0.00"), Count.ToString());
        }
    }
}
