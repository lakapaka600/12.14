static int Mcm(int num1, int num2, int mcm1, int mcm2)
{
    mcm1 = num1;
    mcm2 = num2;

    while (num1 != num2)
    {
        if (num1 < num2)
        {
            num1 += mcm1;
        }
        else
        {
            num2 += mcm2;
        }
    }

    return num1;
}

int num1, num2;

Console.Write("Inserisci il primo numero: ");
while (!int.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("errore");

}

Console.Write("Inserisci il secondo numero: ");
while (!int.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("errore");

}

Console.WriteLine($"MCM risulta: {Mcm(num1, num2, 1, 1)}");
