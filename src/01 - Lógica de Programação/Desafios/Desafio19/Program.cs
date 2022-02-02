Console.Write("Informe a quantidade de valores: ");
int qtd = int.Parse(Console.ReadLine());
int dentro = 0, fora = 0;

for (int i = 1; i <= qtd; i++)
{
    Console.Write($"{i}° valor: ");
    int valor = int.Parse(Console.ReadLine());

    if(valor >= 10 && valor <= 20)
    {
        dentro++;
    }
    else
    {
        fora++;
    }
}

Console.WriteLine($"\n{dentro} in\n{fora} out");

