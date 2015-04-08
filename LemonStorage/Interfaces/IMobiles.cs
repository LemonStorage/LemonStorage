namespace LemonStorage.Interfaces
{
    using LemonStorage.Enumerations;

    public interface IMobiles
    {
        //MobileBrand Brand { get; set; }
        string Processor { get; set; }
        double DisplaySize { get; set; }
        uint Ram { get; set; }
        uint Rom { get; set; }
    }
}