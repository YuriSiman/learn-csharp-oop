int m = 0, n = 0;
bool existeNum = false;

while (n <= 0 || m <= 0)
{
    Console.Write("Informe quantas linhas a Matriz terá: ");
    m = int.Parse(Console.ReadLine());
    Console.Write("Informe quantas colunas a Matriz terá: ");
    n = int.Parse(Console.ReadLine());

    if (n <= 0 || m <= 0) Console.WriteLine("\n[ Informe apenas valores inteiros positivos ]\n");
}

int[,] matriz = new int[m, n];

for (int i = 0; i < matriz.GetLength(0); i++)
{
    Console.Write($"Informe {n} valores para a {i + 1}ª linha: ");
    string[] linha = Console.ReadLine().Split(' ');

    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        matriz[i, j] = int.Parse(linha[j]);
    }
}

Console.WriteLine("\n>>> Matriz\n");
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write($"{matriz[i,j]} ");
    }
    Console.WriteLine();
}

while (!existeNum)
{
    Console.Write("\nInforme um número que pertença à Matriz: ");
    int num = int.Parse(Console.ReadLine());
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            if (num == matriz[i, j])
            {
                existeNum = true;

                Console.WriteLine($"\nPosição: Linha {i}, Coluna {j}");
                if(j > 0) Console.WriteLine($"Esquerda: {matriz[i, j - 1]}");
                if(j < n - 1) Console.WriteLine($"Direita: {matriz[i, j + 1]}");
                if(i > 0) Console.WriteLine($"Acima: {matriz[i - 1, j]}");
                if(i < m - 1) Console.WriteLine($"Abaixo: {matriz[i + 1, j]}");
            }
        }
    }

    if (!existeNum) Console.WriteLine($"\n[ O número {num} não existe na Matriz ]\n");
}

