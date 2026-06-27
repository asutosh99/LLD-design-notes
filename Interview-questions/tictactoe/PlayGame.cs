using System;
using TicTacToe.Model;

namespace TicTacToe
{
    public class PlayGame
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n===>>> TicTacToe Game\n");
            TicTacToeGame game = new TicTacToeGame();
            game.InitializeGame();
            GameStatus status = game.StartGame();
            Console.Write("\n===>>> GAME OVER: ");
            switch (status)
            {
                case GameStatus.WIN:
                    Console.Write(game.winner.name + " won the game");
                    break;
                case GameStatus.DRAW:
                    Console.Write(" Its a Draw!");
                    break;
                default:
                    Console.Write(" Game Ends");
                    break;
            }
        }
    }
}
