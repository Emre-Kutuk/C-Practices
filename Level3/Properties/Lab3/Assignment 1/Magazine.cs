using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Magazine : BookStoreItem
    {
        private string dayOfRelease;
        public string DayOfRelease
        {
            get { return dayOfRelease; }
            set { dayOfRelease = value; }
        }

        public Magazine(string title, string dayOfRelease, double price, double count)
        : base(title, price, count)
        {
            this.DayOfRelease = dayOfRelease;
        }

        public override void Print()
        {
            Console.WriteLine("[MAGAZINE] {0} - Release Date : {1}, {2} ({3}x)", Title, DayOfRelease, Price.ToString("0.00"), Count);
        }
    }
}
