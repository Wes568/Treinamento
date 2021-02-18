using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Classe3
{
    class Produto
    {
        private string nome;
        private double preco;
        private int quantidade;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public double ValorTotalEmEstoque()
        {
            return preco * quantidade;
        }

        public void AdicionarProdutos(int quantity)
        {
            quantidade += quantity;
        }
        public void RemoverProdutos(int quantity)
        {
            quantidade -= quantity;
        }

        public void MostraProduto()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Nome : " + Nome);
            Console.WriteLine("Preco : " + Preco);
            Console.WriteLine("Quantidade : " + Quantidade);
            Console.WriteLine("Total : " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("----------------------");
        }
    }
}
