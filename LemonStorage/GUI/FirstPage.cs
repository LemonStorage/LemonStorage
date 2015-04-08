using LemonStorage.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemonStorage
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct f = new AddProduct();
            f.Show();
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                }
            }
           SqlConnection conn = LemonStorage.LemonStorageMain.CreateConnection();
           using (conn)
           {
               string sql2 = "SELECT * FROM Products WHERE Quantity <= " + 10;
               SqlDataAdapter connect2 = new SqlDataAdapter(sql2, conn);
               DataSet ds2 = new DataSet();
               connect2.Fill(ds2);
               if (ds2.Tables[0].Rows.Count!=0)
               {
                   ToDoForm f = new ToDoForm();
                   f.ShowDialog();
               }
           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchProducts f = new SearchProducts();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you really want to exit?","Exit",MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                this.Close();

            }
            else { }
            
        }

    }
}
