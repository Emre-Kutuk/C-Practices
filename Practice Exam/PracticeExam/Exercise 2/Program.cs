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
            int userInput;

            Console.Write("Enter a number : ");
            userInput = int.Parse(Console.ReadLine());

            while (userInput != 0)
            {
                char star = '*';
                char mark = '!';
                int firstHalf = 0;
                int secondHalf = 0;

                firstHalf = userInput / 2;
                secondHalf = userInput - firstHalf;

                for(int i = 0; i < firstHalf;i++)
                {
                    Console.Write(star);
                }
                for(int i = 0; i < secondHalf; i++)
                {
                    Console.Write(mark);
                }
                Console.Write("\nEnter a number : ");
                userInput = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nend of the program");
            Console.ReadKey();

        }
    }
}
