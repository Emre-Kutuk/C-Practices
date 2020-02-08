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
            YahtzeeGame yahtzeeGame = new YahtzeeGame();
            PlayYahtzee(yahtzeeGame);
        }

        void PlayYahtzee(YahtzeeGame game)
        {
            int nrOfAttempts = 0;

            do
            {
                game.Throw();
                game.DisplayValues();

                nrOfAttempts++;
            }
            while (!game.Yahtzee());

            Console.WriteLine("Number of attempts needed(Yahtzee): {0}", nrOfAttempts);
            Console.ReadKey();
        }
    }
}
