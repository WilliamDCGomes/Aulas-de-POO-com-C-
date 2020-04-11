using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre os dados do produto:\nNome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            /*Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());*/

            Produto p = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.Write("Entre com o novo nome: ");
            //p.SetNome(Console.ReadLine());
            p.Nome="TV 4K";
            Console.WriteLine();
        }
    }
}