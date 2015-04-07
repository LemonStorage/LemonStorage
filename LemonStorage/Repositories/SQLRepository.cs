using LemonStorage.Interfaces;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LemonStorage.Repositories
{
    public class SQLRepository : Repository, IProductRepository
    {
        public override void Run()
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
