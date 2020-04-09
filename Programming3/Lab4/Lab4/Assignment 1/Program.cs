using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace UI
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
            BookDAO bookdao = new BookDAO();
            Book book = bookdao.GetForId(3);

            CustomerDAO customerdao = new CustomerDAO();
            Customer customer = customerdao.GetForId(2);

            ReservationDAO reservationdao = new ReservationDAO();
            
            List<Reservation> reservations = reservationdao.GetAll();

            List<Customer> customers = reservationdao.getAllForBook(book);
            List<Book> books = reservationdao.getAllForCustomer(customer);

            foreach (Reservation r in reservations)
                Console.WriteLine(r.ToString());
            
            foreach (Book b in books)
                Console.WriteLine(b.ToString());
            
            foreach (Customer c in customers)
                Console.WriteLine(c.ToString());
                
            Console.ReadKey();
        }
    }
}
