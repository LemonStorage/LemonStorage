using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemonStorage.GUI
{
    public partial class ToDoForm : Form
    {
        //public static SqlConnection CreateConnection()
        //{
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = "Data Source=User-PC;Initial Catalog=LemonStorage;Integrated Security=True";
        //    return conn;
        //}

        public ToDoForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ToDoForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = LemonStorage.LemonStorageMain.CreateConnection();
            using (conn)
            {
                string sql2 = "SELECT * FROM Products WHERE Quantity <= " + 10;
                SqlDataAdapter connect2 = new SqlDataAdapter(sql2, conn);
                DataSet ds2 = new DataSet();
                connect2.Fill(ds2);
                dataGridView1.DataSource = ds2.Tables[0];

            }
        }
    }
}
