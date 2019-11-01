using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static string[] words = new string[20];
        static int arrayLength = 0;
        static void Main(string[] args)
        {
            string userInput = "";
            

            for(int i = 0; i < words.Length; i++)
            {
                

                Console.Write("Enter a word : ");
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    endProgram();
                    break;
                }
                else
                {
                    words[i] = userInput;
                    arrayLength++;
                }

            }
            if(userInput != "")
            {
                endProgram();
            }

        }
        static void endProgram()
        {
            for (int i = 0; i < arrayLength ;i++)
            {


                if (words[i].Length % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    
                }

                Console.WriteLine(words[i]);
                Console.ResetColor();

            }

            Console.WriteLine("\nend of the program");
            Console.ReadKey();
        }
    }
}
