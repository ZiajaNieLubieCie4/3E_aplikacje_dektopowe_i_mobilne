using System;
namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj temperature poczatkową w Celcjuszach:");
            int cStart = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj temperature końcową w Celcjuszach:");
            int cEnd = Convert.ToInt32(Console.ReadLine());

            if(cStart > cEnd)
            {
                int cEndO = cEnd;
                cEnd = cStart;
                cStart = cEndO;
            }
            while (cStart <= cEnd)
            {
                Console.WriteLine(cStart + " stopni Celcjusza to: " + (2 * cStart + 32) + " stopni Fahrenheita");
                cStart++;
            }
        }
    }
}