using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Revision : Form
    {
        public Revision()
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
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select * from Inventory", myConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void Revision_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SystemDataSet32.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.dB_SystemDataSet32.Inventory);

            TreeNode parentnode = new TreeNode("Номенклатура");
            treeView1.Nodes.Add(parentnode);
            TreeNode firtsnode = treeView1.Nodes[0];
            firtsnode.ImageIndex = 2;
            firtsnode.SelectedImageIndex = 2;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox7.Enabled = true;
            textBox8.Enabled = false;
            textBox9.Enabled = true;
            update_quantity_button1.Enabled = true;
            search_button2.Enabled = true;
            update_quantity_button1.BackColor = System.Drawing.Color.LightGreen;

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
        }

        private void update_quantity_button1_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            if (textBox1.Text != "" && textBox7.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("update Inventory set quantity=@quantity where id_product=@id_product", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@id_product", textBox1.Text);
                    myCommand.Parameters.AddWithValue("@quantity", textBox7.Text);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    displayData3();
                    MessageBox.Show("Успешно променено количество!");
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }

                    treeView1.SelectedNode.Text = textBox3.Text;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
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

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox7.Enabled = true;
            textBox8.Enabled = false;
            textBox9.Enabled = true;
            update_quantity_button1.Enabled = true;
            search_button2.Enabled = true;

            TreeNode selectedNode = treeView1.SelectedNode;
            if (selectedNode != treeView1.Nodes[0] && selectedNode != null)
            {
                if (selectedNode.Parent != null)
                {
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
                        textBox2.Text = myreader["warehouse"].ToString();
                        textBox3.Text = myreader["product_name"].ToString();
                        textBox4.Text = myreader["delivery_price"].ToString();
                        textBox5.Text = myreader["sale_price"].ToString();
                        textBox6.Text = myreader["measure"].ToString();
                        textBox7.Text = myreader["quantity"].ToString();
                        textBox8.Text = myreader["supplier"].ToString();
                    }

                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }
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

        private void textBox9_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var searchFor = textBox9.Text.Trim().ToUpper();
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

        private void search_button2_Click(object sender, EventArgs e)
        {
            var searchFor = textBox9.Text.Trim().ToUpper();
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

        private void DataTableToTextFile(DataTable dt, string outputFilePath)
        {
            int[] maxLengths = new int[dt.Columns.Count];

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                maxLengths[i] = dt.Columns[i].ColumnName.Length;

                foreach (DataRow row in dt.Rows)
                {
                    if (!row.IsNull(i))
                    {
                        int length = row[i].ToString().Length;

                        if (length > maxLengths[i])
                        {
                            maxLengths[i] = length;
                        }
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(outputFilePath, false))
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sw.Write(dt.Columns[i].ColumnName.PadRight(maxLengths[i] + 2));
                }

                sw.WriteLine();

                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        if (!row.IsNull(i))
                        {
                            sw.Write(row[i].ToString().PadRight(maxLengths[i] + 2));
                        }

                        else
                        {
                            sw.Write(new string(' ', maxLengths[i] + 2));
                        }
                    }

                    sw.WriteLine();
                }

                sw.Close();
            }
        }

        private void report_button2_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            Login frm = new Login();
            connectionString = frm.cs;

            DataTable dt = new DataTable();

            foreach (DataGridViewTextBoxColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.Name, column.ValueType);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dr = dt.NewRow();
                foreach (DataGridViewTextBoxColumn column in dataGridView1.Columns)
                {
                    if (row.Cells[column.Name].Value != null)
                    {
                        dr[column.Name] = row.Cells[column.Name].Value.ToString();
                    }
                }

                dt.Rows.Add(dr);
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string filePath = saveFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
            }

            DataTableToTextFile(dt, filePath);
            MessageBox.Show("Справката е създадена успешно!");
        }
    }
}