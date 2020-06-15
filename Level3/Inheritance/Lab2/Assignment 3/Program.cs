using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
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
            Player player1 = new Player("Smith");
            Player player2 = new Player("Neo");

            //creates game and plays it
            WarCardGame war = new WarCardGame(player1, player2);
            PlayTheGame(war);
            Console.ReadKey();
        }

        void PlayTheGame(WarCardGame war)
        {
            war.StartNewGame();
            
            while(!war.EndOfGame())
            {
                war.NextCard();
            }
        }
    }
}
