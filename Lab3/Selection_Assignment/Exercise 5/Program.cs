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
            int number1;
            int number2;
            int result;
            

            Console.Write("Enter the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            number2 = int.Parse(Console.ReadLine());

            if(number1 > number2)
            {
                result = number1 / number2;
                if(number2 * result == number1)
                {
                    Console.WriteLine("Number 1 is multiple of number 2");
                }

                else
                {
                    Console.WriteLine("Numbers are no multiples");
                }
            }

            if (number2 > number1)
            { 
                result = number2 / number1;
                if(number1 * result == number2)
                {
                    Console.WriteLine("Number 2 is multiple of number1");
                }
                else
                {
                Console.WriteLine("Numbers are no multiples");
                }
            }

            Console.ReadKey();
        }   
    }
}
