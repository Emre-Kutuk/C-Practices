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
            double number;
            double avg = 0;
            double numbernumber = 0;
            double total = 0;

            Console.Write("Enter a Number ");
            number = double.Parse(Console.ReadLine());

            while( number != 0)
            {
                if(number > 0)
                { 
                numbernumber++ ;
                total += number;
                avg = total / numbernumber;
                }
                else
                {
                    Console.WriteLine("Please enter a poisitive number!");
                }

                Console.Write("Enter a Number ");
                number = double.Parse(Console.ReadLine());
            }
            




            Console.WriteLine("Average of all positive numbers is : " + avg.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
