Console.Write("Informe a quantidade de valores: ");
int qtd = int.Parse(Console.ReadLine());
double divisao;

for (int i = 0; i < qtd; i++)
{
    Console.Write("Valores: ");
    string[] valores = Console.ReadLine().Split(' ');

    double valor1 = double.Parse(valores[0]);
    double valor2 = double.Parse(valores[1]);

    if (valor2 == 0)
    {
        Console.WriteLine("Divisão Impossível!");
    }
    else
    {
        divisao = valor1 / valor2;
        Console.WriteLine($"{divisao:F1}");
    }
}
