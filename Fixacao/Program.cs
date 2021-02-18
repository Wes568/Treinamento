using System;

namespace Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o número da conta: ");
            int nconta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (S/N)?");
            char resp = char.Parse(Console.ReadLine());

            ContaBancaria conta = new ContaBancaria(nconta, titular);

            if (resp == 'S'||resp == 's')
            {
                Console.WriteLine("Digite o valor de depósito inicial: ");
                double val = double.Parse(Console.ReadLine());

                conta.Depositar(val);
            }

            conta.Mostrar();

            Console.WriteLine("Digite o valor do depósito: ");
            double val2 = double.Parse(Console.ReadLine());

            conta.Depositar(val2);
            conta.Mostrar();

            Console.WriteLine("Digite o valor do saque: ");
            val2 = double.Parse(Console.ReadLine());

            conta.Sacar(val2);
            conta.Mostrar();
        }
    }
}
