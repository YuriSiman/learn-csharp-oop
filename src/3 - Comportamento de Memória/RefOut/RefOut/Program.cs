using RefOut;

// Fazendo o parâmetro ser uma referência para a variável original, exigindo que a variável original seja iniciada
int a = 10;

Calculadora.TriplicarRef(ref a);
Console.WriteLine(a);

// Fazendo o parâmetro ser uma referência para a variável original, sem exigir que a variável original seja iniciada

int b = 10;
int triplicar;

Calculadora.TriplicarOut(b, out triplicar);
Console.WriteLine(triplicar);