using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class ATMMachine
    {
        private IATMState machineState;
        public int AmountInMachine;

        private IATMState cardPresent;
        private IATMState correctPinCode;
        private IATMState noCard;
        private IATMState noCash;

        public ATMMachine(int amount)
        {
            AmountInMachine = amount;
            machineState = new NoCardState(this);


            cardPresent = new CardPresentState(this);
            correctPinCode = new CorrectPinState(this);
            noCard = new NoCardState(this);
            noCash = new NoCashState(this);

            if (AmountInMachine < 0)
                machineState = noCash;
        }

        public void SetMachineState(IATMState machineState)
        {
            this.machineState = machineState;
        }

        public void SetAmountInMachine(int amount)
        {
            AmountInMachine = amount;
        }

        public void EnterPincode(int pin)
        {
            machineState.EnterPincode(pin);
        }

        public void InsertCard()
        {
            machineState.InsertCard();
        }

        public void RejectCard()
        {
            machineState.RejectCard();
        }

        public void WithdrawCash(int cash)
        {
            machineState.WithdrawCash(cash);
        }

        public IATMState GetCardPresentState()
        {
            return cardPresent;
        }

        public IATMState GetCorrectPinState()
        {
            return correctPinCode;    
        }

        public IATMState GetNoCardState()
        {
            return noCard;
        }

        public IATMState GetNoCashState()
        {
            return noCash;
        }
    }
}
