using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    abstract class BookStoreItem
    {
        private string title;
        private double price;
        private double count;

        public string Title {
            get { return title; }
            set { title = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Count
        {
            get { return count; }
            set { count = value; }
        }

        public double TotalPrice
        {
            get { return this.Count * this.Price; }
            private set { }
        }

        public virtual void Print()
        {
            Console.WriteLine("[-] '{0}' {1} ({2}x)", Title, Price.ToString("0.00"), Count.ToString());
        }

        public BookStoreItem(string title, double price, double count)
        {
            this.Title = title;
            this.Price = price;
            this.Count = count;
        }
    }
}
