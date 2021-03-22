using System;
using Heranca.Entities;
namespace Heranca {
    class Program {
        static void Main(string[] args) {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            
            /*Account acc = new Account(1001, "Alex", 0.0);
            Business_Account bacc = new Business_Account(1002, "MAria", 0.0, 500.0);

            Account acc1 = bacc;
            Account acc2 = new Business_Account(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            Business_Account acc4 = (Business_Account)acc2;
            acc4.Loan(100.0);
            if(acc3 is Business_Account) {
                Business_Account acc5 = (Business_Account)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            else if(acc3 is SavingsAccount) {
                SavingsAccount acc5 = acc3 as SavingsAccount;
                Console.WriteLine("Update!");
            }*/
        }
    }
}
