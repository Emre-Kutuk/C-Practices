using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string age;
            int ageint;
            Console.WriteLine("What is your age :");
            age = Console.ReadLine();


            ageint = int.Parse(age);

            bool tooOld;
            tooOld = (ageint >= 65);
            Console.WriteLine("You are old ? {0}", tooOld);

           
            Console.ReadKey();

        }
    }
}
