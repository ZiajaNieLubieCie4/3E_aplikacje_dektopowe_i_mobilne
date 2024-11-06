using System;

class Program

{
    static void Main(string[] args)
    {
        // Zadanie 9
        Console.WriteLine("Podaj liczbę n:");

        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Liczby pierwsze od 2 do " + n + ":");

        for (int i = 2; i <= n; i++)
        {
            bool pierwsza = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {

                if (i % j == 0)
                {
                    pierwsza = false;
                    break;
                }

            }
            if (pierwsza)

            {
                Console.Write(i + " ");
            }

        }
        Console.WriteLine();
    }
}