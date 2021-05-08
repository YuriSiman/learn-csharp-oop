using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa em console que receba do usuário o texto 'Banana Maçã Uva Morango' e imprima cada palavra do texto em uma linha separada");

            string[] vetor = Console.ReadLine().Split(' ');

            string v1 = vetor[0];
            string v2 = vetor[1];
            string v3 = vetor[2];
            string v4 = vetor[3];

            Console.WriteLine($"\nPrimeira palavra: {v1}\nSegunda palavra: {v2}\nTerceira palavra: {v3}\nQuarta palavra: {v4}");
        }
    }
}
