using System;

namespace PolyWorkers
{
    public class Accountant : Worker
    {
        private readonly string WorkerType = "Ksi�gowy";
        public override void Work()
        {
            Console.WriteLine($"{WorkerType} pracuje");
        }
    }
}