using System;

namespace Desafio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe primeiro o código e, após um espaço, a quantidade do item\n");

            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int qtd = int.Parse(valores[1]);

            double total = 0;

            if(codigo == 1)
            {
                total = qtd * 4.0; 
            }else if (codigo == 2)
            {
                total = qtd * 4.5;
            }
            else if (codigo == 3)
            {
                total = qtd * 5.0;
            }
            else if (codigo == 4)
            {
                total = qtd * 2.0;
            }
            else if (codigo == 5)
            {
                total = qtd * 1.5;
            }
            else
            {
                Console.WriteLine("O código não existe!");
            }

            Console.WriteLine($"Total: R$ {total:F2}");
        }
    }
}
