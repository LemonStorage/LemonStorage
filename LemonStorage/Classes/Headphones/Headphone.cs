namespace LemonStorage.Classes
{
    using LemonStorage.Interfaces;
    using System;

    public class Headphone : Product, IProduct
    {
        private int weightInGrams;
        private int minFrequencyInHz; //:5 - 42,000Hz        
        private int maxFrequencyInHz; 
        private int sensitivityINkHz; // max 125dB
        private int inputPowerINmW;     // max 400mW
        private double lengthOfConnectionInMeters; // >0
        private string conectorType; // Wired or Cable

        public Headphone(int price, string brand, string model, string color, int weightInGrams, int minFrequencyInHz, int maxFrequencyInHz, int sensitivityINkHz, int inputPowerINmW, double lengthOfConnectionInMeters, string conectorType)
            : base(price, brand, model, color)
        {
            this.WeightInGrams = weightInGrams;
            this.MinFrequencyInHz = minFrequencyInHz;
            this.MaxFrequencyInHz = maxFrequencyInHz;
            this.SensitivityINkHz = sensitivityINkHz;
            this.InputPowerINmW = inputPowerINmW;
            this.LengthOfConnectionInMeters = lengthOfConnectionInMeters;
            this.ConectorType = conectorType;
        }
        public int WeightInGrams           
        {
            get
            {
                if (this.weightInGrams < 0)
                {
                    throw new ArgumentException("The Weight can't be negative!");
                }
                return this.weightInGrams;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The Weight can't be negative!");
                }
                this.weightInGrams = value;
            }
        }

        public int MinFrequencyInHz
        {
            get
            {
                if (this.minFrequencyInHz <= 4)
                {
                    throw new ArgumentException("Mininum Frequency must be bigger of 4Hz!");
                }
                return this.minFrequencyInHz;
            }
            set
            {
                if (this.minFrequencyInHz <= 4)
                {
                    throw new ArgumentException("Mininum Frequency must be bigger of 4Hz!");
                }
                this.minFrequencyInHz = value;
            }
        }

        public int MaxFrequencyInHz
        {
            get
            {
                if (this.maxFrequencyInHz >= 50000 && this.maxFrequencyInHz < 4)
                {
                    throw new ArgumentException("Maximum Frequency must be between 5 and 50000Hz!");
                }
                return this.maxFrequencyInHz;
            }
            set
            {
                if (this.maxFrequencyInHz >= 50000 && this.maxFrequencyInHz < 4)
                {
                    throw new ArgumentException("Maximum Frequency must be between 5 and 50000Hz!");
                }
                this.maxFrequencyInHz = value;

            }
        }


        public int SensitivityINkHz
        {

            get
            {
                if (this.sensitivityINkHz >= 125 && this.sensitivityINkHz < 0)
                {
                    throw new ArgumentException("Maximum Frequency must be maximum 125dB!");
                }
                return this.sensitivityINkHz;
            }
            set
            {
                if (this.sensitivityINkHz >= 125 && this.sensitivityINkHz < 0)
                {
                    throw new ArgumentException("Maximum Frequency must be maximum 125dB!");
                }
                this.sensitivityINkHz = value;
            }
        }

        public int InputPowerINmW
        {
            get
            {
                if (this.inputPowerINmW >= 400 && this.inputPowerINmW < 0)
                {
                    throw new ArgumentException("Maximum Frequency must be maximum 400mW!");
                }
                return this.inputPowerINmW;
            }
            set
            {
                if (this.inputPowerINmW >= 400 && this.inputPowerINmW < 0)
                {
                    throw new ArgumentException("Maximum Frequency must be maximum 400mW!");
                }
                this.inputPowerINmW = value;
            }

        }

        public double LengthOfConnectionInMeters
        {
            get
            {
                if (this.lengthOfConnectionInMeters <= 0)
                {
                    throw new ArgumentException("Length of the cable must be positiv number !");
                }
                return this.lengthOfConnectionInMeters;
            }
            set
            {
                if (this.lengthOfConnectionInMeters <= 0)
                {
                    throw new ArgumentException("Length of the cable must be positiv number !");
                }
                this.lengthOfConnectionInMeters = value;
            }

        }

        public string ConectorType
        {
            get { return this.conectorType; }
            set
            {
                if (value != "Wireless" && value != "Cable")
                {
                    throw new ArgumentException("The technology can be Wireless or Cable!");
                }
                this.conectorType = value;
            }
        }

    }
}
