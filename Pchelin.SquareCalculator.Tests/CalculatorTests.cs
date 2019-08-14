using NUnit.Framework;
using System;
using Pchelin.SquareCalculator;
using Pchelin.SquareCalculator.Interfaces;

namespace Tests
{
    public class Tests
    {
        ICalculator squareCalulator;
        [SetUp]
        public void Setup()
        {
            squareCalulator = (ICalculator)new Calculator();
        }

        [Test]
        public void Test1()
        {
            Assert.Throws(Is.TypeOf<ArgumentNullException>(), delegate { squareCalulator.CalculateSquare(null); });
        }
    }
}