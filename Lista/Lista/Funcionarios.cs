using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Funcionarios
    {
        List<Funcionario> funcionario = new List<Funcionario>();

        public void Adicionar(Funcionario func)
        {
            funcionario.Add(func);
        }

        public void Pesquisar(int id)
        {
            foreach (Funcionario _fun in funcionario)
            {
                if (_fun.Id == id)
                {
                    Console.Write("Entre com a porcentagem: ");
                    double porc = double.Parse(Console.ReadLine());

                    _fun.aumentaSalario(porc);
                }
                else
                {
                    Console.WriteLine("Este ID não existe!");
                }
            }
        }

        public void Mostrar()
        {
            foreach(Funcionario f in funcionario)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("ID:" + f.Id);
                Console.WriteLine("NOME:" + f.Nome);
                Console.WriteLine("SALÁRIO:" + f.Salario);
                Console.WriteLine("--------------------------");
            }
        }
    }
}
