namespace LemonStorage
{
    using System;
    using LemonStorage.Interfaces;
    using LemonStorage.Enumerations;
    using LemonStorage.Classes.Accessories;
    using LemonStorage.Classes.Computers;
    using LemonStorage.Classes.Mobiles;
    using LemonStorage.Classes.PeripheralDevices;
    using LemonStorage.App_Data;
    using System.Data.SqlClient;
    using System.Data.SqlTypes;
    using System.Data;

    class LemonStorageMain
    {
        public static SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\\Users\\User\\Desktop\\LemonStorage\\LemonStorage\\App_Data\\LemonStorage.mdf;Integrated Security=True";
            return conn;
        }

        static void Main()
        {
           
            Laptop lap = new Laptop(1200, "Apple", "Macbook", "White", "IntelCorei7", 3, 520, "Nehto", "Neshto", 8, 15.6, 5, 6);
            SqlConnection conn = CreateConnection();
            using (conn)
            {
                SqlCommand cmnd = new SqlCommand("dbo.AddProduct", conn);
                cmnd.CommandType = CommandType.StoredProcedure;
                cmnd.CommandText = "AddProduct";
                SqlParameter SubSetID = new SqlParameter("@SubSetID", SqlDbType.Int);
                SubSetID.Value = 1;
                cmnd.Parameters.Add(SubSetID);
                SqlParameter Brand = new SqlParameter("@Brand", SqlDbType.NVarChar);
                Brand.Value = lap.Brand;
                cmnd.Parameters.Add(Brand);
                SqlParameter Model = new SqlParameter("@Model", SqlDbType.NVarChar);
                Model.Value = lap.Model;
                cmnd.Parameters.Add(Model);
                SqlParameter Price = new SqlParameter("@Price", SqlDbType.Money);
                Price.Value =lap.Price;
                cmnd.Parameters.Add(Price);
                SqlParameter Quantity = new SqlParameter("@Qty", SqlDbType.NVarChar);
                Quantity.Value = 15;
                cmnd.Parameters.Add(Quantity);
                SqlParameter Color = new SqlParameter("@Color", SqlDbType.NVarChar);
                Color.Value = lap.Color;
                cmnd.Parameters.Add(Color);
                SqlParameter Details = new SqlParameter("@Details", SqlDbType.NVarChar);
                Details.Value = lap.Ram;
                cmnd.Parameters.Add(Details);
                try
                {
                    conn.Open();
                    cmnd.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    throw new Exception();
                }
          
            }
        }
    }
}
