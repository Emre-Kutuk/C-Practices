using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Song
    {
        public string artist;
        public string name;
        public int minute;
        public int second;

        public Song(string artist, string name)
        {
            this.artist = artist;
            this.name = name;
        }

        public Song(string artist, string name, int minute, int second) : this(artist, name) 
        {
            this.minute = minute;
            this.second = second;
        }
    }
}
