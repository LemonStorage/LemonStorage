namespace LemonStorage.Classes.Computers
{
    using LemonStorage.Interfaces;
    using LemonStorage.Classes.ExceptionClasses;
    using System;

    public abstract class Computer : Product, IProduct, IComputer
    {
        private const uint MinRam = 512;
        private const uint MinHDDSize = 128;
        private const uint MinVideoMemory = 64;
        private const byte MinNumOfCores = 1;
        private const byte MaxNumOfCores = 16;


        private string processor;
        private uint ramInMB;
        private uint hddSizeInGB;
        private string videoCardModel;
        private uint videoCardMemoryInMB;
        private string soundCard;
        private byte cores;

        public Computer(decimal price, string brand, string model, string color, string processor, uint ram, uint hddSize, string videoCardModel, string soundCard, byte cores)
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
                if (value <= MinRam)
                {
                    throw new ArgumentException(string.Format("The ram can not be less than {0}", MinRam));
                }
                if (value % 2 != 0)
                {
                    throw new ArgumentException("RAM memory size must be devidible by 2");
                }
                this.ramInMB = value;
            }
        }

        public uint HDDSize
        {
            get
            {               
                return this.hddSizeInGB;
            }
            set
            {
                if (value <= MinHDDSize)
                {
                    throw new ArgumentException(string.Format("The HDD Size can not be less than {0}", MinHDDSize));
                }
                if (value % 2 != 0)
                {
                    throw new ArgumentException("Memory size must devidible by 2");
                }
                this.hddSizeInGB = value;
            }
        }

        public string VideoCardModel
        {
            get
            {                
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
                return this.videoCardMemoryInMB;
            }
            set
            {
                if (value <= MinVideoMemory)
                {
                    throw new ArgumentException(string.Format
                        ("The video card memory can not be less than {0}", MinVideoMemory));
                }
                if (value % 2 != 0)
                {
                    throw new ArgumentException("Video memory size must be devidible by 2");
                }
                this.videoCardMemoryInMB = value;
            }
        }

        public string SoundCard
        {
            get
            {               
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

        public byte Cores 
        { 
            get
            {                
                return this.cores;
            }
            set
            {
                if (value < MinNumOfCores || value > MaxNumOfCores )
                {
                    throw new InvalidRangeException<byte>(string.Format
                        ("Number of cores \"{0}\" are out of range", value), MinNumOfCores, MaxNumOfCores);
                }
                this.cores = value;
            }
        }
    }
}
