using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_3
{
    class Program
    {
        List<string> tweets = new List<string>();
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }

        void Start()
        {
            Console.Write("Enter a word (to search) : ");
            string word = Console.ReadLine();
            word = word.ToLower();
            SearchWordInFile("tweets_donald.txt", word);

            Console.ReadKey();
        }

        bool WordInLine(string line, string word)
        {
            
            if (Contains(line,word))
            {
                tweets.Add(line);
                return true;
            }
            return false;
        }
       
        void SearchWordInFile(string filename, string word)
        {
            int line = -1;
                    
            StreamReader reader = new StreamReader(filename);
            while(!reader.EndOfStream)
            {
                if(WordInLine(reader.ReadLine(),word))
                {
                    line++;
                }
                
            }

            for (int i = 0; i < line; i++)
            {
                Console.WriteLine();
                DisplayWordInLine(tweets[i], word);
            }
            if (line < 0)
                line = 0;

            Console.WriteLine();
            Console.Write("\nThere are {0} tweets found consisting the word ", line);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(word);
            Console.ResetColor();

        }

        void DisplayWordInLine(string line, string word)
        {
            int firstStringPosition = line.IndexOf(word, StringComparison.OrdinalIgnoreCase);
            string temp = "";
            
            Console.WriteLine();
            temp = line.Substring(0, firstStringPosition);
            Console.Write(temp);
            Console.ForegroundColor = ConsoleColor.Red;
            temp = line.Substring(firstStringPosition, word.Length);
            Console.Write(temp);
            Console.ResetColor();
            temp = line.Substring(firstStringPosition + word.Length);
            Console.Write(temp);
        }

        bool Contains(string line, string word)
        {
            line = line.ToLower();
            word = word.ToLower();

            if (line.Contains(word))
                return true;
            else
                return false;
        }
    }
}
