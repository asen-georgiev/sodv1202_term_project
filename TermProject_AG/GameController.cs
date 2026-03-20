using System;

namespace TermProject_AG
{
    internal class GameController
    {
        private Board board;
        private Player player1;
        private Player player2;

        public GameController()
        {
            board = new Board();
            player1 = new HumanPlayer('X');
            player2 = new HumanPlayer('O');
        }

        public void StartGame()
        {
            while (true)
            {
                board = new Board();

                Player currentPlayer = player1;

                while (true)
                {
                    board.DisplayBoard();

                    Console.WriteLine($"Player {currentPlayer.Symbol}'s turn");

                    int column = currentPlayer.GetMove();

                    if (column < 0 || column >= 7)
                    {
                        Console.WriteLine("Invalid column. Try again.");
                        continue;
                    }

                    if (board.IsColumnFull(column))
                    {
                        Console.WriteLine("Column is full. Try another.");
                        continue;
                    }

                    board.DropDisc(column, currentPlayer.Symbol);

                    if (board.CheckWin(currentPlayer.Symbol))
                    {
                        board.DisplayBoard();
                        Console.WriteLine($"Player {currentPlayer.Symbol} wins!");
                        break;
                    }

                    if (board.IsFull())
                    {
                        board.DisplayBoard();
                        Console.WriteLine("It's a draw!");
                        break;
                    }

                    currentPlayer = currentPlayer == player1 ? player2 : player1;
                }

                Console.Write("Play again? (y/n): ");
                string input = Console.ReadLine().ToLower();

                if (input != "y")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
            }
        }
    }
}
