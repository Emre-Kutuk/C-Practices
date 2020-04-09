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
    public class BookDAO
    {
        SqlConnection con;
        public BookDAO()
        {
            string constr = ConfigurationManager.ConnectionStrings["Assignment_1.Properties.Settings.DB"].ConnectionString;
            con = new SqlConnection(constr);
        }

        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Books]", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Book temp = ReadBook(reader);
                books.Add(temp);
            }

            reader.Close();
            con.Close();
            return books;
        }

        Book ReadBook(SqlDataReader reader)
        {
            int id = (int)reader["Id"];
            string title = (string)reader["Title"];
            string author = (string)reader["Author"];
            Book book = new Book(id,title,author); ;
            return book;
        }

        public Book GetForId(int bookId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Books] WHERE Id = @bookId", con);
            cmd.Parameters.AddWithValue("@bookId", bookId);
            SqlDataReader reader = cmd.ExecuteReader();

            Book temp = null;

            while (reader.Read())
            {
                temp = ReadBook(reader);
            }

            return temp;
        }

    }
}
