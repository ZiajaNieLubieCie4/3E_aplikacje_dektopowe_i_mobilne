using System;

class Program

{
    static void Main(string[] args)

    {
        // Zadanie 5
        Console.WriteLine("Podaj liczbę całkowitą:");

        liczba = int.Parse(Console.ReadLine());
        int sumaCyfr = 0;

        while (liczba != 0)
        {
            sumaCyfr += liczba % 10;
            liczba /= 10;
        }

        Console.WriteLine("Suma cyfr: " + sumaCyfr);
    }
}
