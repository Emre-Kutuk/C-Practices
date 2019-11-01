using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string userAnswerstr;
            int userAnswerint;
            int correctAnswer;

            int number1 = rnd.Next(101, 10000);
            int number2 = rnd.Next(101, 10000);
            int number3 = rnd.Next(101, 10000);
            int number4 = rnd.Next(101, 10000);

            Console.WriteLine("What is the answer of the problem? {0} + {1} + {2} + {3} = ?", number1, number2, number3, number4);
            userAnswerstr = Console.ReadLine();
            userAnswerint = int.Parse(userAnswerstr);
            correctAnswer = number1 + number2 + number3 + number4;

            bool isCorrect;
            isCorrect = (userAnswerint == correctAnswer);
            Console.WriteLine("Your answer is " + isCorrect + ". The correct answer is " + correctAnswer + ".");


            Console.ReadKey();
        }
    }
}
