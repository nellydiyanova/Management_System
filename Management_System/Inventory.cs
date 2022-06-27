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
                treeView1.ImageList = imageList1;
                treeView1.ImageIndex = 0;
            }
            myConnection.Close();
        }

        private void displayData3()
        {
            myConnection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select * from Warehouses where warehouse='" + treeView1.SelectedNode + "'", myConnection);
            myConnection.Close();
        }

        private void displayData4()
        {
            myConnection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select * from Inventory where product_name='" + treeView1.SelectedNode + "'", myConnection);
            myConnection.Close();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;

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
            textBox1.Focus();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (this.treeView1.Nodes[0].IsSelected)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                comboBox1.Text = "";
            }

            var selectedNode = treeView1.SelectedNode;
            if (selectedNode != null)
            {
                if (selectedNode.Parent == null)
                {
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("Select * from Warehouses where warehouse=@warehouse", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@warehouse", e.Node.Text);
                    myConnection.Close();
                    displayData3();
                    myCommand.Connection.Open();
                    SqlDataReader myreader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    if (myreader.Read() == true)
                    {
                        textBox1.Text = myreader["id_warehouse"].ToString();
                        textBox2.Text = myreader["warehouse"].ToString();
                        textBox3.Text = myreader["address"].ToString();
                        textBox4.Text = myreader["zip_code"].ToString();
                    }
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }
                }
                else
                if (selectedNode.Parent != null)
                {
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("Select * from Inventory where product_name=@product_name", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@product_name", e.Node.Text);
                    myConnection.Close();
                    displayData4();
                    myCommand.Connection.Open();
                    SqlDataReader myreader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    if (myreader.Read() == true)
                    {
                        textBox5.Text = myreader["id_product"].ToString();
                        textBox6.Text = myreader["warehouse"].ToString();
                        textBox7.Text = myreader["product_name"].ToString();
                        textBox8.Text = myreader["delivery_price"].ToString();
                        textBox9.Text = myreader["sale_price"].ToString();
                        textBox10.Text = myreader["measure"].ToString();
                        comboBox1.Text = myreader["supplier"].ToString();
                    }
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }
                }
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
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

            TreeNode node = new TreeNode(textBox2.Text);
            treeView1.Nodes.Add(node);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
            groupBox1.Visible = false;
        }

        private void новаСтокаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            textBox5.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(frm.cs);
                myCommand = new SqlCommand("insert into Inventory(id_product, product_name, delivery_price, sale_price, measure, supplier, warehouse) values(@id_product, @product_name, @delivery_price, @sale_price, @measure, @supplier, @warehouse)", myConnection);
                myConnection.Open();
                myCommand.Parameters.AddWithValue("@id_product", textBox5.Text);
                myCommand.Parameters.AddWithValue("@warehouse", textBox6.Text);
                myCommand.Parameters.AddWithValue("@product_name", textBox7.Text);
                myCommand.Parameters.AddWithValue("@delivery_price", textBox8.Text);
                myCommand.Parameters.AddWithValue("@sale_price", textBox9.Text);
                myCommand.Parameters.AddWithValue("@measure", textBox10.Text);
                myCommand.Parameters.AddWithValue("@supplier", comboBox1.Text);
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Успешно въведена нова стока!");
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TreeNode node = new TreeNode(textBox7.Text);
            TreeNode childnode = treeView1.Nodes[0];
            node.Nodes.Add(node);

            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();

            groupBox2.Visible = false;
        }
    }
}