using System;

namespace Fractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(2,3);
            Console.WriteLine(f1);
            Console.WriteLine(f1.Result());
            f1 = new Fraction(0.6666666666);
            Console.WriteLine(f1);
            Console.WriteLine(f1.Result());
        }
    }
}