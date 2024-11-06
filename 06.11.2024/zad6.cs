using System;

class Program

{
    static void Main(string[] args)

    {
        // Zadanie 7

        string haslo;
        do
        {
            Console.WriteLine("Podaj hasło:");
            haslo = Console.ReadLine();

            if (haslo != "secure123")
            {
                Console.WriteLine("Niepoprawne hasło, spróbuj ponownie");
            }

        } while (haslo != "secure123");
        Console.WriteLine("Hasło poprawne!");
    }
}
