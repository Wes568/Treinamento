using Abstrato2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Abstrato2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> lcontri = new List<Contribuinte>();

            Console.Write("Entre com o número de contribuintes: ");
            int num = int.Parse(Console.ReadLine());

            for(int i=0;i<num;i++)
            {
                Console.WriteLine("Contribuinte #" + (i+1) + ": ");
                Console.Write("Pessoa Fisica ou Juridica (f/j)? ");
                char pes = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (pes == 'f')
                {
                    Console.Write("Gasto com saúde: ");
                    double saude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    lcontri.Add(new PessoaFisica(nome, rendaAnual, saude));
                }else if(pes == 'j')
                {
                    Console.Write("Número de funcionários: ");
                    int funci = int.Parse(Console.ReadLine());

                    lcontri.Add(new PessoaJuridica(nome, rendaAnual, funci));
                }

                if (i != num - 1)
                {
                    Console.WriteLine("-------------------------");

                }
            }

            Console.WriteLine("");
            Console.WriteLine("IMPOSTOS PAGOS:");
            
            foreach(Contribuinte con in lcontri)
            {
                Console.WriteLine(con.Nome + ": $ " + con.Imposto().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("");
            Console.Write("TOTAL IMPOSTOS: ");

            double soma =0;

            foreach(Contribuinte con in lcontri)
            {
                soma += con.Imposto();
            }

            Console.WriteLine("$ " + soma);
        }
    }
}
