using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            double b = 2;

            int result = a / (int)b;
            Console.WriteLine(result);
        }
    }
}
