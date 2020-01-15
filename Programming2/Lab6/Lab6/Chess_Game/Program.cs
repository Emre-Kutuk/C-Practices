using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
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
            ChessPiece[,] chessboard = new ChessPiece[8, 8];
            InitChessBoard(chessboard);
            DisplayChessBoard(chessboard);
            PlayChess(chessboard);

            Console.ReadKey();
        }

        void InitChessBoard(ChessPiece[,] chessboard)
        {
            for(int row = 0; row < chessboard.GetLength(0); row++)
            {
                for(int col = 0; col < chessboard.GetLength(1); col++)
                {
                    chessboard[row, col] = null;
                }
            }

            PutChessPieces(chessboard);
        }
        void DisplayChessBoard(ChessPiece[,] chessboard)
        {
            Console.WriteLine("   A  B  C  D  E  F  G  H  ");

            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                Console.Write(row + 1+ " ");
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    if((row + col) % 2 == 0)
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    else
                        Console.BackgroundColor = ConsoleColor.Gray;

                    DisplayChessPiece(chessboard[row, col]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        void PutChessPieces(ChessPiece[,] chessboard)
        {
            ChessPieceType[] order = { ChessPieceType.Rook, ChessPieceType.Knight, ChessPieceType.Bishop, ChessPieceType.King, ChessPieceType.Queen, ChessPieceType.Bishop, ChessPieceType.Knight, ChessPieceType.Rook};
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    ChessPiece chesspiece = new ChessPiece();

                    if (row == 0 || row ==7)
                    {
                        if(row ==0)
                        chesspiece.color = ChessPieceColor.White;
                        else
                            chesspiece.color = ChessPieceColor.Black;

                        chesspiece.type = order[col];
                        chessboard[row, col] = chesspiece;
                    }
                    else if(row == 1 || row == 6)
                    {
                        if (row == 1)
                            chesspiece.color = ChessPieceColor.White;
                        else
                            chesspiece.color = ChessPieceColor.Black;

                        chesspiece.type = ChessPieceType.Pawn;
                        chessboard[row, col] = chesspiece;
                    }
                }
            }
        }

        void DisplayChessPiece(ChessPiece chesspiece)
        {
            if(chesspiece == null)
            {
                Console.Write("   ");
            }
            else
            {
                if (chesspiece.color == ChessPieceColor.Black)
                    Console.ForegroundColor = ConsoleColor.Black;
                else
                    Console.ForegroundColor = ConsoleColor.White;

                ChessPieceType type = chesspiece.type;

                switch(type)
                {
                    case ChessPieceType.Rook:
                        Console.Write(" r ");
                        break;

                    case ChessPieceType.Queen:
                        Console.Write(" Q ");
                        break;

                    case ChessPieceType.Pawn:
                        Console.Write(" p ");
                        break;

                    case ChessPieceType.Knight:
                        Console.Write(" k ");
                        break;

                    case ChessPieceType.King:
                        Console.Write(" K ");
                        break;

                    case ChessPieceType.Bishop:
                        Console.Write(" b ");
                        break;
                }
            }   
        }

        Position ReadPosition(string question)
        {
            Position pos = new Position();
            Console.Write(question);
            string userPos = Console.ReadLine().ToUpper();

            int col = userPos[0] - 'A';
            int row = int.Parse(userPos[1].ToString()) - 1;

            pos.col = col;
            pos.row = row;

            return pos;
        }

        void PlayChess(ChessPiece[,] chessboard)
        {
            while(true)
            {
                try
                {
                    Position fromPos = ReadPosition("Enter the from position : ");
                    Position toPos = ReadPosition("Enter the to position : ");
                    CheckMove(chessboard, fromPos, toPos);
                }
                catch(Exception e)
                {
                    Console.WriteLine("The position you entered was wrong. ; {0}", e.Message);
                }              
                
                finally
                {
                    Console.WriteLine();
                    DisplayChessBoard(chessboard);
                }
            }
        }
        
        void DoMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            chessboard[to.row, to.col] = chessboard[from.row, from.col];
            chessboard[from.row, from.col] = null;
        }

        void CheckMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            if (chessboard[from.row, from.col] == null)
                Console.WriteLine("There is no piece on the from position");
            else if (chessboard[to.row, to.col] != null)
                Console.WriteLine("You can't make this move, to position is occupied by another piece.");
            else if (!ValidMove(chessboard[from.row, from.col], from, to))
                Console.WriteLine("Your piece can't make this move.");
            else
                DoMove(chessboard, from, to);
        }

        bool ValidMove(ChessPiece chesspiece, Position from, Position to)
        {
            int hor = Math.Abs(from.row - to.row);
            int ver = Math.Abs(from.col - to.col);

            do
            {
                switch (chesspiece.type)
                {
                    case ChessPieceType.Rook:
                        if (hor * ver == 0)
                            return true;
                        else
                            return false;
                    case ChessPieceType.Knight:
                        if (hor * ver == 2)
                            return true;
                        else
                            return false;
                    case ChessPieceType.Bishop:
                        if (hor == ver)
                            return true;
                        else
                            return false;
                    case ChessPieceType.King:
                        if(hor == 1 || ver == 1)
                            return true;
                        else
                            return false;
                    case ChessPieceType.Queen:
                        if (hor * ver == 0 || hor == ver)
                            return true;
                        else
                            return false;
                    case ChessPieceType.Pawn:
                        if (ver == 0 && hor == 1)
                            return true;
                        else
                            return false;
                }
            }
            while (hor != 0 && ver != 0);

            return false;


        }
    }
}
