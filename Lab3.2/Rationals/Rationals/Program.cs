using System;

namespace Rationals
{
    internal class Program
    {
        internal static void Main()
        {
            var num1 = new Rational(1, 2);
            var num2 = new Rational(1, 2);

            var num3 = num1.Add(num2);

            var num4 = num2.Mul(num2);

            var num6 = new Rational(2, 4);
            var num7 = new Rational(2, 4);
            num7.Reduce();


            Console.WriteLine($"{num1} + {num2} = {num3}");
            Console.WriteLine($"{num2} * {num2} = {num4}");
            Console.WriteLine($"{num6} reduced {num7}");
        }

        private static void DisplayArr(Rational[] rationalArr)
        {
            Console.WriteLine(rationalArr[0].ToString() + " + " + rationalArr[1].ToString() + " = " + rationalArr[2].ToString() + " = " + rationalArr[2].Value);
            Console.WriteLine(rationalArr[0].ToString() + " * " + rationalArr[1].ToString() + " = " + rationalArr[3].ToString() + " = " + rationalArr[3].Value);
        }
    }
}
