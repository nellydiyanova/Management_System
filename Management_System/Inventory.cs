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
        SqlConnection myConnection;
        SqlCommand myCommand = default(SqlCommand);
        SqlDataAdapter adapt;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();

        private void displayData1()
        {
            myConnection.Open();
            adapt = new SqlDataAdapter("Select product_name from Inventory", myConnection);
            adapt.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode childnode = treeView1.Nodes[0];
                childnode.Nodes.Add(dr["product_name"].ToString());
            }
            myConnection.Close();
        }

        private void displayData2()
        {
            myConnection.Open();
            adapt = new SqlDataAdapter("Select warehouse from Warehouses", myConnection);
            adapt.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                TreeNode parentnode = new TreeNode(dr["warehouse"].ToString());
                treeView1.Nodes.Add(parentnode);
            }
            myConnection.Close();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            try
            {
                myConnection = new SqlConnection(frm.cs);
                myCommand = new SqlCommand("Select product_name from Inventory", myConnection);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                displayData1();
                displayData2();
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

        private void новСкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(frm.cs);
                myCommand = new SqlCommand("insert into Warehouses(id_warehouse, warehouse, address, zip_code) values(@id_warehouse, @warehouse, @address, @zip_code)", myConnection);
                myConnection.Open();
                myCommand.Parameters.AddWithValue("@id_warehouse", textBox1.Text);
                myCommand.Parameters.AddWithValue("@warehouse", textBox2.Text);
                myCommand.Parameters.AddWithValue("@address", textBox3.Text);
                myCommand.Parameters.AddWithValue("@zip_code", textBox4.Text);
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Успешно въведен нов склад!");
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TreeNode node = new TreeNode(textBox1.Text);
            treeView1.Nodes.Add(node);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
            groupBox1.Visible = false;
        }
    }
}