
/* Projekt aplikacji wykorzystującej interfejsy w miejsce dziedziczenia po klasach, tematycznie nawiązujący do samochodu, przygotowany na zajęcia z Programowania Obiektowego sem. II WSB (2021/2022).
 * Autor rozwiązania: Mateusz Stawowski (https://github.com/Mathias007).
 * Link do repozytorium zbiorczego: https://github.com/Mathias007/programowanie-obiektowe. 
 */

using System;

namespace CarInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(100, 100, "A", 1000, "red", 4);
            car.ShowTechnicalData();

            Console.ReadLine();
        }
    }
}
