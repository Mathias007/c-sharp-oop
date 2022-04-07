using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgram
{
    class Car : CarType
    {
        protected string carColor;
        protected int carAxisNumber;

        public Car(double power, double capacity, string category, int weight, string color, int axis) : base(power, capacity, category, weight)
        {
            carColor = color;
            carAxisNumber = axis;
        }

        public void ShowTechnicalData()
        {
            base.ShowTechnicalData();
            Console.WriteLine($"Kolor nadwozia: {carColor}");
            Console.WriteLine($"Liczba osi: {carAxisNumber}");
        }
    }
}
