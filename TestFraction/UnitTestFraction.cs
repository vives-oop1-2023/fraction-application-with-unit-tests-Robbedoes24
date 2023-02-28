using Fractions;

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
        public void TestInitConstructor()
        {
            Fraction f1 = new Fraction();
            Assert.Equal();
            Assert.Equal();

            f1 = new Fraction();
            Assert.Equal();
            Assert.Equal();

            f1 = new Fraction();
            Assert.Equal();
            Assert.Equal();

            f1 = new Fraction();
            Assert.Equal();
            Assert.Equal();
        }

        [Fact]
        public void TestNumeratorProperty()
        {
            Fraction fraction = new Fraction();

            fraction.Numerator = 1;
            Assert.Equal(1, fraction.Numerator);
        }

        [Fact]
        public void TestDenominatorProperty()
        {

        }


        [Fact]
        public void TestToString()
        {

        }

        [Fact] 
        public void TestEquals()
        {

        }

        [Fact]
        public void TestResult()
        {
            Fraction f1 = new Fraction();
            Assert.Equal(1, f1.Result());

            f1 = new Fraction();
            Assert.Equal(1, f1.Result());


        }

        [Fact]
        public void TestAdd()
        {

        }

        [Fact]
        public void TestMultiply() 
        {

        }

        [Fact]
        public void TestSubtract()
        {

        }

        [Fact]
        public void TestDivide()
        {

        }

        [Fact]
        public void TestReciprocal()
        {

        }

        [Fact]
        public void TestInvert()
        {

        }

        [Fact]
        public void TestSimplify()
        {

        }
    }
}