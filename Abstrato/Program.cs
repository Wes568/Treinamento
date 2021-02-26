using System;
using System.Collections.Generic;
using System.Globalization;
using Abstrato.Entities;
using Abstrato.Entities.Enums;

namespace Abstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> lshape = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Shape #" + (i+1) + " data:" );
                Console.Write("Rectangle or Circle? (r/c): ");
                char shape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (shape == 'r')
                {
                    Console.Write("Width: ");
                    double wid = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double hei = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    lshape.Add(new Rectangle(hei, wid, color));
                } else if(shape == 'c')
                {
                    Console.Write("Radius: ");
                    double rad = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    lshape.Add(new Circle(rad, color));
                }

                if (i != num - 1)
                {
                    Console.WriteLine("---------------------------");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("SHAPE AREAS");
            foreach(Shape shap in lshape)
            {
                Console.WriteLine(shap.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
