using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Reservation
    {
        private Customer customer;
        private List<Ticket> tickets;
        private decimal totalprice;

        public Reservation(Customer customer, List<Ticket> tickets)
        {
            Customer = customer;
            Tickets = tickets;

            //I specifically added this method here rather than calling it from Program because I think of this as a notification
            PrintReservation();
        }
        public List<Ticket> Tickets { get { return tickets; } set { tickets = value; } }
        public Customer Customer { get { return customer; } set { customer = value; } }

        public decimal TotalPrice
        {
            get {
                foreach (Ticket ticket in tickets)
                {
                    if (ticket.Discount)
                        totalprice += ticket.Price * 0.95m;
                    else
                        totalprice += ticket.Price;
                }

                if (customer.Discount)
                    return totalprice * 0.90m;
                else
                    return totalprice;
            }

            private set { }
        }

        private void PrintReservation()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("creating tickets for {0}...", Customer.Name);
            Console.ResetColor();

            foreach (Ticket ticket in Tickets)
            {
                Console.WriteLine("created ticket '{0}', starttime: {1} price: {2}, room: {3} ({4}+)", ticket.MovieName, ticket.StartTime , ticket.Price,ticket.CinemaRoom, ticket.MinimumAge);
            }
            Console.WriteLine("Total price of reservation : {0} \n", this.TotalPrice.ToString("0.00"));
        }
    }
}
