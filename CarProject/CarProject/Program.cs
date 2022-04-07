
/* Projekt aplikacji wykorzystującej dziedziczenie klas, tematycznie nawiązujący do parametrów samochodu, przygotowany na zajęcia z Programowania Obiektowego sem. II WSB (2021/2022).
 * Autor rozwiązania: Mateusz Stawowski (https://github.com/Mathias007).
 * Link do repozytorium zbiorczego: https://github.com/Mathias007/programowanie-obiektowe. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgram
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
