using System;
using System.Globalization;

namespace Classe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionarioA = new Funcionario();
            Funcionario funcionarioB = new Funcionario();

            Console.WriteLine("Digite o nome do primeiro funcionario: ");
            funcionarioA.Nome = Console.ReadLine();

            Console.WriteLine("Digite o salario do primeiro funcionario: ");
            funcionarioA.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do outro funcionario: ");
            funcionarioB.Nome = Console.ReadLine();

            Console.WriteLine("Digite o salario do outro funcionario: ");
            funcionarioB.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Media salarial: R$ " + funcionarioA.MediaS(funcionarioA, funcionarioB).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
