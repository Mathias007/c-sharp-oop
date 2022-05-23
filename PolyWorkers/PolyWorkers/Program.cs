
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
            List<Worker> workersList = new()
            {
                new Secretary(),
                new Guard(),
                new Accountant()
            };

            foreach (var worker in workersList)
            {
                worker.Work();
            }

            Console.ReadKey();
        }
    }
}
