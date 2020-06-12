using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
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
            //Pushes the values
            IStack myStack = new ArrayStack(25);
            AddValues(myStack);

            //Asks for value check
            Console.WriteLine("\nEnter a value to check please");
            int userInput = int.Parse(Console.ReadLine());

            //Checks the value
            CheckValues(userInput, myStack);

            //Processes the values
            ProcessValues(myStack);

            Console.ReadKey();
        }
        void AddValues(IStack stack)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int value = rnd.Next(100);
                stack.Push(value);
                Console.WriteLine($"pushed {value}, new count: {stack.Count}");
            }
        }
        void ProcessValues(IStack stack)
        {
            while (!stack.IsEmpty)
            {
                int value = stack.Pop();
                Console.WriteLine($"popped {value}, new count: {stack.Count}");
            }
        }

        void CheckValues(int nr, IStack stack)
        {
            if (stack.Contains(nr))
                Console.WriteLine("\n{0} is in the stack!\n", nr);
            else
                Console.WriteLine("\n{0} is NOT in the stack!\n", nr);
        }
    }
}
