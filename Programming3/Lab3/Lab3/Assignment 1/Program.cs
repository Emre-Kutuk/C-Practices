using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
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
            BookStore Broese = new BookStore();

            Broese.Add(new Book("Dracula", "Bram Stoker", 15.00, 5));
            Broese.Add(new Book("Joe SpeedBoot", "Tommy Wieringa", 12.50, 5));
            Broese.Add(new Magazine("Time", "Friday", 3.90, 10));
            Broese.Add(new Magazine("Donald Duck", "Thursday", 2.50, 8));
            Broese.Add(new Book ("The Hobbit", "J.R.R Tolkien", 12.50, 4));

            Broese.PrintEveryBook();
            Console.WriteLine();
            Broese.PrintCompleteStock();
            Console.ReadKey();
        }
    }
}
