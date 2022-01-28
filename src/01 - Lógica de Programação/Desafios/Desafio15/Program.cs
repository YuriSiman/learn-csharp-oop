int senha = 0;

while (senha != 2002)
{
    Console.Write("Digite a senha: ");
    senha = int.Parse(Console.ReadLine());

    if (senha != 2002) Console.WriteLine("Senha Incorreta!");
}

Console.WriteLine("Senha Correta!");
