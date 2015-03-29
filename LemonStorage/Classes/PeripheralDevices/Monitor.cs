namespace LemonStorage.Classes.PeripheralDevices
{
    using LemonStorage.Interfaces;
    using System;

    public class Monitor : PeripheralDevice, IProduct, IPeripheralDevices
    {
        private int size;

        public Monitor(decimal price = 1, string brand = "Unknown", string model = "Unknown", string color = "Unknown", int size=1)
            :base(price, brand, model, color)
        {
            this.Size = size;
        }
        public int Size
        {
            get 
            { 
                return this.size; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The size of the monitor can not be ");
                }
                this.size = value; 
            }
        }
        // TODO: Implement the logic of the Monitor.Save()
        //public override void Save()
        //{
        //    throw new System.NotImplementedException();
        //}
        //// TODO: Implement the logic of the Monitor.Load()
        //public override void Load()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
