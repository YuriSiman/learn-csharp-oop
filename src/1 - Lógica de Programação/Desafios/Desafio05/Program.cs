using System;
using System.Globalization;

namespace Desafio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as informações das peças");

            Console.Write("Código da peça 1: ");
            int codigo1 = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de peças 1: ");
            int qtd1 = int.Parse(Console.ReadLine());
            Console.Write("Valor de cada unidade da peça 1 em R$: ");
            double valor1 = double.Parse(Console.ReadLine());
            
            Console.Write("Código da peça 2: ");
            int codigo2 = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de peças 2: ");
            int qtd2 = int.Parse(Console.ReadLine());
            Console.Write("Valor de cada unidade da peça 2 em R$: ");
            double valor2 = double.Parse(Console.ReadLine());

            double reultado = (qtd1 * valor1) + (qtd2 * valor2);

            Console.WriteLine($"Valor a pagar: R$ {reultado:F2}");

        }
    }
}
