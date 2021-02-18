using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios listaF = new Funcionarios();

            Console.WriteLine("Quantos funcionários serão adicionados?");
            int qtdeFuncionarios = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtdeFuncionarios; i++)
            {
                Console.WriteLine("Funcionário #" +(i+1)+": ");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("NOME: ");
                string nome = Console.ReadLine();
                Console.Write("SALÁRIO: ");
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");

                Funcionario fun = new Funcionario(id, nome, salario);
                listaF.Adicionar(fun);
            }

            Console.WriteLine("Entre com o id do funcionário a ter aumento de salário: ");
            int id_aumento = int.Parse(Console.ReadLine());

            listaF.Pesquisar(id_aumento);

            listaF.Mostrar();

            Console.ReadKey();
        }
    }
}
