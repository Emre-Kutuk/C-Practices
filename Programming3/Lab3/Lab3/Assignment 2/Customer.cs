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
        private DateTime dateofbirth;

        public Customer(string name, DateTime dateofbirth)
        {
            this.Name = name;
            this.DateOfBirth = dateofbirth;
        }

        public string Name {
            get { return name; }
            
            set {
                if (value != "")
                    name = value;
                else
                    name = "invalid_name";
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
            get { return DateTime.Now; }
            private set {}
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
    }
}
