using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estrutura Condicional Simples
            Console.WriteLine("Informe um valor inteiro e verifique apenas se o mesmo é um valor par:\n");
            int valor1 = int.Parse(Console.ReadLine());

            if (valor1 % 2 == 0) Console.WriteLine("O valor é par!");

            Console.WriteLine("Informe um valor inteiro e verifique apenas se o mesmo é um valor ímpar:\n");
            int valor2 = int.Parse(Console.ReadLine());

            if (valor2 % 2 != 0) Console.WriteLine("O valor é ímpar!");


            // Estrutura Condicional Composta
            Console.WriteLine("Informe um valor inteiro e verifique se o mesmo é um valor par ou ímpar:\n");
            int valor3 = int.Parse(Console.ReadLine());

            if (valor3 % 2 == 0)
            {
                Console.WriteLine("O valor é par!");
            }
            else
            {
                Console.WriteLine("O valor é ímpar!");
            }


            // Estrutura Condicional Encadeada
            Console.WriteLine("Informe um valor inteiro e verifique se o mesmo é um valor negativo, nulo ou positivo:\n");
            int valor4 = int.Parse(Console.ReadLine());

            if (valor4 < 0)
            {
                Console.WriteLine("O valor é negativo!");
            }else if (valor4 == 0)
            {
                Console.WriteLine("O valor é nulo!");
            }
            else
            {
                Console.WriteLine("O valor é positivo!");
            }


            // Estrutura Condicional Encadeada
            Console.WriteLine("Qual a hora atual? HH");
            int hora = int.Parse(Console.ReadLine());

            if(hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if(hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
