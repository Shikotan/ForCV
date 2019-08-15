using NUnit.Framework;
using Pchelin.SquareCalculator.Shapes;
using System;

namespace Pchelin.SquareCalculator.Tests
{
    public class TriangleTests
    {
        [Test]
        public void ConstructorOfTriangleShouldThrowExceptionWhenOneSideIsLongerOrEqualsThanSummOfOtherSides()
        {
            Assert.Throws(Is.TypeOf<ApplicationException>(), delegate { _ = new Triangle(2, 5, 8); });
        }

        [Test]
        public void ConstructorOfTriangleShouldCreateTriangleWithSidesTwoFiveAndFour()
        {
            var triangle = new Triangle(2, 5, 4);
            Assert.AreEqual(2, triangle.A);
            Assert.AreEqual(5, triangle.B);
            Assert.AreEqual(4, triangle.C);
        }

        [Test]
        public void ConstructRigthTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(true, triangle.IsRight);
        }

        [Test]
        public void ConstructNotRigthTriangle()
        {
            var triangle = new Triangle(3, 4, 7);
            Assert.AreEqual(false, triangle.IsRight);
        }
    }
}
