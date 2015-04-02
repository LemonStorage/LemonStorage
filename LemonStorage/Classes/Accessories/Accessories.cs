namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public abstract class Accessories : Product, IProduct
    {
        private string material; // Plastic , Metal, Aluminium ...

        public Accessories(int price, string brand, string model, string color, string material)
            : base(price, brand, model, color)
        {
            this.Material = material;
        }

        public string Material
        {
            get
            {
                return this.material;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Material can not be empty");
                }
                this.material = value;
            }
        }
    }
}
