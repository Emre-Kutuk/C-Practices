using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        public const int MIN = 1;
        public const int MAX = 201;
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }

        void Start()
        {
            int[,] matrix = new int[15, 20];
            FillNatrix(matrix);
            DisplayMatrix(matrix);
            DisplayPosition("smallest", SearchSmallest(matrix));
            DisplayPosition("biggest", SearchBiggest(matrix));
            DisplayMatrixPositions(matrix, SearchBiggest(matrix), SearchSmallest(matrix));

            Console.ReadKey();
        }

        void FillNatrix(int[,] matrix)
        {
            Random rnd = new Random();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rnd.Next(MIN, MAX);
                }
            }
        }

        void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col].ToString("000") + " "); 
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        void DisplayPosition(string name, Position pos)
        {
            Console.WriteLine("{0} : {1} (row : {2} colomn : {3}", name, pos.value, pos.row, pos.colomn);
        }

        Position SearchSmallest(int[,] matrix)
        {
            int smallestValue = MAX;
            Position smallestPos = new Position();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(matrix[row,col] < smallestValue)
                    {
                        smallestValue = matrix[row, col];
                        smallestPos.value = smallestValue;
                        smallestPos.row = row;
                        smallestPos.colomn = col;
                    }
                }
            }
            return smallestPos;

        }

        Position SearchBiggest(int[,] matrix)
        {
            int biggestValue = MIN;
            Position biggestPos = new Position();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > biggestValue)
                    {
                        biggestValue= matrix[row, col];
                        biggestPos.value = biggestValue;
                        biggestPos.row = row;
                        biggestPos.colomn = col;
                    }
                }
            }
            return biggestPos;
        }

        void DisplayMatrixPositions(int[,] matrix, Position biggest, Position smallest)
        {
            Console.WriteLine();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == smallest.row || col == smallest.colomn)
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                    if (row == biggest.row || col == biggest.colomn)
                        Console.ForegroundColor = ConsoleColor.Red;
                    if (matrix[row, col] == smallest.value)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if(matrix[row,col] == biggest.value)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Write(matrix[row, col].ToString("000") + " ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}





