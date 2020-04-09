using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get{return FirstName + LastName;} }

        public Customer(int id, string firstName, string lastName, string emailAddress)
        {
            this.Id = id;
            this.FirstName = FirstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
        }

        public override string ToString()
        {
            return Id + " " +FullName + " " + EmailAddress; 
        }
    
    }
}
