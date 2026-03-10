using System;

namespace TermProject_AG
{
    internal class Board
    {
        private char[,] grid;
        private int rows = 6;
        private int columns = 7;

        public Board()
        {
            grid = new char[rows, columns];
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    grid[r, c] = '.';
                }
            }
        }

        public void DisplayBoard()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.Write(grid[r, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
