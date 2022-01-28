using MembrosEstaticos;
using System.Globalization;

Console.Write("Informe o valor do raio: ");

double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double circ = Calculadora.Circunferencia(raio);
double volume = Calculadora.Volume(raio);

Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Valor de PI: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
