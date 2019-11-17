using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;
            Random random = new Random();
            randomNumber = random.Next(0, 10);

            while (randomNumber > 0)
            {
                randomNumber = random.Next(0, 10);
                if (randomNumber == 0)
                    break;
                Console.WriteLine("Factorial of " + randomNumber + " is " + getFactorial(randomNumber).ToString());
            }

            Console.WriteLine("\nend of the program");
            Console.ReadKey();
        }

        static int getFactorial(int number)
        {
            int factorial = 1;

            for(int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }



            return factorial;
        }


    }
}
