using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    abstract class Payment
    {
        public void Execute()
        {
            EnterInfo();
            ProcessPayment();
            ConfirmPayment();
        }

        void EnterInfo()
        {
            Console.WriteLine("entering information...");
        }

        void ConfirmPayment()
        {
            Console.WriteLine("sending confirmation mail...");
        }

        public abstract void ProcessPayment();
    }
}
