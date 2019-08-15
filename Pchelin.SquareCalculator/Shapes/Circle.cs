using System;
using Pchelin.SquareCalculator.Interfaces;

namespace Pchelin.SquareCalculator.Shapes
{
    public class Circle : IShape
    {
        public uint Radius { get; private set; }
        /// <summary>
        /// Создание круга с заданным радиусом.
        /// </summary>
        /// <param name="radius">Радиус круга в мм.</param>
        public Circle(uint radius)
        {
            if (radius == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius), "Радиус круга должен быть больше 0");
            }
            Radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
