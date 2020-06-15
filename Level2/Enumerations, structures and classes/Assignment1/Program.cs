using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }
        void Start()
        {
            PrintMonths();
            PrintMonth(ReadMonth("\nEnter a month number : "));
            Console.ReadKey();
        }

        void PrintMonth(Month month)
        {

            Console.WriteLine("{0} - {1}", string.Format("{0,2}", (int)month), month);

        }
        void PrintMonths()
        {
            for(Month month = Month.January; month <= Month.December;month++)
            {
                PrintMonth(month);
            }
        }

        Month ReadMonth(string question)
        {
            Console.WriteLine(question);
            int value = int.Parse(Console.ReadLine());
            Month month = (Month)value;

            while (!Enum.IsDefined(typeof(Month), month))
            {
                Console.WriteLine("{0} is not a valid value.\n {1}", month, question);
                value = int.Parse(Console.ReadLine());
                month = (Month)value;
            }
            return month;
        }
    }
}
