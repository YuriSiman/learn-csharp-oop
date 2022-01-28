using Desafio01;

int qtdFuncionario = 0;
int idBuscaFuncionario = 0;
double valor = 0;
bool existeFuncionario = false;

List<Funcionario> lista = new List<Funcionario>();

while(qtdFuncionario < 1)
{
    Console.Write("Informe a quantidade de funcionários: ");
    qtdFuncionario = int.Parse(Console.ReadLine());

    if (qtdFuncionario < 1) Console.WriteLine("\n[ Número inválido! Informe um número inteiro positivo. ]");
}

DadosFuncionario(qtdFuncionario);

ValidarAumento(idBuscaFuncionario, valor, existeFuncionario);

Console.WriteLine("\n========== LISTA DE FUNCIONÁRIOS ==========");
foreach (var func in lista)
{
    Console.WriteLine(func);
}

void DadosFuncionario(int qtdFuncionario)
{
    for (int i = 1; i <= qtdFuncionario; i++)
    {
        Console.Write($"\n\nFUNCIONÁRIO {i}\n");

        int id = 0;

        while (id < 1)
        {
            Console.Write("Informe o ID do funcionário: ");
            id = int.Parse(Console.ReadLine());

            if (id < 1) Console.WriteLine("\n[ Número do ID inválido, informe um número inteiro positivo. ]");

            Funcionario funcionario = lista.Find(x => x.Id == id);

            if(funcionario != null)
            {
                Console.WriteLine("\n[ Já existe um funcionário com este ID, por favor, informe outro número. ]");
                id = 0;
            }
        }

        string? nome = null;

        while (string.IsNullOrEmpty(nome))
        {
            Console.Write("Informe o nome do funcionário: ");
            nome = Console.ReadLine();

            if(string.IsNullOrEmpty(nome)) Console.WriteLine("\n[ Nome inválido! ]");
        }

        double salario = 0.0;

        while (salario < 1000)
        {
            Console.Write("Informe o salário do funcionário: ");
            salario = double.Parse(Console.ReadLine());

            if (salario < 1000) Console.WriteLine("\n[ O salário do funcionário não pode ser menor que R$ 1.000,00 ]");
        }

        lista.Add(new Funcionario(id, nome, salario));
    }
}

void ValidarAumento(int idBuscaFuncionario, double valor, bool existeFuncionario)
{
    while (idBuscaFuncionario == 0)
    {
        Console.Write("\nInforme o ID do Funcionário que receberá aumento: ");
        idBuscaFuncionario = int.Parse(Console.ReadLine());

        Funcionario funcionario = lista.Find(x => x.Id == idBuscaFuncionario);

        if(funcionario != null)
        {
            while (valor <= 0)
            {
                Console.Write($"Informe a porcentagem de aumento que o funcionário {funcionario.Nome} irá receber: ");
                valor = double.Parse(Console.ReadLine());

                if (valor <= 0) Console.WriteLine("\n[ Valor inválido! Informe um valor maior que 0. ]");
            }

            funcionario.AumentarSalario(valor);
            existeFuncionario = true;
        }

        if (!existeFuncionario)
        {
            Console.WriteLine("\n[ Não existe funcionário com o ID informado. ]");
            idBuscaFuncionario = 0;
        }
    }
}