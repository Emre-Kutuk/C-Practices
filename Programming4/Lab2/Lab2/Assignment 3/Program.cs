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
            IObservable player = new MP3Player();

            IObserver mp3Display1 = new SimpleMP3Display(player);
            IObserver mp3Display2 = new FancyMP3Display(player);

            player.NextSong();
            player.NextSong();
            player.NextSong();

            Console.ReadKey();
        }
    }
}
