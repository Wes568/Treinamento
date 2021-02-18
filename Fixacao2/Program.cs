using System;

namespace Fixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospede[] hospedes = new Hospede[10];

            Console.WriteLine("Quantos quartos serão ocupados?");
            int quartos = int.Parse(Console.ReadLine());

            for(int i = 0; i < quartos; i++)
            {
                Console.WriteLine("---------------------");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());


                hospedes[quarto] = new Hospede(nome, email, quarto);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("Quartos alugados: ");
            for(int i =0; i<10;i++)
            {
                if (hospedes[i] != null)
                {
                    hospedes[i].Mostrar();
                }
            }


        }
    }
}
