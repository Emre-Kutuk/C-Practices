using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }

        void Start()
        {
            Pencil pencil = new Pencil();
            Console.Write("Enter a word : ");
            string userInput = Console.ReadLine();

            while(userInput != "stop")
            { 
                pencil.Write(userInput);
                Console.Write("\nEnter a word : ");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("\nend of program");
            Console.ReadKey();
        }
    }
}
