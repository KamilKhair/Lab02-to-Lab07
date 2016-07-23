using System;
using System.Configuration;

namespace Quad
{
    public class Program
    {
        //(1, -2, 1) -> wrong result
        //(1, 6, 9) -> wrong result
        //(1, -2, 4) -> wrong result
        //(1, 1, 1) -> wrong result
        //Can't correctly handle no solutions or less than two solutions.
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

            //Nan stands for 'Not a number', so you can't use the equalty operator to test for equality between a NaN and a number.
            //It is interesting to notice that it will work correctly with Equals, IsNan or with CompareTo.
            if (q.X1 == double.NaN && q.X2 == double.NaN)
            //if(q.X1.Equals(double.NaN) && q.X2.Equals(double.NaN))
            {
                Console.WriteLine("No Real solutions!");
            }
            else if (q.X2 == double.NaN)
            //else if(q.X2.Equals(double.NaN))
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
