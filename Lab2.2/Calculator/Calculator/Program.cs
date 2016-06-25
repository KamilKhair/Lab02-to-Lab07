using System;

namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            var calculator = new Calc();
            Console.WriteLine("Please insert 2 numbers (Hit ENTER after each number)");
            double a, b;
            while (!double.TryParse(Console.ReadLine(), out a) || !double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Please insert only a correct number");
            }
            Console.WriteLine("Insert the operator ( +|-|*|/ )");
            var @operator = (Console.ReadLine());
            var result = calculator.Calcu(a, b, @operator);
            if (result == double.NegativeInfinity || result == double.PositiveInfinity)
            {
                Console.WriteLine("Division by zero is not allowed!");
                return;
            }
            Console.WriteLine(result != double.NaN
                ? $"{a} {@operator} {b} = {result}"
                : "Incorrect operator has been inserted...");
        }
    }
}
