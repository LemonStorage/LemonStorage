namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;
    using System.Data;
    using System.Data.SqlClient;

    class Handsfree : Accessories, IAccessories, IProduct, ISavable
    {
        private const int MinBatteryDuration = 5;
        private const int MinRange = 1;

        private string typeOfConnection;
        private int rangeInMeters;
        private int batteryDurationInHours;

        public Handsfree(int price, string brand, string model, string color, string material, int range, int batteryDuration)
            : base(price, brand, model, color, material)
        {
            this.TypeOfConnection = typeOfConnection;
            this.Range = range;
            this.BatteryDuration = batteryDuration;
            // Types: Wired, Bluetooth, Speakerphones 
        }

        public int Range
        {
            get
            {
                return this.rangeInMeters;
            }
            set
            {
                if (value <= MinRange)
                {
                    throw new ArgumentOutOfRangeException(string.Format
                        ("Range of the bluetooth handsfree more than {0}", MinRange));
                }
                this.rangeInMeters = value;
            }
        }

        public int BatteryDuration
        {
            get
            {
                return this.batteryDurationInHours;
            }
            set
            {
                if (value <= MinBatteryDuration)
                {
                    throw new ArgumentOutOfRangeException(string.Format
                        ("Working hours on battery must be more than {0} hours", MinBatteryDuration));
                }
                this.batteryDurationInHours = value;
            }
        }

        public string TypeOfConnection
        {
            get
            {
                return this.typeOfConnection;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Type of connection can be empty");
                }
                this.typeOfConnection = value;
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
                SubSetID.Value = 10;
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
                Details.Value = "Material:" + this.Material + " Range: " + this.Range.ToString() + " BatteryDuration: " + this.BatteryDuration.ToString();
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
