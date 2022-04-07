using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgram
{
    class CarType : Engine
    {
        protected string carCategory;
        protected int carWeight;

        public CarType(double power, double capacity, string category, int weight) : base(power, capacity)
        {
            carCategory = category;
            carWeight = weight;
        }

        public void ShowTechnicalData()
        {
            base.ShowTechnicalData();
            Console.WriteLine($"Kategoria pojazdu: {carCategory}");
            Console.WriteLine($"Waga pojazdu: {carWeight}");
        }

    }
}


