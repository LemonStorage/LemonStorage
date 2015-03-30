namespace LemonStorage.Classes.Computers
{
    using LemonStorage.Interfaces;
    using System;

    public class Laptop : Computer, IProduct, IComputer
    {
        private const int MinBattDuration = 1;
        private const int MaxBattDuration = 16;
        private const double MinWeight = 0.350;
        private const double MaxWeight = 5.4;
        private const double MinSize = 7;
        private const double MaxSize = 21.2;

        private int batteryDurationInHours;
        private double weightInKG;
        private double size;
        
        public Laptop(decimal price, string brand, string model, string color, string processor, uint ram, uint hddSize, string videoCardModel, string soundCard, int batteryDuration, double weightInKG, double size, byte cores)
            :base(price, brand,model,color,processor,ram,hddSize,videoCardModel,soundCard, cores)
        {
            this.BatteryDuration = batteryDuration;
            this.Weight = weightInKG;
            this.Size = size;
        }

        public int BatteryDuration
        {
            get 
            {               
                return this.batteryDurationInHours; 
            }
            set 
            {
                if (value < MinBattDuration || value > MaxBattDuration)
                {
                    throw new ArgumentException(string.Format
                        ("The battery duration can be from {0} to {1} hours", MinBattDuration,MaxBattDuration));
                }
                this.batteryDurationInHours = value; 
            }
        }

        public double Weight
        {
            get 
            {
                return this.weightInKG; 
            }
            set 
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException(string.Format
                        ("The laptop weight can be from {0} to {1}", MinWeight, MaxWeight));
                }
                this.weightInKG = value; 
            }
        }

        public double Size
        {
            get 
            {               
                return this.size; 
            }
            set 
            {
                if (value < MinSize || value > MaxSize)
                {
                    throw new ArgumentException(string.Format
                        ("The size of the laptop can be from {0} to {1}", MinSize, MaxSize));
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
