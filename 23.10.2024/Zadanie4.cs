using System;
namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj wysokosc: ");
            int wysokosc = Convert.ToInt32(Console.ReadLine());
            if(wysokosc <= 0)
            {
                Console.WriteLine("Wysokosc musi byc wieksza od 0");
                wysokosc = Convert.ToInt32(Console.ReadLine());
            }

            while(wysokosc > 0)
            {
                int n = wysokosc;
                while (n > 0)
                {
                    Console.Write("*");
                    n--;
                }
                Console.WriteLine("");
                wysokosc--;
            }
        }
    }
}