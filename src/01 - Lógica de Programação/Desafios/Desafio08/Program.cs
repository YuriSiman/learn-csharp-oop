using System;

namespace Desafio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("\nPAR");
            }
            else
            {
                Console.WriteLine("\nÍMPAR");
            }
        }
    }
}
