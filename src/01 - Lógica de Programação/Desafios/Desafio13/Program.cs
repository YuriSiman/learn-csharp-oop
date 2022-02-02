using System.Globalization;

Console.Write("Informe o valor de X: ");
double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Informe o valor de Y: ");
double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if(x == 0.0 && y == 0.0)
{
    Console.WriteLine("\nOrigem");
}else if(x == 0.0)
{
    Console.WriteLine("\nEixo Y");
}else if(y == 0.0)
{
    Console.WriteLine("\nEixo X");
}else if (x > 0.0 && y > 0.0)
{
    Console.WriteLine("\nQ1");
}else if(x > 0.0 && y < 0.0)
{
    Console.WriteLine("\nQ4");
}else if(x < 0.0 && y > 0.0)
{
    Console.WriteLine("\nQ2");
}
else
{
    Console.WriteLine("\nQ3");
}
