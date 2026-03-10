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
            Console.WriteLine("Game started!");
            board.DisplayBoard();
        }
    }
}
