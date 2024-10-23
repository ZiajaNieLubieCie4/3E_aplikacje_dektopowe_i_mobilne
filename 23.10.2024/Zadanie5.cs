using System;
namespace Zadanie2
{
    class Zadanie2
    {
        public static void Main(string[] args)
        {
            int wynik = 0;

            Console.Write("Podaj liczbe, 0 konczy program: ");
            int liczba = Convert.ToInt32(Console.ReadLine());
            int ilosc = 0;
            while(liczba != 0)
            {
                ilosc++;
                wynik += liczba;
                Console.Write("Podaj liczbe: ");
                liczba = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Wynik tych liczb to: " + wynik + " podano liczb: " + ilosc);
        }
    }
}