namespace LemonStorage.Classes
{
    using System;
    using LemonStorage.Interfaces;
    using System.Data.SqlClient;
    using System.Data;

    public abstract class Product : IProduct, ISavable
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

        public virtual void SaveToSQL()
        {
            SqlConnection conn = LemonStorage.LemonStorageMain.CreateConnection();
            using (conn)
            {
                SqlCommand cmnd = new SqlCommand("dbo.AddProduct", conn);
                cmnd.CommandType = CommandType.StoredProcedure;
                cmnd.CommandText = "AddProduct";
                SqlParameter SubSetID = new SqlParameter("@SubSetID", SqlDbType.Int);
                SubSetID.Value = 1;
                cmnd.Parameters.Add(SubSetID);
                SqlParameter Brand = new SqlParameter("@Brand", SqlDbType.NVarChar);
                Brand.Value = this.Brand;
                cmnd.Parameters.Add(Brand);
                SqlParameter Model = new SqlParameter("@Model", SqlDbType.NVarChar);
                Model.Value = this.Model;
                cmnd.Parameters.Add(Model);
                SqlParameter Price = new SqlParameter("@Price", SqlDbType.Money);
                Price.Value = this.Price;
                cmnd.Parameters.Add(Price);
                SqlParameter Quantity = new SqlParameter("@Qty", SqlDbType.NVarChar);
                Quantity.Value = 0;
                cmnd.Parameters.Add(Quantity);
                SqlParameter Color = new SqlParameter("@Color", SqlDbType.NVarChar);
                Color.Value = this.Color;
                cmnd.Parameters.Add(Color);
                SqlParameter Details = new SqlParameter("@Details", SqlDbType.NVarChar);
                Details.Value ="";
                cmnd.Parameters.Add(Details);
                try
                {
                    conn.Open();
                    cmnd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw new Exception();
                }

            }
        }
    }
}
