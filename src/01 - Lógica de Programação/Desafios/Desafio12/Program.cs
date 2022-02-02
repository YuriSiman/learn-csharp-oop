using System;
using System.Globalization;

namespace Desafio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número qualquer: ");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("\nFora de Intervalo!");
            }else if(numero <= 25.0)
            {
                Console.WriteLine("\nIntervalo [0,25]");
            }else if(numero <= 50.0)
            {
                Console.WriteLine("\nIntervalo [25,50]");
            }else if(numero <= 75.0)
            {
                Console.WriteLine("\nIntervalo [50,75]");
            }
            else
            {
                Console.WriteLine("\nIntervalo [75,100]");
            }
        }
    }
}
