using System;

namespace TermProject_AG
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(char symbol) : base(symbol)
        {
        }

        public override int GetMove()
        {
            while (true)
            {
                Console.Write("Enter column (1-7): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int column))
                {
                    return column - 1;
                }

                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
