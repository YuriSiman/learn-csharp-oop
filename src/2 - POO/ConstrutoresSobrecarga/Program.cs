using System;
using System.Globalization;

namespace ConstrutoresSobrecarga
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

            // Sintaxe alternativa para inicializar valores 

            //Produto produto = new Produto
            //{
            //    Nome = nome,
            //    Preco = preco,
            //    Quantidade = quantidade
            //};

            Console.WriteLine($"Dados do Produto: {produto}");

            Console.Write("Digite a quantidade de produtos a ser adicionada ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados Atualizados: {produto}");

            Console.Write("Digite a quantidade de produtos a ser removida do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados Atualizados: {produto}");


            // Trabalhando com Construtor Privado

            // Não é possível criar uma instância de um construtor privado.
            // Suponhamos que nós queremos utilizar o Log para conectar em algum serviço externo (ou uma conexão com um banco de dados) e registrar os eventos que acontecem na sua aplicação. Dependendo da complexidade do sistema, será necessário
            // instanciar a classe Log várias vezes em métodos específicos para registrar os eventos, e isso é prejudicial para a sua aplicação. Então, nesse casos em que é necessário ter uma classe que passa por vários lugares, podemos utilizar 
            // um padrão de projeto chamado Sigleton, pois ele permite uma única instância da sua classe e ele reaproveita essa instância durante todo o ciclo de vida da sua aplicação. No nosso exemplo, chamaremos a Log em vários lugares, mas ele 
            // sera o mesmo objeto em todos os lugares que for chamado.

            Log log = Log.GetInstance();

            log.PropriedadeLog = "\n\nTrabalhando com Construtor Privado - Teste Instância";

            Log log2 = Log.GetInstance();

            Console.WriteLine(log2.PropriedadeLog);
        }
    }
}
