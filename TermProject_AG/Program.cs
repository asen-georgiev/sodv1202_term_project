using System;

namespace TermProject_AG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== CONNECT FOUR =====");
            Console.WriteLine("Drop your disc into a column.");
            Console.WriteLine("First player to connect four wins.");
            Console.WriteLine();

            GameController game = new GameController();
            game.StartGame();
        }
    }
}