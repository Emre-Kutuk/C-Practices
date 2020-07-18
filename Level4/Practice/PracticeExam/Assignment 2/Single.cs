using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Single : IVinylSingle
    {
        public string Artist { get; set; }
        public int Ranking {get; set; }
        public string Title { get; set; }

        public Single(int ranking, string title, string artist)
        {
            this.Ranking = ranking;
            this.Title = title;
            this.Artist = artist;
        }

        public void Pause()
        {
            Console.WriteLine($"pausing single {ToString()}");
        }

        public void Play()
        {
            Console.WriteLine($"playing single {ToString()}");
        }

        public void Stop()
        {
            Console.WriteLine($"stopping single {ToString()}");
        }

        public override string ToString()
        {
            return ($"'{this.Title}, {this.Artist} ({this.Ranking})'");
        }
    }
}
