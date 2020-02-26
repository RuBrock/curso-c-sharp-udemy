using System;
using FixacaoEnumComp.Entities;
using FixacaoEnumComp.Entities.Enums;
using System.Globalization;

namespace FixacaoEnumComp {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime bday = DateTime.Parse(Console.ReadLine());
            Client c = new Client(name, email, bday);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            DateTime d = DateTime.Now;
            Order o = new Order(d, status, c);

            Console.Write("How many itens to this order? ");
            int q = int.Parse(Console.ReadLine());

            for(int i = 0; i < q; i++) {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product Name: ");
                string pName = Console.ReadLine();
                Console.Write("Product Price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product p = new Product(pName, pPrice);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem oi = new OrderItem(quantity, p);

                o.AddItem(oi);
            }

            Console.WriteLine();
            Console.WriteLine(o);

        }
    }
}
