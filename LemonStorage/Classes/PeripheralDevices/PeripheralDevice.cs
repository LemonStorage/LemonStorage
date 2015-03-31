namespace LemonStorage.Classes.PeripheralDevices
{
    using LemonStorage.Interfaces;
    using LemonStorage.Enumerations;

    public abstract class PeripheralDevice : Product, IProduct, IPeripheralDevices
    {
        public PeripheralDevice(decimal price, string brand, string model, string color)
            :base(price, brand, model, color)
        {

        }
    }
}
