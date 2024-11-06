using System;

class Program

{
    static void Main(string[] args)
    {
        // Zadanie 4
        Console.WriteLine("Podaj liczbę całkowitą:");
        int liczba = int.Parse(Console.ReadLine());
        int liczbaCyfr = 0;

        while (liczba != 0)
        {
            liczba /= 10;
            liczbaCyfr++;
        }

        Console.WriteLine("Liczba cyfr: " + liczbaCyfr);
    }
}
