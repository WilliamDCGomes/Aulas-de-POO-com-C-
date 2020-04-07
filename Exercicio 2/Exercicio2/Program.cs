using System;
using System.Globalization;
namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {
            Class1 classe = new Class1();
            Console.Write("Dados do primeiro funcionário:\nNome: ");
            classe.nome1 = Console.ReadLine();
            Console.Write("Salário: ");
            classe.sal1= float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Dados do segundo funcionário:\nNome: ");
            classe.nome2 = Console.ReadLine();
            Console.Write("Salário: ");
            classe.sal2 = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Salário médio = "+((classe.sal1+classe.sal2)/2).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
