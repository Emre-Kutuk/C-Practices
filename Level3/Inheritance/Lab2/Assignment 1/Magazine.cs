using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Magazine : BookStoreItem
    {
        string dayOfRelease;

        public Magazine(string title, string dayOfRelease, double price)
        :base(title,price)
        {
            
           this.dayOfRelease = dayOfRelease;
       }

        public override void Print()
        {
            Console.WriteLine("[MAGAZINE] {0} - Release Date : {1}, {2}", title, dayOfRelease, price.ToString("0.00"));
        }
    }
}
