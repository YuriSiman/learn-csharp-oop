using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {






            //CultureInfo.InvariantCulture
            double saldo = 152.1225;
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));

            // Placeholders
            Console.WriteLine("O saldo é R$ {0}", saldo);

            // Interpolação
            Console.WriteLine($"O saldo é R$ {saldo}");

            // Concatenação
            Console.WriteLine("O saldo é R$ " + saldo);

        }
    }
}
