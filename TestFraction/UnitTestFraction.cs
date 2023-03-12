using Fractions;
using System.ComponentModel;

namespace TestFraction
{
    public class UnitTestFraction
    {
        [Fact]
        public void TestDefaultConstructor()
        {
            Fraction f1 = new Fraction();

            Assert.Equal(1, f1.Numerator);
            Assert.Equal(1, f1.Denominator);
        }

        [Fact]
        public void TestNumDenomConstructor()
        {
            Fraction f1 = new Fraction(1,1);
            Assert.Equal(1, f1.Numerator);
            Assert.Equal(1, f1.Denominator);

            f1 = new Fraction(3,4);
            Assert.Equal(3, f1.Numerator);
            Assert.Equal(4, f1.Denominator);

            f1 = new Fraction(-6,2);
            Assert.Equal(-6, f1.Numerator);
            Assert.Equal(2, f1.Denominator);

            f1 = new Fraction(4,-3);
            Assert.Equal(4, f1.Numerator);
            Assert.Equal(-3, f1.Denominator);

            f1 = new Fraction(5, 0);
            Assert.Equal(5, f1.Numerator);
            Assert.Equal(1, f1.Denominator);
        }

        [Fact] 
        public void TestDoubleConstructor() 
        {
            Fraction f1 = new Fraction(0);
            Assert.Equal(0,f1.Numerator);
            Assert.Equal(1, f1.Denominator);

            f1 = new Fraction(10);
            Assert.Equal(10, f1.Numerator);
            Assert.Equal(1, f1.Denominator);

            f1 = new Fraction(2.5);
            Assert.Equal(5, f1.Numerator);
            Assert.Equal(2, f1.Denominator);

            f1 = new Fraction(0.5);
            Assert.Equal(1, f1.Numerator);
            Assert.Equal(2, f1.Denominator);

            f1 = new Fraction(-0.25);
            Assert.Equal(-1, f1.Numerator);
            Assert.Equal(4, f1.Denominator);

            f1 = new Fraction(-5.6);
            Assert.Equal(-28, f1.Numerator);
            Assert.Equal(5, f1.Denominator);

            f1 = new Fraction(0.333333);
            Assert.Equal(3333, f1.Numerator);
            Assert.Equal(10000, f1.Denominator);

            f1 = new Fraction(-0.6666666);
            Assert.Equal(-6667, f1.Numerator);
            Assert.Equal(10000, f1.Denominator);
        }

        [Fact]
        public void TestNumeratorProperty()
        {
            Fraction f1 = new Fraction();

            f1.Numerator = 1;
            Assert.Equal(1, f1.Numerator);

            f1.Numerator = 5;
            Assert.Equal(5, f1.Numerator);

            f1.Numerator = -4;
            Assert.Equal(-4, f1.Numerator);

            f1.Numerator = 0;
            Assert.Equal(0, f1.Numerator);
        }

        [Fact]
        public void TestDenominatorProperty()
        {
            Fraction f1 = new Fraction();

            f1.Denominator = 1;
            Assert.Equal(1, f1.Denominator);

            f1.Denominator = 5;
            Assert.Equal(5, f1.Denominator);

            f1.Denominator = -4;
            Assert.Equal(-4, f1.Denominator);

            f1.Denominator = 0;
            Assert.Equal(1, f1.Denominator);
        }


        [Fact]
        public void TestToString()
        {
            Fraction f1 = new Fraction();
            Assert.Equal("1/1", f1.ToString());

            f1 = new Fraction(3,4);
            Assert.Equal("3/4", f1.ToString());

            f1 = new Fraction(-2,1);
            Assert.Equal("-2/1", f1.ToString());

            f1 = new Fraction(5,-3);
            Assert.Equal("5/-3", f1.ToString());

            f1 = new Fraction(-1, -3);
            Assert.Equal("-1/-3", f1.ToString());
        }

        [Fact] 
        public void TestEquals()
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
            Assert.True(f1.Equals(f2));
            Assert.True(f2.Equals(f1));

            f1 = new Fraction(1,2);
            f2 = new Fraction(1,2);
            Assert.True(f1.Equals(f2));
            Assert.True(f2.Equals(f1));

            f1 = new Fraction(-3, 4);
            f2 = new Fraction(-3, 4);
            Assert.True(f1.Equals(f2));
            Assert.True(f2.Equals(f1));

            f1 = new Fraction(5, -1);
            f2 = new Fraction(5, -1);
            Assert.True(f1.Equals(f2));
            Assert.True(f2.Equals(f1));

