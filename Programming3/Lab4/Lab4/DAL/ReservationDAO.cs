using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class ReservationDAO
    {
        SqlConnection con;
        public ReservationDAO()
        {
            string constr = ConfigurationManager.ConnectionStrings["Assignment_1.Properties.Settings.DB"].ConnectionString;
            con = new SqlConnection(constr);
        }

        public List<Reservation> GetAll()
        {
            List<Reservation> reservations = new List<Reservation>();
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Reservations] INNER JOIN [Books] ON [Reservations].BookId = [Books].Id INNER JOIN [Customers] ON [Reservations].CustomerId = [Customers].Id", con);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                Reservation temp = ReadReservation(reader);
                reservations.Add(temp);
            }

            reader.Close();
            con.Close();

            return reservations;
        }

        Reservation ReadReservation(SqlDataReader reader)
        {
            //reservation table
            int id = (int)reader["Id"];
            int customerid = (int)reader["CustomerId"];
            int bookid = (int)reader["BookId"];

            //books table
            string title = (string)reader["Title"];
            string author = (string)reader["Author"];

            //customers table
            string firstname = (string)reader["FirstName"];
            string lastname = (string)reader["LastName"];
            string emailaddress = (string)reader["EmailAddress"];

            Book book = new Book(bookid, title, author);
            Customer customer = new Customer(customerid, firstname, lastname, emailaddress);
            
            Reservation reservation = new Reservation(id, customer, book);

            return reservation;
        }

        public List<Customer> getAllForBook(Book book)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT *,[Books].[Title],[Customers].[FirstName],[Customers].[LastName] FROM [Reservations] INNER JOIN [Books] ON [Reservations].BookId = [Books].Id INNER JOIN [Customers] ON [Reservations].CustomerId = [Customers].Id WHERE [Reservations].BookId = @BookId ", con);
            cmd.Parameters.AddWithValue("@BookId", book.Id);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Reservation> RequestedList = new List<Reservation>();

            while (reader.Read())
            {

                Reservation temp = ReadReservation(reader);
                RequestedList.Add(temp);
            }

            List<Customer> RequestedListCustomer = new List<Customer>();

            foreach (Reservation R in RequestedList)
            {
                RequestedListCustomer.Add(R.Customer);
            }

            reader.Close();
            con.Close();

            return RequestedListCustomer;

        }

        public List<Book> getAllForCustomer(Customer customer)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT *,[Books].[Title],[Customers].[FirstName],[Customers].[LastName] FROM [Reservations] INNER JOIN [Books] ON [Reservations].BookId = [Books].Id INNER JOIN [Customers] ON [Reservations].CustomerId = [Customers].Id WHERE [Reservations].CustomerId = @CustomerId", con);
            cmd.Parameters.AddWithValue("@CustomerId", customer.Id);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Reservation> RequestedList = new List<Reservation>();

            while (reader.Read())
            {
                Reservation temp = ReadReservation(reader);
                RequestedList.Add(temp);
            }

            List<Book> RequestedListBook = new List<Book>();

            foreach (Reservation R in RequestedList)
            {
                RequestedListBook.Add(R.Book);
            }

            reader.Close();
            con.Close();

            return RequestedListBook;
        }
    }
}
