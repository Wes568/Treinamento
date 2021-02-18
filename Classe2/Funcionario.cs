using System;
using System.Collections.Generic;
using System.Text;

namespace Classe2
{
    class Funcionario
    {
        public string Nome;
        public double Salario;

        public double MediaS(Funcionario A, Funcionario B)
        {
            double media = (A.Salario + B.Salario) / 2;
            return media;
        }

    }
}
