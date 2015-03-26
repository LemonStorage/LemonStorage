namespace LemonStorage.Interfaces
{
    using LemonStorage.Enumerations;

    public interface IPeripheralDevices
    {
        public PeripheralBrands Brand { get; set; }
        public string Model { get; set; }
    }
}
