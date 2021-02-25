using System;
using System.Globalization;
using System.Collections.Generic;
using Heranca3.Entities;

namespace Heranca3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> lprod = new List<Product>(); 

            Console.Write("Enter the number of products: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {

                Console.WriteLine("Product #" +(i+1) + ": ");
                Console.Write("Common, used or imported (C/U/I)? ");
                char opc = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (opc == 'i')
                {
                    Console.Write("Customs fee: ");
                    double cfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product prod = new ImportedProduct(name, price, cfee);

                    lprod.Add(prod);

                }else if (opc == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Product prod = new UsedProduct(name, price, date);

                    lprod.Add(prod);

                } else if(opc == 'c')
                {
                    Product prod = new Product(name, price);
                    lprod.Add(prod);
                }

                if(i!= num - 1)
                {
                    Console.WriteLine("----------------------");
                }

            }

            Console.WriteLine("");
            Console.WriteLine("PRICE TAGS");

            foreach(Product p in lprod)
            {
                Console.WriteLine(p.PriceTag());
            }

            Console.ReadKey();
        }
    }
}
