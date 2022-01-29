int[] array = new int[] { 100, 1, 4, 0, 8, 15, 19, 19, 4, 100 };

var numerosPares = 
    from num in array
    where num % 2 == 0
    orderby num
    select num;

Console.WriteLine($"Número pares: {string.Join(", ", numerosPares)}");

var valorMinimo = array.Min();
var valorMaximo = array.Max();
var valorMedio = array.Average();
var soma = array.Sum();
var arrayUnico = array.Distinct().ToArray();

Console.WriteLine($"Valor Mínimo: {valorMinimo}");
Console.WriteLine($"Valor Máximo: {valorMaximo}");
Console.WriteLine($"Valor Médio: {valorMedio}");
Console.WriteLine($"Resultado da Soma: {soma}");
Console.WriteLine($"Array Original: {string.Join(", ", array)}");
Console.WriteLine($"Array Distinto: {string.Join(", ", arrayUnico)}");