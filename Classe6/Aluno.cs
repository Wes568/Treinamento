using System;
using System.Collections.Generic;
using System.Text;

namespace Classe6
{
    class Aluno
    {
        private string nome;
        private double[] notas = new double[3];
        private bool aprovado;

        public string Nome
        {
            get { return nome; }
            set { nome = value;  }
        }

        public  double[] Notas
        {
            get { return notas; }
            set { notas = value; }
        }

        public void Mostrar()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Nota final: " + Soma());
            Console.WriteLine("Situação: " + (Situacao()?"Aprovado":"Reprovado"));
            if (aprovado == false)
            {
                Console.WriteLine("Faltaram: " + Falta() + " pontos...");
            }
            Console.WriteLine("-------------------------------");
        }

        public bool Situacao()
        {
            double soma = 0;

            for(int i=0;i<3;i++)
            {
                soma += notas[i];
            }

            if(soma>=60)
            {
                aprovado = true;
                return true;
            }
            else
            {
                aprovado = false;
                return false;
            }

        }
        public double Soma()
        {
            double soma = 0;

            for (int i = 0; i < 3; i++)
            {
                soma += notas[i];
            }

            return soma;
        }

        public double Falta()
        {
            double soma = 0;
            double falta;

            for (int i = 0; i < 3; i++)
            {
                soma += notas[i];
            }

            return falta = 60 - soma;
        }

    }
}
