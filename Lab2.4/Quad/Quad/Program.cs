using System;

namespace Quad
{
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
