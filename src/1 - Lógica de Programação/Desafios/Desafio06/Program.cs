using System;
using System.Globalization;

namespace Desafio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe três falores de ponto flutuante: ");
            Console.Write("Valor A: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor B: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor C: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaTrianguloRetangulo = (a * c) / 2;
            double areaCirculo = 3.14159 * Math.Pow(c, 2);
            double areaTrapezio = ((a + b) / 2) * c;
            double areaQuadrado = Math.Pow(b, 2);
            double areaRetangulo = a * b;

            Console.WriteLine($"TRIÂNGULO: {areaTrianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                $"CÍRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                $"TRAPÉZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                $"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                $"RETÂNGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
