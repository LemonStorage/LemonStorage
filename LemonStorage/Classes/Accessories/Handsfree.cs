namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    class Handsfree : Accessories,IAccessories, IProduct, ISavable
    {
        private const int MinBatteryDuration = 5;
        private const int MinRange = 1;

        private string typeOfConnection;
        private int rangeInMeters;
        private int batteryDurationInHours;

        public Handsfree(int price, string brand, string model, string color, string material, int range, int batteryDuration)
            : base(price, brand, model, color, material)
        {
            this.TypeOfConnection = typeOfConnection;
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

        public string TypeOfConnection
        {
            get
            {
                return this.typeOfConnection;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Type of connection can be empty");
                }
                this.typeOfConnection = value;
            }
        }
    }
}
