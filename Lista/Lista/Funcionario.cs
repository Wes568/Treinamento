using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(int _id, string _nome, double _salario)
        {
            Id = _id;
            Nome = _nome;
            Salario = _salario;
        }

        public void aumentaSalario(double porcentagem)
        {
            Salario += Salario * (porcentagem/100);
        }
    }
}
