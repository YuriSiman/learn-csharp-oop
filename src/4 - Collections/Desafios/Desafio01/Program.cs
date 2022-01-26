using Desafio01;

int n = 0;
List<Funcionario> lista = new List<Funcionario>();

while(n < 1)
{
    Console.Write("Informe a quantidade de funcionários: ");
    n = int.Parse(Console.ReadLine());

    if (n < 1) Console.WriteLine("\n[ Número inválido! Informe um número inteiro positivo. ]");
}

for (int i = 1; i <= n; i++)
{
    Console.Write($"\n\nFUNCIONÁRIO {i}\n");
    int id = 0;
    do
    {
        Console.Write("Informe o ID do funcionário: ");
        id = int.Parse(Console.ReadLine());

        if (id < 1) Console.WriteLine("\n[ Número do ID inválido, informe um número inteiro positivo. ]");

        foreach (var func in lista)
        {
            if (func.Id == id)
            {
                Console.WriteLine("\n[ Já existe um funcionário com este ID, por favor, informe outro número. ]");
                id = 0;
            }
        }
    } while (id < 1);
    

    Console.Write("Informe o nome do funcionário: ");
    string? nome = Console.ReadLine();

    double salario = 0.0;

    while (salario < 1000)
    {
        Console.Write("Informe o salário do funcionário: ");
        salario = double.Parse(Console.ReadLine());

        if(salario < 1000) Console.WriteLine("\n[ O salário do funcionário não pode ser menor que R$ 1.000,00 ]");
    }

    Funcionario funcionario = new Funcionario(id, nome, salario);

    lista.Add(funcionario);
}

int idFuncionario = 0;
double valor = 0;
bool existeFuncionario = false;

while (idFuncionario == 0)
{
    Console.Write("\nInforme o ID do Funcionário que receberá aumento: ");
    idFuncionario = int.Parse(Console.ReadLine());

    foreach (var func in lista)
    {
        if (func.Id == idFuncionario)
        {
            while (valor <= 0)
            {
                Console.Write($"Informe a porcentagem de aumento que o funcionário {func.Nome} irá receber: ");
                valor = double.Parse(Console.ReadLine());

                if (valor <= 0) Console.WriteLine("\n[ Valor inválido! Informe um valor maior que 0. ]");
            }

            func.AumentarSalario(valor);
            existeFuncionario = true;
        }
    }

    if (!existeFuncionario)
    {
        Console.WriteLine("\n[ Não existe funcionário com o ID informado. ]");
        idFuncionario = 0;
    }
}

Console.WriteLine("\n========== LISTA DE FUNCIONÁRIOS ==========");
foreach (var func in lista)
{
    Console.WriteLine(func);
}
