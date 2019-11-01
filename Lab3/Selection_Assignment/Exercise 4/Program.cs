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
            int number1;
            int number2;
            int number3;
            int sum;
            int avg;
            int product;
            
            

            Console.Write("Enter the First Number ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Third Number ");
            number3 = int.Parse(Console.ReadLine());
            sum = number1 + number2 + number3;
            avg = sum / 3;
            product = number1 * number2 * number3 ;

            int[] numbers = { number1, number2, number3 };

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + avg);
            Console.WriteLine("Product = " + product);
            Console.WriteLine("The Highest = " + (numbers.Max()));
            Console.WriteLine("The Lowest = " + (numbers.Min()));

            Console.ReadKey();
        }
    }
}
