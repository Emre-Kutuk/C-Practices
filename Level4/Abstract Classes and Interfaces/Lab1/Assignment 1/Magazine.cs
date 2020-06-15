using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Magazine : BookStoreItem
    {
        public DayOfWeek ReleaseDay { get; set; }

        public Magazine(string title, float price,int count, DayOfWeek releaseday) : base(title,price,count)
        {
            ReleaseDay = releaseday;
        }

        public override string ToString()
        {
            return "[MAGAZINE] " + Title + " - " + ReleaseDay + ", " + Price.ToString("0.00") + " (" + NumberOfItems + "x)";
        }

    }
}
