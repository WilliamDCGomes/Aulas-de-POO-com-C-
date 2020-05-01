using Exercicio_11.Entities;
using Exercicio_11.Entities.Enum;
using System;
using System.Globalization;
namespace Exercicio_11 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Client client = new Client(name, email, date);
            Order order = new Order(DateTime.Now,status, client);
            Console.Write("How many items to this order? ");
            int many = int.Parse(Console.ReadLine());
            for(int i = 0; i < many; i++) {
                Console.WriteLine("Enter " + (i+1) + " item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                OrderItem item = new OrderItem(quantity, productPrice, product);
                order.AddItem(item);
            }
            Console.WriteLine(order);
        }
    }
}
