using System;

namespace MulBoard
{
    internal class Program
    {
        private static readonly int[,] MyArr = new int[10, 10];

        public static void Main()
        {
            for (var i = 0; i < 10; ++i)
            {
                Display(i);
            }
        }

        public static void Display(int i)
        {
            for (var j = 0; j < 10; ++j)
            {
                MyArr[i, j] = (i + 1) * (j + 1);
                Console.Write($"{MyArr[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}
