using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class WarCardGame : CardGame
    {
        public Player player1;
        public Player player2;

        public WarCardGame(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void StartNewGame()
        {
            this.deck.Shuffle();
            
            for(int i = 0; i < this.deck.allPlayingCards.Count ; i += 2)
            {
                player1.cards.Add(this.deck.allPlayingCards[i]);
                player2.cards.Add(this.deck.allPlayingCards[i+1]);
            }
        }

        public bool EndOfGame()
        {
            if (player1.cards.Count == 0 || player2.cards.Count == 0)
            {
                string winner;

                if (player1.cards.Count > 0)
                    winner = player1.name;
                else
                    winner = player2.name;

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("The winner is {0} !!!", winner.ToUpper());
                return true;
            }
            else
                return false;
        }

        public void NextCard()
        {
            Console.WriteLine("{0} {1} - {2} {3}", player1.name, player1.cards[0].ToString(), player2.name, player2.cards[0].ToString());

            if(player1.cards[0].rank > player2.cards[0].rank)
            {
                player1.AddCard(player2.cards[0]);
                player1.AddCard(player1.cards[0]);
                player1.GetNextCard();
                player2.GetNextCard();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} got the cards.", player1.name);
                Console.ResetColor();
            }
            else if (player1.cards[0].rank < player2.cards[0].rank)
            {
                player2.AddCard(player1.cards[0]);
                player2.AddCard(player2.cards[0]);
                player1.GetNextCard();
                player2.GetNextCard();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} got the cards.", player2.name);
                Console.ResetColor();
            }
            else if (player1.cards[0].rank == player2.cards[0].rank)
            {
                player1.GetNextCard();
                player2.GetNextCard();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2 cards lost.\nCards left : [{0}] {1}x, [{2}] {3}x", player1.name, player1.cards.Count, player2.name, player2.cards.Count);
                Console.ResetColor();
            }

            

        }
    }
}
