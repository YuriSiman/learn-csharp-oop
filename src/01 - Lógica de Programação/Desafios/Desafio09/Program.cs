using System;

namespace Desafio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros\n");
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || ((a / b) * b == a) || ((b / a) * a == b))
            {
                Console.WriteLine("\nSão Múltiplos");
            }
            else
            {
                Console.WriteLine("\nNão são Múltiplos");
            }
        }
    }
}
