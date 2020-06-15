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
            Random rnd = new Random();
            int[] numbers = new int[21];
            int element;
            int smallest = 151;
            int smallestTime = 0;

            for (int i = 1; i <= 20; i++)
            {
                element = rnd.Next(0, 151);
                numbers[i] = element;
                Console.WriteLine("Element " + i + " is " + numbers[i]);

                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
                  
            }
            for(int j=1; j<=20; j++)
            {
                if(smallest == numbers[j])
                {
                    smallestTime++;
                }
            }


            Console.WriteLine("\n" +"The smallest number is " + smallest.ToString());
            Console.WriteLine("The number of occurence is " + smallestTime.ToString());
            Console.ReadKey();
        }
    }
}
