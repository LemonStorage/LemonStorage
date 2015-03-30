namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public class MemoryCard : Accessories, IProduct
    {
        private const int MinMemoriSize = 256;

        private int memorySizeInMB;

        public MemoryCard(int price, string brand, string model, string color, int memorySize, string type)
            : base(price, brand, model, color, type)
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
                if (value <= MinMemoriSize)
                {
                    throw new ArgumentOutOfRangeException(string.Format
                        ("Size of memory must be more than {0}", MinMemoriSize));
                }
                if (value % 2 != 0)
                {
                    throw new ArgumentException("Memory size must devidible by 2");
                }
                this.memorySizeInMB = value;
            }
        }

        // TODO: Implement the logic of the MemoryCard.Save()
        //public override void Save()
        //{
        //    throw new NotImplementedException();
        //}
        //// TODO: Implement the logic of the MemoryCard.Load()
        //public override void Load()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
