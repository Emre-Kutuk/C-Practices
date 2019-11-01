using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1;
            string number2;
            string number3;
            float nr1Db;
            float nr2Db;
            float nr3Db;
            string result;

            Console.WriteLine("Enter 1st Number");
            number1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd Number");
            number2 = Console.ReadLine();
            Console.WriteLine("Enter 3rd Number");
            number3 = Console.ReadLine();
            nr1Db = float.Parse(number1);
            nr2Db = float.Parse(number2);
            nr3Db = float.Parse(number3);


            result = ((nr1Db + nr2Db + nr3Db)/3).ToString();

            Console.WriteLine("The Average is " + result);
            Console.ReadKey();


        }
    }
}
