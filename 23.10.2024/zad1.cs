using System;
namespace program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbe");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n <= 1)
            {
                Console.WriteLine("Liczba musi byc wieksza od 1");
                n = Convert.ToInt32(Console.ReadLine());
            }

            int i = 0;
            while (i <= n)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

        }
    }
}