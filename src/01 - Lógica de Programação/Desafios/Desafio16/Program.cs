
Console.Write("Coordenada X: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Coordenada Y: ");
int y = int.Parse(Console.ReadLine());


while(x != 0 && y != 0)
{
    if (x < 0)
    {
        if(y < 0)
        {
            Console.WriteLine("Terceiro");
        }
        else
        {
            Console.WriteLine("Segundo");
        }
    }
    else
    {
        if (y < 0)
        {
            Console.WriteLine("Quarto");
        }
        else
        {
            Console.WriteLine("Primeiro");
        }
    }

    Console.Write("Coordenada X: ");
    x = int.Parse(Console.ReadLine());

    Console.Write("Coordenada Y: ");
    y = int.Parse(Console.ReadLine());
}
