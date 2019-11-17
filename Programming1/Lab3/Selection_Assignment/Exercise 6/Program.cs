using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            Console.Write("Enter Score : ");
            result = int.Parse(Console.ReadLine());

            if(result<=100 && result>=90)
            { 
                    Console.WriteLine("grade : A");
                    Console.WriteLine("Course Passed!");
            }
            if(result<=89 && result>=80)
            {
                Console.WriteLine("grade : B");
                Console.WriteLine("Course Passed!");
            }
            if (result <= 79 && result >= 70)
            {
                Console.WriteLine("grade : C");
                Console.WriteLine("Course Passed!");
            }
            if (result <= 69 && result >= 60)
            {
                Console.WriteLine("grade : D");
                Console.WriteLine("Course NOT Passed!");
            }
            if (result <= 59)
            {
                Console.WriteLine("grade : F");
                Console.WriteLine("Course NOT Passed!");
            }
            Console.ReadKey();
        }
    }
}
