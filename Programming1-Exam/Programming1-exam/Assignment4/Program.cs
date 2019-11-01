using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number1;
            int number2;
            int remainder = 0;
            int quotient = 0;

            for(int i = 0; i < 10; i++)
            { 
            number1 = random.Next(1, 51);
            number2 = random.Next(1, 6);

            IntegerDivision(number1, number2, out remainder, out quotient);
            Console.WriteLine(number1 + " / " + number2 + " = " + quotient + " (" + remainder + ")");
            }

            Console.WriteLine("\nend of the program");
            Console.ReadKey();
            
        }

        static void IntegerDivision(int number1, int number2, out int remainder, out int quotient)
        {
            remainder = 0;
            quotient = 0;
            if(number2 <= number1)
            { 
            while (number1 >= 0)
            {
                number1 = number1 - number2;
                quotient++;
            }
            remainder = number1 + number2;
            quotient--;
            }
            else
            {
                remainder = number1;
            }

        }
    }
}
