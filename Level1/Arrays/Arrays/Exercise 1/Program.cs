using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[21];
            double randomNr;
            double totalNumber = 0;
            double avg = 0;
            double difference = 0;
            Random rnd = new Random();

            for(int i = 1; i <= 20; i++)
            {
                randomNr = rnd.Next(0, 201);
                numbers[i] = randomNr;
                totalNumber += randomNr;
                Console.WriteLine("Element " + i + " is " + randomNr);

                if (i == 20)
                {
                    avg = totalNumber / i;
                    Console.WriteLine("\n" + "The average is " + avg.ToString("0.00") + "\n");
                }
            }
            for(int j = 1;j <= 20; j++)
            {
                difference = Math.Abs(avg - numbers[j]);
                Console.WriteLine("Difference between average and the element " + j + " is " + difference.ToString("0.00"));
            }

            Console.ReadKey();
            



        }
    }
}
