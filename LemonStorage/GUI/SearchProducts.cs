using LemonStorage.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace LemonStorage.GUI
{
    public partial class SearchProducts : Form
    {
        public SearchProducts()
        {
            InitializeComponent();
        }

        private void SearchProducts_Load(object sender, EventArgs e)
        {
            Increase.Visible = false;
            string[] Articuls = { "Brand", "Model", "Price" };
            comboBox1.DataSource = Articuls;
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = LemonStorage.LemonStorageMain.CreateConnection();
            using (conn)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    string sql2 = "Select *from Products where Brand like '%" + textBox1.Text + "%'";
                    SqlDataAdapter connect2 = new SqlDataAdapter(sql2, conn);
                    DataSet ds2 = new DataSet();
                    connect2.Fill(ds2);
                    dataGridView1.DataSource = ds2.Tables[0];
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    string sql2 = "Select *from Products where Model like '%" + textBox1.Text + "%'";
                    SqlDataAdapter connect2 = new SqlDataAdapter(sql2, conn);
                    DataSet ds2 = new DataSet();
                    connect2.Fill(ds2);
                    dataGridView1.DataSource = ds2.Tables[0];
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    string sql2 = "Select *from Products where Price = " + int.Parse(textBox1.Text);
                    SqlDataAdapter connect2 = new SqlDataAdapter(sql2, conn);
                    DataSet ds2 = new DataSet();
                    connect2.Fill(ds2);
                    dataGridView1.DataSource = ds2.Tables[0];
                }
                else
                {
                    MessageBox.Show("Choose a searchig by item!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = LemonStorage.LemonStorageMain.CreateConnection();
            using (conn)
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                System.Data.SqlClient.SqlDataAdapter SDA = new System.Data.SqlClient.SqlDataAdapter("Select * from Products", conn);
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Increase.Visible = true;
            SqlConnection conn = LemonStorage.LemonStorageMain.CreateConnection();
            using (conn)
            {
                SqlCommand comm0 = new SqlCommand("select * from Products where ProductID = @ID", conn);
                comm0.Parameters.Add("@ID", SqlDbType.Int).Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                try
                {
                    conn.Open();
                    SqlDataReader reader = comm0.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("There is no selecte row. Please select a row!");

                    }
                    reader.Close();
                }
                catch (SqlException ol)
                {
                    MessageBox.Show(ol.Message.ToString());
                }

            }
        }
        private void Increase_Click(object sender, EventArgs e)
        {
            SqlConnection conn = LemonStorage.LemonStorageMain.CreateConnection();
            using (conn)
            {
                DialogResult result1 = MessageBox.Show("Do you want to save the changes?",
    "Save changes",
    MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    SqlCommand cmnd = new SqlCommand("UpdateProducts", conn);
                    cmnd.CommandType = CommandType.StoredProcedure;
                    cmnd.CommandText = "UpdateProducts";
                    SqlParameter ProductID = new SqlParameter("@ProductID", SqlDbType.Int);
                    ProductID.Value = dataGridView1.CurrentRow.Cells[0].Value;
                    cmnd.Parameters.Add(ProductID);
                    SqlParameter Quantity = new SqlParameter("@Quantity", SqlDbType.Int);
                    Quantity.Value = dataGridView1.CurrentRow.Cells[5].Value;
                    cmnd.Parameters.Add(Quantity);
                    SqlParameter count = new SqlParameter("@e_ID", SqlDbType.Int);
                    count.Direction = ParameterDirection.Output;
                    cmnd.Parameters.Add(count);
                    try
                    {
                        conn.Open();
                        SqlDataReader dr = cmnd.ExecuteReader();
                        int res = (Int32)cmnd.Parameters["@e_ID"].Value;
                        if (res != 0)
                        {
                            MessageBox.Show("Customer edited successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Error!");
                        }
                    }
                    catch (SqlException se)
                    {
                        MessageBox.Show(se.ToString());
                    }
                }
                else
                {
                }
                Increase.Visible = false;
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Increase.Visible = true;
            SqlConnection conn = LemonStorage.LemonStorageMain.CreateConnection();
            using (conn)
            {
                SqlCommand comm0 = new SqlCommand("select * from Products where ProductID = @ID", conn);
                comm0.Parameters.Add("@ID", SqlDbType.Int).Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                try
                {
                    conn.Open();
                    SqlDataReader reader = comm0.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("There is no selecte row. Please select a row!");

                    }
                    reader.Close();
                }
                catch (SqlException ol)
                {
                    MessageBox.Show(ol.Message.ToString());
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

            SqlConnection conn = LemonStorage.LemonStorageMain.CreateConnection();
            using (conn)
            {
                DialogResult result1 = MessageBox.Show("Do you want to delete customer?",
    "Delete customer",
    MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {

                    SqlCommand cmnd = new SqlCommand("deleteProducts", conn);
                    cmnd.CommandType = CommandType.StoredProcedure;
                    cmnd.CommandText = "deleteProducts";
                    SqlParameter ProductID = new SqlParameter("@ProductID", SqlDbType.Int);
                    ProductID.Value = dataGridView1.CurrentRow.Cells[0].Value;
                    cmnd.Parameters.Add(ProductID);

                    try
                    {
                        conn.Open();
                        SqlDataReader dr = cmnd.ExecuteReader();
                        MessageBox.Show("Customer deleted successfully!");

                    }
                    catch (SqlException se)
                    {
                        MessageBox.Show(se.ToString());
                    }
                }
                else { }

            }
        }
    }
}
