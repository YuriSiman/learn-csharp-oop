using System;

namespace OperadoresComparativosLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Precedência: ! > && > ||
            bool comparador1 = 2 > 3 || 4 != 5;
            bool comparador2 = !(2 > 3) && 4 != 5;

            Console.WriteLine($"Comparador1: {comparador1}\nComparador2: {comparador2}");

            bool comparador3 = 10 < 5;
            bool comparador4 = comparador1 || comparador2 && comparador3;

            Console.WriteLine($"Comparador4: {comparador4}");
        }
    }
}