            f1 = new Fraction(-3, -9);
            f2 = new Fraction(-3, -9);
            Assert.True(f1.Equals(f2));
            Assert.True(f2.Equals(f1));

            f1 = new Fraction(-9, 2);
            f2 = new Fraction(9, 2);
            Assert.False(f1.Equals(f2));
            Assert.False(f2.Equals(f1));

            f1 = new Fraction(2, -1);
            f2 = new Fraction(2, 1);
            Assert.False(f1.Equals(f2));
            Assert.False(f2.Equals(f1));

            f1 = new Fraction(6, 3);
            f2 = new Fraction(-6, 3);
            Assert.False(f1.Equals(f2));
            Assert.False(f2.Equals(f1));

            f1 = new Fraction(4, 3);
            f2 = new Fraction(4, -3);
            Assert.False(f1.Equals(f2));
            Assert.False(f2.Equals(f1));

            f1 = new Fraction(-5, 4);
            f2 = new Fraction(5, -4);
            Assert.False(f1.Equals(f2));
            Assert.False(f2.Equals(f1));

            f1 = new Fraction(6, -7);
            f2 = new Fraction(-6, 7);
            Assert.False(f1.Equals(f2));
            Assert.False(f2.Equals(f1));

        }

        [Fact]
        public void TestResult()
        {
            Fraction f1 = new Fraction();
            Assert.Equal(1.0, f1.Result());

            f1 = new Fraction(2,1);
            Assert.Equal(2.0, f1.Result());

            f1 = new Fraction(3, 4);
            Assert.Equal(0.75, f1.Result());

            f1 = new Fraction(1, 3);
            Assert.Equal(0.333, Math.Round(f1.Result(), 3));

            f1 = new Fraction(-2, 4);
            Assert.Equal(-0.5, f1.Result());

            f1 = new Fraction(8, -8);
            Assert.Equal(-1, f1.Result());

            f1 = new Fraction(-1, -5);
            Assert.Equal(0.2, f1.Result());
        }

        [Fact]
        public void TestAdd()
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
            Fraction f3 = f1.Add(f2);
            Assert.Equal(2, f3.Numerator);
            Assert.Equal(1, f3.Denominator);

            f1 = new Fraction(1,2);
            f2 = new Fraction(5,6);
            f3 = f1.Add(f2);
            Assert.Equal(16, f3.Numerator);
            Assert.Equal(12, f3.Denominator);

            f1 = new Fraction(-4,8);
            f2 = new Fraction(9,5);
            f3 = f1.Add(f2);
            Assert.Equal(52, f3.Numerator);
            Assert.Equal(40, f3.Denominator);

            f1 = new Fraction(2,-6);
            f2 = new Fraction(1,2);
            f3 = f1.Add(f2);
            Assert.Equal(-2, f3.Numerator);
            Assert.Equal(-12, f3.Denominator);

            f1 = new Fraction(8,9);
            f2 = new Fraction(-4,2);
            f3 = f1.Add(f2);
            Assert.Equal(-20, f3.Numerator);
            Assert.Equal(18, f3.Denominator);

            f1 = new Fraction(7,4);
            f2 = new Fraction(6,-2);
            f3 = f1.Add(f2);
            Assert.Equal(10, f3.Numerator);
            Assert.Equal(-8, f3.Denominator);

            f1 = new Fraction(-5,7);
            f2 = new Fraction(9,-1);
            f3 = f1.Add(f2);
            Assert.Equal(68, f3.Numerator);
            Assert.Equal(-7, f3.Denominator);

            f1 = new Fraction(3,-5);
            f2 = new Fraction(-7,10);
            f3 = f1.Add(f2);
            Assert.Equal(65, f3.Numerator);
            Assert.Equal(-50, f3.Denominator);

            f1 = new Fraction(-1,9);
            f2 = new Fraction(-3,5);
            f3 = f1.Add(f2);
            Assert.Equal(-32, f3.Numerator);
            Assert.Equal(45, f3.Denominator);

