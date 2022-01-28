int[] array = new int[] { 2, 8, 4, 10, 1, 7, 3, 6, 5, 9 };
int[] arrayCopia = new int[15];

Console.WriteLine("\n====== Ordenando um Array ======");
Console.Write("\nArray original: ");
ImprimirArray(array);
Console.Write("Array ordenado: ");
Array.Sort(array);
ImprimirArray(array);

Console.WriteLine("\n\n====== Copiando um Array ======");
Console.Write("\nArray antes da cópia: ");
ImprimirArray(arrayCopia);
Console.Write("Array depois da cópia: ");
Array.Copy(array, arrayCopia, array.Length);
ImprimirArray(arrayCopia);

Console.WriteLine("\n\n====== Verificando um elemento existente em um Array ======");
int valor = 5;
Console.Write($"\nVerificando se existe o número {valor} no array: ");
string retorno = Array.Exists(array, x => x == valor) ? $"O valor {valor} foi encontrado no Array" : $"O valor {valor} não foi encontrado no Array";
Console.Write(retorno);

Console.WriteLine("\n\n====== Verificando todos os elementos existentes em um Array ======");
int valor2 = 0;
Console.Write($"\nVerificando se todos os elementos do Array são maiores que {valor2}: ");
string retorno2 = Array.TrueForAll(array, x => x > valor2) ? $"Verdadeiro! Todos os elementos são maiores que {valor2}" : $"Falso! Nem todos os elementos são maiores que {valor2}";
Console.Write(retorno2);

Console.WriteLine("\n\n====== Encontrando um elemento no Array e retornando seu valor ======");
int valor3 = 10;
Console.Write($"\nProcurando o valor {valor3}: ");
int obterValor3 = Array.Find(array, x => x == valor3);
string retorno3 = obterValor3 > 0 ? $"Valor encontrado!\nValor: {obterValor3}" : "Valor não encontrado!";
Console.WriteLine(retorno3);

Console.WriteLine("\n\n====== Encontrando um elemento no Array e retornando sua posição ======");
int valor4 = 8;
Console.Write($"\nProcurando a posição do valor {valor4}: ");
int obterValor4 = Array.IndexOf(array, valor4);
string retorno4 = obterValor4 > -1 ? $"Valor encontrado!\nO indice do elemento {valor4} é {obterValor4}" : "Valor não encontrado!";
Console.WriteLine(retorno4);

Console.WriteLine("\n\n====== Redimencionando um Array em tempo de execução ======");
int novoTamanho = array.Length * 2;
Console.Write($"\nCapacidade atual do array: {array.Length}");
Array.Resize(ref array, novoTamanho);
Console.Write($"\nCapacidade atual do array após redimensionar: {array.Length}");

Console.WriteLine("\n\n======Convertendo um Array de um tipo para outro tipo ======");
Console.Write("\nConvertendo um array de inteiro para string: ");
string[] arrayString = Array.ConvertAll(array, x => x.ToString());
var linha = string.Join(" ", arrayString);
Console.WriteLine(linha);

void ImprimirArray(int[] array)
{
    var linha = string.Join(" ", array);
    Console.WriteLine(linha);
}