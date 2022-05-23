namespace HermetizedPlane
{
    public interface IPlaneType
    {
        int Weight { get;  set; }
        int Engine { get;  set; }
        int EngineQuantity { get;  set; }
        int SeatsQuantity { get;  set; }
        string WingType { get;  set; }
    }
}
