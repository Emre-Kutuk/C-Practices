using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class ReadTools
    {
        public static int ReadInt(string question)
        {
            Console.Write(question);
            int value = int.Parse(Console.ReadLine());
            return value;
        }

        public static int ReadInt(string question, int min, int max)
        {
            Console.Write(question);
            int value = int.Parse(Console.ReadLine());
            while (value > max || value < min)
            {
                Console.Write(question);
                value = int.Parse(Console.ReadLine());
            }
            return value;
        }

        public static string ReadString(string question)
        {
            Console.Write(question);
            string value = Console.ReadLine();
            return value;
        }


    }
}
