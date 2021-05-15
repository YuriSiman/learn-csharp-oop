using System;

namespace EstruturaRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero = 0;

            // Estrutura de Repetição [ While ]
            while (numero >= 0)
            {
                Console.WriteLine("[while] Digite um número: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Repete [while]");
            }

            // Estrutura de Repetição [ Do - While ]
            do
            {
                Console.WriteLine("[do-while] Digite um número: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Repete [do-while]");
            } while (numero >= 0);

            // Estrutura de Repetição [ For ]
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
