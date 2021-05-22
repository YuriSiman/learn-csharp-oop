using System;

namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe dois valores inteiros\nPrimeiro Valor: ");
            int primeiroValor = int.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            int segundoValor = int.Parse(Console.ReadLine());

            int soma = primeiroValor + segundoValor;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}
