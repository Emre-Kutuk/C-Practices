using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAYSIZE = 20;
            const int MINRNDVALUE = 1;
            const int MAXRNDVALUE = 99;
            Random random = new Random();
            int minValue;
            int maxValue;
            int[] randomarr = new int[ARRAYSIZE];


            Console.Write("Minimum Value : ");
            minValue = int.Parse(Console.ReadLine());

            Console.Write("Maximum Value : ");
            maxValue = int.Parse(Console.ReadLine());

            for (int i = 0; i < ARRAYSIZE; i++)
               randomarr[i] = random.Next(MINRNDVALUE, MAXRNDVALUE);

            for (int i = 0; i < randomarr.Length; i++)
            {
                if (randomarr[i] < (maxValue - 20) && randomarr[i] > (minValue+20) )
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (randomarr[i] < (maxValue - 10) && randomarr[i] > (minValue + 10))
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.Red;

                Console.Write(randomarr[i].ToString() + " ");
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
