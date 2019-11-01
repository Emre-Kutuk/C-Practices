using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameIsFinished = false;
            int wordOrder = 0;
            char blank = '_';
            string chosenWord;
            char userGuess;
            int userTry = 10;
            bool didWell = false;
            string[] wordBank = new string[8] { "dictionary", "cigarette", "bear", "cat", "light", "objective", "time", "baby"};

            Random random = new Random();
            wordOrder = random.Next(0, 9);

            chosenWord = wordBank[wordOrder];
            char[] outputWord = new char[chosenWord.Length];

            for (int i = 0; i < chosenWord.Length;i++)
            { 
                outputWord[i] = blank;
            }

            while(gameIsFinished != true)
            {
                didWell = false;
                Console.WriteLine(outputWord);
                Console.Write("\n\nType a letter ("+ userTry +") : ");
                userGuess = char.Parse(Console.ReadLine());
               
                
                for(int i=0; i < chosenWord.Length; i++)
                {
                    if (chosenWord[i] == userGuess)
                    {
                        outputWord[i] = userGuess;
                        didWell = true;
                    }
                }
                if (didWell == false)
                    userTry--;

                if (!outputWord.Contains('_'))
                {
                    Console.WriteLine("\n\n" + chosenWord + "\nGood Job!!!!!!");
                    Console.ReadKey();
                }
                if (userTry == 0)
                    break;
            }
            Console.WriteLine("GET OUT!!!!!");
            Console.ReadKey();

        }
    }
}
