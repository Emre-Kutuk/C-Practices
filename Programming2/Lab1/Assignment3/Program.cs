using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
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
            yahtzeeGame.Init();
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
