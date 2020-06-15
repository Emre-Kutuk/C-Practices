using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MyTools;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();


        }
        void Start()
        {
            LingoGame Lingo = new LingoGame();
            string filename = "words.txt";
            List<string> lingoWords = Reader(filename);
            SecretwordInit(ref lingoWords, ref Lingo);
            
            if (PlayLingo(Lingo) == true)
            {
                Console.WriteLine("\nSecret word was {0}", Lingo.lingoWord);
                Console.WriteLine("\n\nYou won! Congratz!");
                Console.ResetColor();
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nSecret word was {0}", Lingo.lingoWord);
                Console.WriteLine("\n\nBetter luck next time!!");
                Console.ResetColor();
            }
            Console.ReadKey();

        }
        bool PlayLingo(LingoGame lingo)
        {
            bool isRoundWin = false;
            int nrOfAttempts = 5;
            string playerWord = "";
            while (nrOfAttempts > 0 && lingo.isGuessed(lingo, playerWord) == false)
            {

                playerWord = UserInput(lingo);
                ColorDefiner(lingo, playerWord);
                if (lingo.isGuessed(lingo, playerWord) == true)
                {
                    isRoundWin = true;

                }
                else
                {
                    nrOfAttempts--;
                    Console.WriteLine("You have {0} attempts left", nrOfAttempts);
                }


            }
            return isRoundWin;


        }
        string UserInput(LingoGame lingo)
        {
            string userword = "";

            do
            {
                userword = MyTools.ReadTools.ReadString("Please enter a (5 letter)word :  ");

            } while (lingo.lingoWord.Length != userword.Length);
            return userword;
        }
        void ColorDefiner(LingoGame lingo, string userWord)
        {
            lingo.InitLingo(lingo.lingoWord);
            LetterState[] allletters = new LetterState[userWord.Length];
            List<char> list = new List<char>();
            for (int i = 0; i < userWord.Length; i++)
            {
                if (lingo.lingoWord[i] != userWord[i])
                {
                    list.Add(lingo.lingoWord[i]);
                }
            }
            for (int i = 0; i < userWord.Length; i++)
            {
                if (lingo.lingoWord[i] == userWord[i])
                {
                    allletters[i] = LetterState.Correct;
                }
                else if (list.Contains(userWord[i]))
                {
                    allletters[i] = LetterState.WrongPosition;
                    list.Remove(userWord[i]);
                }
                else
                {
                    allletters[i] = LetterState.Incorrect;
                }

            }
            ColorPrinter(allletters, userWord);
            Console.WriteLine();
        }
        void ColorPrinter(LetterState[] letter, string userWord)
        {
            for (int i = 0; i < userWord.Length; i++)
            {
                if (letter[i] == LetterState.Correct)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                }
                else if (letter[i] == LetterState.WrongPosition)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write("{0}", char.ToUpper(userWord[i]));
                Console.ResetColor();
            }

        }

        List<string> Reader(string filepath)
        {
            StreamReader reader = new StreamReader(filepath);
            List<string> lingoWords = new List<string>();
            while (!reader.EndOfStream)
            {
                lingoWords.Add(reader.ReadLine());
            }
            reader.Close();
            return lingoWords;


        }
        void SecretwordInit(ref List<string> words, ref LingoGame Lingo)
        {
            Random rnd = new Random();
            Lingo.lingoWord = words[rnd.Next(0, words.Count)];
        }

    }
}