            f1 = new Fraction(6,-1);
            f2 = new Fraction(10,-3);
            f3 = f1.Add(f2);
            Assert.Equal(-28, f3.Numerator);
            Assert.Equal(3, f3.Denominator);
        }

        [Fact]
        public void TestMultiply() 
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
            Fraction f3 = f1.Multiply(f2);
            Assert.Equal(1, f3.Numerator);
            Assert.Equal(1, f3.Denominator);

            f1 = new Fraction(1, 2);
            f2 = new Fraction(5, 6);
            f3 = f1.Multiply(f2);
            Assert.Equal(5, f3.Numerator);
            Assert.Equal(12, f3.Denominator);

            f1 = new Fraction(-4, 8);
            f2 = new Fraction(9, 5);
            f3 = f1.Multiply(f2);
            Assert.Equal(-36, f3.Numerator);
            Assert.Equal(40, f3.Denominator);

            f1 = new Fraction(2, -6);
            f2 = new Fraction(1, 2);
            f3 = f1.Multiply(f2);
            Assert.Equal(2, f3.Numerator);
            Assert.Equal(-12, f3.Denominator);

            f1 = new Fraction(8, 9);
            f2 = new Fraction(-4, 2);
            f3 = f1.Multiply(f2);
            Assert.Equal(-32, f3.Numerator);
            Assert.Equal(18, f3.Denominator);

            f1 = new Fraction(7, 4);
            f2 = new Fraction(6, -2);
            f3 = f1.Multiply(f2);
            Assert.Equal(42, f3.Numerator);
            Assert.Equal(-8, f3.Denominator);

            f1 = new Fraction(-5, 7);
            f2 = new Fraction(9, -1);
            f3 = f1.Multiply(f2);
            Assert.Equal(-45, f3.Numerator);
            Assert.Equal(-7, f3.Denominator);

            f1 = new Fraction(3, -5);
            f2 = new Fraction(-7, 10);
            f3 = f1.Multiply(f2);
            Assert.Equal(-21, f3.Numerator);
            Assert.Equal(-50, f3.Denominator);

            f1 = new Fraction(-1, 9);
            f2 = new Fraction(-3, 5);
            f3 = f1.Multiply(f2);
            Assert.Equal(3, f3.Numerator);
            Assert.Equal(45, f3.Denominator);

            f1 = new Fraction(6, -1);
            f2 = new Fraction(10, -3);
            f3 = f1.Multiply(f2);
            Assert.Equal(60, f3.Numerator);
            Assert.Equal(3, f3.Denominator);
        }

        [Fact]
        public void TestSubtract()
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
            Fraction f3 = f1.Subtract(f2);
            Assert.Equal(0, f3.Numerator);
            Assert.Equal(1, f3.Denominator);

            f1 = new Fraction(1, 2);
            f2 = new Fraction(5, 6);
            f3 = f1.Subtract(f2);
            Assert.Equal(-4, f3.Numerator);
            Assert.Equal(12, f3.Denominator);

            f1 = new Fraction(-4, 8);
            f2 = new Fraction(9, 5);
            f3 = f1.Subtract(f2);
            Assert.Equal(-92, f3.Numerator);
            Assert.Equal(40, f3.Denominator);

            f1 = new Fraction(2, -6);
            f2 = new Fraction(1, 2);
            f3 = f1.Subtract(f2);
            Assert.Equal(10, f3.Numerator);
            Assert.Equal(-12, f3.Denominator);

            f1 = new Fraction(8, 9);
            f2 = new Fraction(-4, 2);
            f3 = f1.Subtract(f2);
            Assert.Equal(52, f3.Numerator);
            Assert.Equal(18, f3.Denominator);

            f1 = new Fraction(7, 4);
            f2 = new Fraction(6, -2);
            f3 = f1.Subtract(f2);
            Assert.Equal(-38, f3.Numerator);
            Assert.Equal(-8, f3.Denominator);

            f1 = new Fraction(-5, 7);
            f2 = new Fraction(9, -1);
            f3 = f1.Subtract(f2);
            Assert.Equal(-58, f3.Numerator);
            Assert.Equal(-7, f3.Denominator);

            f1 = new Fraction(3, -5);
            f2 = new Fraction(-7, 10);
            f3 = f1.Subtract(f2);
            Assert.Equal(-5, f3.Numerator);
            Assert.Equal(-50, f3.Denominator);

            f1 = new Fraction(-1, 9);
            f2 = new Fraction(-3, 5);
            f3 = f1.Subtract(f2);
            Assert.Equal(22, f3.Numerator);
            Assert.Equal(45, f3.Denominator);

            f1 = new Fraction(6, -1);
            f2 = new Fraction(10, -3);
            f3 = f1.Subtract(f2);
            Assert.Equal(-8, f3.Numerator);
            Assert.Equal(3, f3.Denominator);
        }

        [Fact]
        public void TestDivide()
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
            Fraction f3 = f1.Divide(f2);
            Assert.Equal(1, f3.Numerator);
            Assert.Equal(1, f3.Denominator);

            f1 = new Fraction(1, 2);
            f2 = new Fraction(5, 6);
            f3 = f1.Divide(f2);
            Assert.Equal(6, f3.Numerator);
            Assert.Equal(10, f3.Denominator);

            f1 = new Fraction(-4, 8);
            f2 = new Fraction(9, 5);
            f3 = f1.Divide(f2);
            Assert.Equal(-20, f3.Numerator);
            Assert.Equal(72, f3.Denominator);

            f1 = new Fraction(2, -6);
            f2 = new Fraction(1, 2);
            f3 = f1.Divide(f2);
            Assert.Equal(4, f3.Numerator);
            Assert.Equal(-6, f3.Denominator);

            f1 = new Fraction(8, 9);
            f2 = new Fraction(-4, 2);
            f3 = f1.Divide(f2);
            Assert.Equal(16, f3.Numerator);
            Assert.Equal(-36, f3.Denominator);

            f1 = new Fraction(7, 4);
            f2 = new Fraction(6, -2);
            f3 = f1.Divide(f2);
            Assert.Equal(-14, f3.Numerator);
            Assert.Equal(24, f3.Denominator);

            f1 = new Fraction(-5, 7);
            f2 = new Fraction(9, -1);
            f3 = f1.Divide(f2);
            Assert.Equal(5, f3.Numerator);
            Assert.Equal(63, f3.Denominator);

            f1 = new Fraction(3, -5);
            f2 = new Fraction(-7, 10);
            f3 = f1.Divide(f2);
            Assert.Equal(30, f3.Numerator);
            Assert.Equal(35, f3.Denominator);

            f1 = new Fraction(-1, 9);
            f2 = new Fraction(-3, 5);
            f3 = f1.Divide(f2);
            Assert.Equal(-5, f3.Numerator);
            Assert.Equal(-27, f3.Denominator);

            f1 = new Fraction(6, -1);
            f2 = new Fraction(10, -3);
            f3 = f1.Divide(f2);
            Assert.Equal(-18, f3.Numerator);
            Assert.Equal(-10, f3.Denominator);
        }

        [Fact]
        public void TestReciprocal()
        {
            Fraction f1 = new Fraction();
            f1 = f1.Reciprocal();
            Assert.Equal(1, f1.Numerator);
            Assert.Equal(1, f1.Denominator);

            f1 = new Fraction(3,4);
            f1 = f1.Reciprocal();
            Assert.Equal(4, f1.Numerator);
            Assert.Equal(3, f1.Denominator);

            f1 = new Fraction(-9,4);
            f1 = f1.Reciprocal();
            Assert.Equal(4, f1.Numerator);
            Assert.Equal(-9, f1.Denominator);

            f1 = new Fraction(2,-4);
            f1 = f1.Reciprocal();
            Assert.Equal(-4, f1.Numerator);
            Assert.Equal(2, f1.Denominator);

            f1 = new Fraction(0,6);
            f1 = f1.Reciprocal();
            Assert.Equal(6, f1.Numerator);
            Assert.Equal(1, f1.Denominator);
        }

        [Fact]
        public void TestInvert()
        {
            Fraction f1 = new Fraction();
            f1 = f1.Invert();
            Assert.Equal(-1, f1.Numerator);
            Assert.Equal(1, f1.Denominator);

            f1 = new Fraction(6,8);
            f1 = f1.Invert();
            Assert.Equal(-6, f1.Numerator);
            Assert.Equal(8, f1.Denominator);

            f1 = new Fraction(-1, 2);
            f1 = f1.Invert();
            Assert.Equal(1, f1.Numerator);
            Assert.Equal(2, f1.Denominator);

            f1 = new Fraction(3, -6);
            f1 = f1.Invert();
            Assert.Equal(-3, f1.Numerator);
            Assert.Equal(-6, f1.Denominator);
        }

        [Fact]
        public void TestSimplify()
        {
            Fraction f1 = new Fraction();
            f1 = f1.Simplify();
            Assert.Equal(1, f1.Numerator);
            Assert.Equal(1, f1.Denominator);

            f1 = new Fraction(850, 550);
            f1 = f1.Simplify();
            Assert.Equal(17, f1.Numerator);
            Assert.Equal(11, f1.Denominator);

            f1 = new Fraction(-88, 14);
            f1 = f1.Simplify();
            Assert.Equal(-44, f1.Numerator);
            Assert.Equal(7, f1.Denominator);

            f1 = new Fraction(12, -92);
            f1 = f1.Simplify();
            Assert.Equal(-3, f1.Numerator);
            Assert.Equal(23, f1.Denominator);

            f1 = new Fraction(-69, -39);
            f1 = f1.Simplify();
            Assert.Equal(23, f1.Numerator);
            Assert.Equal(13, f1.Denominator);
        }
    }
}