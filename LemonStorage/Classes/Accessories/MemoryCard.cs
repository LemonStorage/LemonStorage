namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public class MemoryCard : Accessories, IProduct
    {
        private const int MinMemoriSizeInMB = 256;

        private int memorySizeInMB;

        public MemoryCard(int price, string brand, string model, string color, int memorySize, string material)
            : base(price, brand, model, color, material)
        {
            this.MemorySize = memorySize;
            // Types: M2, SD, microSD
        }

        public int MemorySize
        {
            get
            {               
                return this.memorySizeInMB;
            }
            set
            {
                if (value <= MinMemoriSizeInMB)
                {
                    throw new ArgumentOutOfRangeException(string.Format
                        ("Size of memory must be more than {0}", MinMemoriSizeInMB));
                }
                if (value % 2 != 0)
                {
                    throw new ArgumentException("Memory size must devidible by 2");
                }
                this.memorySizeInMB = value;
            }
        }
    }
}
