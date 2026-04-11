using System;

namespace TermProject_AG
{
    internal class ComputerPlayer : Player
    {
        private Random random = new Random();

        public ComputerPlayer(char symbol) : base(symbol)
        {
        }

        public override int GetMove()
        {
            int column;

            do
            {
                column = random.Next(0, 7);
            }
            while (false);

            Console.WriteLine($"Computer chooses column {column + 1}");

            return column;
        }
    }
}
