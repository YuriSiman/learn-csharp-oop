using Desafio03;

Aluno aluno = new Aluno();

Console.Write("Informe o nome do aluno: ");
aluno.Nome = Console.ReadLine();

for (int i = 1; i <= 3; i++)
{
    Console.Write($"\nInforme a {i}ª nota: ");
    double nota = double.Parse(Console.ReadLine());

    while ((i == 1 && nota > 30) || ((i == 2 || i == 3) && nota > 35))
    {
        Console.Write($"\n\nNota incorreta para o {i}º trimestre\nInforme a {i}ª nota: ");
        nota = double.Parse(Console.ReadLine());
    }
        
    aluno.NotaFinal(nota);
}

string situacaoFinal = aluno.Status() ? "APROVADO" : "REPROVADO";

Console.WriteLine($"{aluno}\nSituação: {situacaoFinal}\nNota Restante: {aluno.NotaRestante():F2}");
