using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Fixacao
{
    class ContaBancaria
    {
        private int Nconta { get; set; }
        private string Titular { get; set; }
        private double Saldo { get; set; }

        public ContaBancaria()
        { 
        }

        public ContaBancaria(int nc, string tit)
        {
            Nconta = nc;
            Titular = tit;
        }

        public void Mostrar()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Conta: " + Nconta);
            Console.WriteLine("Titular: " + Titular);
            Console.WriteLine("Saldo: R$ "+ Saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("-------------------------");
        }

        public void Depositar (double valor)
        {
            Saldo += valor;
        }

        public void Sacar (double valor)
        {
            Saldo = (Saldo - valor)-5;
        }
    }
}
