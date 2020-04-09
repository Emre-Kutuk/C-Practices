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
    public class CustomerDAO
    {
        SqlConnection con;

        public CustomerDAO()
        {
            string constr = ConfigurationManager.ConnectionStrings["Assignment_1.Properties.Settings.DB"].ConnectionString;
            con = new SqlConnection(constr);
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Customers]", con);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                Customer temp = ReadCustomer(reader);
                customers.Add(temp);
            }

            reader.Close();
            con.Close();
            return customers;
        }

        Customer ReadCustomer(SqlDataReader reader)
        {
            int id = (int)reader["Id"];
            string emailaddress = (string)reader["EmailAddress"];
            string firstname = (string)reader["FirstName"];
            string lastname = (string)reader["LastName"];
            Customer customer = new Customer(id,firstname,lastname,emailaddress);
            return customer;
        }

        public Customer GetForId(int customerId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Customers] WHERE Id = @customerId", con);
            cmd.Parameters.AddWithValue("@customerId", customerId);
            SqlDataReader reader = cmd.ExecuteReader();
            
            Customer temp = null;

            while (reader.Read())
            { 
                temp = ReadCustomer(reader);
            }
            
            return temp;
        }
    }
}
