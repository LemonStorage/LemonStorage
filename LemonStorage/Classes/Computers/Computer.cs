namespace LemonStorage.Classes.Computers
{
    using LemonStorage.Interfaces;
    using System;

    public abstract class Computer : Product, IProduct, IComputer
    {
        private string processor;
        private uint ram;
        private uint hddSize;
        private string videoCardModel;
        private uint videocardMemory;
        private string soundCard;

        public Computer(decimal price, string brand, string model, string color, string processor, uint ram, uint hddSize, string videoCardModel, string soundCard)
            :base(price, brand, model, color)
        {
            this.Processor = processor;
            this.Ram = ram;
            this.HDDSize = hddSize;
            this.VideoCardModel = videoCardModel;
            this.SoundCard = soundCard;
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
                return this.ram;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The ram can not be less or equal to zero");
                }
                this.ram = value;
            }
        }

        public uint HDDSize
        {
            get
            {
                return this.hddSize;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The HDD Size can not be less or equal to zero");
                }
                this.hddSize = value;
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
                return this.videocardMemory;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The video card memory can not be less or equal to zero");
                }
                this.videocardMemory = value;
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

        public abstract void Save();

        public abstract void Load();
    }
}
