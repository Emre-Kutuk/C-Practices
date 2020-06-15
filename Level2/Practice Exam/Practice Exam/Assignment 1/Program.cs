using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
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
            Console.WriteLine("Please enter a sentence : ");
            string sentence = Console.ReadLine();
            Console.WriteLine(ShuffleWords(sentence));
            Console.ReadKey();
        }

        string ShuffleWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            sentence = null;
            for (int i = 0; i < words.Length; i++)
            {
                sentence += ShuffleWord(words[i]) + " ";
            }
            return sentence;
        }

        string ShuffleWord(string word)
        {
            if (word.Length > 3)
            {
                Random rnd = new Random();
                string newWord = word[0].ToString();
                string remainingWord = word.Substring(1, (word.Length - 2));
                
                while(remainingWord != "")
                {
                    int index = rnd.Next(0, remainingWord.Length);
                    newWord += remainingWord[index];
                    remainingWord = remainingWord.Remove(index, 1);
                }

                word = newWord + remainingWord + word[word.Length - 1];

            }

            return word;
        }
    }
}
