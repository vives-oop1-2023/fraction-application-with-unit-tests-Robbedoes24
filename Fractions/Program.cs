using System;

namespace Fractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction(1,2);
            Fraction f3 = new Fraction(2,3);
            Fraction f4 = new Fraction(-3,4);
            Fraction f5 = new Fraction(4,-5);

            // test tostring
            Console.WriteLine("Tostring");
            Console.WriteLine(f1); // 1/1
            Console.WriteLine(f2); // 1/2
            Console.WriteLine(f3); // 2/3
            Console.WriteLine(f4); // -3/4
            Console.WriteLine(f5); // 4/-5

            // test result
            Console.WriteLine("Result");
            Console.WriteLine(f1.Result()); // 1
            Console.WriteLine(f2.Result()); // 0.5
            Console.WriteLine(f3.Result()); // 0.66666666
            Console.WriteLine(f4.Result()); // -0.75
            Console.WriteLine(f5.Result()); //

            // test add
            Console.WriteLine("Add");
            Console.WriteLine(f1.Add(f2)); // 1/1 + 1/2 -> 2/2 + 1/2 -> 3/2
            Console.WriteLine(f2.Add(f3)); // 1/2 + 2/3 -> 3/6 + 4/6 -> 7/6
            Console.WriteLine(f3.Add(f4)); // 2/3 + -3/4 -> 8/12 + -9/12 -> -1/12
            Console.WriteLine(f4.Add(f5)); // -3/4 + 1/1 -> -3/4 + 4/4 -> 1/4
            Console.WriteLine(f5.Add(f1)); //

            // test multiply
            Console.WriteLine("Multiply");
            Console.WriteLine(f1.Multiply(f2)); //
            Console.WriteLine(f2.Multiply(f3)); //
            Console.WriteLine(f3.Multiply(f4)); //
            Console.WriteLine(f4.Multiply(f5)); //
            Console.WriteLine(f5.Multiply(f1));

            // test subtract
            Console.WriteLine("Subtract");
            Console.WriteLine(f1.Subtract(f2)); //
            Console.WriteLine(f2.Subtract(f3)); //
            Console.WriteLine(f3.Subtract(f4)); //
            Console.WriteLine(f4.Subtract(f5)); //
            Console.WriteLine(f5.Subtract(f1)); //

            // test divide
            Console.WriteLine("Divide");
            Console.WriteLine(f1.Divide(f2)); //
            Console.WriteLine(f2.Divide(f3)); //
            Console.WriteLine(f3.Divide(f4)); //
            Console.WriteLine(f4.Divide(f5)); //
            Console.WriteLine(f5.Divide(f1));

            // test reciprocal
            Console.WriteLine("Reciprocal");
            Console.WriteLine(f1.Reciprocal()); //
            Console.WriteLine(f2.Reciprocal()); //
            Console.WriteLine(f3.Reciprocal()); //
            Console.WriteLine(f4.Reciprocal()); //
            Console.WriteLine(f5.Reciprocal()); //

            // test invert
            Console.WriteLine("Invert");
            Console.WriteLine(f1.Invert()); //
            Console.WriteLine(f2.Invert()); //
            Console.WriteLine(f3.Invert()); //
            Console.WriteLine(f4.Invert()); //
            Console.WriteLine(f5.Invert()); //
        }
    }
}