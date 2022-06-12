using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        Login frm = new Login();
        SqlConnection myconnection;
        SqlCommand mycommand = default(SqlCommand);
        SqlDataAdapter adapt, adapt1;
        DataTable dt = new DataTable();
        
        private void displayData()
        {
            myconnection.Open();
            adapt = new SqlDataAdapter("Select warehouse from Warehouses", myconnection);
            adapt1 = new SqlDataAdapter("Select product_name from Inventory", myconnection);
            adapt.Fill(dt);
            adapt1.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode node = new TreeNode(dr["warehouse"].ToString());
                node.Nodes.Add(dr["product_name"].ToString());
                treeView1.Nodes.Add(node);
            }
            myconnection.Close();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            try
            {
                myconnection = new SqlConnection(frm.cs);
                mycommand = new SqlCommand("Select * from Warehouses", myconnection);
                myconnection.Open();
                mycommand.ExecuteNonQuery();
                myconnection.Close();
                displayData();
                if (myconnection.State == ConnectionState.Open)
                {
                    myconnection.Dispose();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}