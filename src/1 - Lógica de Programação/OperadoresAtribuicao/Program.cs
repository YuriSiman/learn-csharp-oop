using System;

namespace OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 0;
            b += a++;

            Console.WriteLine($"a - {a}\nb - {b}");
        }
    }
}
