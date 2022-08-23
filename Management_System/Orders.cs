using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Orders : Form
    {
        public Orders()
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
            adapt = new SqlDataAdapter("select * from Orders", myConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SystemDataSet15.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.dB_SystemDataSet15.Orders);
            // TODO: This line of code loads data into the 'dB_SystemDataSet13.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.dB_SystemDataSet13.Status);
            // TODO: This line of code loads data into the 'dB_SystemDataSet12.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dB_SystemDataSet12.Clients);
            // TODO: This line of code loads data into the 'dB_SystemDataSet11.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.dB_SystemDataSet11.Inventory);

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            comboBox1.Text = "";

            try
            {
                myConnection = new SqlConnection(frm.cs);
                myCommand = new SqlCommand("Select * from Orders", myConnection);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            listBox1.Items.Clear();
            listBox1.Items.Add(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            listBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            listBox1.Items.Clear();
            listBox1.Items.Add(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            listBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("update Orders set ID=@ID, quantity=@quantity, full_price=@full_price, client=@client, date=@date, status=@status, username=@username where ID=@ID", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@ID", textBox1.Text);
                    myCommand.Parameters.AddWithValue("@quantity", Convert.ToDouble(textBox3.Text));
                    myCommand.Parameters.AddWithValue("@full_price", Convert.ToDouble(textBox4.Text));
                    myCommand.Parameters.AddWithValue("@client", listBox2.Text);
                    myCommand.Parameters.AddWithValue("@date", Convert.ToDateTime(dateTimePicker1.Text));
                    myCommand.Parameters.AddWithValue("@status", comboBox1.Text);
                    myCommand.Parameters.AddWithValue("@username", textBox2.Text);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Успешно редактирана поръчка!");
                    displayData();
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }

                    textBox1.Clear();
                    textBox2.Clear();
                    listBox1.Items.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    dateTimePicker1.Text = "";
                    comboBox1.Text = "";
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

        private void новаПоръчкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_order frm = new New_order();
            frm.Show();
        }

        private void изтрийПоръчкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("delete Orders where ID=@ID", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@ID", textBox1.Text);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Успешно изтрита поръчка!");
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }

                    textBox1.Clear();
                    listBox1.Items.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    dateTimePicker1.Text = "";
                    comboBox1.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        var new_Quantity = +int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        myConnection = new SqlConnection(frm.cs);
                        myCommand = new SqlCommand("update Inventory set quantity=quantity+@new_quantity, product_name=@product_name where product_name=@product_name", myConnection);
                        myConnection.Open();
                        myCommand.Parameters.AddWithValue("@product_name", dataGridView1.Rows[i].Cells[1].Value.ToString());
                        myCommand.Parameters.AddWithValue("@new_quantity", new_Quantity);
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                    }

                    displayData();
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }

                    textBox1.Clear();
                    listBox1.Items.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    dateTimePicker1.Text = "";
                    comboBox1.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Изберете поръчка за изтриване!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        private void button2_Click(object sender, EventArgs e)
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
            MessageBox.Show("Фактурата е създадена успешно!");
        }
    }
}