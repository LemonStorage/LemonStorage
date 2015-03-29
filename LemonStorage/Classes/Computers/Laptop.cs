namespace LemonStorage.Classes.Computers
{
    using LemonStorage.Interfaces;
    using System;

    public class Laptop : Computer, IProduct, IComputer
    {
        private int batteryDuration;
        private double weight;
        private int size;
        
        public Laptop(decimal price, string brand, string model, string color, string processor, uint ram, uint hddSize, string videoCardModel, string soundCard, int batteryDuration, double weight, int size, int cores)
            :base(price, brand,model,color,processor,ram,hddSize,videoCardModel,soundCard, cores)
        {
            this.BatteryDuration = batteryDuration;
            this.Weight = weight;
            this.Size = size;
        }

        public int BatteryDuration
        {
            get 
            {
                if (this.batteryDuration <= 0)
                {
                    throw new ArgumentException("The battery duration can not be less or equal to zero");
                }
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
                if (this.weight <= 0)
                {
                    throw new ArgumentException("The laptop weight can not be less or equal to zero");
                }
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

        public int Size
        {
            get 
            {
                if (this.size <= 0)
                {
                    throw new ArgumentException("The size of the laptop can not be less or equal to zero");
                }
                return this.size; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The size of the laptop can not be less or equal to zero");
                }
                this.size = value; 
            }
        }
        // TODO: Implement the logic of the Laptop.Save()
        //public override void Save()
        //{
        //    throw new NotImplementedException();
        //}
        //// TODO: Implement the logic of the Laptop.Load()
        //public override void Load()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
