using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    class RandomCellLayout
    {
        public void RandBoardLayout()
        {
            Random rand = new Random();

            BoardRenderer.board = new bool[BoardRenderer.Width, BoardRenderer.Height];

            for (int y = 0; y < BoardRenderer.Height; y++)
            {
                for (int x = 0; x < BoardRenderer.Width; x++)
                {
                    if (rand.Next(2) == 0)
                    {
                        BoardRenderer.board[x, y] = true;
                    }
                }
            }
        }
    }
}
