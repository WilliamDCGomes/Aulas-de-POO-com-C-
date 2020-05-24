using Exercicio_14.Entities;
using Exercicio_14.Entities.Exception;
using System;
using System.Globalization;
namespace Exercicio_14 {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, holder, initialBalance, withdrawLimit);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdrawAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.WithDraw(withdrawAmount);
                Console.Write("Enter amount for deposit: ");
                double depositAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Deposit(depositAmount);
                Console.WriteLine(account);
            }
            catch (WithDrawException e) {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
        }
    }
}