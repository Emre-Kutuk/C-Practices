using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class DeckOfCards
    {
        public List<PlayingCard> allPlayingCards = new List<PlayingCard>();
        private const int CARDCOUNT = 13;

        public DeckOfCards()
        {
            InitCards();
        }

        private void InitCards()
        {
            foreach(int i in Enum.GetValues(typeof(CardSuit)))
            {
                for(int j = 1; j <= CARDCOUNT; j++)
                {
                    PlayingCard card = new PlayingCard(j, (CardSuit)i);
                    allPlayingCards.Add(card);
                }
            }
        }

        public void Print()
        {
            foreach(PlayingCard card in allPlayingCards)
            {
                Console.WriteLine(card.ToString());
            }
        }

        public void Shuffle()
        {
            //Fisher Yates Shuffle Method
            Random rnd = new Random();

            for (int n = allPlayingCards.Count - 1; n > 0; --n)
            {
                int k = rnd.Next(n + 1);
                PlayingCard temp = allPlayingCards[n];
                allPlayingCards[n] = allPlayingCards[k];
                allPlayingCards[k] = temp;
            }

        }
    }
}
