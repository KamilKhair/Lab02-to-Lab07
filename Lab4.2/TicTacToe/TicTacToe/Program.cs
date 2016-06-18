using System;

namespace TicTacToe
{
    internal enum Player
    {
        None,
        X,
        O
    }

    internal enum Cell
    {
        Empty,
        X,
        O
    }

    internal class TicTacToeGame
    {
        public TicTacToeGame()
        {
            _round = 0;
            Winner = Player.None;
            IsGameOver = false;
            Board = new Cell[3, 3];
            IsDraw = false;
        }

        internal bool IsGameOver { get; set; }

        private bool IsDraw { get; set; }

        private Cell[,] Board { get; }

        private Player Winner { get; set; }

        private int _round;

        public void DisplayBoard()
        {
            Console.WriteLine();
            for (var i = 0; i < 3; ++i)
            {
                for (var j = 0; j < 3; ++j)
                {
                    Console.Write($"{Board[i, j].ToString(),8}");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        private void Click(int a, int b, Player player)
        {
            if (Board[a, b] != Cell.Empty)
            {
                return;
            }

            ++_round;

            Cell c;

            if (player == Player.O)
            {
                Board[a, b] = Cell.O;
                c = Cell.O;
            }
            else
            {
                Board[a, b] = Cell.X;
                c = Cell.X;
            }

            if (a == 0 && b == 0)
            {
                if ((Board[0, 1] == c && Board[0, 2] == c) || (Board[1, 0] == c && Board[2, 0] == c) || (Board[1, 1] == c && Board[2, 2] == c))
                {
                    IsGameOver = true;
                }
            }
            else if (a == 0 && b == 1)
            {
                if ((Board[0, 0] == c && Board[0, 2] == c) || (Board[1, 1] == c && Board[2, 1] == c))
                {
                    IsGameOver = true;
                }
            }
            else if (a == 0 && b == 2)
            {
                if ((Board[0, 0] == c && Board[0, 1] == c) || (Board[1, 2] == c && Board[2, 2] == c) || (Board[1, 1] == c && Board[2, 0] == c))
                {
                    IsGameOver = true;
                }
            }
            else if (a == 1 && b == 0)
            {
                if ((Board[0, 0] == c && Board[2, 0] == c) || (Board[1, 1] == c && Board[1, 2] == c))
                {
                    IsGameOver = true;
                }
            }
            else if (a == 1 && b == 1)
            {
                if ((Board[0, 0] == c && Board[2, 2] == c) || (Board[2, 0] == c && Board[0, 2] == c) || (Board[0, 1] == c && Board[2, 1] == c) || (Board[1, 0] == c && Board[1, 2] == c))
                {
                    IsGameOver = true;
                }
            }
            else if (a == 1 && b == 2)
            {
                if ((Board[1, 0] == c && Board[1, 1] == c) || (Board[0, 2] == c && Board[2, 2] == c))
                {
                    IsGameOver = true;
                }
            }
            else if (a == 2 && b == 0)
            {
                if ((Board[0, 0] == c && Board[1, 0] == c) || (Board[2, 1] == c && Board[2, 2] == c) || (Board[1, 1] == c && Board[0, 2] == c))
                {
                    IsGameOver = true;
                }
            }
            else if (a == 2 && b == 1)
            {
                if ((Board[2, 0] == c && Board[2, 2] == c) || (Board[1, 1] == c && Board[0, 1] == c))
                {
                    IsGameOver = true;
                }
            }
            else
            {
                if ((Board[2, 0] == c && Board[2, 1] == c) || (Board[1, 2] == c && Board[0, 2] == c) || (Board[1, 1] == c && Board[0, 0] == c))
                {
                    IsGameOver = true;
                }
            }

            if (IsGameOver)
            {
                Winner = player;
            }

            if (_round < 9) return;
            if (Winner != Player.None)
            {
                IsGameOver = true;
                return;
            }
            IsGameOver = true;
            IsDraw = true;
        }

        public void Start()
        {
            Console.WriteLine("Game started!");
            DisplayBoard();
            var i = 0;
            while (!IsGameOver)
            {
                var a = new Random().Next(1, 4);
                var b = new Random().Next(1, 4);
                while (Board[a - 1, b - 1] != Cell.Empty)
                {
                    a = new Random().Next(1, 4);
                    b = new Random().Next(1, 4);
                }
                Click(a - 1, b - 1, i % 2 == 0 ? Player.X : Player.O);
                Console.WriteLine("Now " + (i % 2 == 0 ? Player.X.ToString() : Player.O.ToString()) + " is playing:");
                ++i;
                DisplayBoard();
            }

            if (IsDraw)
            {
                Console.WriteLine("Draw !");
                return;
            }
            Console.WriteLine("The winner is: " + Winner.ToString() + " !");
        }
    }

    internal class Program
    {
        private static void Main()
        {
            var game = new TicTacToeGame();
            game.Start();
        }
    }
}
