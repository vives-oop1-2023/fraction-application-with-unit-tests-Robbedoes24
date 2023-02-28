using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    public class Fraction
    {
        public Fraction() {}

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
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
                return false ;
            }

            // cast obj to faction
            Fraction right = (Fraction)obj;

            // check if they are equal
            return (this.numerator == right.numerator && this.denominator == right.denominator);
        }

        public double Result()
        {
            return (double)numerator/denominator ;
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
            return new Fraction(numerator, denominator);
        }
        
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set { 
                if(value == 0) {
                    value = denominator;
                }
                denominator = value;
            }
        }

        private int numerator = 1;
        private int denominator = 1;
    }
}
