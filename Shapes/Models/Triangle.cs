using System;
using Shapes.Interfaces;

namespace Shapes.Models
{
    public class Triangle : IShape
    {
        private readonly double _sideB;
        private readonly double _sideC;
        private readonly double _sideA;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double GetArea()
        {
            var p = (_sideA + _sideB + _sideC) / 2;
            return Math.Round(Math.Sqrt(Math.Abs(p * (p - _sideA) * (p - _sideB) * (p - _sideC))), 2);
        }

        public bool IsRight()
        {
            return Math.Pow(_sideA, 2) == Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2) ||
                   Math.Pow(_sideB, 2) == Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2) ||
                   Math.Pow(_sideC, 2) == Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2);
        }
    }
}