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
            return random.Next(0, 7);
        }
    }
}
