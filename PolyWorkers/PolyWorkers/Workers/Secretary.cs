using System;

namespace PolyWorkers
{
    public class Secretary : Worker
    {
        private readonly string WorkerType = "Sekretarka";
        public override void Work()
        {
            Console.WriteLine($"{WorkerType} pracuje");
        }
    }
}