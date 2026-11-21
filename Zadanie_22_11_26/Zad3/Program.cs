using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("ile ocen chcesz wprowadzić?");
        int ile = int.Parse(Console.ReadLine());

        int suma = 0;
        int najwyzsza = int.MinValue;
        int najnizsza = int.MaxValue;
        int pozytywne = 0;

        for (int i = 0; i < ile; i++)
        {
            Console.Write("podaj ocenę:");
            int ocena = int.Parse(Console.ReadLine());

            while (ocena < 1 || ocena > 6)
            {
                Console.Write("ocena musi być od 1 do 6, podaj ocenę:10");
                ocena = int.Parse(Console.ReadLine());
            }

            suma += ocena;

            if (ocena > najwyzsza)
                najwyzsza = ocena;

            if (ocena < najnizsza)
                najnizsza = ocena;

            if (ocena >= 3)
                pozytywne++;
        }

        double srednia = (double)suma / ile;

        Console.WriteLine();
        Console.WriteLine("Średnia: " + srednia.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine($"Najwyższa ocena: {najwyzsza}");
        Console.WriteLine($"Najniższa ocena: {najnizsza}");
        Console.WriteLine($"Liczba ocen pozytywnych: {pozytywne}");
    }
}