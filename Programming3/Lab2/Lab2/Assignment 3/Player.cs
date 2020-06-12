using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Player
    {
        public string name;
        public List<PlayingCard> cards = new List<PlayingCard>();

        public void AddCard(PlayingCard card)
        {
            cards.Add(card);
        }

        public PlayingCard GetNextCard()
        {
            PlayingCard temp = cards[0];
            cards.Remove(cards[0]);
            return temp;
        }

        public Player(string name)
        {
            this.name = name;
        }
    }
}
