using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
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
            int[,] testarray = new int[8, 8];
            int min = 4;
            int max = 129;
            int searchnumber;
            InitMatrixRandom(testarray, min, max);
            DisplayMatrix(testarray);
            AskForNumber(out searchnumber);
            SearchNumber(testarray, searchnumber);
            SearchNumberBackwards(testarray, searchnumber);
            PrintNumbers(SearchNumber(testarray,searchnumber),SearchNumberBackwards(testarray, searchnumber),searchnumber);
            Console.ReadKey();
        }

        void InitMatrixRandom(int [,] matrix ,int min, int max)
        {
            Random rnd = new Random();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int colomn = 0; colomn < matrix.GetLength(1); colomn++)
                {
                    int value = rnd.Next(min, max + 1);
                    matrix[row, colomn] = value;
                }
            }
        }

        void DisplayMatrix(int[,] matrix)
        {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int colomn = 0; colomn < matrix.GetLength(1); colomn++)
                    {
                        Console.Write("{0,4}", matrix[row, colomn]);
                    }
                    Console.WriteLine();
                }
        }

        Position SearchNumber(int[,] matrix, int number)
        {
            Position position = new Position();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int colomn = 0; colomn < matrix.GetLength(1); colomn++)
                {
                    if(matrix[row,colomn] == number)
                    {        
                        position.row = row;
                        position.colomn = colomn;
                    }
                }

            }
            return position;
        }
        Position SearchNumberBackwards(int[,] matrix, int number)
        {
            Position position = new Position();

            for (int row = matrix.GetLength(0) - 1; row >= 0 ; row--)
            {
                for (int colomn = matrix.GetLength(1) - 1 ; colomn >= 0; colomn--)
                {
                    if (matrix[row, colomn] == number)
                    {
                        position.row = row;
                        position.colomn = colomn;
                    }
                }

            }
            return position;
        }
        void AskForNumber(out int number)
        {
            Console.WriteLine();
            Console.WriteLine("Enter a number (to search for) : ");
            number = int.Parse(Console.ReadLine());
        }
        void PrintNumbers(Position positionBackwards, Position position, int number)
        {
            Console.WriteLine();
            Console.WriteLine("Number {0} is found first at position [{1},{2}] ", number, position.row, position.colomn);
            Console.WriteLine("Number {0} is found last at position [{1},{2}] ", number, positionBackwards.row, positionBackwards.colomn);
        }
    }
}
