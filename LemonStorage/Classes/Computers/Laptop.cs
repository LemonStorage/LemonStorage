namespace LemonStorage.Classes.Computers
{
    using LemonStorage.Interfaces;
    using System;

    public class Laptop : Computer, IProduct, IComputer
    {
        private int batteryDuration;
        private double weight;

        public Laptop(decimal price, string brand, string model, string color, string processor, uint ram, uint hddSize, string videoCardModel, string soundCard, int batteryDuration, double weight)
            :base(price, brand,model,color,processor,ram,hddSize,videoCardModel,soundCard)
        {
            this.BatteryDuration = batteryDuration;
            this.Weight = weight;
        }

        public int BatteryDuration
        {
            get 
            { 
                return this.batteryDuration; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The battery duration can not be less or equal to zero");
                }
                this.batteryDuration = value; 
            }
        }
        public double Weight
        {
            get 
            { 
                return this.weight; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The laptop weight can not be less or equal to zero");
                }
                this.weight = value; 
            }
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }

        public override void Load()
        {
            throw new NotImplementedException();
        }
    }
}
