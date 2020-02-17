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
            Book book1 = new Book("Dracula", "Bram Stoker", 15.00);
            Book book2 = new Book("Joe Speedbot", "Tommy Wieringa", 12.50);
            Magazine magazine1 = new Magazine("Time", "Friday", 3.90);
            Magazine magazine2 = new Magazine("Donald Duck", "Thursday", 2.50);
            Book book3 = new Book("The Hobbit", "J.R.R. Tolkien", 12.50);

            Broese.Add(book1);
            Broese.Add(book2);
            Broese.Add(magazine1);
            Broese.Add(magazine2);
            Broese.Add(book3);

            Broese.PrintEveryBook();
            Console.WriteLine();
            Broese.PrintCompleteStock();
            Console.ReadKey();
        }
    }
}
