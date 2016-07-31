using System;
using System.Collections.Generic;

namespace Primes
{
    internal class Program
    {
        //Consider extracting this logic to a different class.
        private static void Main()
        {
            Console.WriteLine("Please enter the first positive integer number:");
            int a;

            label1:
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Error parsing");
                return;
            }

            Console.WriteLine("Please enter the second integer number:");
            int b;
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Error Parsing");
                return;
            }

            if (a <= 0 || b <= 0 || (b - a) <= 0)
            {
                Console.WriteLine("Error: Please Enter only 2 positive integers, the first one has to be larger than the second one, Enter the first nimber:");
                goto label1;
            }

            //What is this magic number for?
            if (b - a > 49999)
            {
                //LOL
                Console.WriteLine("Processing... Please wait ");
            }

            var arr = CalcPrimes(a, b);

            Console.WriteLine("The primes are: ");

            //Consider a better name for both of them
            foreach (var t in arr)
            {
                //Consider the use of Console.Write overload that accepts a format: Console.Write("{0} ", t);
                //Or string.Format: Console.Write(string.Format("{0} ", t));
                //Or even better string interpolation: Console.Write($"{t} ");
                Console.Write(t + " ");
            }

            Console.WriteLine();
        }

        private static IEnumerable<int> CalcPrimes(int a, int b)
        {
            var list = new List<int>();
            var size = 0;
            for (var i = a; i <= b; ++i)
            {
                var isPrime = true;
                for (var j = 2; j < i; ++j)
                {
                    if (i % j != 0) continue;
                    isPrime = false;
                    break;
                }
                if (!isPrime) continue;
                list.Add(i);
                ++size;
            }

            //Size is not necessary. You could use list.Count: var result = new int[list.Count]
            var result = new int[size];
            list.CopyTo(result);
            return result;
        }
    }
}
