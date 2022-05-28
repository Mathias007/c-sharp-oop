
/* Projekt implementujący algorytm Wież Hanoi, przygotowany na zajęcia z Programowania Obiektowego sem. II WSB (2021/2022). * 
 * Autor rozwiązania: Mateusz Stawowski (https://github.com/Mathias007).
 * Link do repozytorium zbiorczego: https://github.com/Mathias007/programowanie-obiektowe. 
 * Uwagi podstawowe:
   - Główną inspirację stanowiła propozycja implementacji zaprezentowana przez dra K. Jakubczyka (http://kaj.uniwersytetradom.pl/cshf.html), przy czym nn. projekt stanowi jej twórcze rozwinięcie.
   - Zastosowane zostały takie elementy programowania obiektowego jak dziedziczenie, hermetyzacja, interfejsy, klasy abstrakcyjne. 
   - Program składa się z dwóch klas abstrakcyjnych: TowerService zawiera metody obejmujące właściwą implementację algorytmu wież Hanoi, natomiast TowersPainter zapewnia graficzną wizualizację działania programu w konsoli.
   - Klasa Towers korzysta z ww. klas abstrakcyjnych, implementuje także własny interfejs. Podstawowe dane konfiguracyjne (liczba elementów wieży, zatrzymywanie po kolejnych krokach) są personalizowane przy starcie programu przez użytkownika lub ustalone statycznie (tablica stosów, tablica stringów do rysowania elementów).
   - Na obecnym etapie zrezygnowano z enuma zawierającego oznaczenie stosów elementów wieży oraz metod wypisujących tekstowo kolejne kroki algorytmu, ponieważ zastąpiono je graficzną interpretacją.
   - Struktura projektu uwzględnia podstawowe katalogi (dla klas oraz dla interfejsów) i zasady nazewnictwa oraz stara się zachować czystość kodu.
 */

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
