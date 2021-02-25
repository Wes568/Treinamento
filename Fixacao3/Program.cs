using System;
using Fixacao3.Entities.Enums;
using Fixacao3.Entities;
using System.Globalization;

namespace Fixacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, date);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int many = int.Parse(Console.ReadLine());

            for(int i=0;i<many;i++)
            {
                Console.WriteLine("Enter #" +(i+1)+" item data: ");
                Console.Write("Product name: ");
                string name2 = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qty = int.Parse(Console.ReadLine());

                Product product = new Product(name2, price);
                OrderItem ordemItem = new OrderItem(qty, price, product);
                order.Additem(ordemItem);

                if (i != many - 1)
                {
                    Console.WriteLine("----------------------------------");
                }

                Console.WriteLine("");
                Console.WriteLine("Order Summary: ");

                Console.WriteLine(order);
            }

        }
    }
}
