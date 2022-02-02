
Console.Write("\nCoordenada X: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Coordenada Y: ");
int y = int.Parse(Console.ReadLine());


while(x != 0 && y != 0)
{
    if (x < 0)
    {
        if(y < 0)
        {
            Console.WriteLine("\nTerceiro");
        }
        else
        {
            Console.WriteLine("\nSegundo");
        }
    }
    else
    {
        if (y < 0)
        {
            Console.WriteLine("\nQuarto");
        }
        else
        {
            Console.WriteLine("\nPrimeiro");
        }
    }

    Console.Write("\nCoordenada X: ");
    x = int.Parse(Console.ReadLine());

    Console.Write("Coordenada Y: ");
    y = int.Parse(Console.ReadLine());
}
