using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class CreditCardPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("processing CreditCard payment...");
        }
    }
}
