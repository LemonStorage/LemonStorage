namespace LemonStorage.Classes.Mobiles
{
    using LemonStorage.Interfaces;
    using System;

    public class SmartPhone : Mobile, IProduct, IMobiles
    {
        public SmartPhone(decimal price, string brand, string model, string color, string processor,
                      double displaySize, double camInMPix, uint ram, uint rom)
            : base(price, brand, model, color, processor, displaySize, camInMPix, ram, rom)
        {

        }
    }
}
