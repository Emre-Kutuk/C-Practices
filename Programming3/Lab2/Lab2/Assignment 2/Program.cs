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
            DeckOfCards deck = new DeckOfCards();
            deck.Print();

            Console.WriteLine();
            Console.WriteLine();

            deck.Shuffle();
            deck.Print();

            Console.ReadKey();
        }
    }
}
