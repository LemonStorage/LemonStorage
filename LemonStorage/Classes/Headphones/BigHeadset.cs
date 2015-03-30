namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public class BigHeadset : Headphone, IProduct
    {
        private double diametreInSantimeters;

        public BigHeadset(int price, string brand, string model, string color, int weightInGrams, int minFrequencyInHz, int maxFrequencyInHz, int sensitivityINkHz, int inputPowerINmW, double lengthOfConnectionInMeters, string conectorType, double diametre)
            : base(price, brand, model, color, weightInGrams, minFrequencyInHz, maxFrequencyInHz, sensitivityINkHz, inputPowerINmW, lengthOfConnectionInMeters, conectorType)
        {
            this.DiametreInSantimeters = diametreInSantimeters;
        }        

        public double DiametreInSantimeters
        {
            get { return this.diametreInSantimeters; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The diametre can't be negative!");
                }
                this.diametreInSantimeters = value;
            }
        }

    }
}
