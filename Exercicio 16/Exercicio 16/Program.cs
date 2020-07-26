using Exercicio_16.Entities;
using Exercicio_16.Service;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_16 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Contract contract = new Contract(number, date, amount);
            Console.Write("Enter number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());
            CalculationAmount calculationAmount = new CalculationAmount();
            List<Installment> installments = new List<Installment>();
            for (int i = 0; i < numberInstallments; i++) {
                installments.Add(calculationAmount.MakeContract(contract, i+1, numberInstallments));
            }
            Console.WriteLine("Installments:");
            foreach(Installment installment in installments) {
                Console.WriteLine(installment);
            }
        }
    }
}
