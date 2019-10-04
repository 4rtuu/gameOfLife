namespace GameOfLife
{
    public class Layout
    {
        // blinker
        public void CustomBoardLayout_Blinker()
        {
            BoardRenderer.Width = 7;
            BoardRenderer.Height = 7;

            BoardRenderer.board = new bool[BoardRenderer.Width, BoardRenderer.Height];
            BoardRenderer.board[3, 2] = true;
            BoardRenderer.board[3, 3] = true;
            BoardRenderer.board[3, 4] = true;
        }
        // toad
        public void CustomBoardLayout_Toad()
        {
            BoardRenderer.Width = 8;
            BoardRenderer.Height = 8;

            BoardRenderer.board = new bool[BoardRenderer.Width, BoardRenderer.Height];
            BoardRenderer.board[3, 3] = true;
            BoardRenderer.board[4, 3] = true;
            BoardRenderer.board[5, 3] = true;
            BoardRenderer.board[2, 4] = true;
            BoardRenderer.board[3, 4] = true;
            BoardRenderer.board[4, 4] = true;
        }
        // Glider
        public void CustomBoardLayout_Glider()
        {
            BoardRenderer.Width = 32;

            BoardRenderer.loopEdges = false;

            BoardRenderer.board = new bool[BoardRenderer.Width, BoardRenderer.Height];
            BoardRenderer.board[3, 3] = true;
            BoardRenderer.board[4, 4] = true;
            BoardRenderer.board[5, 2] = true;
            BoardRenderer.board[5, 3] = true;
            BoardRenderer.board[5, 4] = true;
        }
        // Penta-decathlon
        public void CustomBoardLayout_PentaDecathlon()
        {
            BoardRenderer.Width = 13;
            BoardRenderer.Height = 24;

            BoardRenderer.board = new bool[BoardRenderer.Width, BoardRenderer.Height];

            BoardRenderer.board[5, 5] = true;
            BoardRenderer.board[6, 5] = true;
            BoardRenderer.board[7, 5] = true;

            BoardRenderer.board[6, 6] = true;
            BoardRenderer.board[6, 7] = true;

            BoardRenderer.board[5, 8] = true;
            BoardRenderer.board[6, 8] = true;
            BoardRenderer.board[7, 8] = true;

            BoardRenderer.board[5, 10] = true;
            BoardRenderer.board[6, 10] = true;
            BoardRenderer.board[7, 10] = true;

            BoardRenderer.board[5, 11] = true;
            BoardRenderer.board[6, 11] = true;
            BoardRenderer.board[7, 11] = true;

            BoardRenderer.board[5, 13] = true;
            BoardRenderer.board[6, 13] = true;
            BoardRenderer.board[7, 13] = true;

            BoardRenderer.board[6, 14] = true;
            BoardRenderer.board[6, 15] = true;

            BoardRenderer.board[5, 16] = true;
            BoardRenderer.board[6, 16] = true;
            BoardRenderer.board[7, 16] = true;
        }
    }
}
