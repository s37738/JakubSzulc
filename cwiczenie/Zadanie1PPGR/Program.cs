        Console.Write("Podaj liczbę całkowitą N: ");
        int n = int.Parse(Console.ReadLine());

        long suma = 0;
        for (int i = 1; i <= n; i++)
        {
            suma += i;
        }

        Console.WriteLine($"Suma liczb od 1 do {n} wynosi: {suma}");
