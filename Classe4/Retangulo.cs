using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Classe4
{
    class Retangulo
    {
        private double largura;
        private double altura;

        public double Largura
        {
            get { return largura; }
            set { largura = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public void Mostrar()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Area: " + Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("----------------------");
        }

        public double Area()
        {
            return Altura*Largura;
        }

        public double Perimetro()
        {
            return (Altura+ Largura)*2;
        }

        public double Diagonal()
        {    
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }

    }
}
