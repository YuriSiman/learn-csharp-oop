using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a fórmula de Báskara e execute em console mostrando os resultados de ambas as raízes. O projeto tem como finalidade o estudo de operadores aritméticos.");

            double a = 1, b = -3, c = -4;

            double delta = Math.Pow(b, 2) - (4 * a * c);
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
        }
    }
}
