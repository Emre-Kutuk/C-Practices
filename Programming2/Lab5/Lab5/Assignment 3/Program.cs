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
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }

        void Start()
        {
            string filename = "dictionary.csv";
            TranslateWords(ReadWords(filename));

            Console.ReadKey();
        }

        Dictionary<string, string> ReadWords (string filename)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            StreamReader reader = new StreamReader(filename);

            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] words = line.Split(';');
                string dutch = words[0];
                string english = words[1];
                dictionary.Add(dutch, english);
            }
            return dictionary;
        }

        void TranslateWords(Dictionary<string, string> words)
        {
            Console.Write("Enter a word : ");
            string userInput = Console.ReadLine();

            while(userInput != "stop" && userInput != "list all")
            {
                if (words.ContainsKey(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(userInput + " => " + words[userInput]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("word '{0}' not found", userInput);
                }
                Console.Write("Enter a word : ");
                userInput = Console.ReadLine();
            }

            if (userInput == "list all")
                ListAllWords(words);


            Console.WriteLine();
            Console.WriteLine("End of the program.");
        }

        void ListAllWords(Dictionary<string, string> words)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (KeyValuePair<string, string> line in words)            
                Console.WriteLine("{0} => {1}", line.Key, line.Value);

            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
