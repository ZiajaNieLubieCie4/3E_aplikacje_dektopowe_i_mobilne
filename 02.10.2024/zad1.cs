using System;
using System.Reflection.Emit;

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj x");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj y");
        double y = Convert.ToDouble(Console.ReadLine());

        string c;

        if (x > 0 && y > 0)
        {
            c = ("Lewy gorny");
        }
        else if (x > 0 && y > 0)
        {
            c = ("Prawy gorny");
        }
        else if (x < 0 && y < 0)
        {
            c = ("Lewy dolny");
        }
        else if (x > 0 && y < 0)
        {
            c = ("Prawy dolny");
        }
        else
        {
            c = "Linia wykresu";
        }

        Console.WriteLine(c);
    }
}