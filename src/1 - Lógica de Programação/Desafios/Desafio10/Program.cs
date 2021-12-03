using System;

namespace Desafio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a hora inicial e a hora final do jogo");

            Console.Write("Hora Inicial: ");
            int horaInicial = int.Parse(Console.ReadLine());
            Console.Write("Hora Final: ");
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao;
            
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine($"O jogo durou {duracao} horas");
        }
    }
}
