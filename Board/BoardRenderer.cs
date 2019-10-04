using System;
using System.Text;

namespace GameOfLife
{
    public class BoardRenderer
    {
        //board width*height
        public static bool[,] board;
        // speed at which to update board in ms
        public static int delay = 250;
        // defined width and height for board size
        public static int Width = 60;
        public static int Height = 30;
        // presume the board size is infinite for cell movement
        public static bool loopEdges = true;
        // singleton instance of string builder instanciation
        StringBuilder builder = Singleton.Builder;

        public void DrawBoard()
        {
            builder.Clear();
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    var cell = board[x, y]
                                ? ConsoleManager.FilledBlock
                                : ConsoleManager.EmptyBlock;

                    builder.Append(cell).Append(cell);
                }
                // end of cell, go to next line
                builder.Append(Environment.NewLine);
            }
            string builderString = builder.ToString();
            // stop scroll/flicker
            Console.SetCursorPosition(0, 0);
            Console.Write(builderString);
        }
    }
}
