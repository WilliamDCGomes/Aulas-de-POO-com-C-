using Actions.Entities;
using System;
using System.Collections.Generic;

namespace Actions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product> 
            {
                new Product("Tv", 900.00),
                new Product("Mouse", 50.00),
                new Product("Tablet", 350.50),
                new Product("HD Case", 80.90)
            };

            list.ForEach(UpdatePrice);
            list.ForEach(ShowProductPrice);
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * .1;
        }

        static void ShowProductPrice(Product p)
        {
            Console.WriteLine(p.ToString());
        }
    }
}
