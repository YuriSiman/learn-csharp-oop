using System.Globalization;

Console.Write("Informe o valor de X: ");
double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Informe o valor de Y: ");
double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if(x == 0.0 && y == 0.0)
{
    Console.WriteLine("Origem");
}else if(x == 0.0)
{
    Console.WriteLine("Eixo Y");
}else if(y == 0.0)
{
    Console.WriteLine("Eixo X");
}else if (x > 0.0 && y > 0.0)
{
    Console.WriteLine("Q1");
}else if(x > 0.0 && y < 0.0)
{
    Console.WriteLine("Q4");
}else if(x < 0.0 && y > 0.0)
{
    Console.WriteLine("Q2");
}
else
{
    Console.WriteLine("Q3");
}
