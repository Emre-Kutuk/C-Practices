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
            const double MAXCREDIT = 60;
            string studentName;
            double exemptionEC;
            double studentEC;
            double neededEC;

            Console.Write("Enter your name : ");
            studentName = Console.ReadLine();

            Console.Write("Enter your number of exemption ECs : ");
            exemptionEC = double.Parse(Console.ReadLine());

            Console.Write("Enter your total number of ECs (of the first year) : ");
            studentEC = double.Parse(Console.ReadLine());

            neededEC = ((MAXCREDIT - exemptionEC) * 0.75) + exemptionEC;
            Console.Write("(Minimum required ECs to go to the 2nd year : " + neededEC + ")");

            if (neededEC <= studentEC)
                Console.Write("\n\n" + studentName + ", you have enough ECs to go to the 2nd year.");
            else
                Console.Write("\n\n" + studentName + ", you DON'T have enough ECs to go to the 2nd year.");

            Console.ReadKey();
        }


    }
}
