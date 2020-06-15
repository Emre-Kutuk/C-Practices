using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int inputInt;
            int hour;
            int minute;
            int second;
            string hourStr;
            string minuteStr;
            string secondStr;

            Console.Write("Enter the Number of Seconds : ");
            input = Console.ReadLine();

            inputInt = int.Parse(input);

            hour = inputInt / 3600;
            minute = (inputInt - (hour*3600)) / 60 ;
            second = inputInt - ((hour*3600) + (minute*60));

            hourStr = hour.ToString("00");
            minuteStr = minute.ToString("00");
            secondStr = second.ToString("00");


            Console.WriteLine(hourStr+ ":" + minuteStr + ":" + secondStr);

            Console.ReadKey();
            
        }
    }
}
