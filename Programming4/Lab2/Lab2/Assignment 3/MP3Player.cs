using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class MP3Player : IObservable
    {
        private List<Song> songs = new List<Song>();
        Random rnd = new Random();

        public MP3Player()
        { 
            songs.Add(new Song("Pink Floyd", "Wish You Were Here", 3, 40));
            songs.Add(new Song("Led Zeppelin", "Dazed and Confused", 3, 12));
            songs.Add(new Song("Bruno Mars", "Billionaire", 4, 0));

        }

        public Song CurrentSong { get; private set; }
        private List<IObserver> MP3Displays = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            MP3Displays.Add(observer);
        }

        public void NextSong()
        {

            CurrentSong = songs[rnd.Next(songs.Count)];
            NotifyObservers();
        }

        public void RemoveObserver(IObserver observer)
        {
            MP3Displays.Remove(observer);
        }

        void NotifyObservers()
        {
            foreach (IObserver o in MP3Displays)
                o.Update(CurrentSong);
        }
    }
}
