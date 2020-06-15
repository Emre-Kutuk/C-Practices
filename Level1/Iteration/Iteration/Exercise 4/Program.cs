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
            int nr1 = 1;
            int nr2 = 1;
            int nr3;
            int i;

            Console.WriteLine(nr1.ToString());
            Console.WriteLine(nr2.ToString());

            for(i = 2; i <20;)
            {
                i++;
                nr3 = nr1 + nr2;
                Console.WriteLine(nr3);
                nr1 = nr2;
                nr2 = nr3;
                
                
          
            }

            Console.ReadKey();

        }
    }
}
