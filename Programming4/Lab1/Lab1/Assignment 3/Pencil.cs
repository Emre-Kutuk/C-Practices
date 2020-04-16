using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Pencil : IPencil
    {
        private Char[] charArray;
        private const int MAXTOWRITE = 20;
        private int nrOfCharsWritten;
        public bool CanWrite { get { if (nrOfCharsWritten >= MAXTOWRITE ) return false; else return true; } }

        public void AfterSharpening()
        {
            this.nrOfCharsWritten = 0;
        }

        public void Write(string message)
        {
            if(message == "sharpen")
            {
                PencilSharpener sharpener = new PencilSharpener();
                sharpener.Sharpen(this);
            }
            else
            { 
                charArray = message.ToCharArray();
                Console.ForegroundColor = ConsoleColor.Green;
                foreach(char c in charArray)
                {
                    if (CanWrite)
                    { 
                        Console.Write(c);
                        nrOfCharsWritten++;
                    }
                    else
                        Console.Write("#");
                }
                Console.ResetColor();
            }
        }
    }
}
