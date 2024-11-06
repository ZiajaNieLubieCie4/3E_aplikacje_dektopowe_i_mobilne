using System;

class Program

{
    static void Main(string[] args)

    {
        // Zadanie 8
        Console.WriteLine("Podaj wysokość prostokąta:");
        int wysokosc = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj szerokość prostokąta:");
        int szerokosc = int.Parse(Console.ReadLine());

        for (int i = 0; i < wysokosc; i++)
        {

            for (int j = 0; j < szerokosc; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

}