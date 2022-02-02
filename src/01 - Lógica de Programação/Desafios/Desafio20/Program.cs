using System.Globalization;

Console.Write("Informe a quantidade de casos de teste: ");
int qtd = int.Parse(Console.ReadLine());

for (int i = 0; i < qtd; i++)
{
    Console.Write("Valores: ");
    string[] valores = Console.ReadLine().Split(' ');
    double valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
    double valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
    double valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

    double media = (valor1 * 2.0 + valor2 * 3.0 + valor3 * 5.0) / 10.0;
    Console.WriteLine($"\n{media.ToString("F1", CultureInfo.InvariantCulture)}\n");
}


