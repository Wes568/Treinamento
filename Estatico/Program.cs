using System;
using System.Globalization;

namespace Estatico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares você vai comprar?");
            double v = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.Conversao(cotacao, v).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
