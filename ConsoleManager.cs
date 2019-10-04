using System;

namespace GameOfLife
{
    public class ConsoleManager
    {
        // cell color based on its state
        const ConsoleColor initialCell = ConsoleColor.Gray;
        const ConsoleColor deadCell = ConsoleColor.White;
        const ConsoleColor aliveCell = ConsoleColor.Black;

        // unicode values of both empty and filled blocks
        // public vars == starts with capital
        public const char EmptyBlock = '\u0020';
        public const char FilledBlock = '\u2588';

        // game layout constants
        public const string CustomRandBoard = "c";
        public const string ToadBoard = "t";
        public const string BlinkerBoard = "b";
        public const string GliderBoard = "g";
        public const string PentaDecathlon = "d";

        // TODO: NEED A NEW CLASS FOR CONSOLE
        // IMPLEMENT AN INTERFACE OF CONSOLE
        public void PrepareConsole()
        {
            Console.BackgroundColor = initialCell;
            Console.Clear();

            // remove cursor
            Console.CursorVisible = false;

            int Width = BoardRenderer.Width * 2 + 2;
            int Height = BoardRenderer.Height + 1;

            Console.SetWindowSize(Width, Height);
            Console.SetBufferSize(Width, Height);

            Console.BackgroundColor = deadCell;
            Console.ForegroundColor = aliveCell;
        }
    }
}