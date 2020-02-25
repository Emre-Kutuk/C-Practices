using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class DeckOfCards
    {
        public List<PlayingCard> allPlayingCards = new List<PlayingCard>();
        const int CARDCOUNT = 13;

        public DeckOfCards()
        {
            InitCards();
        }

        void InitCards()
        {
            for(int i = 0; i < Enum.GetNames(typeof(CardSuit)).Length; i++)
            {
                for(int j = 1; j <= CARDCOUNT; j++)
                {
                    PlayingCard card = new PlayingCard();
                    card.suit = (CardSuit)i;
                    card.rank = j;
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
            // Fisher Yates Shuffle
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
