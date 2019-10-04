namespace GameOfLife
{
    public class BoardUpdater
    {
        public void UpdateBoard()
        {
            bool[,] newDraw = new bool[BoardRenderer.Width, BoardRenderer.Height];

            for (int y = 0; y < BoardRenderer.Height; y++)
            {
                for (int x = 0; x < BoardRenderer.Width; x++)
                {
                    var living = CountTheLiving(x, y);

                    if (BoardRenderer.board[x, y]
                        && living == 2
                        || living == 3
                        || !BoardRenderer.board[x, y]
                        && living == 3)
                    {
                        newDraw[x, y] = true;
                    }
                }
            }
            BoardRenderer.board = newDraw;
        }

        private int CountTheLiving(int x, int y)
        {
            int value = 0;

            for (int h = -1; h <= 1; h++)
            {
                if (!BoardRenderer.loopEdges && (y + h) < 0
                    || (y + h) >= BoardRenderer.Height)
                {
                    continue;
                }
                int newY = (y + h + BoardRenderer.Height) % BoardRenderer.Height;

                for (int w = -1; w <= 1; w++)
                {
                    if (!BoardRenderer.loopEdges && (x + w) < 0
                        || (x + w) >= BoardRenderer.Width)
                    {
                        continue;
                    }
                    int newX = (x + w + BoardRenderer.Width) % BoardRenderer.Width;
                    value += BoardRenderer.board[newX, newY] ? 1 : 0;
                }
            }
            return value - (BoardRenderer.board[x, y] ? 1 : 0);
        }
    }
}
