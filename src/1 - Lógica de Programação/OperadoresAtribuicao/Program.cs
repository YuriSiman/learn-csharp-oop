using System;

namespace OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 0, c = 10, d = 0;
            b += a++;
            d += ++c;

            Console.WriteLine($"a - {a}\nb - {b}\nc - {c}\nd - {d}");
        }
    }
}
