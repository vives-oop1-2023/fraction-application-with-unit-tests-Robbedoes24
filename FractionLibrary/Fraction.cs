namespace FractionLibrary
{
    public class Fraction
    {
        public Fraction() { }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction(double number) // Rounds to 4 decimal places
        {
            int multiplier = 10_000; // For 4 dicimal places
            int intNumber = (int)Math.Round(number * multiplier);
            int gcd = FindGcd(Math.Abs(intNumber), multiplier);

            Numerator = intNumber / gcd;
            Denominator = multiplier / gcd;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public override bool Equals(object? obj)
        {
            // make sure obj is not null
            if (obj == null)
            {
                return false;
            }

            // cast obj to faction
            Fraction right = (Fraction)obj;

            // check if they are equal
            return (this.numerator == right.numerator && this.denominator == right.denominator);
        }

        public double Result()
        {
            return (double)numerator / denominator;
        }

        public Fraction Add(Fraction right)
        {
            Fraction f1 = new Fraction(numerator * right.Denominator, denominator * right.Denominator);
            Fraction f2 = new Fraction(right.Numerator * denominator, right.Denominator * denominator);
            return new Fraction(f1.numerator + f2.numerator, f1.denominator);
        }

        public Fraction Multiply(Fraction right)
        {
            return new Fraction(numerator * right.Numerator, denominator * right.Denominator);
        }

        public Fraction Subtract(Fraction right)
        {
            return Add(right.Invert());
        }

        public Fraction Divide(Fraction right)
        {
            return Multiply(right.Reciprocal());
        }

        public Fraction Reciprocal()
        {
            return new Fraction(denominator, numerator);
        }

        public Fraction Invert()
        {
            return new Fraction(-numerator, denominator);
        }

        public Fraction Simplify()
        {
            int gcd = FindGcd(Math.Abs(numerator), Math.Abs(denominator));
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }

            return new Fraction(numerator / gcd, denominator / gcd);
        }

        private int FindGcd(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            if (a < b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                {
                    value = 1;
                }
                denominator = value;
            }
        }

        private int numerator = 1;
        private int denominator = 1;
    }
}