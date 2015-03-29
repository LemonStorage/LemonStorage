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
                //if (this.withUSBPort == null)
                //{
                //    throw new ArgumentNullException("You must add wheather the charger has a usb port or not");
                //}
                return this.withUSBPort;
            }
            set
            {
                //if (value == null)
                //{
                //    throw new ArgumentNullException("You must add wheather the charger has a usb port or not");
                //}
                this.withUSBPort = value;
            } 
        }
        // TODO: Implement the logic of the Charger.Save()
        //public override void Save()
        //{
        //    throw new NotImplementedException();
        //}
        //// TODO: Implement the logic of the Charger.Load()
        //public override void Load()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
