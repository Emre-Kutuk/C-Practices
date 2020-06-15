using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class HangmanGame
    {
        public string secretWord;
        public string guessedWord;

        public void Init(string secretWord)
        {
            string guessedWord = "";
            int letters = secretWord.Length;

            for (int i = 0; i < letters; i++)
            {
                guessedWord += ".";
            }

            this.secretWord = secretWord;
            this.guessedWord = guessedWord;
        }

        public bool GuessLetter(char letter)
        {
            if (secretWord.Contains(letter))
            {
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (letter == secretWord[i])
                    {
                        guessedWord = guessedWord.Remove(i, 1);
                        guessedWord = guessedWord.Insert(i, letter.ToString());
                    }
                }
                return true;
            }
            else
                return false;
        }

        public bool isGuessed()
        {
            if (secretWord == guessedWord)
                return true;
            else
                return false;
        }
    }
}
