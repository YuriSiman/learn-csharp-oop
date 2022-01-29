Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

Console.WriteLine("\n>>>> Lista\n");
ListarEstados(estados);

Console.WriteLine("\n>>>> Atualizando o Estado de Minas Gerais\n");
string chaveProcurada = "MG";

if(ValidarChave(estados, chaveProcurada))
{
    Console.WriteLine($"Valor Original: {estados[chaveProcurada]}");
    estados[chaveProcurada] = "MG - Atualização";
    Console.WriteLine($"Valor Atualizado: {estados[chaveProcurada]}");
}

Console.WriteLine("\n>>>> Lista\n");
ListarEstados(estados);

Console.WriteLine("\n>>>> Removendo o Estado de Minas Gerais\n");

if (ValidarChave(estados, chaveProcurada))
{
    estados.Remove(chaveProcurada);
}

ListarEstados(estados);

void ListarEstados(Dictionary<string, string> estados)
{
    foreach (KeyValuePair<string, string> item in estados)
    {
        Console.WriteLine($"Chave: {item.Key}\nValor: {item.Value}");
    }
}

bool ValidarChave(Dictionary<string, string> estados, string chave)
{
    if (estados.TryGetValue(chave, out string valor)) return true;

    Console.WriteLine($"Chave {chave} não existe!");
    return false;
}