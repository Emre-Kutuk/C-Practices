using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Album : IVinylAlbum
    {
        private string Band { get;  set; }
        private string Title { get; set; }
        private int Year { get; set; }

        public Album(string title, string band, int year)
        {
            this.Band = band;
            this.Title = title;
            this.Year = year;
        }


        public void Pause()
        {
            Console.WriteLine($"pausing album {ToString()}");
        }

        public void Play()
        {
            Console.WriteLine($"playing album {ToString()}");
        }

        public void Stop()
        {
            Console.WriteLine($"stopping album {ToString()}");
        }
        public override string ToString()
        {
            return ($"'{this.Title}, {this.Band} ({this.Year})'");
        }
    }
}
