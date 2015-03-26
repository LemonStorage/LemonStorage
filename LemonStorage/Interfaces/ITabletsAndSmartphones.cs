namespace LemonStorage.Interfaces
{
    using LemonStorage.Enumerations;

    public interface ITabletsAndSmartphones
    {
        MobileBrand Brand { get; set; }
        string Processor { get; set; }
        double DisplaySize { get; set; }
        double CamInMPix { get; set; }
        uint Ram { get; set; }
        uint Rom { get; set; }
    }
}