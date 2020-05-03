using System;
using Heranca.Entities;
namespace Heranca {
    class Program {
        static void Main(string[] args) {
            Business_Account account = new Business_Account(8010, "Bob Brown", 100.0, 500.0);
            Console.WriteLine(account.Balance);
            //account.Balance = 600.0;
        }
    }
}
