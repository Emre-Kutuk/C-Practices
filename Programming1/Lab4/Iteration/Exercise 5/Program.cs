using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearInput;

            Console.Write("Enter a year : ");
            yearInput = int.Parse(Console.ReadLine());

            while (yearInput != 0)
            {
                if(yearInput < 0)
                {
                    Console.WriteLine("Please Enter a Positive Number!");
                }
                else
                { 
                if (yearInput % 400 == 0 || yearInput % 4 == 0 && yearInput % 100 !=0)
                {
                    Console.WriteLine(yearInput.ToString() + " is a leap year.");
                }
                else
                {
                    Console.WriteLine(yearInput.ToString() + " is NOT a leap year.");
                }
                }
                Console.Write("Enter a year : ");
                yearInput = int.Parse(Console.ReadLine());

            }

            Console.ReadKey();

        }
    }
}
