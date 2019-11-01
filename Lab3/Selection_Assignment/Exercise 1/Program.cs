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
            int number1;
            int number2;

            Console.WriteLine("Enter the First Number");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            number2 = int.Parse(Console.ReadLine());

            if(number1 > number2)
            {
                Console.WriteLine("The Highest Value is : " + number1);
                Console.WriteLine("The Lowest Value is : " + number2);
            }
            else
            {
                Console.WriteLine("The Highest Value is : " + number2);
                Console.WriteLine("The Lowest Value is : " + number1);

            }

            Console.ReadKey();
        }
    }
}
