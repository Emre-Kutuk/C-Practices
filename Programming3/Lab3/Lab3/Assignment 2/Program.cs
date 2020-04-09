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
            Customer test = new Customer("Emre", new DateTime(1992, 4, 7));
            PrintCustomer(test);


            Console.ReadKey();
        }
        public void PrintCustomer(Customer c)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(c.Name);
            Console.ResetColor();
            Console.WriteLine("Date of Birth : " + c.DateOfBirth.ToString("dd/MM/yyyy") +
                              "\nAge : " + c.Age +
                              "\nDate of Registration : " + c.DateOfRegistration.ToString("dd/MM/yyyy") +
                              "\nDiscount : " + c.Discount
                              ) ;
        }
    }
}
