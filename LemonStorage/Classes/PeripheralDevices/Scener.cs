namespace LemonStorage.Classes.PeripheralDevices
{
    using LemonStorage.Interfaces;
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class Scener : PeripheralDevice, IPeripheralDevices, IProduct, ISavable
    {
        private int resolution;

        public Scener(decimal price, string brand, string model, string color, int resolution)
            : base(price, brand, model, color)
        {
            this.Resolution = resolution;
        }
        public int Resolution
        {
            get
            {
                return this.resolution;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The scener resolution can not be less or equal to zero");
                }
                this.resolution = value;
            }
        }

        public override void SaveToSQL()
        {
            SqlConnection conn = LemonStorage.LemonStorageMain.CreateConnection();
            using (conn)
            {
                SqlCommand cmnd = new SqlCommand("dbo.AddProduct", conn);
                cmnd.CommandType = CommandType.StoredProcedure;
                cmnd.CommandText = "AddProduct";
                SqlParameter SubSetID = new SqlParameter("@SubSetID", SqlDbType.Int);
                SubSetID.Value = 8;
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
                Details.Value = "Resolution:" + this.Resolution; 
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
