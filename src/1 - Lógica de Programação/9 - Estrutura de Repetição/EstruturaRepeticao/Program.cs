using System;

namespace EstruturaRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero = 1;

            while (numero > 0)
            {
                Console.WriteLine("Digite um número:");
                numero = int.Parse(Console.ReadLine());

                if(numero < 0)
                {
                    Console.WriteLine("Número negativo!");
                }
                else
                {
                    double raizQuadrada = Math.Sqrt(numero);
                    Console.WriteLine(raizQuadrada.ToString("F3"));
                }
            }
        }
    }
}
