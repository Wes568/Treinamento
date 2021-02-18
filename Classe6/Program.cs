using System;

namespace Classe6
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite a nota do primeiro trimestre: ");
            aluno.Notas[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do segundo trimestre: ");
            aluno.Notas[1] = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do terceiro trimestre: ");
            aluno.Notas[2] = double.Parse(Console.ReadLine());

            aluno.Mostrar();
       

        }
    }
}
