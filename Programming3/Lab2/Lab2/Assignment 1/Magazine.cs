using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Magazine : Book
    {
        public string dayOfRelease;

        public Magazine(string title, string dayOfRelease, double price)
        {
            this.title = title;
            this.dayOfRelease = dayOfRelease;
            this.price = price;
        }

        public override void Print()
        {
            Console.WriteLine("[MAGAZINE] {0} - Release Date : {1}, {2}", title, dayOfRelease, price.ToString("0.00"));
        }
    }
}
