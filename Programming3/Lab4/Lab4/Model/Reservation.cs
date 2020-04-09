using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reservation
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public Customer Customer { get; set; }
        public DateTime ReservationDateTime { get; set; }

        public override string ToString()
        {
            return Id + " " + Id + " " + Book + " has reserved by " + Customer + " on " + ReservationDateTime; 
        }

        public Reservation(int id, Customer customer, Book book)
        {
            this.Id = id;
            this.Customer = customer;
            this.Book = book;
        }


    }
}
