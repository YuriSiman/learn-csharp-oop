int[] array = new int[] { 2, 8, 4, 10, 1, 7, 3, 6, 5, 9 };
int[] arrayCopia = new int[15];

Console.WriteLine("\n====== Ordenando um Array ======");

Console.Write("\nArray original: ");
ImprimirArray(array);
Console.Write("\nArray ordenado: ");
Array.Sort(array);
ImprimirArray(array);

Console.WriteLine("\n\n====== Copiando um Array ======");

Console.Write("\nArray antes da cópia: ");
ImprimirArray(arrayCopia);
Console.Write("\nArray depois da cópia: ");
Array.Copy(array, arrayCopia, array.Length);
ImprimirArray(arrayCopia);








void ImprimirArray(int[] array)
{
    var linha = string.Join(" ", array);
    Console.WriteLine(linha);
}