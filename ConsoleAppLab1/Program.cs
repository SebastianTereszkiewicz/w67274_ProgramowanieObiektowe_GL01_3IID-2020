using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Sprawdz czy liczba jest patzysta lub nieparzysta");
                Console.WriteLine("2. Liczby parzyste");
                Console.WriteLine("3. Silnia");

                var input = Console.ReadLine();

                switch (int.Parse(input))
                {
                    case 1:
                        DisplayNumberIsEven();
                        break;

                    case 2:
                        DispalyEvenNumber();
                        break;
                    case 3:
                        Console.WriteLine(Silnia());
                        break;
                }
            }
        }

        static void DisplayNumberIsEven()
        {
            Console.WriteLine("Podaj liczbę");

            var input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta.");
            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta.");
            }
        }

        static void DispalyEvenNumber()
        {
            Console.WriteLine("Podaj liczbe:");

            var input = Console.ReadLine();

            for (var i = 0; i < int.Parse(input); i++)
            {
                if (NumberIsEven(i))
                    Console.WriteLine(i);
            }
        }

        static bool NumberIsEven(int number)
        => number % 2 == 0;

        static long Silnia()
        {
            Console.WriteLine("Podaj liczbe:");

            var input = int.Parse(Console.ReadLine());

            if (input == 0 || input == 1)
                return 1;
            long wynik = 1;
            for (int i = 2; i <= input; i++)
            {
                wynik *= i;
            }
            return wynik;
        }



    }
}
