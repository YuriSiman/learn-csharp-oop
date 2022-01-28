Console.Write("Informe uma quantidade de pessoas: ");
int qtd = int.Parse(Console.ReadLine());

double[] altura = new double[qtd];
double somaAltura = 0;

for (int i = 0; i < altura.Length; i++)
{
    Console.Write($"Altura da {i+1}ª pessoa: ");
    altura[i] = double.Parse(Console.ReadLine());
    somaAltura += altura[i];
}

double media = somaAltura / qtd;
Console.WriteLine($"Altura média: {media:F2}");


