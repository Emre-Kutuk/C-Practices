using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int row = 0;
            int total = 0;


            Console.Write("Enter a Number : ");
            number = int.Parse(Console.ReadLine());

            while ( number != 0 )
            {
                row++;

                if( row % 5 == 0)
                {
                    total += number;
                }

                Console.Write("Enter a Number : ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum of 5th, 10th, 15th, ... number is : " + total.ToString());
            Console.ReadKey();
        }
    }
}
