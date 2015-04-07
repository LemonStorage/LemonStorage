namespace LemonStorage.Classes.Computers
{
    using LemonStorage.Interfaces;
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class Laptop : Computer, IComputer, IProduct, ISavable
    {
        private int batteryDuration;
        private double weight;
        private int size;

        public Laptop(decimal price, string brand, string model, string color, string processor, uint ram, uint hddSize, string videoCardModel, string soundCard, int batteryDuration, double weight, int size, byte cores)
            : base(price, brand, model, color, processor, ram, hddSize, videoCardModel, soundCard, cores)
        {
            this.BatteryDuration = batteryDuration;
            this.Weight = weight;
            this.Size = size;
        }

        public int BatteryDuration
        {
            get
            {
                if (this.batteryDuration <= 0)
                {
                    throw new ArgumentException("The battery duration can not be less or equal to zero");
                }
                return this.batteryDuration;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The battery duration can not be less or equal to zero");
                }
                this.batteryDuration = value;
            }
        }
        public double Weight
        {
            get
            {
                if (this.weight <= 0)
                {
                    throw new ArgumentException("The laptop weight can not be less or equal to zero");
                }
                return this.weight;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The laptop weight can not be less or equal to zero");
                }
                this.weight = value;
            }
        }

        public int Size
        {
            get
            {
                if (this.size <= 0)
                {
                    throw new ArgumentException("The size of the laptop can not be less or equal to zero");
                }
                return this.size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The size of the laptop can not be less or equal to zero");
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
                Details.Value = "Processor:" + this.Processor + " Ram:" + this.Ram + " HDD:" + this.HDDSize + " Video card:" +
                    this.VideoCardModel + " Sound card:" + this.SoundCard + " Cores:" + this.Cores + " Battery:" + this.BatteryDuration
                    + " Size:" + this.Size + " Weight:" + this.Weight;
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
