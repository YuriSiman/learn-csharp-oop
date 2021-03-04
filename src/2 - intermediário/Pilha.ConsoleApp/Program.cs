using Pilha.ConsoleApp.Estrutura;
using System;

namespace Pilha.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pilha = new EstruturaPilha();

            Console.WriteLine("Empilhando os Itens\n");
            for (int i = 1; i < 4; i++)
            {
                Console.Write($"Informe o {i}º item: ");
                var item = Console.ReadLine();
                pilha.Empilha(item);
            }

            Console.WriteLine("\nDesempilhando os Itens\n");
            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine($"{i}º item desempilhado: " + pilha.Desempilha());
            }
        }
    }
}
