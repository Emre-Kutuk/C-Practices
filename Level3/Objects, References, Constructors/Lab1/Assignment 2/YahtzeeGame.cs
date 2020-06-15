using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class YahtzeeGame
    {
        private Dice[] dices = new Dice[5];
        private Random rnd = new Random();

        public YahtzeeGame()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i] = new Dice(rnd);
            }
        }

        public void Throw()
        {
            for (int i = 0; i < dices.Length; i++)
                dices[i] = new Dice(rnd);
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
