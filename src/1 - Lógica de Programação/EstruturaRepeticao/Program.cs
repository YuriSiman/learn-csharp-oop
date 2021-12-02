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
                Console.WriteLine("[while] Digite um número: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Repete [while]");
            }

            // Estrutura de Repetição [ Do - While ]
            do
            {
                Console.WriteLine("[do-while] Digite um número: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Repete [do-while]");
            } while (numero >= 0);

            // Estrutura de Repetição [ For ]
            Console.WriteLine("Digite a quantidade de números que serão somados:");
            int qtd = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"Digite o {i+1}º número:");
                soma += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Soma total: {soma}");
        }
    }
}
