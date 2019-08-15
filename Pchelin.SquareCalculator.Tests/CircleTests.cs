using NUnit.Framework;
using Pchelin.SquareCalculator.Shapes;
using System;

namespace Pchelin.SquareCalculator.Tests
{

    public class CircleTests
    {
        [Test]
        public void ConstructorOfCircleShouldThrowExceptionWhenRadiusIsZero()
        {
            Assert.Throws(Is.TypeOf<ArgumentOutOfRangeException>(), delegate { _ = new Circle(0); });
        }

        [Test]
        public void ConstructorOfCircleShouldCreateCircleWithRadiusTwo()
        {
            Assert.AreEqual(2, new Circle(2).Radius);
        }
    }
}
