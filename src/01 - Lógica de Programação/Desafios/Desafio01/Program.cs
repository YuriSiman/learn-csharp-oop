using System;
using System.Globalization;

namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            double aX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double bX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double cX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            double aY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double bY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double cY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (aX + bX + cX) / 2;
            double areaX = Math.Sqrt(p * (p - aX) * (p - bX) * (p - cX));

            p = (aY + bY + cY) / 2;
            double areaY = Math.Sqrt(p * (p - aY) * (p - bY) * (p - cY));
            char maiorArea = areaX > areaY ? 'X' : 'Y';

            Console.WriteLine($"Área de X: {areaX.ToString("F4", CultureInfo.InvariantCulture)}\nÁrea de X: {areaY.ToString("F4", CultureInfo.InvariantCulture)}\nMaior Área: {maiorArea}");
        }
    }
}
