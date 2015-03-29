namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public abstract class Accessories : Product, IProduct
    {
        private string type;

        public Accessories(int price, string brand, string model, string color, string type)
            : base(price, brand, model, color)
        {
            this.Type = type;
        }

        public string Type
        {
            get
            {
                if (string.IsNullOrEmpty(this.type))
                {
                    throw new ArgumentNullException("Type can not be empty");
                }
                return this.type;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Type can not be empty");
                }
                this.type = value;
            }
        }

        public abstract void Save();

        public abstract void Load();
    }
}
