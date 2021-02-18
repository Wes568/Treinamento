using System;

namespace Classe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo... ");
            Console.Write("Largura: ");
            retangulo.Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine());

            retangulo.Mostrar();
        }
    }
}
