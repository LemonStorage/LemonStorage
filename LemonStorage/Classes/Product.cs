namespace LemonStorage.Classes
{
    using System;
    using LemonStorage.Interfaces;

    public abstract class Product: IProduct
    {
        private decimal price;
        private string brand;
        private string model;
        private string color;

        public Product(decimal price, string brand, string model, string color)
        {
            this.Price = price;
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
        }
        public decimal Price
        {
            get
            {
                if (this.price <= 0)
                {
                    throw new ArgumentException("The price can not be zero less or equal to zero.");
                }
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The price can not be zero less or equal to zero.");                  
                }
                this.price = value;
            }
        }

        public string Brand
        {
            get
            {
                if (string.IsNullOrEmpty(this.brand))
                {
                    throw new ArgumentException("The brand can not be empty");
                }
                return this.brand;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The brand can not be empty");
                }
                this.brand = value;
            }
        }

        public string Model
        {
            get
            {
                if (string.IsNullOrEmpty(this.model))
                {
                    throw new ArgumentException("The model can not be empty");
                }
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The model can not be empty");
                }
                this.model = value;
            }
        }

        public string Color
        {
            get
            {
                if (string.IsNullOrEmpty(this.color))
                {
                    throw new ArgumentException("The color can not be empty");
                }
                return this.color;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The color can not be empty");
                }
                this.color = value;
            }
        }
    }
}
