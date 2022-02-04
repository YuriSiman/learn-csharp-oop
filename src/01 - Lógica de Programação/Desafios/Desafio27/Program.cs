int n = 0, contaNegativos = 0;

while (n <= 0)
{
    Console.Write("Informe um número: ");
    n = int.Parse(Console.ReadLine());

    if (n <= 0) Console.WriteLine("\n[ Número inválido! Informe um número inteiro positivo ]\n");
}

int[,] matriz = new int[n, n];

for (int i = 0; i < matriz.GetLength(0); i++)
{
    Console.Write($"Informe os valores da {i + 1}ª linha: ");
    string[] linha = Console.ReadLine().Split(' ');

    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        matriz[i, j] = int.Parse(linha[j]);
        if (matriz[i, j] < 0) contaNegativos++;
    }
}

Console.WriteLine(">>> MATRIZ\n");
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write($"{matriz[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("\n>>> DIAGONAL PRINCIPAL\n");
for (int i = 0; i < matriz.GetLength(0); i++)
{
    Console.Write($"{matriz[i, i]} ");
}

Console.WriteLine("\n\n>>> QUANTIDADE DE VALORES NEGATIVOS\n");
Console.WriteLine(contaNegativos);