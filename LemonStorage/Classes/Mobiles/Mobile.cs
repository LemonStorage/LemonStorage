namespace LemonStorage.Classes.Mobiles
{
    using LemonStorage.Interfaces;
    using System;

    public abstract class Mobile : Product, IProduct, IMobiles
    {
        //public Enumerations.MobileBrand Brand
        //{
        //    get
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //    set
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //}

        private string processor;
        private double displaySize;
        private double camInMPix;
        private uint ram;
        private uint rom;

        //constructor
        public Mobile(decimal price, string brand, string model, string color, string processor,
                      double displaySize, double camInMPix, uint ram, uint rom)
            : base(price, brand, model, color)
        {
            this.Processor = processor;
            this.DisplaySize = displaySize;
            this.CamInMPix = camInMPix;
            this.Ram = ram;
            this.Rom = rom;
        }

        //properties
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("Processor can not be empty");
                }
                this.processor = value;
            }
        }

        public double DisplaySize
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Display size can not be less or equal to zero");
                }
                this.displaySize = value;
            }
        }

        public double CamInMPix
        {
            get
            {
                return this.camInMPix;
            }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Camera megapixels can not be less or equal to zero");
                }
                this.camInMPix = value;
            }
        }

        public uint Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Ram memory can not be less or equal to zero");
                }
                this.ram = value;
            }
        }

        public uint Rom
        {
            get
            {
                return this.rom;
            }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Rom memory can not be less or equal to zero");
                }
                this.rom = value;
            }
        }

        //public abstract void Save();

        //public abstract void Load();
    }
}
