namespace LemonStorage.Classes
{
    using LemonStorage.Interfaces;
    using System;

    public class Headphone : Product, IProduct
    {
        private const int MinWeight = 10;
        private const int MaxWeight = 400;
        private const int MinLowFrequency = 5;
        private const int MaxLowFrequency = 35;
        private const int MinHighFrequency = 18000;
        private const int MaxHighFrequency = 40000;
        private const int MinSensitivity = 12;
        private const int MaxSensitivity = 125;
        private const int MaxInputPower = 400;
        private const double MinLengthOfConnection = 0.40;


        private int weightInGrams;
        private int lowFrequencyInHz; //:5 - 42,000Hz        
        private int highFrequencyInHz; 
        private int sensitivityInDB; // max 125dB
        private int inputPowerINmW;     // max 400mW
        private double lengthOfConnectionInMeters; // >0
        private string conectorType; // Wired or Cable

        public Headphone(int price, string brand, string model, string color, int weightInGrams, int lowFrequencyInHz, int highFrequencyInHz, int sensitivityInDB, int inputPowerINmW, double lengthOfConnectionInMeters, string conectorType)
            : base(price, brand, model, color)
        {
            this.WeightInGrams = weightInGrams;
            this.LowFrequencyInHz = lowFrequencyInHz;
            this.HighFrequencyInHz = highFrequencyInHz;
            this.SensitivityInDB = sensitivityInDB;
            this.InputPowerINmW = inputPowerINmW;
            this.LengthOfConnectionInMeters = lengthOfConnectionInMeters;
            this.ConectorType = conectorType;
        }
        public int WeightInGrams           
        {
            get
            {               
                return this.weightInGrams;
            }
            set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException(string.Format
                    ("Weight must be from {0} to {1} Hz.", MinWeight, MaxWeight));
                }
                this.weightInGrams = value;
            }
        }

        public int LowFrequencyInHz
        {
            get
            {                
                return this.lowFrequencyInHz;
            }
            set
            {
                if (value < MinLowFrequency || value > MaxLowFrequency)
                {
                    throw new ArgumentException(string.Format
                    ("Lower bound must be from {0} to {1} Hz.", MinLowFrequency, MaxLowFrequency));
                }
                this.lowFrequencyInHz = value;
            }
        }

        public int HighFrequencyInHz
        {
            get
            {                
                return this.highFrequencyInHz;
            }
            set
            {
                if (value < MinHighFrequency || value > MaxHighFrequency)
                {
                    throw new ArgumentException(string.Format
                        ("High frequency must be between {0} and {1}Hz!", MinHighFrequency, MaxHighFrequency));
                }
                this.highFrequencyInHz = value;
            }
        }


        public int SensitivityInDB
        {

            get
            {               
                return this.sensitivityInDB;
            }
            set
            {
                if (value < MinSensitivity || value > MaxSensitivity)
                {
                    throw new ArgumentException(string.Format
                        ("Sensitivity must be minimum {0}dB maximum {1}dB!", MinSensitivity, MaxSensitivity));
                }
                this.sensitivityInDB = value;
            }
        }

        public int InputPowerINmW
        {
            get
            {                
                return this.inputPowerINmW;
            }
            set
            {
                if (value < 0 || value > MaxInputPower)
                {
                    throw new ArgumentException(string.Format
                        ("Input power must be maximum {0}mW!", MaxInputPower));
                }
                this.inputPowerINmW = value;
            }
        }

        public double LengthOfConnectionInMeters
        {
            get
            {              
                return this.lengthOfConnectionInMeters;
            }
            set
            {
                if (value < MinLengthOfConnection)
                {
                    throw new ArgumentException(string.Format 
                        ("Length of the cable must be bigger than {0}!", MinLengthOfConnection));
                }
                this.lengthOfConnectionInMeters = value;
            }
        }

        public string ConectorType
        {
            get 
            {
                return this.conectorType; 
            }
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
