namespace LemonStorage.Classes
{
    using LemonStorage.Interfaces;

    public abstract class Product: IProduct
    {
        public decimal Price
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public string Brand
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public uint Quantity
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }


        public string Model
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public System.ConsoleColor Color
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void Load()
        {
            throw new System.NotImplementedException();
        }

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
