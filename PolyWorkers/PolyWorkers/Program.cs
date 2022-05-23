
/* Projekt klas różnych pracowników zbudowanych z wykorzystaniem polimorfizmu, przygotowany na zajęcia z Programowania Obiektowego sem. II WSB (2021/2022).
 * Autor rozwiązania: Mateusz Stawowski (https://github.com/Mathias007).
 * Link do repozytorium zbiorczego: https://github.com/Mathias007/programowanie-obiektowe. 
 */

using System;
using System.Collections.Generic;

namespace PolyWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pracownik> lista = new List<Pracownik>();
            lista.Add(new Sekretarka());
            lista.Add(new Ochroniarz());
            lista.Add(new Ksiegowy());

            foreach (var i in lista)
            {
                i.Pracuj();
            }

            Console.ReadKey();
        }
    }
}
