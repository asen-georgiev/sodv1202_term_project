using System;

namespace TermProject_AG
{
    internal abstract class Player
    {
        public char Symbol { get; protected set; }

        public Player(char symbol)
        {
            Symbol = symbol;
        }

        public abstract int GetMove();
    }
}
