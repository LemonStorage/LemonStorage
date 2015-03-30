namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    class Handsfree : Accessories, IProduct
    {
        private const int MinBatteryDuration = 5;
        private const int MinRange = 1;

        private int rangeInMeters;
        private int batteryDurationInHours;

        public Handsfree(int price, string brand, string model, string color, string type, int range, int batteryDuration)
            : base(price, brand, model, color, type)
        {
            this.Range = range;
            this.BatteryDuration = batteryDuration;
            // Types: Wired, Bluetooth, Speakerphones 
        }

        public int Range
        {
            get
            {                
                return this.rangeInMeters;
            }
            set
            {
                if (value <= MinRange)
                {
                    throw new ArgumentOutOfRangeException(string.Format
                        ("Range of the bluetooth handsfree more than {0}", MinRange));
                }
                this.rangeInMeters = value;
            }
        }

        public int BatteryDuration
        {
            get
            {               
                return this.batteryDurationInHours;
            }
            set
            {
                if (value <= MinBatteryDuration)
                {
                    throw new ArgumentOutOfRangeException(string.Format
                        ("Working hours on battery must be more than {0} hours", MinBatteryDuration));
                }
                this.batteryDurationInHours = value;
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
