﻿namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    class Handsfree : Accessories, IProduct
    {
        private int range;
        private int batteryDuration;

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
                if (this.range <= 0)
                {
                    throw new ArgumentOutOfRangeException("Range of the bluetooth handsfree must be a positive number");
                }
                return this.range;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Range of the bluetooth handsfree must be a positive number");
                }
                this.range = value;
            }
        }

        public int BatteryDuration
        {
            get
            {
                if (this.batteryDuration <= 0)
                {
                    throw new ArgumentOutOfRangeException("Range of the bluetooth handsfree must be a positive number");
                }
                return this.batteryDuration;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Range of the bluetooth handsfree must be a positive number");
                }
                this.batteryDuration = value;
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
