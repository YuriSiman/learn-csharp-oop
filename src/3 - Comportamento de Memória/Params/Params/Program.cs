using Params;

//int soma1 = Calculadora.Soma(new int[] { 2, 3});
//int soma2 = Calculadora.Soma(new int[] { 2, 4, 3});


// Utilizando o modificador de parâmetros "params" não é necessário instanciar um vetor nos parâmetros, basta informar os valores desejados do vetor
int soma1 = Calculadora.Soma(2, 3 );
int soma2 = Calculadora.Soma(2, 4, 3 );

Console.WriteLine(soma1);
Console.WriteLine(soma2);