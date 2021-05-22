using System;

namespace Desafio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros");
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());

            if(a == 0 || b == 0)
            {
                Console.WriteLine("São Múltiplos");
            }
            else
            {
                if (a > b)
                {
                    int divisao = a / b;
                    if (divisao * b == a)
                    {
                        Console.WriteLine("São Múltiplos");
                    }
                    else
                    {
                        Console.WriteLine("Não são Múltiplos");
                    }
                }
                else
                {
                    int divisao = b / a;
                    if (divisao * a == b)
                    {
                        Console.WriteLine("São Múltiplos");
                    }
                    else
                    {
                        Console.WriteLine("Não são Múltiplos");
                    }
                }
            }
        }
    }
}
