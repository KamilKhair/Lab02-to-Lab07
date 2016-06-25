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
                    return b != 0 ? Div(a, b) : double.NaN;
                default:
                    return double.NaN;  // double.NAN represents a value that is not a number
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