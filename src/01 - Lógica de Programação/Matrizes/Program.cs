int[,] matriz = new int[4, 2]
{
    {8, 8},
    {10, 20},
    {50, 100},
    {90, 200}
};

// GetLength(0) retorna o número de elementos na primeira dimensão do Array
for (int i = 0; i < matriz.GetLength(0); i++)
{
    // GetLength(1) retorna o número de elementos na segunda dimensão do Array
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.WriteLine(matriz[i,j]);
    }
}
