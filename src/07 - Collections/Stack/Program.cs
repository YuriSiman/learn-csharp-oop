Console.WriteLine("Stack (Pilha) - Obedece a ordem LIFO (Last In First Out)");

Stack<string> pilha = new Stack<string>();

// Adicionando um objeto no início da pilha
pilha.Push(".NET");
pilha.Push("DDD");
pilha.Push("Código Limpo");

// Count - Retorna a quantidade de elementos presente na fila
Console.WriteLine($"\nLivros para a leitura: {pilha.Count}");

while (pilha.Count > 0)
{
    // Retorna o último objeto da pilha, mas não remove
    Console.WriteLine($"\nPróximo livro para a leitura: {pilha.Peek()}");
    // Remove o último objeto da pilha
    Console.WriteLine($"\n{pilha.Pop()} lido com sucesso.");
}

Console.WriteLine($"\nLivros para a leitura: {pilha.Count}");