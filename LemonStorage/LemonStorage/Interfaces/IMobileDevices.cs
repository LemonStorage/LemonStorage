namespace LemonStorage.Interfaces
{
    using LemonStorage.Enumerations;
    public interface IMobileDevices
    {
        public string Model { get; set; }
        public MobileBrand Brand { get; set; }
        public string Processor { get; set; }
        public double DisplaySize { get; set; }
        public double CamInMPix { get; set; }
        public uint Ram { get; set; }
        public uint Rom { get; set; }
    }
}
