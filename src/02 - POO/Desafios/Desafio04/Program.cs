using Desafio04;

Console.WriteLine("============ CADASTRO DA CONTA BANCÁRIA ============");

Console.Write("\nInforme o Número da conta: ");
int numero = NumeroConta(int.Parse(Console.ReadLine()));
Console.Write("Informe o nome do Titular da conta: ");
string nomeTitular = TitularConta(Console.ReadLine());
Console.Write("Informe o valor de depósito inicial da conta: ");
decimal valorInicial = decimal.Parse(Console.ReadLine());


ContaBancaria contaBancaria = new ContaBancaria(numero, nomeTitular, valorInicial);

int menu = 0;

do
{
    Console.WriteLine("\nInforme a operação desejada\n\n[1] - DEPÓSITO\n[2] - SAQUE\n[3] - DADOS DA CONTA\n[0] - SAIR\n");
    decimal valor = 0;
    menu = int.Parse(Console.ReadLine());

    switch (menu)
    {
        case 0:
            Console.Write("\n[ Programa Encerrado ]");
            break;
        case 1:
            Console.Write("\nInforme o valor para depósito: ");
            valor = decimal.Parse(Console.ReadLine());
            contaBancaria.Deposito(valor);
            Console.WriteLine(contaBancaria);
            break;
        case 2:
            Console.Write("\nInforme o valor para saque: ");
            valor = decimal.Parse(Console.ReadLine());
            contaBancaria.Saque(valor);
            Console.WriteLine(contaBancaria);
            break;
        case 3:
            Console.WriteLine(contaBancaria);
            break;
        default:
            Console.Write("\n[ Opção Inválida ]");
            break;
    }

} while (menu != 0);

static int NumeroConta(int numero)
{
    while (numero <= 0)
    {
        Console.Write("\n[ Número inválido ]\nInforme o Número da conta: ");
        numero = int.Parse(Console.ReadLine());
    }

    return numero;
}

static string TitularConta(string titular)
{
    while (string.IsNullOrEmpty(titular))
    {
        Console.Write("\n[ Nome do Titular inválido ]\nInforme o nome do Titular da conta: ");
        titular = Console.ReadLine();
    }

    return titular;
}






