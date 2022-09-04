using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Filling_cabinet : Form
    {
        public Filling_cabinet()
        {
            InitializeComponent();
        }

        Login frm = new Login();
        SqlConnection myConnection;
        SqlCommand myCommand = default(SqlCommand);
        SqlDataAdapter adapt;

        public static bool IsValidEmail(string email)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            return emailRegex.IsMatch(email);
        }

        public static bool IsValidPhone(string phone)
        {
            Regex phoneRegex = new Regex(@"^(\+)?(359|0)8[789]\d{1}(|-| )\d{3}(|-| )\d{3}$", RegexOptions.IgnoreCase);
            return phoneRegex.IsMatch(phone);
        }

        private void displayData1()
        {
            myConnection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Clients", myConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void displayData2()
        {
            myConnection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Suppliers", myConnection);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            myConnection.Close();
        }

        private void Filling_cabinet_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            update_client_button1.BackColor = System.Drawing.Color.LightGreen;
            update_supplier_button2.BackColor = System.Drawing.Color.LightGreen;
            create_client_button3.BackColor = System.Drawing.Color.LightGreen;
            create_supplier_button4.BackColor = System.Drawing.Color.LightGreen;
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SystemDataSet3.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dB_SystemDataSet3.Clients);

            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SystemDataSet4.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.dB_SystemDataSet4.Suppliers);

            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            update_client_button1.Enabled = true;
            update_supplier_button2.Enabled = false;
            create_client_button3.Enabled = false;
            create_supplier_button4.Enabled = false;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            update_client_button1.Enabled = true;
            update_supplier_button2.Enabled = false;
            create_client_button3.Enabled = false;
            create_supplier_button4.Enabled = false;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox9.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox10.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox11.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox12.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox13.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox14.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBox15.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            textBox16.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();

            update_client_button1.Enabled = false;
            update_supplier_button2.Enabled = true;
            create_client_button3.Enabled = false;
            create_supplier_button4.Enabled = false;
        }

        void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox9.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox10.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox11.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox12.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox13.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox14.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox15.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox16.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();

            update_client_button1.Enabled = false;
            update_supplier_button2.Enabled = true;
            create_client_button3.Enabled = false;
            create_supplier_button4.Enabled = false;
        }

        private void newClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
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
            update_client_button1.Enabled = false;
            update_supplier_button2.Enabled = false;
            create_client_button3.Enabled = true;
            create_supplier_button4.Enabled = false;
            textBox1.Focus();

            // TODO: This line of code loads data into the 'dB_SystemDataSet3.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dB_SystemDataSet3.Clients);
        }

        private void update_client_button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("update Clients set client=@client, bullstat=@bullstat, MOL=@MOL, city=@city, post_code=@post_code, address=@address, email=@email, phone=@phone where bullstat=@bullstat", myConnection);
                    myConnection.Open();
                    if ((IsValidEmail(textBox7.Text) == true || textBox7.Text == "") && (IsValidPhone(textBox8.Text) == true || textBox8.Text == ""))
                    {
                        myCommand.Parameters.AddWithValue("@client", textBox1.Text);
                        myCommand.Parameters.AddWithValue("@bullstat", textBox2.Text);
                        myCommand.Parameters.AddWithValue("@MOL", textBox3.Text);
                        myCommand.Parameters.AddWithValue("@city", textBox4.Text);
                        myCommand.Parameters.AddWithValue("@post_code", textBox5.Text);
                        myCommand.Parameters.AddWithValue("@address", textBox6.Text);
                        myCommand.Parameters.AddWithValue("@email", textBox7.Text);
                        myCommand.Parameters.AddWithValue("@phone", textBox8.Text);
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                        MessageBox.Show("Успешно редактиран клиент!");
                        displayData1();
                        if (myConnection.State == ConnectionState.Open)
                        {
                            myConnection.Dispose();
                        }

                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                    }

                    else
                    if (IsValidEmail(textBox7.Text) == false && textBox7.Text != "")
                    {
                        MessageBox.Show("Имейл адресът не е коректен!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    if (IsValidPhone(textBox8.Text) == false && textBox8.Text != "")
                    {
                        MessageBox.Show("Телефонният номер не е коректен!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void newSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            update_client_button1.Enabled = false;
            update_supplier_button2.Enabled = false;
            create_client_button3.Enabled = false;
            create_supplier_button4.Enabled = true;
            textBox9.Focus();

            // TODO: This line of code loads data into the 'dB_SystemDataSet4.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.dB_SystemDataSet4.Suppliers);
        }

        private void update_supplier_button2_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("update Suppliers set supplier=@supplier, bullstat=@bullstat, MOL=@MOL, city=@city, post_code=@post_code, address=@address, email=@email, phone=@phone where bullstat=@bullstat", myConnection);
                    myConnection.Open();
                    if ((IsValidEmail(textBox15.Text) == true || textBox15.Text == "") && (IsValidPhone(textBox16.Text) == true || textBox16.Text == ""))
                    {
                        myCommand.Parameters.AddWithValue("@supplier", textBox9.Text);
                        myCommand.Parameters.AddWithValue("@bullstat", textBox10.Text);
                        myCommand.Parameters.AddWithValue("@MOL", textBox11.Text);
                        myCommand.Parameters.AddWithValue("@city", textBox12.Text);
                        myCommand.Parameters.AddWithValue("@post_code", textBox13.Text);
                        myCommand.Parameters.AddWithValue("@address", textBox14.Text);
                        myCommand.Parameters.AddWithValue("@email", textBox15.Text);
                        myCommand.Parameters.AddWithValue("@phone", textBox16.Text);
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                        MessageBox.Show("Успешно редактиран доставчик!");
                        displayData2();
                        if (myConnection.State == ConnectionState.Open)
                        {
                            myConnection.Dispose();
                        }

                        textBox9.Clear();
                        textBox10.Clear();
                        textBox11.Clear();
                        textBox12.Clear();
                        textBox13.Clear();
                        textBox14.Clear();
                        textBox15.Clear();
                        textBox16.Clear();
                    }

                    else
                    if (IsValidEmail(textBox15.Text) == false && textBox15.Text != "")
                    {
                        MessageBox.Show("Имейл адресът не е коректен!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    if (IsValidPhone(textBox16.Text) == false && textBox16.Text != "")
                    {
                        MessageBox.Show("Телефонният номер не е коректен!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void create_client_button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("insert into Clients(client, bullstat, MOL, city, post_code, address, email, phone) values(@client, @bullstat, @MOL, @city, @post_code, @address, @email, @phone)", myConnection);
                    myConnection.Open();
                    if ((IsValidEmail(textBox7.Text) == true || textBox7.Text == "") && (IsValidPhone(textBox8.Text) == true || textBox8.Text == ""))
                    {
                        myCommand.Parameters.AddWithValue("@client", textBox1.Text);
                        myCommand.Parameters.AddWithValue("@bullstat", textBox2.Text);
                        myCommand.Parameters.AddWithValue("@MOL", textBox3.Text);
                        myCommand.Parameters.AddWithValue("@city", textBox4.Text);
                        myCommand.Parameters.AddWithValue("@post_code", textBox5.Text);
                        myCommand.Parameters.AddWithValue("@address", textBox6.Text);
                        myCommand.Parameters.AddWithValue("@email", textBox7.Text);
                        myCommand.Parameters.AddWithValue("@phone", textBox8.Text);
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                        displayData1();
                        MessageBox.Show("Успешно въведен нов клиент!");
                        if (myConnection.State == ConnectionState.Open)
                        {
                            myConnection.Dispose();
                        }

                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                    }

                    else
                    if (IsValidEmail(textBox7.Text) == false && textBox7.Text != "")
                    {
                        MessageBox.Show("Имейл адресът не е коректен!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    if (IsValidPhone(textBox8.Text) == false && textBox8.Text != "")
                    {
                        MessageBox.Show("Телефонният номер не е коректен!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void create_supplier_button4_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("insert into Suppliers(supplier, bullstat, MOL, city, post_code, address, email, phone) values(@supplier, @bullstat, @MOL, @city, @post_code, @address, @email, @phone)", myConnection);
                    myConnection.Open();
                    if ((IsValidEmail(textBox15.Text) == true || textBox15.Text == "") && (IsValidPhone(textBox16.Text) == true || textBox16.Text == ""))
                    {
                        myCommand.Parameters.AddWithValue("@supplier", textBox9.Text);
                        myCommand.Parameters.AddWithValue("@bullstat", textBox10.Text);
                        myCommand.Parameters.AddWithValue("@MOL", textBox11.Text);
                        myCommand.Parameters.AddWithValue("@city", textBox12.Text);
                        myCommand.Parameters.AddWithValue("@post_code", textBox13.Text);
                        myCommand.Parameters.AddWithValue("@address", textBox14.Text);
                        myCommand.Parameters.AddWithValue("@email", textBox15.Text);
                        myCommand.Parameters.AddWithValue("@phone", textBox16.Text);
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                        MessageBox.Show("Успешно въведен нов доставчик!");
                        displayData2();
                        if (myConnection.State == ConnectionState.Open)
                        {
                            myConnection.Dispose();
                        }

                        textBox9.Clear();
                        textBox10.Clear();
                        textBox11.Clear();
                        textBox12.Clear();
                        textBox13.Clear();
                        textBox14.Clear();
                        textBox15.Clear();
                        textBox16.Clear();
                    }

                    else
                    if (IsValidEmail(textBox15.Text) == false && textBox15.Text != "")
                    {
                        MessageBox.Show("Имейл адресът не е коректен!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    if (IsValidPhone(textBox16.Text) == false && textBox16.Text != "")
                    {
                        MessageBox.Show("Телефонният номер не е коректен!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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