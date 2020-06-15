using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment3
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
            DisplaySongs(ReadSongs("top2000-2019.csv"));
            DisplayDuplicateTitles(DuplicateTitles(ReadSongs("top2000-2019.csv")));
            
            Console.ReadKey();


        }

        List<Song> ReadSongs(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            
            List<Song> songs = new List<Song>();

            while(!reader.EndOfStream)
            {
                Song tempsong = new Song();

                string line = reader.ReadLine();

                string[] song = line.Split(';');
                tempsong.Ranking = int.Parse(song[0]);
                tempsong.Title = song[1];
                tempsong.Artist = song[2];
                tempsong.Year = int.Parse(song[3]);

                songs.Add(tempsong);
            }

            return songs;
        }

        void DisplaySongs(List<Song> songs)
        {
            for(int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine("{0}. {1} - {2}", songs[i].Ranking, songs[i].Artist, songs[i].Title);
            }
        }

        List<string> DoubleArtists(List<Song> songs)
        {
            List<string> DoubleArtists = new List<string>();
            Song previousSong = new Song();
            previousSong = songs[0];

            for(int i = 1; i < songs.Count; i++)
            {
                if (songs[i].Artist == previousSong.Artist && !DoubleArtists.Contains(songs[i].Artist))
                    DoubleArtists.Add(songs[i].Artist);

                previousSong = songs[i];
            }

            return DoubleArtists;
        }

        Dictionary<string, List<Song>> DuplicateTitles(List<Song> songs)
        {
            Dictionary<string, List<Song>> DuplicateTitles = new Dictionary<string, List<Song>>();

            for (int i = 0; i < songs.Count; i++)
            {
                if (!DuplicateTitles.ContainsKey(songs[i].Title))
                {
                    List<Song> temp = new List<Song>();
                    temp.Add(songs[i]);
                    DuplicateTitles.Add(songs[i].Title, temp);
                }
                else
                {
                    //...
                }
            }
            return DuplicateTitles;
        }

        void DisplayDuplicateTitles(Dictionary<string, List<Song>> titleSongs)
        {
            //....
        }
    }
}
