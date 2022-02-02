Console.Write("Digite um valor inteiro de 1 a 1000: ");
int x = int.Parse(Console.ReadLine());

while(x < 1 || x > 1000)
{
    Console.Write("\n[ Valor Inválido ]\n\nDigite um valor inteiro de 1 a 1000: ");
    x = int.Parse(Console.ReadLine());
}

for (int i = 0; i < x; i++)
{
    if (!(i % 2 == 0)) Console.WriteLine($"Valor Ímpar: {i}"); 
}

if (!(x % 2 == 0)) Console.WriteLine($"Valor Ímpar: {x}");