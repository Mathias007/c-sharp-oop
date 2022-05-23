namespace HermetizedPlane
{
    class Plane : IPlaneType
    {
        private int weight;
        private int engine;
        private int engineQuantity;
        private int seatsQuantity;
        private string wingType;

        public Plane(int weight, int engine, int engineQuantity, int seatsQuantity, string wingType)
        {
            this.weight = weight;
            this.engine = engine;
            this.engineQuantity = engineQuantity;
            this.seatsQuantity = seatsQuantity;
            this.wingType = wingType;
        }

        public int Weight { get { return weight; } set { weight = value; } }
        public int Engine { get { return engine; } set { engine = value; } }
        public int EngineQuantity { get { return engineQuantity; } set { engineQuantity = value; } }
        public int SeatsQuantity { get { return seatsQuantity; } set { seatsQuantity = value; } }
        public string WingType { get { return wingType; } set { wingType = value; } }
    }

}