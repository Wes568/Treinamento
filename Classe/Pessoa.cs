using System;
using System.Collections.Generic;
using System.Text;

namespace Classe
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Maisvelha(Pessoa A, Pessoa B)
        {
            Pessoa MVelha = new Pessoa();

            if (A.Idade > B.Idade)
            {
                MVelha = A;
                return A.Nome;
            }
            else
            {
                MVelha = B;
                return B.Nome;
            }

        }
    }
}
