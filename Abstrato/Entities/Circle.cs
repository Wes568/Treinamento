using Abstrato.Entities.Enums;
using Abstrato.Entities;
using System;

namespace Abstrato.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color):base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
