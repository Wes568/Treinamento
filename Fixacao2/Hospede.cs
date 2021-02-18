using System;
using System.Collections.Generic;
using System.Text;

namespace Fixacao2
{
    class Hospede
    {
        private string Nome { get; set; }
        private string Email { get; set; }
        private int Quarto { get; set; }

        public Hospede(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }
        public void Mostrar()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Email: "+ Email);
            Console.WriteLine("Quarto:" + Quarto );
            Console.WriteLine("---------------------");
        }
    }
}
