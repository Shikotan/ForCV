using NUnit.Framework;
using System;
using Pchelin.SquareCalculator;
using Pchelin.SquareCalculator.Interfaces;
using Pchelin.SquareCalculator.Shapes;

namespace Pchelin.SquareCalculator.Tests
{
    public class CalculatorTests
    {
        ICalculator squareCalulator;

        [SetUp]
        public void Setup()
        {
            squareCalulator = (ICalculator)new Calculator();
        }

        [Test]
        public void CalculateSquareShouldThrowExceptionWhenShapeIsNull()
        {
            Assert.Throws(Is.TypeOf<ArgumentNullException>(), delegate { squareCalulator.CalculateSquare(null); });
        }

        [Test]
        public void CalculateSquareOfCircle()
        {
            var circle = new Circle(2);
            Assert.AreEqual(12.5664d, squareCalulator.CalculateSquare(circle));
        }

        [Test]
        public void CalculateSquareOfTriangle()
        {
            var triangle = new Triangle(2, 5, 6);
            Assert.AreEqual(4.6837d, squareCalulator.CalculateSquare(triangle));
        }

        [Test]
        public void CalculateSquareOfCircleWithTwoDigitsPrecision()
        {
            var circle = new Circle(2);
            Assert.AreEqual(12.57d, new Calculator(2).CalculateSquare(circle));
        }
    }
}