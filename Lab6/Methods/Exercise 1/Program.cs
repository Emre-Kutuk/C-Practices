using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double userInput;
            double VAT;
            Console.WriteLine("Enter a price");
            userInput = double.Parse(Console.ReadLine());

            VAT = calculateVAT(userInput);

            Console.WriteLine("price = " + userInput.ToString("0.00") + ", vat = " + VAT.ToString("0.00") + ", total = " + ((VAT + userInput).ToString("0.00")));
            Console.ReadKey();
        }

        static double calculateVAT(double price)
        {
            double VAT;
            VAT = price * 0.21;
            return VAT;

            
        }

    }
}
