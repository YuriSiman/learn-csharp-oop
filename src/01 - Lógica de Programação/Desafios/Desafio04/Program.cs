using System;
using System.Globalization;

namespace Desafio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as informações do funcionário\n");
            Console.Write("Número do funcionário: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Número de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Valor que recebe por hora em R$: ");
            double valor = double.Parse(Console.ReadLine());

            double salario = valor * horas;

            Console.WriteLine($"\nNúmero do funcionário: {numero}\nSalário: R$ {salario:F2}");
        }
    }
}
