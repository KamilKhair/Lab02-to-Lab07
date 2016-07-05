using System;
using System.Collections.Generic;

namespace Primes
{
    internal class Program
    {
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

            if (b - a > 49999)
            {
                Console.WriteLine("Processing... Please wait ");
            }

            var arr = CalcPrimes(a, b);

            Console.WriteLine("The primes are: ");

            foreach (var t in arr)
            {
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
            var result = new int[size];
            list.CopyTo(result);
            return result;
        }
    }
}
