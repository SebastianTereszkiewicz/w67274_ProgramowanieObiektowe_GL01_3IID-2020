using System;
using System.Reflection;
using System.Xml;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Zadanie 
                Console.WriteLine("Wybierz zadanie od 1 do 6:");
                var input = Console.ReadLine();
                switch (int.Parse(input))
                {
                    case 1:
                        {
                            DisplayNumberIsEven();
                            break;
                        }
                    case 2:
                        {
                            DisplayNumber();
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            Factorial();
                            break;
                        }
                    case 5:
                        {
                            Game();
                            break;
                        }
                    case 6:
                        {
                            Converting();
                            break;
                        }
                    case 0:
                        {
                            return;
                        }
                }

            }
        }
        static void DisplayNumberIsEven()
        {
            Console.WriteLine("Podaj liczbę do sprawdzenia:");
            var number = Console.ReadLine();
            if (int.Parse(number) % 2 == 0)
            {
                Console.WriteLine("Liczba parzysta.");
            }
            else
            {
                Console.WriteLine("Liczba nieparzysta.");
            }
        }

        //Zadanie 2
        static void DisplayNumber()
        {
            Console.WriteLine("Podaj liczbę:");
            var input = Console.ReadLine();
            for (var i = 0; i <= int.Parse(input); i++)
            {
                Console.WriteLine(i);
            }
        }

        //Zadanie 4
        static void Factorial()
        {
            Console.WriteLine("Podaj liczbę z ktorej chcesz obliczyc silnie:");
            var input = Console.ReadLine();
            var result = 1;
            for (var i = 1; i <= int.Parse(input); i++)
            {
                result = result * i;
            }
            Console.WriteLine($"Silnia z {input} to {result}");
        }

        //Zadanie 5
        static void Game()
        {
            var random = new Random();
            var number = random.Next(1, 4);

            int count = 0;
            int shoot;

            do
            {
                count++;
                Console.WriteLine("Podaj liczbe: ");
                var input = Console.ReadLine();

                shoot = int.Parse(input);
            }
            while (shoot != number);
            {
                Console.WriteLine($"Zgadłeś za {count} strzalem");
            }
        }

        //Zadanie 6
        static void Converting()
        {

        }
    }
}