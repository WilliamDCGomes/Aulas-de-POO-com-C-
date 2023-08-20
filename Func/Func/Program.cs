using Actions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Func
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

            Func<Product, string> func = NameUpper;

            List<string> result = list.Select(func).ToList();
            result.ForEach(ShowResult);
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

        static void ShowResult(string name)
        {
            Console.WriteLine(name);
        }
    }
}
