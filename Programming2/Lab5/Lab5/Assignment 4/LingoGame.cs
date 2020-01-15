using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class LingoGame
    {
        public string lingoWord;
        public string playerWord;
        public LetterState[] letters = { LetterState.Correct, LetterState.WrongPosition, LetterState.Incorrect };

        public void InitLingo(string something)
        {
            this.lingoWord = something;
        }
        public bool isGuessed(LingoGame game, string playerword)
        {
            bool isguessed;
            if (game.lingoWord == playerword)
            {
                isguessed = true;
            }
            else
            {
                isguessed = false;
            }
            return isguessed;
        }
    }
}
