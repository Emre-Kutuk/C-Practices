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
            IStack myStack = new ArrayStack(25);
            AddValues(myStack);
            Console.WriteLine();
            ProcessValues(myStack);
            Console.WriteLine();
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

        bool CheckValues(int nr, IStack stack)
        {
            if (stack.Contains(nr))
                return true;
            else
                return false;
        }
    }
}
