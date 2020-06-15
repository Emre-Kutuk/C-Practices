using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Book : BookStoreItem
    {
        public string Author { get; set; }

        public Book(string title, float price, int count, string author) : base(title,price,count)
        {
            Author = author;
        }

        public override string ToString()
        {
            return "[BOOK] " + Title + " - " + Author + ", " + Price.ToString("0.00") + " (" + NumberOfItems + "x)";
        }
    }
}
