using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class FancyMP3Display : IObserver
    {
        private IObservable MP3Player;

        public FancyMP3Display(IObservable MP3Player)
        {
            this.MP3Player = MP3Player;
            MP3Player.AddObserver(this);
        }

        public void Update(Song song)
        {
            Console.WriteLine("Fancy Display: '{0}' - {1} ({2}:{3})", song.name, song.artist,song.minute.ToString("00"), song.second.ToString("00"));
        }
    }
}
