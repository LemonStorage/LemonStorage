namespace LemonStorage.Classes.Mobiles
{
    using LemonStorage.Interfaces;
    using System;

    class MobilePhone : Mobile, IProduct, IMobiles
    {
        public MobilePhone(decimal price, string brand, string model, string color, string processor,
                      double displaySize, double camInMPix, uint ram, uint rom)
            : base(price, brand, model, color, processor, displaySize, camInMPix, ram, rom)
        {

        }

        // TODO: Implement the logic of the MobilePhone.Save()
        public override void Save()
        {
            throw new NotImplementedException();
        }
        // TODO: Implement the logic of the MobilePhone.Load()
        public override void Load()
        {
            throw new NotImplementedException();
        }
    }
}
