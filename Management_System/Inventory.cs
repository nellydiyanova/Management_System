using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        public static string Status;
        private void displayData1()
        {
            myConnection.Open();
            adapt = new SqlDataAdapter("Select product_name from Inventory", myConnection);
            adapt.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode childnode = treeView1.Nodes[0].Nodes.Add(dr["product_name"].ToString());
                childnode.ImageIndex = 1;
                childnode.SelectedImageIndex = 1;
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
            // TODO: This line of code loads data into the 'dB_SystemDataSet29.Warehouses' table. You can move, or remove it, as needed.
            this.warehousesTableAdapter.Fill(this.dB_SystemDataSet29.Warehouses);
            // TODO: This line of code loads data into the 'dB_SystemDataSet6.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.dB_SystemDataSet6.Suppliers);

            TreeNode parentnode = new TreeNode("Номенклатура");
            treeView1.Nodes.Add(parentnode);
            TreeNode firtsnode = treeView1.Nodes[0];
            firtsnode.ImageIndex = 2;
            firtsnode.SelectedImageIndex = 2;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox12.Enabled = false;
            comboBox1.Enabled = true;
            comboBox2.Enabled = false;
            update_warehouse_button1.Enabled = true;
            update_product_button2.Enabled = true;
            update_warehouse_button1.BackColor = System.Drawing.Color.LightGreen;
            update_product_button2.BackColor = System.Drawing.Color.LightGreen;
            create_warehouse_button4.BackColor = System.Drawing.Color.LightGreen;
            create_product_button5.BackColor = System.Drawing.Color.LightGreen;

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

        private void newWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in treeView1.Nodes)
            {
                node.Checked = false;
                treeView1.SelectedNode = null;
            }

            groupBox1.Visible = true;
            groupBox2.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox2.Text = "";
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            comboBox1.Text = "";
            textBox2.Focus();
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = false;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            comboBox1.Enabled = true;
            update_warehouse_button1.Enabled = false;
            update_product_button2.Enabled = false;
            create_warehouse_button4.Enabled = true;
            create_product_button5.Enabled = true;
            checkBox1.Checked = true;
        }

        private void update_warehouse_button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Status = "Active";
            }

            else
            {
                Status = "Inactive";
            }

            TreeNode selectedNode = treeView1.SelectedNode;
            if (selectedNode != treeView1.Nodes[0] && textBox2.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("select * from Warehouses count(id_warehouse)", myConnection);
                    myCommand = new SqlCommand("update Warehouses set warehouse=@warehouse, address=@address, zip_code=@zip_code, status=@status where id_warehouse=@id_warehouse", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@id_warehouse", textBox1.Text);
                    myCommand.Parameters.AddWithValue("@warehouse", textBox2.Text);
                    myCommand.Parameters.AddWithValue("@address", textBox3.Text);
                    myCommand.Parameters.AddWithValue("@zip_code", textBox4.Text);
                    myCommand.Parameters.AddWithValue("@status", Status);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Успешно редактиран склад!");
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }

                    treeView1.SelectedNode.Text = textBox2.Text;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    groupBox1.Visible = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Въведете празните полета!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in treeView1.Nodes)
            {
                node.Checked = false;
                treeView1.SelectedNode = null;
            }

            groupBox1.Visible = false;
            groupBox2.Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox2.Enabled = true;
            comboBox2.Text = "";
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            comboBox1.Text = "";
            textBox7.Focus();
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = false;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            comboBox1.Enabled = true;
            update_warehouse_button1.Enabled = false;
            update_product_button2.Enabled = false;
            create_warehouse_button4.Enabled = false;
            create_product_button5.Enabled = true;
            checkBox2.Checked = true;
        }

        private void update_product_button2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Status = "Active";
            }

            else
            {
                Status = "Inactive";
            }

            if (textBox7.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("select * from Inventory count(id_product)", myConnection);
                    myCommand = new SqlCommand("update Inventory set product_name=@product_name, delivery_price=@delivery_price, sale_price=@sale_price, measure=@measure, supplier=@supplier, warehouse=@warehouse, status=@status where id_product=@id_product", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@id_product", textBox5.Text);
                    myCommand.Parameters.AddWithValue("@warehouse", comboBox2.Text);
                    myCommand.Parameters.AddWithValue("@product_name", textBox7.Text);
                    myCommand.Parameters.AddWithValue("@delivery_price", textBox8.Text);
                    myCommand.Parameters.AddWithValue("@sale_price", textBox9.Text);
                    myCommand.Parameters.AddWithValue("@measure", textBox10.Text);
                    myCommand.Parameters.AddWithValue("@supplier", comboBox1.Text);
                    myCommand.Parameters.AddWithValue("@status", Status);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Успешно редактирана стока!");
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }

                    treeView1.SelectedNode.Text = textBox7.Text;
                    textBox5.Clear();
                    comboBox2.Text = "";
                    comboBox2.Enabled = false;
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox10.Clear();
                    comboBox1.Text = "";
                    groupBox2.Visible = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Въведете празните полета!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stockReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_reference frm = new Stock_reference();
            frm.Show();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = false;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = false;
            update_warehouse_button1.Enabled = true;
            update_product_button2.Enabled = true;
            create_warehouse_button4.Enabled = false;
            create_product_button5.Enabled = false;

            TreeNode selectedNode = treeView1.SelectedNode;
            if (selectedNode == treeView1.Nodes[0])
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                textBox1.Clear();
                textBox1.Enabled = false;
                textBox2.Clear();
                textBox2.Enabled = false;
                textBox3.Clear();
                textBox3.Enabled = false;
                textBox4.Clear();
                textBox4.Enabled = false;
                textBox5.Clear();
                textBox5.Enabled = false;
                comboBox2.Text = "";
                textBox7.Clear();
                textBox7.Enabled = false;
                textBox8.Clear();
                textBox8.Enabled = false;
                textBox9.Clear();
                textBox9.Enabled = false;
                textBox10.Clear();
                textBox10.Enabled = false;
                comboBox1.Text = "";
                comboBox1.Enabled = false;
                update_warehouse_button1.Enabled = false;
                update_product_button2.Enabled = false;
                create_warehouse_button4.Enabled = false;
                create_product_button5.Enabled = false;
            }

            else
            {
                if (selectedNode != treeView1.Nodes[0] && selectedNode != null)
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
                            Status = myreader["status"].ToString();
                            if (Status == "Active")
                            {
                                checkBox1.Checked = true;
                            }

                            else
                            {
                                checkBox1.Checked = false;
                            }
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
                            comboBox2.Text = myreader["warehouse"].ToString();
                            textBox7.Text = myreader["product_name"].ToString();
                            textBox8.Text = myreader["delivery_price"].ToString();
                            textBox9.Text = myreader["sale_price"].ToString();
                            textBox10.Text = myreader["measure"].ToString();
                            comboBox1.Text = myreader["supplier"].ToString();
                            textBox12.Text = myreader["quantity"].ToString();
                            Status = myreader["status"].ToString();
                            if (Status == "Active")
                            {
                                checkBox2.Checked = true;
                            }

                            else
                            {
                                checkBox2.Checked = false;
                            }
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
        }

        public TreeNode Find(TreeNodeCollection nodes, string key)
        {
            key = key.ToUpper();
            Stack<TreeNode> stackNodes = new Stack<TreeNode>();
            foreach (TreeNode item in nodes)
            {
                stackNodes.Push(item);
            }

            while (stackNodes.Count > 0)
            {
                TreeNode currentNode = stackNodes.Pop();
                if (currentNode.Text.ToUpper() == key)
                {
                    return currentNode;
                }
                    
                else
                    foreach (TreeNode item in currentNode.Nodes)
                    {
                        stackNodes.Push(item);
                    }
            }

            return null;
        }

        private void textBox11_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var searchFor = textBox11.Text.Trim().ToUpper();
                if (searchFor != "")
                {
                    if (treeView1.Nodes.Count > 0)
                    {
                        if (SearchRecursive(treeView1.Nodes, searchFor))
                        {
                            treeView1.SelectedNode.Expand();
                            treeView1.Focus();
                        }
                    }
                }
            }
        }

        private bool SearchRecursive(IEnumerable nodes, string searchFor)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text.ToUpper().Contains(searchFor))
                {
                    treeView1.SelectedNode = node;
                    node.BackColor = Color.Yellow;
                }

                else
                {
                    node.BackColor = Color.Empty;
                }

                if (SearchRecursive(node.Nodes, searchFor))
                {
                    return true;
                }
            }

            return false; 
        }

        private void search_button3_Click(object sender, EventArgs e)
        {
            var searchFor = textBox11.Text.Trim().ToUpper();
            if (searchFor != "")
            {
                if (treeView1.Nodes.Count > 0)
                {
                    if (SearchRecursive(treeView1.Nodes, searchFor))
                    {
                        treeView1.SelectedNode.Expand();
                        treeView1.Focus();
                    }
                }
            }
        }

        private void create_warehouse_button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Status = "Active";
            }

            else
            {
                Status = "Inactive";
            }

            if (textBox2.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("select * from Warehouses count(id_warehouse)", myConnection);
                    myCommand = new SqlCommand("insert into Warehouses(warehouse, address, zip_code, status) values(@warehouse, @address, @zip_code, @status)", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@warehouse", textBox2.Text);
                    myCommand.Parameters.AddWithValue("@address", textBox3.Text);
                    myCommand.Parameters.AddWithValue("@zip_code", textBox4.Text);
                    myCommand.Parameters.AddWithValue("@status", Status);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Успешно въведен нов склад!");
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }

                    TreeNode node = new TreeNode(textBox2.Text);
                    treeView1.Nodes.Add(node);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    groupBox1.Visible = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Въведете празните полета!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void create_product_button5_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Status = "Active";
            }

            else
            {
                Status = "Inactive";
            }

            if (textBox7.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("select * from Inventory count(id_product)", myConnection);
                    myCommand = new SqlCommand("insert into Inventory(product_name, delivery_price, sale_price, measure, quantity, supplier, warehouse, status) values(@product_name, @delivery_price, @sale_price, @measure, @quantity, @supplier, @warehouse, @status)", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@warehouse", comboBox2.Text);
                    myCommand.Parameters.AddWithValue("@product_name", textBox7.Text);
                    myCommand.Parameters.AddWithValue("@delivery_price", textBox8.Text);
                    myCommand.Parameters.AddWithValue("@sale_price", textBox9.Text);
                    myCommand.Parameters.AddWithValue("@measure", textBox10.Text);
                    myCommand.Parameters.AddWithValue("@supplier", comboBox1.Text);
                    myCommand.Parameters.AddWithValue("@quantity", textBox12.Text);
                    myCommand.Parameters.AddWithValue("@status", Status);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Успешно въведена нова стока!");
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }

                    TreeNode node = new TreeNode(textBox7.Text);
                    TreeNode childnode = treeView1.Nodes[0];
                    childnode.Nodes.Add(node);
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                    textBox5.Clear();
                    comboBox2.Text = "";
                    comboBox2.Enabled = false;
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox10.Clear();
                    comboBox1.Text = "";
                    groupBox2.Visible = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Въведете празните полета!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}