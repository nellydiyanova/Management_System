using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Stock_reference : Form
    {
        public Stock_reference()
        {
            InitializeComponent();
        }

        Login frm = new Login();
        SqlConnection myConnection;
        SqlCommand myCommand = default(SqlCommand);
        SqlDataAdapter adapt;

        private void displayData()
        {
            myConnection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Inventory", myConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void Stock_reference_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SystemDataSet34.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter2.Fill(this.dB_SystemDataSet34.Inventory);

            try
            {
                myConnection = new SqlConnection(frm.cs);
                myCommand = new SqlCommand("Select * from Inventory", myConnection);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                displayData();
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}