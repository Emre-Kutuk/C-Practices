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
            int userInput = 0;
            bool isLeap;
            Console.Write("Enter a year(0 is stop value) : ");
            userInput = int.Parse(Console.ReadLine());
            while(userInput != 0)
            {
                isLeap = checkIfLeap(userInput);
              
                if (isLeap)
                {
                    Console.WriteLine(userInput + " is a leap year.");
                }
                else
                {
                    Console.WriteLine(userInput + " is NOT a leap year.");
                }
                Console.Write("Enter a year(0 is stop value) : ");
                userInput = int.Parse(Console.ReadLine());
                
            

            }
            Console.WriteLine("end of the program.");
            Console.ReadKey();


        }

        static bool checkIfLeap(int year)
        {
            bool isLeap;
            if( year % 400 == 0 || year % 100 != 0 && year % 4 == 0)
            {
                isLeap = true;
            }
            else
            {
                isLeap = false;
            }

            return isLeap;
        }
    }
}
