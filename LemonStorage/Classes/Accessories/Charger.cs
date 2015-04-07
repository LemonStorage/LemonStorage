namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;
    using System.Data;
    using System.Data.SqlClient;

    class Charger : Accessories, IAccessories, IProduct, ISavable
    {
        private bool withUSBPort;

        public Charger(int price, string brand, string model, string color, string material, bool withUSBPort)
            : base(price, brand, model, color, material)
        {
            this.withUSBPort = withUSBPort;
            // Types: For car, for computer with usb, normal or powerbank
        }

        public bool WithUSBPort 
        { 
            get
            {                
                return this.withUSBPort;
            }
            set
            {
                this.withUSBPort = value;
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
                SubSetID.Value = 7;
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
                Details.Value = "Material:" + this.Material + string.Format(" USB Port:{0}", this.WithUSBPort ? "No" : "Yes");
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
