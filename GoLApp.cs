using System;
using System.Threading;

namespace GameOfLife
{
    public class GoLApp
    {
        public void Run()
        {
            var boardCustomizer = new BoardCustomizer();
            boardCustomizer.Customize();

            var setup = new ConsoleManager();
            var board = new BoardRenderer();
            var boardUpdate = new BoardUpdater();

            setup.PrepareConsole();

            while (!Console.KeyAvailable || Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                board.DrawBoard();
                boardUpdate.UpdateBoard();

                Thread.Sleep(BoardRenderer.delay);
            }
        }
    }
}
