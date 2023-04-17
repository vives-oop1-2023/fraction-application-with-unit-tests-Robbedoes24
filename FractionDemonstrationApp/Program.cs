using FractionLibrary;

namespace FractionDemonstrationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ## Here are some examples of the different methodes that the fraction class offers ##


            // There are 3 ways to create a new fraction object:

            // 1. giving no data (this gives a fraction 1/1)
            Fraction f1 = new Fraction();
            Console.WriteLine($"Creating a fraction with no data: {f1}");

            // 2. giving a numerator and denominator (this gives a fraction numerator/denominator)
            Fraction f2 = new Fraction(3,6); // this should result in a fraction 3/6
            Console.WriteLine($"Creating a fraction with numerator and denominator: {f2}");

            // 3. giving a floating point value (this gives a simplified fraction for the given value)
            Fraction f3 = new Fraction(2.5); // this should result in a fraction 5/2
            Console.WriteLine($"Creating a fraction with a floating point value: {f3}");


            // The fraction class overrides the ToString methode, so you can use this to visualize the value of a fraction object
            f1 = new Fraction(1, 2);
            Console.WriteLine($"Visualizing with the ToString methode: {f1.ToString()}");
            Console.WriteLine($"Visualizing with the variable name: {f1}"); // c# calls the ToString methode behind the scene

            // The fraction class overrides the Equals methode, so you can use this to see if 2 fractions are equal
            // Note: There is no simplification done, so values of the numerator and denominator need to be equal
            f1 = new Fraction(2, 6);
            f2 = new Fraction(2, 6);
            Console.WriteLine($"Fraction {f1} equals Fraction {f2}: {f1.Equals(f2)}");
            

            // The fraction class has a result methode that returns the floating point equivalent of the fraction
            f1 = new Fraction(1, 2);
            double result = f1.Result(); // this should have a value of 0.5
            Console.WriteLine($"Result methode {result}");


            // The fraction class has multiple methodes to perform mathematical operations on fractions:
            // Note: All these methodes return a new fraction object

            // 1. Addition (fraction_1 + fraction_2)
            f1 = new Fraction(1,2);
            f2 = new Fraction(2,3);
            f3 = f1.Add(f2); // this should result in a fraction 7/6
            Console.WriteLine($"Addition of fractions: {f3}");

            // 2. Substraction (fraction_1 - fraction_2)
            f1 = new Fraction(1, 2);
            f2 = new Fraction(2, 3);
            f3 = f1.Subtract(f2); // this should result in a fraction -1/6
            Console.WriteLine($"Substraction of fractions: {f3}");

            // 3. Multiplication (fraction_1 * fraction_2)
            f1 = new Fraction(1, 2);
            f2 = new Fraction(2, 3);
            f3 = f1.Multiply(f2); // this should result in a fraction 2/6
            Console.WriteLine($"Multiplication of fractions: {f3}");

            // 4. Division (fraction_1 / fraction_2)
            f1 = new Fraction(1, 2);
            f2 = new Fraction(2, 3);
            f3 = f1.Divide(f2); // this should result in a fraction 3/4
            Console.WriteLine($"Division of fractions: {f3}");

            // 5. Inversion (- fraction_1)
            f1 = new Fraction(1, 2);
            f1 = f1.Invert(); // this should result in a fraction -1/2
            Console.WriteLine($"Inversion of fractions: {f1}");

            // 6. Multiplicative inversion ( 1 / fraction_1)
            f1 = new Fraction(1, 2);
            f1 = f1.Reciprocal(); // this should result in a fraction 2/1
            Console.WriteLine($"Multiplicative inversion of fractions: {f1}");

            // 7. Simplification (Simplifies a fraction to its simplest form)
            f1 = new Fraction(60, 12);
            f1 = f1.Simplify(); // this should result in a fraction 5/1
            Console.WriteLine($"Simplification of fractions: {f1}");
        }
    }
}