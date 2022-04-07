namespace CarInterface
{
    interface ICarTech
    {
        string CarColor { get; set; }
        int CarAxisNumber { get; set; }

        void ShowTechnicalData();
    }
}


