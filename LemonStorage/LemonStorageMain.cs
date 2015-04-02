namespace LemonStorage
{
    using System;
    using LemonStorage.Interfaces;
    using LemonStorage.Enumerations;
    using LemonStorage.Classes.Accessories;
    using LemonStorage.Classes.Computers;
    using LemonStorage.Classes.Mobiles;
    using LemonStorage.Classes.PeripheralDevices;
    using System.Data.SqlClient;
    using System.Data.SqlTypes;
    using System.Data;
    using System.Windows.Forms;

    class LemonStorageMain
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new FirstPage());

        }
        public static SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=User-PC;Initial Catalog=LemonStorage;Integrated Security=True";
            return conn;
        }
    }
}
