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
            Player player1 = new Player("Emre");
            Player player2 = new Player("Ege");

            //create game and play it

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
                System.Threading.Thread.Sleep(400);
            }
        }
    }
}
