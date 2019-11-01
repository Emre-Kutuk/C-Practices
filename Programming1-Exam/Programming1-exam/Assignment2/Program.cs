using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int factor = 2;
            int userInput;

            askForNumber(out userInput, out factor);

            while (userInput >= 1)
            {
                while(factor <= userInput)  
            {
                if (userInput % factor == 0)
                {
                    Console.Write(factor + " ");
                    userInput = userInput / factor;
                }
                else
                    factor++;
            }
                Console.WriteLine("\n");
                askForNumber(out userInput, out factor);
            }
            Console.WriteLine("\nend of the program.");
            Console.ReadKey();
        }
        static void askForNumber(out int userInput, out int factor)
        {
            factor = 2;
            Console.Write("Enter a number : ");
            userInput = int.Parse(Console.ReadLine());
        }
    }
}
