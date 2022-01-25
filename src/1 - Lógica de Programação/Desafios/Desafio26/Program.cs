using Desafio26;

int n = 0;
Aluguel[] vect = new Aluguel[10];

do
{
    Console.WriteLine("Quantos quartos serão alugados?");
    n = int.Parse(Console.ReadLine());

    if(n < 1 || n > 10) Console.WriteLine("Quantidade incorreta de quartos, temos apenas 10 quartos.");

} while(n < 1 || n > 10);

Console.WriteLine("\n\n======= RESGISTRO DE ALUGUEL =======");

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\n\n>> Aluguel {i+1}");
    Console.Write("Nome do estudante: ");
    string nome = Console.ReadLine();
    Console.Write("Email do estudante: ");
    string email = Console.ReadLine();
    int quarto = 0;

    do
    {
        Console.Write("Quarto escolhido pelo estudante [0 - 9]: ");
        quarto = int.Parse(Console.ReadLine());

        if (quarto < 0 || quarto > 9)
        {
            Console.WriteLine("\nO número do quarto não existe.");
        }
        else
        {
            if (vect[quarto] != null) Console.WriteLine("\nEste quarto está alugado.");
        }

    } while (quarto < 0 || quarto > 9 || vect[quarto] != null);

    vect[quarto] = new Aluguel(nome, email, quarto);
}

Console.WriteLine("\n\n======= Quartos Ocupados =======\n");
for (int i = 0; i < 10; i++)
{
    if (vect[i] != null) Console.WriteLine($"{vect[i]}");
}