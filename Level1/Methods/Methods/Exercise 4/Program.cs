using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int fullStops, commas, semiColons;

            Console.Write("Enter a text > ");
            userInput = Console.ReadLine();
            searchText(userInput, out fullStops, out commas,out semiColons);

            Console.WriteLine("Result : " + fullStops + " full stops, " + commas + " commas, " + semiColons + " semi colons.");
            Console.ReadKey();

        }

        static void searchText(string text,out int nrOfFullStops, out int nrOfCommas, out int nrOfSemiColons)
        {
            nrOfCommas = 0;
            nrOfFullStops = 0;
            nrOfSemiColons = 0;

            char fullStop = '.';
            char comma = ',';
            char semiColon = ';';

            char[] ch = text.ToCharArray();

            for (int i= 0; i<ch.Length; i++)
            {
                if (ch[i] == fullStop)
                    nrOfFullStops++;
                if (ch[i] == comma)
                    nrOfCommas++;
                if (ch[i] == semiColon)
                    nrOfSemiColons++;

             }




        }
    }

}

