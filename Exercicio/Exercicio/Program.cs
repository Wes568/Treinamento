using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 10.Receba dois números, o primeiro deve ser maior que 10 e menor que 25, o segundo
            deve ser maior ou igual a zero, o terceiro deve ser a soma dos dois primeiros e o quarto
            é o produto dos três números anteriores. Calcule e exiba a soma dos quadrados de cada
            um dos quatro números. Caso o resultado seja menor que 50000, solicite novos dados.*/

            int num1 = 0, num2 = 0;
            int aux = 1;

            while (aux == 1)
            {
                int aux2 = 1;
                while (aux2 == 1)
                {
                    Console.WriteLine("Digite dois números: ");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());

                    if ((num1 > 10 && num1 < 25) && (num2 >= 0))
                    {
                        aux2 = 2;
                    }
                    else
                    {
                        Console.WriteLine("Números inválidos.");
                        Console.WriteLine("O primeiro deve ser maior que 10 e menor que 25. O segundo " +
                        "deve ser maior ou igual a zero.");
                        Console.WriteLine("Tente novamente...");
                        aux2 = 1;
                    }
                }

                int num3 = num1 + num2;
                int num4 = num1 * num2 * num3;

                double somaQ = Math.Pow(num1, 2) + Math.Pow(num2, 2) + Math.Pow(num3, 2) + Math.Pow(num4, 2);

                if(somaQ<50000)
                {
                    Console.WriteLine("A soma dos quadrados, " + somaQ + ", é menor que 50.000, digite os dados novamente!");
                    aux = 1;
                }
                else
                {
                    Console.WriteLine("Soma dos quadrados: " + somaQ);
                    aux = 2;
                }
            }
            Console.ReadKey();


        }
    }
}
