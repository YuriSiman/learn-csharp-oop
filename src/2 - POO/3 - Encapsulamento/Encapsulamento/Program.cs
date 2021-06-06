using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            Console.Write("Quantidade no Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

            Console.WriteLine("Digite outro nome para o produto: ");
            produto.Nome = Console.ReadLine();

            Console.WriteLine($"Dados do Produto: {produto}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados Atualizados: {produto}");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados Atualizados: {produto}");
        }
    }
}
