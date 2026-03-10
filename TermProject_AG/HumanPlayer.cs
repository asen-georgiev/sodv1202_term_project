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
            Console.Write("Enter column (1-7): ");
            int column = int.Parse(Console.ReadLine());
            return column - 1;
        }
    }
}
