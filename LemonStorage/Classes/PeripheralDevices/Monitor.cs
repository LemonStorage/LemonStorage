namespace LemonStorage.Classes.PeripheralDevices
{
    using LemonStorage.Interfaces;
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class Monitor : PeripheralDevice, IPeripheralDevices, IProduct, ISavable
    {
        private int size;

        public Monitor(decimal price = 1, string brand = "Unknown", string model = "Unknown", string color = "Unknown", int size=1)
            :base(price, brand, model, color)
        {
            this.Size = size;
        }
        public int Size
        {
            get 
            { 
                return this.size; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The size of the monitor can not be ");
                }
                this.size = value; 
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
                SubSetID.Value = 6;
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
                Details.Value = "Size:" + this.Size;
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
