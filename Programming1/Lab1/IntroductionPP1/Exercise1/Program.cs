using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();

            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("Your age is {0}", age);

            Console.ReadKey();
        }
    }
}
