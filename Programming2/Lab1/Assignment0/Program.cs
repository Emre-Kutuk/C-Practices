using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment0
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
            int value = ReadInt("Enter a value");
            Console.WriteLine("You entered {0}.", value);
            int age = ReadInt("How old are you?", 0, 120);
            Console.WriteLine("You are {0} years old.", age);
            string name = ReadString("What is your name?");
            Console.WriteLine("Nice meeting you {0}.", name);
            Console.ReadKey();
        }

        int ReadInt(string question)
        {
            Console.WriteLine(question);
            int value = int.Parse(Console.ReadLine());
            return value;

        }
        int ReadInt(string question, int min, int max)
        {
            Console.WriteLine(question);
            int value = int.Parse(Console.ReadLine());
            while (value > max || value < min)
            {
                Console.WriteLine(question);
                value = int.Parse(Console.ReadLine());
            }
            return value;

        }
        string ReadString(string question)
        {
            Console.WriteLine(question);
            string value = Console.ReadLine();
            return value;

        }
    }
}
