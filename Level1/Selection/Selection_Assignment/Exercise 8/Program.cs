using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingHours;
            int years;
            int failures;

            Console.Write("Enter Number of Working Hours : ");
            workingHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Number of Years : ");
            years = int.Parse(Console.ReadLine());
            Console.Write("Enter Number of Failures : ");
            failures = int.Parse(Console.ReadLine());

            if(workingHours > 10000 || years > 7 || failures > 25)
            {
                Console.WriteLine("Machine needs to be replaced");
            }
            else
            {
                Console.WriteLine("Machine does not need to be replaced");
            }

            Console.ReadKey();
        }
    }
}
