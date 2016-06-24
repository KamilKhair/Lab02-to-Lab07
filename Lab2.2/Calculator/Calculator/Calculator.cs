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
}