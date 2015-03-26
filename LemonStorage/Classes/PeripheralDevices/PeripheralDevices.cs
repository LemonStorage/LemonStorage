namespace LemonStorage.Classes.PeripheralDevices
{
    using LemonStorage.Interfaces;
    using LemonStorage.Enumerations;

    public abstract class PeripheralDevices : Product, IProduct, IPeripheralDevices
    {
        public PeripheralBrands Brand
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
