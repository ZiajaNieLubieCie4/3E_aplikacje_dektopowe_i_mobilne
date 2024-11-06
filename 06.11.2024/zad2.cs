using System;

class Program

{
    static void Main(string[] args)

    {
        // Zadanie 3
        Random random = new Random();

        int losowaLiczba = random.Next(1, 101);
        int zgaduj;

        do
        {
            Console.WriteLine("Zgadnij liczbę od 1 do 100:");

            zgaduj = int.Parse(Console.ReadLine());

            if (zgaduj < losowaLiczba)
            {
                Console.WriteLine("Za mało");
            }

            else if (zgaduj > losowaLiczba)

            {
                Console.WriteLine("Za dużo");
            }

            else

            {
                Console.WriteLine("Zgadłeś");
            }

        } while (zgaduj != losowaLiczba);
    }
}