namespace LemonStorage.Classes.Computers
{
    using LemonStorage.Classes.PeripheralDevices;
using LemonStorage.Interfaces;
    using System;

    public class DesktopPC : Computer , IProduct, IComputer
    {
        private const int MinPowSupply = 150;
        private const int MaxPowSupply = 1200;

        private string coolingSystem;
        private int powerSupplyInWatts;
        private string computerCase;

        public DesktopPC(decimal price, string brand, string model, string color, string processor, uint ram, uint hddSize, string videoCardModel, string soundCard, byte cores, string coolingSystem, int powerSupplyInWatts, string computerCase)
            :base(price, brand, model, color, processor, ram, hddSize, videoCardModel, soundCard, cores)
        {

        }

        public string CoolingSystem
        {
            get
            {
                return this.coolingSystem;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("You can't leave cooling system field empty.");
                }
                this.coolingSystem = value;
            }
        }

        public int PowerSupply
        {
            get
            {
                return this.powerSupplyInWatts;
            }
            set
            {
                if (value < MinPowSupply || value > MaxPowSupply)
                {
                    throw new ArgumentException(string.Format
                    ("Power supply can be from {0} to {1} watts.", MinPowSupply, MaxPowSupply));
                }
                this.powerSupplyInWatts = value;
            }
        }

        public string ComputerCase
        {
            get
            {
                return this.computerCase;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("You can't leave computer case field empty.");
                }
                this.computerCase = value;
            }
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
