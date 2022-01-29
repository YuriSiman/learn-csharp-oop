Console.WriteLine("Queue (Fila) - Obedece a ordem FIFO (First In First Out)");

Queue<string> fila = new Queue<string>();

// Adicionando um objeto no fim da fila
fila.Enqueue("João");
fila.Enqueue("Maria");
fila.Enqueue("José");

// Count - Retorna a quantidade de elementos presente na fila
Console.WriteLine($"\nPessoas na fila: {fila.Count}");

while (fila.Count > 0)
{
    // Retorna o objeto do começo da fila, mas não remove
    Console.WriteLine($"\nVez de: {fila.Peek()}");
    // Remove e retorno o objeto atual no começo da fila
    Console.WriteLine($"\n{fila.Dequeue()} atendido.");
}

Console.WriteLine($"\nPessoas na fila: {fila.Count}");