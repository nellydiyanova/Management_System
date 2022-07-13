using System;
using System.Collections;
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
            TreeNode parentnode = new TreeNode("Inventory");
            treeView1.Nodes.Add(parentnode);
            TreeNode firtsnode = treeView1.Nodes[0];
            firtsnode.ImageIndex = 2;
            firtsnode.SelectedImageIndex = 2;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            comboBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button1.BackColor = System.Drawing.Color.LightGreen;
            button2.BackColor = System.Drawing.Color.LightGreen;

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
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
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
            textBox1.Focus();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            comboBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button1.BackColor = System.Drawing.Color.LightGreen;
            button2.BackColor = System.Drawing.Color.LightGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            if (selectedNode != treeView1.Nodes[0] && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("update Warehouses set warehouse=@warehouse, address=@address, zip_code=@zip_code where id_warehouse=@id_warehouse", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@id_warehouse", textBox1.Text);
                    myCommand.Parameters.AddWithValue("@warehouse", textBox2.Text);
                    myCommand.Parameters.AddWithValue("@address", textBox3.Text);
                    myCommand.Parameters.AddWithValue("@zip_code", textBox4.Text);
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
                    pictureBox1.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            if (textBox1.Text != "" && textBox2.Text != "")
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

                    TreeNode node = new TreeNode(textBox2.Text);
                    treeView1.Nodes.Add(node);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    groupBox1.Visible = false;
                    pictureBox1.Visible = true;
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

        private void новаСтокаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in treeView1.Nodes)
            {
                node.Checked = false;
                treeView1.SelectedNode = null;
            }

            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = true;
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
            textBox5.Focus();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            comboBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button1.BackColor = System.Drawing.Color.LightGreen;
            button2.BackColor = System.Drawing.Color.LightGreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            if (textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("update Inventory set id_product=@id_product, product_name=@product_name, delivery_price=@delivery_price, sale_price=@sale_price, measure=@measure, supplier=@supplier, warehouse=@warehouse  where id_product=@id_product", myConnection);
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
                    MessageBox.Show("Успешно редактирана стока!");

                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }

                    treeView1.SelectedNode.Text = textBox7.Text;
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox10.Clear();
                    comboBox1.Text = "";
                    groupBox2.Visible = false;
                    pictureBox2.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            if (textBox5.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
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

                    TreeNode node = new TreeNode(textBox7.Text);
                    TreeNode childnode = treeView1.Nodes[0];
                    childnode.Nodes.Add(node);
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox10.Clear();
                    comboBox1.Text = "";
                    groupBox2.Visible = false;
                    pictureBox2.Visible = true;
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

        private void стоковаСправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_reference frm = new Stock_reference();
            frm.Show();
        }

        private void изтриванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            if (selectedNode != treeView1.Nodes[0] && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("delete Warehouses where id_warehouse=@id_warehouse", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@id_warehouse", textBox1.Text);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Успешно изтрит склад!");

                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }

                    treeView1.SelectedNode.Remove();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    groupBox1.Visible = false;
                    pictureBox1.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            if (selectedNode != treeView1.Nodes[0] && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("delete Inventory where id_product=@id_product", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@id_product", textBox5.Text);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Успешно изтрита стока!");

                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }

                    treeView1.SelectedNode.Remove();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox10.Clear();
                    groupBox2.Visible = false;
                    pictureBox2.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Изберете склад или стока за изтриване!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            comboBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button1.BackColor = System.Drawing.Color.LightGreen;
            button2.BackColor = System.Drawing.Color.LightGreen;

            TreeNode selectedNode = treeView1.SelectedNode;

            if (selectedNode == treeView1.Nodes[0])
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
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
                textBox6.Clear();
                textBox6.Enabled = false;
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
                button1.Enabled = false;
                button1.BackColor = System.Drawing.Color.Red;
                button2.Enabled = false;
                button2.BackColor = System.Drawing.Color.Red;
            }

            else
            {
                if (selectedNode != treeView1.Nodes[0] && selectedNode != null)
                {
                    if (selectedNode.Parent == null)
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = true;
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
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = false;
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
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    groupBox1.Visible = false;
                    groupBox2.Visible = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}