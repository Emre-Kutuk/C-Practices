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
            int number1;
            int number2;
            int number3;


            Console.WriteLine("Enter the First Number");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            number3 = int.Parse(Console.ReadLine());



            if(number3<number2 && number3<number1)

            {
                Console.WriteLine("The third number is the smallest of the three");
            }
            else
            {
                Console.WriteLine("The third number is NOT the smallest of the three");
            }

            Console.ReadKey();
        }
    }
}
