using System;
using System.Collections.Generic;
using System.Globalization;
using Heranca2.Entities;

namespace Heranca2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lfunc = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Employee #" + (i + 1) + " data:");
                Console.Write("Outsourced (Y/N)? ");
                char outs = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outs == 'y')
                {
                    Console.Write("Additional charge: ");
                    double add = double.Parse(Console.ReadLine());

                    Employee emp = new OutsourcedEmployee(name, hour, value, add);
                    lfunc.Add(emp);

                }
                else if (outs == 'n')
                {
                    Employee emp = new Employee(name, hour, value);
                    lfunc.Add(emp);

                }

                if (i != (num - 1))
                {
                    Console.WriteLine("-------------------------");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("PAYMENTS");

            foreach (Employee e in lfunc)
            {
                Console.WriteLine(e.Name + " - $" + e.Payment().ToString("N2", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
