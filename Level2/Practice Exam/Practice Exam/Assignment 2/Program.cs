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
            int[,] matrix = new int[5, 10];
            FillMatrix(matrix);
            DisplayMatrix(matrix);
            Console.WriteLine("Enter a search number : ");
            int searchnumber = int.Parse(Console.ReadLine());
            ShiftMatrix(matrix, searchnumber);
            DisplayMatrix(matrix);
            Console.ReadKey();
        }

        void FillMatrix(int[,] matrix)
        {
            Random rnd = new Random();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rnd.Next(1, 100);
                }
            }
        }

        void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col].ToString("00") + " ");
                }
                Console.WriteLine();
            }
        }

        void ShiftMatrix(int[,] matrix, int number)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(matrix[row,col] == number)
                    {
                        ShiftRow(matrix, row, col);
                        break;                    
                    }
                }
            }
        }

        void ShiftRow(int[,] matrix, int row, int col)
        {
            int[] temp = new int [matrix.GetLength(1)];

            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                temp[column] = matrix[row, col];
                col = (col + 1) % matrix.GetLength(1);

            }

            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = temp[column];
            }
        }
    }
}
