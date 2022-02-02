using System;

namespace Desafio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero < 0)
            {
                Console.WriteLine("\nNEGATIVO");
            }
            else
            {
                Console.WriteLine("\nNÃO NEGATIVO");
            }
        }
    }
}
