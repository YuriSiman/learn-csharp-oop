using System;

namespace Desafio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quatro valores inteiros");
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("C: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("D: ");
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b) - (c * d);
            Console.WriteLine($"Diferença = {diferenca}");
        }
    }
}
