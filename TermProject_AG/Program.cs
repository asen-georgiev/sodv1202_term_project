using System;

namespace TermProject_AG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connect Four - Term Project");

            GameController game = new GameController();
            game.StartGame();
        }
    }
}