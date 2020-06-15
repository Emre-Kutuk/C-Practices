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
            int input;

            Console.WriteLine("Enter a number (1....4): ");
            input = int.Parse(Console.ReadLine());

            switch(input)
                {
                case 1:
                    Console.WriteLine("clubs");
                    break;
                case 2:
                    Console.WriteLine("diamonds");
                    break;
                case 3:
                    Console.WriteLine("hearts");
                    break;
                case 4:
                    Console.WriteLine("spades");
                    break;
                default:
                    Console.WriteLine("Incorrect Number!");
                    break;
                }

            Console.ReadKey();
        }
    }
}
