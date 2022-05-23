using System;

namespace PolyWorkers
{
    public class Guard : Worker
    {
        private readonly string WorkerType = "Ochroniarz";
        public override void Work()
        {
            Console.WriteLine($"{WorkerType} pracuje");
        }
    }
}