using System;

namespace Calculator
{
    public class Calculator
    {
        public double Calc(double a, double b, string s)
        {
            switch (s)
            {
                case "+":
                    return Add(a, b);
                case "-":
                    return Sub(a, b);
                case "*":
                    return Mul(a, b);
                case "/":
                    return Div(a, b);
                default:
                    return Math.PI; // if the operator is incorrect Calc returns a non-rational number - For example Math.PI
            }
        }
        private static double Add(double a, double b)
        {
            return a + b;
        }

        private static double Sub(double a, double b)
        {
            return a - b;
        }

        private static double Mul(double a, double b)
        {
            return a * b;
        }

        private static double Div(double a, double b)
        {
            return a / b;
        }
    }
    public class Program
    {
        public static void Main()
        {
            var calculator = new Calculator();
            Console.WriteLine("Please insert 2 numbers (Hit ENTER after each number)");
            double a, b;
            while (!double.TryParse(Console.ReadLine(), out a) || !double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Please insert only a correct number");
            }
            Console.WriteLine("Insert the operator ( +|-|*|/ )");
            var @operator = (Console.ReadLine());
            var result = calculator.Calc(a, b, @operator);
            if (result == double.NegativeInfinity || result == double.PositiveInfinity)
            {
                Console.WriteLine("Division by zero is not allowed!");
                return;
            }
            Console.WriteLine(result != Math.PI
                ? $"{a} {@operator} {b} = {result}"
                : "Incorrect operator has been inserted...");
        }
    }
}
