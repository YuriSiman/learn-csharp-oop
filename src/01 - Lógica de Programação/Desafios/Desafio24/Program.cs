
int num = 0;

while(num <= 0)
{
    Console.Write("\nInforme um número inteiro positivo: ");
    num = int.Parse(Console.ReadLine());

    if (num <= 0) Console.WriteLine("O número não é um inteiro positivo!");
}

for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"{i} {Math.Pow(i,2)} {Math.Pow(i, 3)}");
}

