
// Criando uma lista vazia
List<string> list = new List<string>();

// Adicionando no final da lista
list.Add("João");
list.Add("Maria");
list.Add("Eduardo");
list.Add("Mônica");
list.Add("Erick");
list.Add("Matheus");
list.Add("Paulo");
list.Add("Henrique");
list.Add("Vitória");
list.Add("Yuri");
list.Add("Fábio");


// Adicionando na posição desejada
list.Insert(2, "Marcos");

// Imprimindo a lista
Console.WriteLine("\nLista:\n");
foreach (var item in list)
{
    Console.WriteLine(item);
}

// Mostrando o tamanho da lista
Console.Write($"\nTamanho da lista: {list.Count}\n");

// Encontrando o primeiro ou o último da lista que satisfação um predicado (utilizando expressão lambda)
string nome1 = list.Find(x => x[0] == 'E');
Console.Write($"\nPrimeiro nome encontrado que começa com 'E': {nome1}\n");

string nome2 = list.FindLast(x => x[0] == 'E');
Console.Write($"\nÚltimo nome encontrado que começa com 'E': {nome2}\n");

int posicao1 = list.FindIndex(x => x[0] == 'E');
Console.Write($"\nPosição do primeiro nome encontrado que começa com 'E': {posicao1}\n");

int posicao2 = list.FindLastIndex(x => x[0] == 'E');
Console.Write($"\nPosição do último nome encontrado que começa com 'E': {posicao2}\n");

// Recebendo todos os nomes que possuem 5 caracteres
List<string> list2 = list.FindAll(x => x.Length == 5);

// Imprimindo a lista
Console.WriteLine("\nNomes com 5 caracteres:\n");
foreach (var item in list2)
{
    Console.WriteLine(item);
}


// Removendo elementos da lista
list.Remove("João");
Console.WriteLine("\nRemovendo o nome 'João' da lista:\n");
foreach (var item in list)
{
    Console.WriteLine(item);
}

// Removendo todos os nomes que começam com 'M'
list.RemoveAll(x => x[0] == 'M');
Console.WriteLine("\nRemovendo todos os nomes que começam com 'M' da lista:\n");
foreach (var item in list)
{
    Console.WriteLine(item);
}

// Removendo um elemento pela posição dele
list.RemoveAt(2);
Console.WriteLine("\nRemovendo o nome na posição 2:\n");
foreach (var item in list)
{
    Console.WriteLine(item);
}

// Removendo os elementos de uma faixa
list.RemoveRange(2, 3);
Console.WriteLine("\nRemovendo 3 nomes a partir da posição 2:\n");
foreach (var item in list)
{
    Console.WriteLine(item);
}

// Adicionando um array de elementos na lista
string[] novosNomes = new string[] { "Luana", "Thales", "Bruno" };
Console.WriteLine("\nAdicionando os nomes Luana, Thales e Bruno na lista:\n");
list.AddRange(novosNomes);
foreach (var item in list)
{
    Console.WriteLine(item);
}

// Adicionando um elemento na posição desejada
string novoNome = "Yuri";
Console.WriteLine("\nAdicionando o nome Yuri na segunda posição da lista:\n");
list.Insert(1, novoNome);
foreach (var item in list)
{
    Console.WriteLine(item);
}