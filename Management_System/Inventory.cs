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
        SqlDataAdapter adapt;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();

        private void displayData1()
        {
            myconnection.Open();
            adapt = new SqlDataAdapter("Select product_name from Inventory", myconnection);
            adapt.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode childnode = treeView1.Nodes[0];
                childnode.Nodes.Add(dr["product_name"].ToString());
            }
            myconnection.Close();
        }

        private void displayData2()
        {
            myconnection.Open();
            adapt = new SqlDataAdapter("Select warehouse from Warehouses", myconnection);
            adapt.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                TreeNode parentnode = new TreeNode(dr["warehouse"].ToString());
                treeView1.Nodes.Add(parentnode);
            }
            myconnection.Close();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            try
            {
                myconnection = new SqlConnection(frm.cs);
                mycommand = new SqlCommand("Select product_name from Inventory", myconnection);
                myconnection.Open();
                mycommand.ExecuteNonQuery();
                myconnection.Close();
                displayData1();
                displayData2();
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