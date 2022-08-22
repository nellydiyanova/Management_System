﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Management_System
{
    public partial class New_order : Form
    {
        public New_order()
        {
            InitializeComponent();
        }

        Login frm = new Login();
        SqlConnection myConnection;
        SqlCommand myCommand = default(SqlCommand);
        SqlDataAdapter adapt;
        DataTable dt = new DataTable();

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
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select * from Inventory where product_name='" + treeView1.SelectedNode + "'", myConnection);
            myConnection.Close();
        }

        private void displayData3()
        {
            myConnection.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("Select * from Users where username='" + Login.passingText + "'", myConnection);
            myConnection.Close();
        }

        private void displayData4()
        {
            myConnection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select * from Cart", myConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void CalculateFullPrice()
        {
            double sale_price, quantity;
            if (double.TryParse(textBox3.Text, out sale_price) && double.TryParse(textBox4.Text, out quantity))
            {
                textBox5.Text = (sale_price * quantity).ToString();
            }
        }
        
        private void CalculateQuantity()
        {
            double quantity=0, full_quantity = 0;
            quantity = Convert.ToDouble(textBox4.Text);
            full_quantity += quantity;
            textBox8.Text = Convert.ToString(full_quantity);
        }

        private void RECalculateQuantity()
        {
            double quantity = 0, full_quantity = 0;
            quantity = Convert.ToDouble(textBox4.Text);
            full_quantity -= quantity;
            textBox8.Text = Convert.ToString(full_quantity);
        }

        private void CalculateTotal()
        {
            double full_price;
            if (double.TryParse(textBox5.Text, out full_price))
            {
                textBox9.Text = full_price.ToString();
            }
        }

        private void RECalculateTotal()
        {
            double full_price;
            if (double.TryParse(textBox5.Text, out full_price))
            {
                textBox9.Text = full_price.ToString();
            }
        }

        private void deleteData()
        {
            myConnection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("delete from Cart", myConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void New_order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SystemDataSet18.Cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter.Fill(this.dB_SystemDataSet18.Cart);
            // TODO: This line of code loads data into the 'dB_SystemDataSet17.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.dB_SystemDataSet17.Status);
            // TODO: This line of code loads data into the 'dB_SystemDataSet16.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dB_SystemDataSet16.Clients);
            // TODO: This line of code loads data into the 'dB_SystemDataSet14.Warehouses' table. You can move, or remove it, as needed.
            this.warehousesTableAdapter.Fill(this.dB_SystemDataSet14.Warehouses);
            
            TreeNode parentnode = new TreeNode("Номенклатура");
            treeView1.Nodes.Add(parentnode);
            TreeNode firtsnode = treeView1.Nodes[0];
            firtsnode.ImageIndex = 2;
            firtsnode.SelectedImageIndex = 2;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox5.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox10.Text = Convert.ToString(Login.passingText);
            comboBox1.Text = "";
            comboBox2.Text = "";
            button1.BackColor = System.Drawing.Color.LightGreen;
            button5.BackColor = System.Drawing.Color.LightGreen;
            button3.BackColor = System.Drawing.Color.LightGreen;

            try
            {
                myConnection = new SqlConnection(frm.cs);
                myCommand = new SqlCommand("Select product_name from Inventory", myConnection);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                displayData1();
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            myConnection = new SqlConnection(frm.cs);
            myCommand = new SqlCommand("Select * from Users where username=@username", myConnection);
            myConnection.Open();
            myCommand.Parameters.AddWithValue("@username", Login.passingText);
            myConnection.Close();
            displayData3();
            myCommand.Connection.Open();
            SqlDataReader myreader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
            if (myreader.Read() == true)
            {
                textBox10.Text = myreader["username"].ToString();
            }
            if (myConnection.State == ConnectionState.Open)
            {
                myConnection.Dispose();
            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            if (selectedNode != treeView1.Nodes[0] && selectedNode != null)
            {
                if (selectedNode.Parent != null)
                {
                    comboBox1.Text = "";
                    textBox4.Clear();
                    textBox5.Clear();
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("Select * from Inventory where product_name=@product_name", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@product_name", e.Node.Text);
                    myConnection.Close();
                    displayData2();
                    myCommand.Connection.Open();
                    SqlDataReader myreader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    if (myreader.Read() == true)
                    {
                        textBox1.Text = myreader["id_product"].ToString();
                        textBox2.Text = myreader["product_name"].ToString();
                        textBox3.Text = myreader["sale_price"].ToString();
                    }

                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("insert into Cart(id_product, warehouse, product_name, sale_price, quantity, full_price) values(@id_product, @warehouse, @product_name, @sale_price, @quantity, @full_price)", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@id_product", textBox1.Text);
                    myCommand.Parameters.AddWithValue("@warehouse", comboBox1.Text);
                    myCommand.Parameters.AddWithValue("@product_name", textBox2.Text);
                    myCommand.Parameters.AddWithValue("@sale_price", Convert.ToDouble(textBox3.Text));
                    myCommand.Parameters.AddWithValue("@quantity", Convert.ToDouble(textBox4.Text));
                    myCommand.Parameters.AddWithValue("@full_price", Convert.ToDouble(textBox5.Text));
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    displayData4();
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }

                    CalculateTotal();
                    CalculateQuantity();
                    textBox1.Clear();
                    comboBox1.Text = "";
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(frm.cs);
                myCommand = new SqlCommand("delete Cart where id_product=@id_product", myConnection);
                myConnection.Open();
                myCommand.Parameters.AddWithValue("@id_product", textBox1.Text);
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                displayData4();
                MessageBox.Show("Успешно изтрита стока!");
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }

                textBox1.Clear();
                comboBox1.Text = "";
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("update Cart set id_product=@id_product, warehouse=@warehouse, product_name=@product_name, sale_price=@sale_price, quantity=@quantity, full_price=@full_price where id_product=@id_product", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@id_product", textBox1.Text);
                    myCommand.Parameters.AddWithValue("@warehouse", comboBox1.Text);
                    myCommand.Parameters.AddWithValue("@product_name", textBox2.Text);
                    myCommand.Parameters.AddWithValue("@sale_price", Convert.ToDouble(textBox3.Text));
                    myCommand.Parameters.AddWithValue("@quantity", Convert.ToDouble(textBox4.Text));
                    myCommand.Parameters.AddWithValue("@full_price", Convert.ToDouble(textBox5.Text));
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Успешно редактирана стока!");
                    displayData4();
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }

                    CalculateTotal();
                    CalculateQuantity();
                    textBox1.Clear();
                    comboBox1.Text = "";
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
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
        
        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var searchFor = textBox6.Text.Trim().ToUpper();
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
        
        private void button4_Click(object sender, EventArgs e)
        {
            var searchFor = textBox6.Text.Trim().ToUpper();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CalculateFullPrice();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CalculateFullPrice();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0 && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && comboBox2.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("insert into Orders(ID, products_name, quantity, full_price, client, date, status, username) values(@ID, @products_name, @quantity, @full_price, @client, @date, @status, @username)", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@ID", textBox7.Text);
                    myCommand.Parameters.AddWithValue("@products_name", dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    myCommand.Parameters.AddWithValue("@quantity", Convert.ToDouble(textBox8.Text));
                    myCommand.Parameters.AddWithValue("@full_price", Convert.ToDouble(textBox9.Text));
                    myCommand.Parameters.AddWithValue("@client", listBox1.Text);
                    myCommand.Parameters.AddWithValue("@date", Convert.ToDateTime(dateTimePicker1.Text));
                    myCommand.Parameters.AddWithValue("@status", comboBox2.Text);
                    myCommand.Parameters.AddWithValue("@username", textBox10.Text);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Успешно въведена нова поръчка!");
                    deleteData();
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }

                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    comboBox2.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                this.Hide();
                Orders f = new Orders();
                f.Show();
            }

            else
            {
                MessageBox.Show("Поръчката не е довършена!", "Не може да продължите напред!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}