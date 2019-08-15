using System;
using Pchelin.SquareCalculator.Interfaces;

namespace Pchelin.SquareCalculator
{
    public class Calculator : ICalculator
    {
        public int Precision { get; private set; }

        public Calculator(int precision = 4)
        {
            Precision = precision;
        }

        public double CalculateSquare(IShape shape)
        {
            if (shape == null)
            {
                throw new ArgumentNullException(nameof(shape));
            }

            return Math.Round(shape.GetSquare(), Precision);
        }
    }
}
