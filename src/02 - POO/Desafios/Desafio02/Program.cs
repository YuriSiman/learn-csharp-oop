using Desafio02;

Console.WriteLine("Informe os dados do funcionário\n");

Funcionario funcionario = new Funcionario();

Console.Write("Nome: ");
funcionario.Nome = Console.ReadLine();

Console.Write("Salário Bruto: ");
funcionario.SalarioBruto = double.Parse(Console.ReadLine());

Console.Write("Imposto: ");
funcionario.Imposto = double.Parse(Console.ReadLine());

Console.WriteLine($"\nDados do Funcionário {funcionario}");

Console.Write("\nInforme a porcentagem para aumentar o salário: ");
double porcentagem = double.Parse(Console.ReadLine());  
funcionario.AumentarSalario(porcentagem);

Console.WriteLine($"\nDados Atualizados do Funcionário {funcionario}");
