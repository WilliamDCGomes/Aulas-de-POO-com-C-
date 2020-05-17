using System;
using Exercicio_13.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio_13 {
    class Program {
        static void Main(string[] args) {
            List<TaxPayers> list = new List<TaxPayers>();
            Console.Write("Enter the number of tax payers: ");
            int numberOfTaxPayers = int.Parse(Console.ReadLine());
            for(int i = 0; i < numberOfTaxPayers; i++) {
                Console.WriteLine($"Tax payer #{i+1} data:");
                Console.Write("Individual or company (i/c)? ");
                char typeOfPayer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(typeOfPayer == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Person(name, anualIncome, healthExpenditures));
                }
                else if (typeOfPayer == 'c') {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(numberOfEmployees, name, anualIncome));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            TotalTaxes init = new TotalTaxes(0);
            foreach (TaxPayers t in list) {
                Console.WriteLine($"{t.Name}: $ {t.taxesPaid().ToString("F2",CultureInfo.InvariantCulture)}");
                init.Total(t.taxesPaid());
            }
            Console.WriteLine();
            Console.Write($"TOTAL TAXES: $ {init.ReturnTotal().ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
