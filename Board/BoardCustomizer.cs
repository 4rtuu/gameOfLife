using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    class BoardCustomizer
    {
        public void Customize()
        {
            Console.WriteLine("Choose game and press enter:");
            Console.WriteLine("Write \"c\" for a customizable randomized board;");
            Console.WriteLine("Write \"b\" for a single BLINKER board example;");
            Console.WriteLine("Write \"t\" for a single TOAD board example;");
            Console.WriteLine("Write \"g\" for a single GLIDER board example;");
            Console.WriteLine("Write \"d\" for a single PENTA-DECATHLON board example;");
            string response = Console.ReadLine();
            ResponseCheck(response);
        }

        public void ResponseCheck(string response)
        {
            switch (response)
            {
                case ConsoleManager.CustomRandBoard:
                    CustomRandomizedBoard();
                    break;
                case ConsoleManager.ToadBoard:
                    ToadBoard();
                    break;
                case ConsoleManager.BlinkerBoard:
                    BlinkerBoard();
                    break;
                case ConsoleManager.GliderBoard:
                    GliderBoard();
                    break;
                case ConsoleManager.PentaDecathlon:
                    PentaDecathlon();
                    break;

                default:
                    break;
            }
        }

        public void ToadBoard()
        {
            var layout = new Layout();
            layout.CustomBoardLayout_Toad();
        }

        public void BlinkerBoard()
        {
            var layout = new Layout();
            layout.CustomBoardLayout_Blinker();
        }

        public void GliderBoard()
        {
            var layout = new Layout();
            layout.CustomBoardLayout_Glider();
        }

        public void PentaDecathlon()
        {
            var layout = new Layout();
            layout.CustomBoardLayout_PentaDecathlon();
        }

        public void CustomRandomizedBoard()
        {
            Console.WriteLine("Set defaults by leaving values empty;");
            Console.WriteLine($"{BoardRenderer.delay} for delay, {BoardRenderer.Width} for width, {BoardRenderer.Height} for height;");

            CustomizeDelay();
            CustomizeWidth();
            CustomizeHeight();

            var randCellPosition = new RandomCellLayout();
            randCellPosition.RandBoardLayout();
        }

        // todo check for invalid values
        private void CustomizeDelay()
        {
            Console.WriteLine("Provide the speed of Game in milliseconds (eg. 1000 = 1 seconds):");
            string sleep = Console.ReadLine();

            if (String.IsNullOrEmpty(sleep))
            {
                Console.WriteLine("Speed set to default.");
            }
            else
            {
                if (Int32.TryParse(sleep, out BoardRenderer.delay))
                {
                    Console.WriteLine("Speed set to {0}", BoardRenderer.delay);
                }
                else
                {
                    Console.WriteLine("Viss slikti...");
                    Console.ReadKey();
                    Environment.Exit(-1);
                }
            }
        }

        private void CustomizeWidth()
        {
            Console.WriteLine("Provide the width of the board:");
            string horz = Console.ReadLine();

            if (String.IsNullOrEmpty(horz))
            {
                Console.WriteLine("Width set to default.");
            }
            else
            {
                if (Int32.TryParse(horz, out BoardRenderer.Width))
                {
                    Console.WriteLine("Width set to {0}", BoardRenderer.Width);
                }
                else
                {
                    Console.WriteLine("Viss slikti...");
                    Console.ReadKey();
                    Environment.Exit(-1);
                }
            }
        }

        private void CustomizeHeight()
        {
            Console.WriteLine("Provide the height of the board:");
            string vert = Console.ReadLine();

            if (String.IsNullOrEmpty(vert))
            {
                Console.WriteLine("Height set to default.");
            }
            else
            {
                if (Int32.TryParse(vert, out BoardRenderer.Height))
                {
                    Console.WriteLine($"Height set to {BoardRenderer.Height}");
                }
                else
                {
                    Console.WriteLine("Viss slikti...");
                    Console.ReadKey();
                    Environment.Exit(-1);
                }
            }
        }
    }
}
