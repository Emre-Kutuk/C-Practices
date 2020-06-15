using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 200;
            int level = 3;
            int nItems = 4;

            int score_new, level_new;

            score_new = score++;
            level_new = level++;

            Console.WriteLine("Score (old): {0}, score (new): {1}", score, score_new);
            Console.WriteLine("level (old): {0}, level (new): {1}", level, level_new);

            nItems += 5;
            Console.WriteLine("number of items: {0}", nItems);

            Console.ReadKey();

        }
    }
}
