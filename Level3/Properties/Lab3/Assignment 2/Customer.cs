using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Customer
    {
        private string name;
        private DateTime dateofregistration;
        private DateTime dateofbirth;

        //Normally I didnt give date of registration as a parameter but instead I used DateTime.Now but in order to have the same results 
        //as given assignment I had to enter it manually
        public Customer(string name, DateTime dateofbirth, DateTime dateofregistration)
        {
            this.Name = name;
            this.DateOfBirth = dateofbirth;
            this.DateOfRegistration = dateofregistration;

            //I specifically added this method here rather than calling it from Program because I think of this as a notification
            PrintCustomer();
        }

        public string Name {
            get { return name; }
            
            set 
            {
                if (!String.IsNullOrEmpty(value))
                    name = value;
                else
                    throw new ArgumentException("Error occured : Customer name can't be empty!", "name");

            }
        }
        public DateTime DateOfBirth
        {
            get { return dateofbirth; }
            set { if (DateTime.Compare(value, DateTime.Now) < 0 && DateTime.Compare(value, new DateTime(1930, 1, 1, 0, 0, 0)) > 0)
                    dateofbirth = value;
                        }
        }


        public DateTime DateOfRegistration
        {
            //This is how it is normally
            /*
            get { return dateofregistration ;}
            
            private set {dateofregistration = DateTime.Now; }
            */

            get { return dateofregistration; }
            set { dateofregistration = value; }
        }

        public int Age
        {
            get { return DateTime.Now.Year - DateOfBirth.Year; }
            private set {}
        }

        public bool Discount
        {
            get {if (DateTime.Now.Year - this.DateOfRegistration.Year < 2)
                    return false;
                else
                    return true;
            }
            private set { }
        }

        private void PrintCustomer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this.Name);
            Console.ResetColor();
            Console.WriteLine("Date of Birth : " + this.DateOfBirth.ToString("dd/MM/yyyy") +
                             "\nAge : " + this.Age +
                             "\nDate of Registration : " + this.DateOfRegistration.ToString("dd/MM/yyyy") +
                             "\nDiscount : " + this.Discount
                             );
            Console.WriteLine();

        }
    }
}
