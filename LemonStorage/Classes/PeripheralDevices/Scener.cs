namespace LemonStorage.Classes.PeripheralDevices
{
    using LemonStorage.Interfaces;
    using System;

    public class Scener : PeripheralDevice, IProduct, IPeripheralDevices
    {
        private int resolution;

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
        // TODO: Implement the logic of the Scener.Load()
        public override void Save()
        {
            throw new NotImplementedException();
        }
        // TODO: Implement the logic of the Scener.Save()
        public override void Load()
        {
            throw new NotImplementedException();
        }
    }
}
