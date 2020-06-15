using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class CardPresentState : IATMState
    {
        private ATMMachine machine;

        public CardPresentState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode(int pin)
        {
            if (pin == 1234)
            {
                Console.WriteLine("You have entered the correct pincode.\n");
                machine.SetMachineState(machine.GetCorrectPinState());
            }
            else
                RejectCard();
        }

        public void InsertCard()
        {
            Console.WriteLine("You have already inserted a card.\n");
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected.\n");
            machine.SetMachineState(machine.GetNoCardState());
        }

        public void WithdrawCash(int amount)
        {
            Console.WriteLine("You need to enter pin code first to withdraw.\n");
        }
    }
}
