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
            Console.ReadKey();
        }

        void Start()
        {
            BookStore store = new BookStore();
            Book book1 = new Book("Dracula", 15.00f, 5, "Bram Stoker");
            Book book2 = new Book("Joe Speedboot", 12.50f, 3, "Tommy Wieringa");
            Magazine magazine = new Magazine("Time", 3.90f, 10, DayOfWeek.Friday);
            Magazine magazine2 = new Magazine("Donald Duck", 2.50f, 15, DayOfWeek.Thursday);
            CD cd = new CD("Seventeen Seconds", 3.90f, 5, "The Cure");
            store.Add(book1);
            store.Add(book2);
            store.Add(magazine);
            store.Add(magazine2);
            store.Add(cd);
            store.PrintAllItems();
        }
    }
}
