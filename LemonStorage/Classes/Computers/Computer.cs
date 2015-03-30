namespace LemonStorage.Classes.Computers
{
    using LemonStorage.Interfaces;
    using System;

    public abstract class Computer : Product, IProduct, IComputer
    {
        private const uint MinRam = 512;
        private const uint MinHDDSize = 128;

        private string processor;
        private uint ramInMB;
        private uint hddSizeInGB;
        private string videoCardModel;
        private uint videoCardMemory;
        private string soundCard;
        private int cores;

        public Computer(decimal price, string brand, string model, string color, string processor, uint ram, uint hddSize, string videoCardModel, string soundCard, int cores)
            :base(price, brand, model, color)
        {
            this.Processor = processor;
            this.Ram = ram;
            this.HDDSize = hddSize;
            this.VideoCardModel = videoCardModel;
            this.SoundCard = soundCard;
            this.Cores = cores;
        }
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
                    throw new ArgumentException("The processor can not be empty");
                }
                this.processor = value;
            }
        }

        public uint Ram
        {
            get
            {                
                return this.ramInMB;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The ram can not be less or equal to zero");
                }
                this.ramInMB = value;
            }
        }

        public uint HDDSize
        {
            get
            {
                if (this.hddSizeInGB <= 0)
                {
                    throw new ArgumentException("The HDD Size can not be less or equal to zero");
                }
                return this.hddSizeInGB;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The HDD Size can not be less or equal to zero");
                }
                this.hddSizeInGB = value;
            }
        }

        public string VideoCardModel
        {
            get
            {
                if (string.IsNullOrEmpty(this.videoCardModel))
                {
                    throw new ArgumentException("The video card model can not be empty");
                }
                return this.videoCardModel;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The video card model can not be empty");
                }
                this.videoCardModel = value;
            }
        }

        public uint VideocardMemory
        {
            get
            {
                if (this.videoCardMemory <= 0)
                {
                    throw new ArgumentException("The video card memory can not be less or equal to zero");
                }
                return this.videoCardMemory;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The video card memory can not be less or equal to zero");
                }
                this.videoCardMemory = value;
            }
        }

        public string SoundCard
        {
            get
            {
                if (string.IsNullOrEmpty(this.soundCard))
                {
                    throw new ArgumentException("The sound card can not be empty");
                }
                return this.soundCard;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The sound card can not be empty");
                }
                this.soundCard = value;
            }
        }

        public int Cores 
        { 
            get
            {
                if (this.cores <= 0)
                {
                    throw new ArgumentOutOfRangeException("Number of cores must over 0");
                }
                return this.cores;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Number of cores must over 0");
                }
                this.cores = value;
            }
        }

        //public abstract void Save();

        //public abstract void Load();
    }
}
