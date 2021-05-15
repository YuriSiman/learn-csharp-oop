using System;

namespace EstruturaRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {

            double numero = 0;

            double result = ReceberValor(numero);

            while (result >= 0)
            {
                double raizQuadrada = Math.Sqrt(result);
                Console.WriteLine(raizQuadrada.ToString("F3"));

                result = ReceberValor(numero);
            }
            Console.WriteLine("Número negativo!");
        }

        static double ReceberValor(double numero)
        {
            Console.WriteLine("Digite um número:");
            numero = double.Parse(Console.ReadLine());
            return numero;
        }
    }
}
