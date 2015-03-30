namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public class BigHeadset : Headphone, IProduct
    {
        private const double MinDiameter = 2;
        private const double MaxDiameter = 15;

        private double diametreInSantimeters;

        public BigHeadset(int price, string brand, string model, string color, int weightInGrams, int minFrequencyInHz, int maxFrequencyInHz, int sensitivityINkHz, int inputPowerINmW, double lengthOfConnectionInMeters, string conectorType, double diametre)
            : base(price, brand, model, color, weightInGrams, minFrequencyInHz, maxFrequencyInHz, sensitivityINkHz, inputPowerINmW, lengthOfConnectionInMeters, conectorType)
        {
            this.DiametreInSantimeters = diametreInSantimeters;
        }        

        public double DiametreInSantimeters
        {
            get 
            {
                return this.diametreInSantimeters; 
            }
            set
            {
                if (value < MinDiameter || value > MaxDiameter)
                {
                    throw new ArgumentException(string.Format
                    ("The diametre can be form {0} to {1} cm.", MinDiameter, MaxDiameter));
                }
                this.diametreInSantimeters = value;
            }
        }

    }
}
