namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public class MemoryCard : Accessories, IProduct
    {
        private int memorySize;
        private string type;

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
                if (this.memorySize <= 0)
                {
                    throw new ArgumentOutOfRangeException("Size of memory must be a positive number");
                }
                return this.memorySize;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Size of memory must be a positive number");
                }
                this.memorySize = value;
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
