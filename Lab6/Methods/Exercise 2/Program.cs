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
            bool isPrime;
            int userInput;
            Console.Write("Enter a number (0 = stop) : ");
            userInput = int.Parse(Console.ReadLine());
            while (userInput != 0)
            {
                if(userInput >= 0)
                { 
                isPrime = checkIfPrime(userInput);
                if (isPrime)
                {
                    Console.WriteLine(userInput + " is a prime number.");
                }
                else if(isPrime == false)
                {
                    Console.WriteLine(userInput + " is NOT a prime number.");
                }
                }
                else
                {
                    Console.WriteLine("Please enter a positive value.");
                }
                Console.Write("Enter a number (0 = stop) : ");
                userInput = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("end of the program.");
            Console.ReadKey();

        }
        static bool checkIfPrime(int number)
        {
            bool isPrime;

            int a = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    a++;
                }
            }

            if (a == 2)
            {
                isPrime = true;
            }
            else
            {
                isPrime = false;
            }

            return isPrime;
        }
    }
}
