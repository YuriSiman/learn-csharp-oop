using System;

namespace TipoDeDados.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quais são os valores máximos e mínimos dos tipos abaixo:\n" +
                "sbyte\nshort\nint\nlong\nbyte\nushort\nuint\nulong\nfloat\ndouble\ndecimal");

            Console.WriteLine("Valor máximo do sbyte: {0}", sbyte.MaxValue);
            Console.WriteLine("Valor mínimo do sbyte: {0}", sbyte.MinValue);
            Console.WriteLine();
            Console.WriteLine("Valor máximo do short: {0}", short.MaxValue);
            Console.WriteLine("Valor mínimo do short: {0}", short.MinValue);
            Console.WriteLine();
            Console.WriteLine("Valor máximo do int: {0}", int.MaxValue);
            Console.WriteLine("Valor mínimo do int: {0}", int.MinValue);
            Console.WriteLine();
            Console.WriteLine("Valor máximo do long: {0}", long.MaxValue);
            Console.WriteLine("Valor mínimo do long: {0}", long.MinValue);
            Console.WriteLine();
            Console.WriteLine("Valor máximo do byte: {0}", byte.MaxValue);
            Console.WriteLine("Valor mínimo do byte: {0}", byte.MinValue);
            Console.WriteLine();
            Console.WriteLine("Valor máximo do ushort: {0}", ushort.MaxValue);
            Console.WriteLine("Valor mínimo do ushort: {0}", ushort.MinValue);
            Console.WriteLine();
            Console.WriteLine("Valor máximo do uint: {0}", uint.MaxValue);
            Console.WriteLine("Valor mínimo do uint: {0}", uint.MinValue);
            Console.WriteLine();
            Console.WriteLine("Valor máximo do ulong: {0}", ulong.MaxValue);
            Console.WriteLine("Valor mínimo do ulong: {0}", ulong.MinValue);
            Console.WriteLine();
            Console.WriteLine("Valor máximo do float: {0}", float.MaxValue);
            Console.WriteLine("Valor mínimo do float: {0}", float.MinValue);
            Console.WriteLine();
            Console.WriteLine("Valor máximo do double: {0}", double.MaxValue);
            Console.WriteLine("Valor mínimo do double: {0}", double.MinValue);
            Console.WriteLine();
            Console.WriteLine("Valor máximo do decimal: {0}", decimal.MaxValue);
            Console.WriteLine("Valor mínimo do decimal: {0}", decimal.MinValue);
            Console.WriteLine();
        }
    }
}
