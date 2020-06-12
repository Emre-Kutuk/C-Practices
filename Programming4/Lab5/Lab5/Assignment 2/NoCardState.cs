using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class NoCardState : IATMState
    {
        private ATMMachine machine;

        public NoCardState(ATMMachine machine)
        {
            this.machine = machine;
        }
        public void EnterPincode(int pin)
        {
            Console.WriteLine("You need to insert a card first.\n");
        }

        public void InsertCard()
        {
            Console.WriteLine("Please enter your pincode.\n");
            machine.SetMachineState(machine.GetCardPresentState());
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected.\n");
        }

        public void WithdrawCash(int amount)
        {
            Console.WriteLine("You need to enter your pin first to withdraw cash.\n");
        }
    }
}
