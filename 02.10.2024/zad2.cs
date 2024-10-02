using System;

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj a");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj b");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj c");
        int c = Convert.ToInt32(Console.ReadLine());

        double obwod = a + b + c;
        double pole = (0.25 * (Math.Sqrt(4 * a * a * b * b - (a * a + b * b - c * c) * (a * a + b * b - c * c))));

        if (b + c > a && b + a > c && c > b)
        {
            Console.WriteLine("Da sie zbudowac trójkąt");
        }
        else
        {
            Console.WriteLine("Nie da sie zbudować trójkąta");
        }
        Console.WriteLine("Pole " + pole);
        Console.WriteLine("Obowod " + obwod);
    }
}