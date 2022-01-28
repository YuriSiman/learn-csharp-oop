Console.Write("Número: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    int resul = num / i;

    if(resul * i == num)
    {
        Console.WriteLine(resul);
    }
}