using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_12.Entities;
namespace Exercicio_12 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of products: ");
            int manyProducts = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();
            for(int i = 0; i < manyProducts; i++) {
                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeOfProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(typeOfProduct == 'c') {
                    list.Add(new Product(name, price));
                }
                else if(typeOfProduct == 'u') {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product p in list) {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
