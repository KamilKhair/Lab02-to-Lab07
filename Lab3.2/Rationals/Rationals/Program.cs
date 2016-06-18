using System;

namespace Rationals
{
    struct Rational
    {
        public Rational(int numerator, int denomirator)
        {
            Numrrator = numerator;
            Denomirator = denomirator == 0 ? 1 : denomirator;
        }

        public Rational(int numerator)
        {
            Numrrator = numerator;
            Denomirator = 1;
        }
        public int Numrrator { get; private set; }

        public int Denomirator { get; private set; }

        public double Value => (double)Numrrator / Denomirator;

        public Rational Add(Rational r)
        {
            if (Denomirator == r.Denomirator)
            {
                Rational newRational = new Rational(Numrrator + r.Numrrator, Denomirator);
                return newRational;
            }
            else
            {
                int denomirator = Denomirator * r.Denomirator;
                Rational newRational = new Rational((denomirator / r.Denomirator) * r.Numrrator + (denomirator / Denomirator) * Numrrator, denomirator);
                return newRational;
            }
        }

        public Rational Mul(Rational r)
        {
            var newRational = new Rational(Numrrator * r.Numrrator, Denomirator * r.Denomirator);
            return newRational;
        }

        public void Reduce()
        {
            var numerator = Numrrator;
            Numrrator /= Gcd(Numrrator, Denomirator);
            Denomirator /= Gcd(numerator, Denomirator);
        }

        public override string ToString()
        {
            return Numrrator.ToString() + "/" + Denomirator.ToString();
        }

        public static int Gcd(int a, int b) // Greatest Common Divisor
        {
            while (true)
            {
                if (b == 0)
                {
                    return a;
                }
                var r = a % b;
                a = b;
                b = r;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var r1 = new Rational(2, 12);
            var r2 = new Rational(6, 32);
            var r3 = r1.Add(r2);
            var r4 = r1.Mul(r2);

            Console.WriteLine(r1.ToString() + " + " + r2.ToString() + " = " + r3.ToString() + " = " + r3.Value);
            Console.WriteLine(r1.ToString() + " * " + r2.ToString() + " = " + r4.ToString() + " = " + r4.Value);

            r1.Reduce();
            r2.Reduce();
            r3.Reduce();
            r4.Reduce();

            Console.WriteLine("After Reduce:");
            Console.WriteLine(r1.ToString() + " + " + r2.ToString() + " = " + r3.ToString() + " = " + r3.Value);
            Console.WriteLine(r1.ToString() + " * " + r2.ToString() + " = " + r4.ToString() + " = " + r4.Value);
        }
    }
}
