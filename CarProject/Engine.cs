using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgram
{
    class Engine
    {
        public double enginePower;
        public double engineCapacity;

        public Engine(double power, double capacity)
        {
            enginePower = power;
            engineCapacity = capacity;
        }

        public void ShowTechnicalData()
        {
            Console.WriteLine($"Moc silnika to: {enginePower} kW");
            Console.WriteLine($"Pojemność silnika wynosi: {engineCapacity}");            
        }

    }
}
