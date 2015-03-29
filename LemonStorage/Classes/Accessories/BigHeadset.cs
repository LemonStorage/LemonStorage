namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public class BigHeadset : Headphone, IProduct
    {
        private string technology; //Wireless or with cable
        private double frequency;
        private double diametre;

        public BigHeadset(int price, string brand, string model, string color, string type, string technology, double frequency,double diametre)
            : base(price, brand, model, color,type)
        {
            this.Frequency = frequency;
            this.Technology = technology;
            this.Diametre = diametre;
        }

        public string Technology
        {
            get { return this.technology; }
            set
            {
                if (value != "Wireless" && value != "Cable")
                {
                    throw new ArgumentException("The technology can be Wireless ot Cable!");
                }
                this.technology = value;
            }
        }

        public double Frequency
        {
            get { return this.frequency; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Frequency can't be negative!");
                }
                this.frequency = value;
            }
        }

        public double Diametre
        {
            get { return this.diametre; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The diametre can't be negative!");
                }
                this.diametre= value;
            }
        }

    }
}
