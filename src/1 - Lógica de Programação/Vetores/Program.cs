Console.Write("Informe uma quantidade de pessoas: ");
int qtdPessoas = int.Parse(Console.ReadLine());

double[] altura = new double[qtdPessoas];
double somaAltura = 0;

for (int i = 1; i <= qtdPessoas; i++)
{
    Console.Write($"Altura da {i}ª pessoa: ");
    altura[i - 1] = double.Parse(Console.ReadLine());
    somaAltura += altura[i - 1];
}

double media = somaAltura / qtdPessoas;
Console.WriteLine($"Altura média: {media:F2}");


