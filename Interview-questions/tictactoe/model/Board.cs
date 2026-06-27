using System;
using System.Collections.Generic;

namespace TicTacToe.Model
{
    public class Board
    {
        public int size;
        public PlayingPiece[,] board;

        public Board(int size)
        {
            this.size = size;
            board = new PlayingPiece[size, size];
        }

        public bool AddPiece(int row, int column, PlayingPiece playingPiece)
        {
            if (board[row, column] != null)
            {
                return false;
            }
            board[row, column] = playingPiece;
            return true;
        }

        public List<Tuple<int, int>> GetFreeCells()
        {
            List<Tuple<int, int>> freeCells = new List<Tuple<int, int>>();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (board[i, j] == null)
                    {
                        Tuple<int, int> rowColumn = Tuple.Create(i, j);
                        freeCells.Add(rowColumn);
                    }
                }
            }

            return freeCells;
        }

        public void PrintBoard()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (board[i, j] != null)
                    {
                        Console.Write(board[i, j].pieceType.ToString() + "   ");
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
    }
}
