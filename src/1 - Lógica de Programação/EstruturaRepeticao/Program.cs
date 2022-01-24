using System;

namespace EstruturaRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero = 0;

            // Estrutura de Repetição [ While ]
            while (numero >= 0)
            {
                Console.WriteLine("\n[while] Digite um número: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Repete [while]");
            }

            // Estrutura de Repetição [ Do - While ]
            do
            {
                Console.WriteLine("\n[do-while] Digite um número: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Repete [do-while]");
            } while (numero >= 0);

            // Estrutura de Repetição [ For ]
            Console.WriteLine("\nDigite a quantidade de números que serão somados:");
            int qtd = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"Digite o {i+1}º número:");
                soma += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Soma total: {soma}\n");

            // Sintaxe opcional e simplificada para percorrer coleções [ For Each ]
            string[] nomes = new string[] { "João", "Maria", "Eduardo", "Mônica" };

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
