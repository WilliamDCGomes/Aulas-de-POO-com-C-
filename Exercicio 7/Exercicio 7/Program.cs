using System;
using System.Globalization;
namespace Exercicio_7 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre o número da conta: ");
            int num_conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o títular da conta: ");
            string titular_conta = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char verif_depo_ini = char.Parse(Console.ReadLine());
            double dep_ini=0.00;
            if(verif_depo_ini == 's' || verif_depo_ini == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                dep_ini = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            Conta c = new Conta(num_conta, titular_conta, dep_ini);
            Console.WriteLine("\n\nDados da conta:\n" + c+"\n");
            Console.Write("\nEntre um valor para depósito: ");
            c.Depositar(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c+"\n");
            Console.Write("\nEntre um valor para saque: ");
            c.Sacar(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
        }
    }
}
