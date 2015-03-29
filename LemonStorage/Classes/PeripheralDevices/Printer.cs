namespace LemonStorage.Classes.PeripheralDevices
{
    using LemonStorage.Interfaces;
    using System;

    public class Printer : PeripheralDevice, IProduct, IPeripheralDevices
    {
        private string type;

        public Printer(decimal price, string brand, string model, string color, string type)
            :base(price, brand, model, color)
        {
            this.Type = type;
        }

        public string Type
        {
            get 
            { 
                return this.type; 
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The type of the printer can not be empty");
                }
                this.type = value; 
            }
        }
        // TODO: Implement the logic of the Printer.Save()
        //public override void Save()
        //{
        //    throw new NotImplementedException();
        //}
        //// TODO: Implement the logic of the Printer.Load()
        //public override void Load()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
