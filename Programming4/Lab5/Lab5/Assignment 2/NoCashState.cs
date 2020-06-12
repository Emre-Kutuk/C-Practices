using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class NoCashState : IATMState
    {
        private ATMMachine machine;

        public NoCashState(ATMMachine machine)
        {
            this.machine = machine;
        }
        public void EnterPincode(int pin)
        {
            Console.WriteLine("Not enough cash available in machine.\n");
        }

        public void InsertCard()
        {
            Console.WriteLine("Not enough cash available in machine.\n");
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected.\n");
            machine.SetMachineState(machine.GetNoCardState());
        }

        public void WithdrawCash(int amount)
        {
            Console.WriteLine("Not enough cash available in machine.\n");
        }
    }
}
