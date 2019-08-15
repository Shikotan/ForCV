using System;
using System.Linq;
using Pchelin.SquareCalculator.Interfaces;

namespace Pchelin.SquareCalculator.Shapes
{
    public class Triangle : IShape
    {
        public uint A { get; private set; }
        public uint B { get; private set; }
        public uint C { get; private set; }

 
        /// <summary>
        /// True, если треугольник - прямоугольный.
        /// </summary>
        public bool IsRight { get; private set; }

        /// <summary>
        /// Создание трегугольника по трем сторонам
        /// </summary>
        /// <param name="a">Сторона A в мм.</param>
        /// <param name="b">Сторона B в мм.</param>
        /// <param name="c">Сторона C в мм.</param>
        public Triangle(uint a, uint b, uint c)
        {
            A = a;
            B = b;
            C = c;

            if (!CheckCanExists(A, B, C))
            {
                throw new ApplicationException($"Одна из сторон треугольника больше суммы двух других его сторон. Треугольник с длинами сторон {A}, {B}, {C} не существует.");
            }

            IsRight = CheckIsRight(A, B, C);
        }

        public double GetSquare()
        {
            var halfP = (A + B + C) / 2.0;

            return Math.Sqrt(halfP * (halfP - A) * (halfP - B) * (halfP - C));
        }

        private static bool CheckCanExists(uint a, uint b, uint c)
        {
            var sides = new uint[3] { a, b, c };
            sides = sides.OrderBy(x => x).ToArray();
            return sides[2] <= sides[0] + sides[1];
        }

        private static bool CheckIsRight(uint a, uint b, uint c)
        {
            var sides = new uint[3] { a, b, c };
            sides = sides.OrderBy(x => x).ToArray();

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
