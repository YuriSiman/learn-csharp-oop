
int combustivel = 0, alcool = 0, gasolina = 0, diesel = 0;

while(combustivel != 4)
{
    Console.Write("Informe o Tipo de Combustível: ");
    combustivel = int.Parse(Console.ReadLine());

    if (combustivel < 1 || combustivel > 4)
    {
        Console.WriteLine($"Código [{combustivel}] Inválido! Informe um novo código.");
    }
    else if(combustivel == 1)
    {
        alcool++;
    }
    else if(combustivel == 2)
    {
        gasolina++;
    }
    else if(combustivel == 3)
    {
        diesel++;
    }
}

Console.WriteLine($"\n\nMuito Obrigado!\nÁlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");

