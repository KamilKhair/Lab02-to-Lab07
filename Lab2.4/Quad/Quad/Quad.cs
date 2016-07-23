using System;

namespace Quad
{
    public class Quad
    {
        public Quad(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            X1 = double.NaN;
            X2 = double.NaN;
        }

        //C# 6 features. Nice.
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public double X1 { get; private set; }
        public double X2 { get; private set; }

        public void Calculate()
        {
            var sqrtPart = B * B - 4 * A * C;
            // One Real Solution
            if (!(Math.Abs(A) > 0) && Math.Abs(B) > 0) // if A == 0 AND B != 0
            {
                X1 = -1.0*C/B;
            }
            else if (!(Math.Abs(A) > 0))
            {
                // Do nothing
            }
            // Two Real Solution
            else if (sqrtPart > 0)
            {
                X1 = (-B + Math.Sqrt(sqrtPart)) / (2 * A);
                X2 = (-B - Math.Sqrt(sqrtPart)) / (2 * A);
            }
            // One Real Solution
            else if ( !(Math.Abs(sqrtPart) > 0) && (Math.Abs(A) > 0 || Math.Abs(B) > 0 || Math.Abs(C) > 0))
            {
                X1 = (-B + Math.Sqrt(sqrtPart)) / (2 * A);
            }
        }
    }
}