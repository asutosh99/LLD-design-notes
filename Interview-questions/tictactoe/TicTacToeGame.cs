using System;
using System.Collections.Generic;
using TicTacToe.Model;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public LinkedList<Player> players;
        public Board gameBoard;
        public Player winner;

        public void InitializeGame()
        {
            players = new LinkedList<Player>();
            PlayingPieceX crossPiece = new PlayingPieceX();
            Player player1 = new Player("Player1", crossPiece);

            PlayingPieceO noughtsPiece = new PlayingPieceO();
            Player player2 = new Player("Player2", noughtsPiece);

            players.AddLast(player1);
            players.AddLast(player2);

            gameBoard = new Board(3);
        }

        public GameStatus StartGame()
        {
            bool noWinner = true;
            while (noWinner)
            {
                Player currentPlayer = players.First.Value;
                players.RemoveFirst();

                gameBoard.PrintBoard();
                List<Tuple<int, int>> freeSpaces = gameBoard.GetFreeCells();
                if (freeSpaces.Count == 0)
                {
                    noWinner = false;
                    continue;
                }

                Console.Write("Player: " + currentPlayer.name + " - Please enter [row, column]: ");
                string s = Console.ReadLine();
                string[] values = s.Split(',');
                int inputRow = int.Parse(values[0]);
                int inputColumn = int.Parse(values[1]);

                bool validMove = gameBoard.AddPiece(inputRow, inputColumn, currentPlayer.playingPiece);
                if (!validMove)
                {
                    Console.WriteLine("Incorrect position chosen, try again!");
                    players.AddFirst(currentPlayer);
                    continue;
                }
                players.AddLast(currentPlayer);

                bool isWinner = CheckForWinner(inputRow, inputColumn, currentPlayer.playingPiece.pieceType);
                if (isWinner)
                {
                    gameBoard.PrintBoard();
                    winner = currentPlayer;
                    return GameStatus.WIN;
                }
            }

            return GameStatus.DRAW;
        }

        public bool CheckForWinner(int row, int column, PieceType pieceType)
        {
            bool rowMatch = true;
            bool columnMatch = true;
            bool diagonalMatch = true;
            bool antiDiagonalMatch = true;

            for (int i = 0; i < gameBoard.size; i++)
            {
                if (gameBoard.board[row, i] == null || gameBoard.board[row, i].pieceType != pieceType)
                {
                    rowMatch = false;
                    break;
                }
            }

            for (int i = 0; i < gameBoard.size; i++)
            {
                if (gameBoard.board[i, column] == null || gameBoard.board[i, column].pieceType != pieceType)
                {
                    columnMatch = false;
                    break;
                }
            }

            for (int i = 0, j = 0; i < gameBoard.size; i++, j++)
            {
                if (gameBoard.board[i, j] == null || gameBoard.board[i, j].pieceType != pieceType)
                {
                    diagonalMatch = false;
                    break;
                }
            }

            for (int i = 0, j = gameBoard.size - 1; i < gameBoard.size; i++, j--)
            {
                if (gameBoard.board[i, j] == null || gameBoard.board[i, j].pieceType != pieceType)
                {
                    antiDiagonalMatch = false;
                    break;
                }
            }

            return rowMatch || columnMatch || diagonalMatch || antiDiagonalMatch;
        }
    }
}
