namespace Rationals
{
    internal struct Rational
    {
        public Rational(int numerator, int denomirator)
        {
            Numrrator = numerator;
            Denomirator = denomirator == 0 ? 1 : denomirator;
        }
        //It was better to call the other constructor: Rational(int numerator) : this(numerator, 1) { }
        public Rational(int numerator)
        {
            Numrrator = numerator;
            Denomirator = 1;
        }
        public int Numrrator { get; private set; }

        public int Denomirator { get; private set; }

        //Nice
        public double Value => (double)Numrrator / Denomirator;

        public Rational Add(Rational r)
        {
            if (Denomirator == r.Denomirator)
            {
                var newRational = new Rational(Numrrator + r.Numrrator, Denomirator);
                return newRational;
            }
            else
            {
                var denomirator = Denomirator * r.Denomirator;
                var newRational = new Rational((denomirator / r.Denomirator) * r.Numrrator + (denomirator / Denomirator) * Numrrator, denomirator);
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

        //The 'ToString' in here is redeundant. You are concatenating strings, so it will be called implicitly.
        //Also, consider the use of string interplation (with the '$' sign)
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
}