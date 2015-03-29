namespace LemonStorage.Classes.Computers
{
    using LemonStorage.Classes.PeripheralDevices;
using LemonStorage.Interfaces;
    using System;

    public class DesktopPC : Computer , IProduct, IComputer
    {
        public DesktopPC(decimal price, string brand, string model, string color, string processor, uint ram, uint hddSize, string videoCardModel, string soundCard, int cores)
            :base(price, brand, model, color, processor, ram, hddSize, videoCardModel, soundCard, cores)
        {

        }

        // TODO: Implement the logic of the DesktopPC.Save()
        //public override void Save()
        //{
        //    throw new NotImplementedException();
        //}
        //// TODO: Implement the logic of the DesktopPC.Load()
        //public override void Load()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
