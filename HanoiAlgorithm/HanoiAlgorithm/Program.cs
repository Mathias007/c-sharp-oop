using System;
using System.Collections.Generic;

namespace HanoiAlgorithm
{
    class Program
    {
        protected static int numberOfElements;
        protected static Stack<int>[] towersOfHanoi;
        protected static char stop;
        protected static string[] towerElement;

        public static void SetProgramParameters()
        {
            Console.WriteLine("Wieże Hanoi - Konfiguracja startowa \n-----------");
            Console.WriteLine("Program pozwala na symulację i wizualizację kolejnych kroków algorytmu wież Hanoi. Zanim przejdziesz do głównego okna aplikacji, podaj kluczowe parametry do wykonania programu \n-----------");
            Console.Write("Podaj liczbę elementów wieży z przedziału 1-10: ");
            numberOfElements = int.Parse(Console.ReadLine().Trim());
            if (numberOfElements <= 0 || numberOfElements > 10) throw new Exception("Podana liczba elementów wieży nie jest obsługiwana");

            Console.Write("Czy chcesz zatrzymywać bieg programu po kolejnych ruchach dla ułatwienia analizy? (T/N) ");
            stop = char.ToUpper(Console.ReadKey(true).KeyChar);
            Console.WriteLine(stop);

            towerElement = new string[11];

            towersOfHanoi = new Stack<int>[] {
                new Stack<int>(),
                new Stack<int>(),
                new Stack<int>(),
                };
        }

        static void Main(string[] args)
        {
            try
            {
                SetProgramParameters();

                Towers towers = new(numberOfElements, towersOfHanoi, stop, towerElement);
                towers.HanoiTowersManagement();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
}
