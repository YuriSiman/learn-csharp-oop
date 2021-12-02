using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa em console que receba do usuário um texto (uma linha)" +
                " o primeiro nome, a idade, o salário e a primeira letra do nome, exemplo: 'Fulano 23 1000 F' " +
                "e imprima cada palavra do texto em uma linha separada sendo nome do tipo string, idade do tipo int, " +
                "salário do tipo double e primeira letra do nome do tipo char'");

            string[] vetor = Console.ReadLine().Split(' ');

            string nome = vetor[0];
            int idade = int.Parse(vetor[1]);
            double salario = double.Parse(vetor[2]);
            char letra = char.Parse(vetor[3]);

            Console.WriteLine($"\nPrimeiro nome: {nome}\nIdade: {idade}\nSalário: R$ {salario.ToString("F2")}\nPrimeira letra do nome: {letra}");
        }
    }
}
