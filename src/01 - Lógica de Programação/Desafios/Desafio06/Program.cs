using System;
using System.Globalization;

namespace Desafio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe três valores de ponto flutuante: ");
            Console.Write("Valor A: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor B: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor C: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Área do Triângulo Retângulo - (base * altura) / 2
            double areaTrianguloRetangulo = (a * c) / 2;

            // Área do Círculo - π * raio²
            double areaCirculo = 3.14159 * Math.Pow(c, 2);

            // Área do Trapézio - ((base + base) * altura) / 2
            double areaTrapezio = ((a + b) * c) / 2;

            // Área do Quadrado - lado²
            double areaQuadrado = Math.Pow(b, 2);

            // Área do Retângulo - base * altura
            double areaRetangulo = a * b;

            Console.WriteLine($"\nTRIÂNGULO: {areaTrianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                $"CÍRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                $"TRAPÉZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                $"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                $"RETÂNGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
