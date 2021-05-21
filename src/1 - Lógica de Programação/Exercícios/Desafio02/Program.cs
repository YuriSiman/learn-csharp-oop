using System;
using System.Globalization;

namespace Desafio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inform o diâmetro de um círculo: ");
            double diametro = double.Parse(Console.ReadLine());

            double raio = diametro / 2;
            double pi = 3.14159;
            double area = pi * (Math.Pow(raio, 2));

            Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
