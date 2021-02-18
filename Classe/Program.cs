using System;

namespace Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoaA = new Pessoa();
            Pessoa pessoaB = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            pessoaA.Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da primeira pessoa: ");
            pessoaA.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da outra pessoa: ");
            pessoaB.Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da outra pessoa: ");
            pessoaB.Idade = int.Parse(Console.ReadLine());

            Console.Write("Pessoa mais velha: ");
            Console.WriteLine(pessoaA.Maisvelha(pessoaA, pessoaB));
        }

    }
}
