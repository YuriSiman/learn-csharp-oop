using Desafio01;

Console.WriteLine("Digite a base e altura do retângulo");

Retangulo retangulo = new Retangulo();

Console.Write("Base: ");
retangulo.Base = double.Parse(Console.ReadLine());
Console.Write("Altura: ");
retangulo.Altura = double.Parse(Console.ReadLine());

Console.WriteLine($"Área: {retangulo.Area():F2}\nPerímetro: {retangulo.Perimetro():F2}\nDiagonal: {retangulo.Diagonal():F2}");




