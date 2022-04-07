using System;

namespace CarInterface
{
    class Car : IEngine, ICarType, ICarTech
    {
        public double EnginePower { get; set; }
        public double EngineCapacity { get; set; }
        public string CarCategory { get; set; }
        public int CarWeight { get; set; }
        public string CarColor { get; set; }
        public int CarAxisNumber { get; set; }

        public Car(double power, double capacity, string category, int weight, string color, int axis)
        {
            EnginePower = power;
            EngineCapacity = capacity;
            CarCategory = category;
            CarWeight = weight;
            CarColor = color;
            CarAxisNumber = axis;
        }

        public void ShowTechnicalData()
        {
            Console.WriteLine($"Moc silnika to: {EnginePower} kW");
            Console.WriteLine($"Pojemność silnika wynosi: {EngineCapacity}");
            Console.WriteLine($"Kategoria pojazdu: {CarCategory}");
            Console.WriteLine($"Waga pojazdu: {CarWeight}");
            Console.WriteLine($"Kolor nadwozia: {CarColor}");
            Console.WriteLine($"Liczba osi: {CarAxisNumber}");
        }
    }
}
