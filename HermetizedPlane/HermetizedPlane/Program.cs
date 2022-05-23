
/* Projekt implementacji interfejsu w klasie z parametrami samolotu, wykorzystujący hermetyzację, przygotowany na zajęcia z Programowania Obiektowego sem. II WSB (2021/2022).
 * Autor rozwiązania: Mateusz Stawowski (https://github.com/Mathias007).
 * Link do repozytorium zbiorczego: https://github.com/Mathias007/programowanie-obiektowe. 
 */

using System;

namespace HermetizedPlane
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(5, 4, 3, 100, "górnopłat");
            Console.WriteLine(plane.WingType);
            Console.ReadKey();
        }
    }
}
