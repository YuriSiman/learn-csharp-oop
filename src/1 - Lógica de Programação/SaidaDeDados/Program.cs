using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador", produto2 = "Mesa de escritório";
            double preco1 = 2100.00, preco2 = 650.50;
            int idade = 30, codigo = 5290;
            char genero = 'M';
            double medida = 53.23456700;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é R$ {preco1.ToString("F2")}");
            Console.WriteLine($"{produto2}, cujo preço é R$ {preco2.ToString("F2")}\n");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}\n");
            Console.WriteLine($"Medida com oito casas decimais: {medida.ToString("F8")}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida.ToString("F3")}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
