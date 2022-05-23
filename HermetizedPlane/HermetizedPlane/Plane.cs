namespace HermetizedPlane
{
    public class Plane : IPlaneType
    {
        private int _weight;
        private int _engine;
        private int _engineQuantity;
        private int _seatsQuantity;
        private string _wingType;

        public int Weight { get => _weight; set => _weight = value; }
        public int Engine { get => _engine; set => _engine = value; }
        public int EngineQuantity { get => _engineQuantity; set => _engineQuantity = value; }
        public int SeatsQuantity { get => _seatsQuantity; set => _seatsQuantity = value; }
        public string WingType { get => _wingType; set => _wingType = value; }

        public Plane(int weight, int engine, int engineQuantity, int seatsQuantity, string wingType) {
            _weight = weight;
            _engine = engine;
            _engineQuantity = engineQuantity;
            _seatsQuantity = seatsQuantity;
            _wingType = wingType;
        }
    }

}