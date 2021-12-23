using System;

namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            double aX = double.Parse(Console.ReadLine());
            double bX = double.Parse(Console.ReadLine());
            double cX = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            double aY = double.Parse(Console.ReadLine());
            double bY = double.Parse(Console.ReadLine());
            double cY = double.Parse(Console.ReadLine());

            double pX = (aX + bX + cX) / 2;
            double pY = (aY + bY + cY) / 2;
            double areaX = Math.Sqrt(pX * (pX - aX) * (pX - bX) * (pX - cX));
            double areaY = Math.Sqrt(pY * (pY - aY) * (pY - bY) * (pY - cY));
            char maiorArea = areaX > areaY ? 'X' : 'Y';

            Console.WriteLine($"Área de X: {areaX:F4}\nÁrea de X: {areaY:F4}\nMaior Área: {maiorArea}");
        }
    }
}
