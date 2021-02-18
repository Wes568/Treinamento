using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Classe5
{
    class Funcionario
    {
        private string nome;
        private double salarioBruto;
        private double imposto;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double SalarioBruto
        {
            get { return salarioBruto; }
            set { salarioBruto = value; }
        }

        public double Imposto
        {
            get { return imposto; }
            set { imposto = value; }
        }

        public void Mostrar()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salario: R$" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("-----------------------");
        }

        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            salarioBruto += (salarioBruto / porcentagem);
        }
    }
}
