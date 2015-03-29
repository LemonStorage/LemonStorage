namespace LemonStorage.Classes.Mobiles
{
    using LemonStorage.Interfaces;
    using System;

    public class Tablet : Mobile, IProduct, IMobiles
    {
        public Tablet(decimal price, string brand, string model, string color, string processor,
                      double displaySize, double camInMPix, uint ram, uint rom)
            : base(price, brand, model, color, processor, displaySize, camInMPix, ram, rom)
        {

        }

        // TODO: Implement the logic of the Tablet.Save()
        //public override void Save()
        //{
        //    throw new NotImplementedException();
        //}
        //// TODO: Implement the logic of the Tablet.Load()
        //public override void Load()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
