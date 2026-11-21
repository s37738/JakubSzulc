using System;

class Program
{
    static void Main()
    {
        Console.Write("podaj liczbę:");
        int n = int.Parse(Console.ReadLine());

        int parzyste = 0;
        int nieparzyste = 0;

        Console.Write("liczby parzyste:");

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(" " + i);
                parzyste++;
            }
            else
            {
                nieparzyste++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"liczb parzystych: {parzyste}");
        Console.WriteLine($"liczb nieparzystych: {nieparzyste}");
    }
}