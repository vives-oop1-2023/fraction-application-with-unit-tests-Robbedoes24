using FractionLibrary;

namespace FractionDemonstrationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // There are 3 ways to create a new fraction object:
            // 1. giving no data (this gives a fraction 1/1)
            Fraction fraction1 = new Fraction();
            Console.WriteLine($"Creating a fraction with no data: {fraction1}");

            // 2. giving a numerator and denominator (this gives a fraction numerator/denominator)
            Fraction fraction2 = new Fraction(3,6); // this should result in a fraction 3/6
            Console.WriteLine($"Creating a fraction with numerator and denominator: {fraction2}");

            // 3. giving a floating point value (this gives a simplified fraction for the given value)
            Fraction fraction3 = new Fraction(2.5); // this should result in a fraction 5/2
            Console.WriteLine($"Creating a fraction with a floating point value: {fraction3}");

            // The fraction class overrides the ToString methode, so you can use this to visualize the value of a fraction object
            Fraction f = new Fraction(1, 2);
            Console.WriteLine($"Visualizing with the ToString methode: {f.ToString()}");
            Console.WriteLine($"Visualizing with the variable name: {f}"); // c# calls the ToString methode behind the scene

            // The fraction class has multiple methodes ....
            // 1. Addition (fraction 1 + fraction 2, returns a new fraction object)
            Fraction f1 = new Fraction(1,2);
            Fraction f2 = new Fraction(1,2);
            Fraction f3 = f1.Add(f2); // this should result in a fraction /
            Console.WriteLine($"Addition of fractions: {f3}");

            // 2. Substraction (fraction 1 - fraction 2, returns a new fraction object)
            f1 = new Fraction(1, 2);
            f2 = new Fraction(1, 2);
            f3 = f1.Subtract(f2); // this should result in a fraction /
            Console.WriteLine($"Substraction of fractions: {f3}");

            // 3. Multiplication (fraction 1 * fraction 2, returns a new fraction object)
            f1 = new Fraction(1, 2);
            f2 = new Fraction(1, 2);
            f3 = f1.Multiply(f2); // this should result in a fraction /
            Console.WriteLine($"Multiplication of fractions: {f3}");

            // 4. Division (fraction 1 / fraction 2, returns a new fraction object)
            f1 = new Fraction(1, 2);
            f2 = new Fraction(1, 2);
            f3 = f1.Divide(f2); // this should result in a fraction /
            Console.WriteLine($"Division of fractions: {f3}");

            // 5. Inversion (- fraction 1, returns a new fraction object)
            f1 = new Fraction(1, 2);
            f2 = f1.Invert(); // this should result in a fraction /
            Console.WriteLine($"Inversion of fractions: {f2}");

            // 6. Multiplicative inversion ( 1 / fraction 1, returns a new fraction object)
            f1 = new Fraction(1, 2);
            f2 = f1.Reciprocal(); // this should result in a fraction /
            Console.WriteLine($"Multiplicative inversion of fractions: {f2}");

            // 7. Simplification ( ... , returns a new fraction object)
            f1 = new Fraction(1, 2);
            f2 = f1.Simplify(); // this should result in a fraction /
            Console.WriteLine($"Multiplicative inversion of fractions: {f2}");
        }
    }
}