using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyCrushLogic
{
    public class CandyCrusher
    {
        public static bool ScoreRowPresent(RegularCandies[,] candies)
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

        public static bool ScoreColomnPresent(RegularCandies[,] candies)
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
    }
}
