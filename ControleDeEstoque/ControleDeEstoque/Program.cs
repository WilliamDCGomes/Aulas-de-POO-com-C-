using System;
using System.Globalization;
namespace ControleDeEstoque {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto();
            Console.Write("Entre os dados do produto:\nNome: ");
            p.Nome=Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDados do produto: "+p+"\n");
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nDados atualizados: "+p+"\n");
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nDados atualizados: "+p+"\n");
        }
    }
}