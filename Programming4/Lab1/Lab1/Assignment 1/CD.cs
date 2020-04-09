using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class CD : BookStoreItem
    {
        public string Artist { get; set; }

        public CD(string title, float price, int count, string artist) : base(title,price,count)
        {
            Artist = artist;
        }

        public override string ToString()
        {
            return "[CD] " + Title + " - " + Artist + ", " + Price.ToString("0.00") + " (" + NumberOfItems + "x)";
        }
    }
}
