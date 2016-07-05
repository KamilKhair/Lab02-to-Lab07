using System;

namespace Rationals
{
    internal class Program
    {
        internal static void Main()
        {
            var rationalArr = new[]
            {
                new Rational(2, 12),
                new Rational(6, 32),
                new Rational(),
                new Rational()
            };

            rationalArr[2] = rationalArr[0].Add(rationalArr[1]);
            rationalArr[3] = rationalArr[0].Mul(rationalArr[1]);


            Console.WriteLine("Before Reduce:");
            DisplayArr(rationalArr);

            for (var i = 0; i < rationalArr.Length; ++i)
            {
                rationalArr[i].Reduce();
            }

            Console.WriteLine();
            Console.WriteLine("After Reduce:");
            DisplayArr(rationalArr);
        }

        private static void DisplayArr(Rational[] rationalArr)
        {
            Console.WriteLine(rationalArr[0].ToString() + " + " + rationalArr[1].ToString() + " = " + rationalArr[2].ToString() + " = " + rationalArr[2].Value);
            Console.WriteLine(rationalArr[0].ToString() + " * " + rationalArr[1].ToString() + " = " + rationalArr[3].ToString() + " = " + rationalArr[3].Value);
        }
    }
}
