using System;

namespace Calculator
{
    public class Calc
    {
        public double Calcu(double a, double b, string s)
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
                    if (Math.Abs(b) > 0)
                    {
                        return Div(a, b);
                    }
                    throw new ArgumentOutOfRangeException(null, "Division by zero accured, And it is not allowed!");
                default:
                    return double.NaN;  // double.NAN represents a value that is not a number, Calcu returns double.NAN if an incorrect operator has been loaded.
            }
        }
        private static double Add(double a, double b)
        {
            var result = a + b;
            return result;
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
}