using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
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
            RegularCandies[,] candies = new RegularCandies[6,6];
            InitCandies(candies);
            DisplayCandies(candies);
            DisplayScore(ScoreRowPresent(candies), ScoreColomnPresent(candies));
           
            Console.ReadKey();
        }

        void InitCandies(RegularCandies[,] candies)
        {
            Random rnd = new Random();

            for(int row = 0; row < candies.GetLength(0);row++)
            {
                for(int colomn = 0; colomn < candies.GetLength(1); colomn++)
                {
                         int value = rnd.Next(1, 7);
                    RegularCandies candyvalue = (RegularCandies)value;
                    candies[row, colomn] = candyvalue;
                }
            }
        }

        void DisplayCandies(RegularCandies[,] candies)
        {
            for (int row = 0; row < candies.GetLength(0); row++)
            {
                for (int colomn = 0; colomn < candies.GetLength(1); colomn++)
                {
                    if ((int)candies[row, colomn] == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    if ((int)candies[row, colomn] == 2)
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    if ((int)candies[row, colomn] == 3)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    if ((int)candies[row, colomn] == 4)
                        Console.ForegroundColor = ConsoleColor.Green;
                    if ((int)candies[row, colomn] == 5)
                        Console.ForegroundColor = ConsoleColor.Blue;
                    if ((int)candies[row, colomn] == 6)
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                    Console.Write("# ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        bool ScoreRowPresent(RegularCandies[,] candies)
        {
            int currentcandy = 0;
            int scorecombo = 1;
            for (int row = 0; row < candies.GetLength(0); row++)
            {
                for (int colomn = 0; colomn < candies.GetLength(1); colomn++)
                {
                    if (currentcandy != 0)
                    {
                        if (currentcandy == (int)candies[row, colomn])
                            scorecombo++;
                        else
                        {
                            scorecombo = 1;
                            currentcandy = (int)candies[row, colomn];
                        }
                        if (scorecombo >= 3)
                            return true;
                    }

                    else if (currentcandy == 0)
                        currentcandy = (int)candies[row, colomn];
                }
            }
                return false;
        }

        bool ScoreColomnPresent(RegularCandies[,] candies)
        {
            int currentcandy = 0;
            int scorecombo = 1;

            for (int colomn = 0; colomn < candies.GetLength(1); colomn++)
            {
                for (int row = 0; row < candies.GetLength(0); row++)
                {
                    if (currentcandy != 0)
                    {
                        if (currentcandy == (int)candies[row, colomn])
                            scorecombo++;
                        else
                        {
                            scorecombo = 1;
                            currentcandy = (int)candies[row, colomn];
                        }

                        if (scorecombo >= 3)
                        {
                          return true;       
                        }
                    }
                    else if (currentcandy == 0)
                        currentcandy = (int)candies[row, colomn];
                }
            }
            return false;

        }
        
        void DisplayScore(bool row, bool colomn)
        {
            if (row)
                Console.WriteLine("row score!");
            else
                Console.WriteLine("no row score!");
            if (colomn)
                Console.WriteLine("colomn score!");
            else
                Console.WriteLine("no colomn score!");
        }
    }
}
