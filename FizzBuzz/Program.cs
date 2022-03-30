using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Witaj w grze FizzBuzz, podaj liczbę:");

                while (true)
                {
                    FrizzBuzz fizzBuzz = new FrizzBuzz();
                    var number = GetNumber();
                    Console.WriteLine(fizzBuzz.GetOutput(number));

                    Console.WriteLine("Podaj kolejną liczbę lub aby wyjść naciśnij \"x\"");
                }
            }
        }

        private static int GetNumber()
        {
            while (true)
            {
                var volume = Console.ReadLine();

                if (volume.ToUpper() == "X")
                    Environment.Exit(0);

                if (!int.TryParse(volume, out int number))
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane, spróbuj ponownie");
                    continue;
                }
                return number;
            }
        }
    }
}
