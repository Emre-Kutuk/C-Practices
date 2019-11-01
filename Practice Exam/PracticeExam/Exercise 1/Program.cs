using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;


            Console.Write("Enter a word : ");
            userInput = Console.ReadLine();

            if(checkIfTrue(userInput) == false)
            {
                Console.WriteLine(userInput + " is NOT a palindrome.");
            }
            else
            {
                Console.WriteLine(userInput + " is a palindrome.");
            }
            Console.ReadKey();


        }
        static bool checkIfTrue(string userInput)
        {
            bool isTrue;
            string first = userInput.Substring(0, userInput.Length / 2);
            char[] arr = userInput.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            if (first == second)
                isTrue = true;
            else
                isTrue = false;
            return isTrue;
        }
    }
}
