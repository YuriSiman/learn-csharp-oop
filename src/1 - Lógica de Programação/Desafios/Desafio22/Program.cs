Console.Write("Número: ");
int num = int.Parse(Console.ReadLine());

int fatorial = 1;

for (int i = 1; i <= num; i++)
{
    fatorial = fatorial * i;
}

Console.WriteLine(fatorial);