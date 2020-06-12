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
            Customer customer1 = new Customer("Lionel Messi", new DateTime(1987, 6, 24), new DateTime(2019, 2,20));
            Customer customer2 = new Customer("Piet Paulusma", new DateTime(1956, 12, 15), new DateTime(2017, 2, 20));

            //For the sake of testing and displaying, only one list has been created
            List<Ticket> testTickets = new List<Ticket>();
            testTickets.Add(new Ticket("Bohemian Rapsody", 1, new DateTime(2019,02,23,21,30,0), 10.50m ,6));
            testTickets.Add(new Ticket("The Prodigy", 4, new DateTime(2019, 2, 23, 22, 0, 0), 10.50m, 16));
            testTickets.Add(new Ticket("Green Book", 5, new DateTime(2019, 2, 25, 19, 30, 0), 10.50m, 12));


            Reservation res1 = new Reservation(customer1, testTickets);
            Reservation res2 = new Reservation(customer2, testTickets);

            Console.ReadKey();
        }
        
    }
}
