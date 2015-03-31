namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    class Charger : Accessories, IProduct
    {
        private bool withUSBPort;

        public Charger(int price, string brand, string model, string color, string type, bool withUSBPort)
            : base(price, brand, model, color, type)
        {
            this.withUSBPort = withUSBPort;
            // Types: For car, for computer with usb, normal or powerbank
        }

        public bool WithUSBPort 
        { 
            get
            {                
                return this.withUSBPort;
            }
            set
            {
                this.withUSBPort = value;
            } 
        }
    }
}
