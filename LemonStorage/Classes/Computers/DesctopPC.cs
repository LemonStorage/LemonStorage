namespace LemonStorage.Classes.Computers
{
    using LemonStorage.Classes.PeripheralDevices;
using LemonStorage.Interfaces;
    using System;

    public class DesctopPC : Computer , IProduct, IComputer
    {
        public DesctopPC(decimal price, string brand, string model, string color, string processor, uint ram, uint hddSize, string videoCardModel, string soundCard)
            :base(price, brand, model, color, processor, ram, hddSize, videoCardModel, soundCard)
        {

        }

        // TODO: Implement the logic of the DesctopPC.Save()
        public override void Save()
        {
            throw new NotImplementedException();
        }
        // TODO: Implement the logic of the DesctopPC.Load()
        public override void Load()
        {
            throw new NotImplementedException();
        }
    }
}
