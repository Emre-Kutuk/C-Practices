using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
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
            int[,] testarray = new int[15, 15];
            InitMatrix2D(testarray);
            //InitMatrixLinear(testarray);
            //DisplayMatrix(testarray);
            DisplayMatrixWithCross(testarray);
            Console.ReadKey();
        }

        void InitMatrix2D(int[,] matrix)
        {
            int value = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int colomn = 0; colomn < matrix.GetLength(1); colomn++)
                {
                    matrix[row, colomn] = value;
                    value++;
                    
                }
            }
        }

        void DisplayMatrix(int [,] matrix)
        {
            for(int row=0; row < matrix.GetLength(0); row++)
            {
                for(int colomn = 0; colomn < matrix.GetLength(1); colomn++)
                {
                    Console.Write("{0,4}", matrix[row, colomn]);
                }


                Console.WriteLine();
            }
        }

        void InitMatrixLinear(int[,] matrix)
        {
            int value = 1;
            int row = 0;
            int colomn = 0;

            for(int i = 0; i< matrix.Length ; i++)
            {
                matrix[row, colomn] = value;
                colomn++;
                value++;
                if (colomn == matrix.GetLength(1))
                {
                    colomn = 0;
                    row++;
                }
            }
        }

        void DisplayMatrixWithCross(int [,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int colomn = 0; colomn < matrix.GetLength(1); colomn++)
                {
                    int yellowPlace = (matrix.GetLength(1) - row) - 1;

                        if(colomn == yellowPlace)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                        if(row == colomn)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    
                    Console.Write("{0,4}", matrix[row, colomn]);
                    Console.ResetColor();
                }


                Console.WriteLine();
            }
        }
    }
}
