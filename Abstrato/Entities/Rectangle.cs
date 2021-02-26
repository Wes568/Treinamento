using Abstrato.Entities;
using Abstrato.Entities.Enums;

namespace Abstrato.Entities
{
    class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Weight { get; set; }

        public Rectangle()
        { 
        }

        public Rectangle(double height, double weight, Color color):base(color)
        {
            Height = height;
            Weight = weight;
        }

        public override double Area()
        {
            return Height * Weight;
        }
    }
}
