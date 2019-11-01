using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double price;
            double VATValue = 0.21;

            string total;
            string calculatedVAT;

            Console.WriteLine("Enter a Price");
            input = Console.ReadLine();
            price = double.Parse(input);


            calculatedVAT = (price * VATValue).ToString("0.00");
            total = ((price * VATValue) + price).ToString("0.00");


            Console.WriteLine("Price : " + input +", VAT : "+ calculatedVAT + ", Total : " + total);




            Console.ReadKey();
        }
    }
}
