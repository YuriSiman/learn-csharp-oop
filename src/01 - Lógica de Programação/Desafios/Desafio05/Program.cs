using System;
using System.Globalization;

namespace Desafio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as informações das peças\n");

            Console.Write("Código da peça X: ");
            int codigo1 = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de peças X: ");
            int qtd1 = int.Parse(Console.ReadLine());
            Console.Write("Valor de cada unidade da peça X em R$: ");
            double valor1 = double.Parse(Console.ReadLine());
            
            Console.Write("\nCódigo da peça Y: ");
            int codigo2 = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de peças Y: ");
            int qtd2 = int.Parse(Console.ReadLine());
            Console.Write("Valor de cada unidade da peça Y em R$: ");
            double valor2 = double.Parse(Console.ReadLine());

            double reultado = (qtd1 * valor1) + (qtd2 * valor2);

            Console.WriteLine($"\nValor a pagar: R$ {reultado:F2}");

        }
    }
}
