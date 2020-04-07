using System;
namespace Exercicio1 {
    class Program {
        static void Main(string[] args) {
            Class1 classe = new Class1();
            Console.Write("Dados da primeira pessoa:\nNome: ");
            classe.nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            classe.idade1 = int.Parse(Console.ReadLine());
            Console.Write("Dados da segunda pessoa:\nNome: ");
            classe.nome2=Console.ReadLine();
            Console.Write("Idade: ");
            classe.idade2 = int.Parse(Console.ReadLine());
            Console.Write("Pessoa mais velha: ");
            if (classe.idade1 > classe.idade2) {
                Console.WriteLine(classe.nome1);
            }
            else if (classe.idade2 > classe.idade1) {
                Console.WriteLine(classe.nome2);
            }
            else {
                Console.WriteLine(classe.nome1+" e "+classe.nome2+" tem a mesma idade!");
            }
        }
    }
}
