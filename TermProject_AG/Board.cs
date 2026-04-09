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
            Console.WriteLine("1 2 3 4 5 6 7");

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.Write(grid[r, c] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public bool DropDisc(int column, char symbol)
        {
            for (int row = rows - 1; row >= 0; row--)
            {
                if (grid[row, column] == '.')
                {
                    grid[row, column] = symbol;
                    return true;
                }
            }

            return false; 
        }

        public bool IsColumnFull(int column)
        {
            return grid[0, column] != '.';
        }

        public bool CheckWin(char symbol)
        {
            
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns - 3; col++)
                {
                    if (grid[row, col] == symbol &&
                        grid[row, col + 1] == symbol &&
                        grid[row, col + 2] == symbol &&
                        grid[row, col + 3] == symbol)
                    {
                        return true;
                    }
                }
            }

         
            for (int col = 0; col < columns; col++)
            {
                for (int row = 0; row < rows - 3; row++)
                {
                    if (grid[row, col] == symbol &&
                        grid[row + 1, col] == symbol &&
                        grid[row + 2, col] == symbol &&
                        grid[row + 3, col] == symbol)
                    {
                        return true;
                    }
                }
            }

          
            for (int row = 0; row < rows - 3; row++)
            {
                for (int col = 0; col < columns - 3; col++)
                {
                    if (grid[row, col] == symbol &&
                        grid[row + 1, col + 1] == symbol &&
                        grid[row + 2, col + 2] == symbol &&
                        grid[row + 3, col + 3] == symbol)
                    {
                        return true;
                    }
                }
            }

            for (int row = 3; row < rows; row++)
            {
                for (int col = 0; col < columns - 3; col++)
                {
                    if (grid[row, col] == symbol &&
                        grid[row - 1, col + 1] == symbol &&
                        grid[row - 2, col + 2] == symbol &&
                        grid[row - 3, col + 3] == symbol)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool IsFull()
        {
            for (int col = 0; col < columns; col++)
            {
                if (grid[0, col] == '.')
                    return false;
            }
            return true;
        }
    }
}
