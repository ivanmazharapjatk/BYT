using BYT_PartTwo;
using NUnit.Framework;

namespace BYT_PartTwo_Tests
{
    public class CalculatorTests
    {
        [Test]
        public void AdditionTest()
        {
            Calculator calc = new Calculator(5, 3, '+');
            Assert.That(calc.Compute(), Is.EqualTo(8));
        }

        [Test]
        public void DivisionTest()
        {
            Calculator calc = new Calculator(20, 5, '/');
            Assert.That(calc.Compute(), Is.EqualTo(4));
        }
        
        [Test]
        public void SubtractionTest()
        {
            Calculator calc = new Calculator(10, 4, '-');
            Assert.That(calc.Compute(), Is.EqualTo(6));
        }

        [Test]
        public void MultiplicationTest()
        {
            Calculator calc = new Calculator(3, 6, '*');
            Assert.That(calc.Compute(), Is.EqualTo(18));
        }

        [Test]
        public void DivisionByZeroThrows()
        {
            Calculator calc = new Calculator(5, 0, '/');
            Assert.Throws<DivideByZeroException>(() => calc.Compute());
        }

        [Test]
        public void InvalidOperatorThrows()
        {
            Calculator calc = new Calculator(5, 5, '%');
            Assert.Throws<InvalidOperationException>(() => calc.Compute());
        }

        [Test]
        public void NegativeNumberOperationTest()
        {
            Calculator calc = new Calculator(-4, -2, '+');
            Assert.That(calc.Compute(), Is.EqualTo(-6));
        }

        [Test]
        public void DecimalCalculationTest()
        {
            Calculator calc = new Calculator(5.5, 2.2, '+');
            Assert.That(calc.Compute(), Is.EqualTo(7.7).Within(0.0001));
        }

        [Test]
        public void MultiplyingByZeroReturnsZero()
        {
            Calculator calc = new Calculator(10, 0, '*');
            Assert.That(calc.Compute(), Is.EqualTo(0));
        }

        [Test]
        public void LargeValuesWork()
        {
            Calculator calc = new Calculator(1000000, 1000000, '+');
            Assert.That(calc.Compute(), Is.EqualTo(2000000));
        }
    }
}
