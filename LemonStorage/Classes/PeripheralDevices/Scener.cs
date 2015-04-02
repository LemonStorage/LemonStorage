namespace LemonStorage.Classes.PeripheralDevices
{
    using LemonStorage.Interfaces;
    using System;

    public class Scener : PeripheralDevice, IProduct, IPeripheralDevices
    {
        private int resolution;

        public Scener(decimal price, string brand, string model, string color, int resolution)
            :base(price, brand, model, color)
        {
            this.Resolution = resolution;
        }
        public int Resolution
        {
            get 
            { 
                return this.resolution; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The scener resolution can not be less or equal to zero");
                }
                this.resolution = value; 
            }
        }
    }
}
