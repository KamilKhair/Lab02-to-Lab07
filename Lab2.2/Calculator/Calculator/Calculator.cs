using System;

namespace Calculator
{
    //Gr8 work!
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
                    //Did you used this due to the ReSharper waning for 'b != 0' ?
                    if (Math.Abs(b) > 0)
                    {
                        return Div(a, b);
                    }

                    //Gr8 work!
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