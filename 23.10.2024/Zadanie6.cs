using System;
using System.Security.Cryptography;

namespace Zadanie6
{
    class Zadanie6
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int liczba = rnd.Next(1, 10);
            Console.Write("Zgadnij liczbe: ");
            int zgadnij = Convert.ToInt32(Console.ReadLine());
            int liczbaProb = 1;

            while(zgadnij != liczba)
            {
                liczbaProb++;
                Console.WriteLine("Źle! Podaj jeszcze raz");
                zgadnij = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Brawo, zgadles liczba to: " + liczba + " ,liczba prob to: " + liczbaProb);
        }
    }
}