using System;

namespace DollarStairs
{
    internal class Program
    {
        internal static void Main()
        {
            Console.WriteLine("Plaese enter an integer number");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Plaese enter an integer number");
            }
            for (var i = 1; i < n + 1; ++i)
            {
                DisplayDollars(i);
            }
        }

        internal static void DisplayDollars(int i)
        {
            for (var j = 0; j < i; ++j)
            {
                Console.Write("$");
            }
            Console.WriteLine();
        }
    }
}
