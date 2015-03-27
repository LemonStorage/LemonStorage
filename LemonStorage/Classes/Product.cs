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

        //public uint Quantity
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


        public string Model
        {
            get
            {
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

        public abstract void Save();

        public abstract void Load();

        //public void Buy()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void Sell()
        //{
        //    throw new System.NotImplementedException();
        //}

        //int IProduct.Quantity()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
