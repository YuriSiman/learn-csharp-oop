int senha = 0;

while (senha != 2002)
{
    Console.Write("\nDigite a senha: ");
    senha = int.Parse(Console.ReadLine());

    if (senha != 2002) Console.WriteLine("\n[ Senha Inválida ]");
}

Console.WriteLine("\n[ Acesso Permitido ]");
