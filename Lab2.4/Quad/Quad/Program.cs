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

        public double A { get; }
        public double B { get; }
        public double C { get; }
        public double X1 { get; private set; }
        public double X2 { get; private set; }

        public void Calculate()
        {
            var sqrtPart = B * B - 4 * A * C;
            if (A == 0 && B != 0)
            {
                X1 = -1.0*C/B;
            }
            else if (A == 0)
            {
                // do nothing
            }
            else if (sqrtPart > 0)
            {
                X1 = (-B + Math.Sqrt(sqrtPart)) / (2 * A);
                X2 = (-B - Math.Sqrt(sqrtPart)) / (2 * A);
            }
            else if (sqrtPart == 0 && (A != 0 || B != 0 || C != 0))
            {
                X1 = (-B + Math.Sqrt(sqrtPart)) / (2 * A);
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Command Line arguments error!");
                return;
            }
            double a, b, c;
            if (!double.TryParse(args[0], out a))
            {
                Console.WriteLine("Unable to parse " + args[0]);
                return;
            }
            if (!double.TryParse(args[1], out b))
            {
                Console.WriteLine("Unable to parse " + args[1]);
                return;
            }
            if (!double.TryParse(args[2], out c))
            {
                Console.WriteLine("Unable to parse " + args[2]);
                return;
            }
            var q = new Quad(a,b,c);
            q.Calculate();
            if (q.X1 == double.NaN && q.X2 == double.NaN)
            {
                Console.WriteLine("No Real solutions!");
            }
            else if (q.X2 == double.NaN)
            {
                Console.WriteLine("One Real solution: " + q.X1);
            }
            else
            {
                Console.WriteLine("Two Real solutions: " + q.X1 + " " + q.X2);
            }
        }
    }
}
