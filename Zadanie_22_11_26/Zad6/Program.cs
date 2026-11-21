using System;

class Program
{
    static void Main()
    {
        Console.Write("podaj liczbę: ");
        int n = int.Parse(Console.ReadLine());

        bool pierwsza = true;

        if (n < 2)
        {
            pierwsza = false;
        }
        else
        {
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    pierwsza = false;
                    break;
                }
            }
        }

        if (pierwsza)
            Console.WriteLine($"{n} jest liczbą pierwszą.");
        else
            Console.WriteLine($"{n} nie jest liczbą pierwszą.");
    }
}