using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNumber;
            int inputNumber;
            int equals = 0;

            Console.Write("Enter Target Number: ");
            targetNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter a Number : ");
            inputNumber = int.Parse(Console.ReadLine());

            while (inputNumber != 0)
            {
                if(targetNumber == inputNumber)
                {
                    equals++;
                }

                Console.Write("Enter a Number : ");
                inputNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Count of numbers equal to target number : " + equals);
            Console.ReadKey();

        }
    }
}
