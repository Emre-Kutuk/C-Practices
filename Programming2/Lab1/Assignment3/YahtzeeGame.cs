using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class YahtzeeGame
    {
        Dice[] dices = new Dice[5];

        public void Init()
        {
            for (int i = 0; i < dices.Length; i++)
                dices[i] = new Dice();
        }
    
        public void Throw()
        {
            for (int i = 0; i < dices.Length; i++)
                dices[i].Throw();
        }

        public void DisplayValues()
        {
            for (int i = 0; i < dices.Length; i++)
                dices[i].DisplayValue();

            Console.WriteLine();
        }
        public bool Yahtzee()
        {
            bool yahtzee = false;

            for (int i = 0; i < dices.Length; i++)
            {
                if (dices[i].value == dices[0].value)
                    yahtzee = true;
                else
                {
                    yahtzee = false;
                    break;
                }
            }
            return yahtzee;

        }

    }

}


