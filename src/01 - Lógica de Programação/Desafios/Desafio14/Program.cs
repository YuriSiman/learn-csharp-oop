Console.Write("Salário em R$: ");
double salario = double.Parse(Console.ReadLine());

double imposto;

if (salario <= 2000.0)
{
    imposto = 0.0;
}
else if (salario <= 3000.0)
{
    imposto = (salario - 2000.0) * 0.08;
}
else if (salario <= 4500.0)
{
    imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
}
else
{
    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
}

if (imposto == 0.0)
{
    Console.WriteLine("\nIsento");
}
else
{
    Console.WriteLine($"\nImposto de Renda: R$ {imposto:F2}");
}

