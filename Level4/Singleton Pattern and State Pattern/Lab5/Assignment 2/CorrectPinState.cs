using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class CorrectPinState : IATMState
    {
        private ATMMachine machine;

        public CorrectPinState(ATMMachine machine)
        {
            this.machine = machine;
        }
        public void EnterPincode(int pin)
        {
            Console.WriteLine("Your pin has already been approved.\n");
        }

        public void InsertCard()
        {
            Console.WriteLine("There's already a card inside the machine\n");
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected.\n");
            machine.SetMachineState(machine.GetNoCardState());
        }

        public void WithdrawCash(int amount)
        {
            if (amount <= machine.AmountInMachine)
            {
                Console.WriteLine("{0} withdrawn from machine.", amount);
                machine.SetAmountInMachine(machine.AmountInMachine - amount);

            }
            else
            {
                Console.WriteLine("Not enough cash available in machine.");
            }

            RejectCard();

            if (machine.AmountInMachine == 0)
                machine.SetMachineState(machine.GetNoCashState());
        }
    }
}
