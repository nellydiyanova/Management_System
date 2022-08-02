using System;
using System.Data;
using System.Data.SqlClient;
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

        private void displayData3()
        {
            myConnection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Users", myConnection);
            adapt.Fill(dt);
            dataGridView3.DataSource = dt;
            myConnection.Close();
        }

        private void Filling_cabinet_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            textBox18.Enabled = false;
            button1.BackColor = System.Drawing.Color.LightGreen;
            button2.BackColor = System.Drawing.Color.LightGreen;
            button3.BackColor = System.Drawing.Color.LightGreen;
            button4.BackColor = System.Drawing.Color.LightGreen;
            button5.BackColor = System.Drawing.Color.LightGreen;
        }

        private void клиентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            // TODO: This line of code loads data into the 'dB_SystemDataSet3.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dB_SystemDataSet3.Clients);
        }

        private void дистрибуториToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            // TODO: This line of code loads data into the 'dB_SystemDataSet4.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.dB_SystemDataSet4.Suppliers);
        }

        private void служителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            // TODO: This line of code loads data into the 'dB_SystemDataSet5.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dB_SystemDataSet5.Users);
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
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
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
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox17.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            textBox18.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            textBox19.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            textBox20.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            textBox21.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            textBox22.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            textBox23.Text = dataGridView3.CurrentRow.Cells[6].Value.ToString();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void новКлиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            // TODO: This line of code loads data into the 'dB_SystemDataSet3.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dB_SystemDataSet3.Clients);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("update Clients set client=@client, bullstat=@bullstat, MOL=@MOL, city=@city, post_code=@post_code, address=@address, email=@email, phone=@phone where bullstat=@bullstat", myConnection);
                    myConnection.Open();
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
        }

        private void новДистрибуторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = true;
            // TODO: This line of code loads data into the 'dB_SystemDataSet4.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.dB_SystemDataSet4.Suppliers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("update Suppliers set supplier=@supplier, bullstat=@bullstat, MOL=@MOL, city=@city, post_code=@post_code, address=@address, email=@email, phone=@phone where bullstat=@bullstat", myConnection);
                    myConnection.Open();
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox17.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("update Users set username=@username, password=@password, name=@name, personal_number=@personal_number, address=@address, phone=@phone, email=@email where username=@username", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@username", textBox17.Text);
                    myCommand.Parameters.AddWithValue("@password", textBox18.Text);
                    myCommand.Parameters.AddWithValue("@name", textBox19.Text);
                    myCommand.Parameters.AddWithValue("@personal_number", textBox20.Text);
                    myCommand.Parameters.AddWithValue("@city", textBox21.Text);
                    myCommand.Parameters.AddWithValue("@address", textBox22.Text);
                    myCommand.Parameters.AddWithValue("@phone", textBox23.Text);
                    myCommand.Parameters.AddWithValue("@email", textBox24.Text);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Успешно редактиран служител!");
                    displayData3();
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }

                    textBox17.Clear();
                    textBox18.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox24.Clear();
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

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox17.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox19.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox20.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox21.Text = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox22.Text = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox23.Text = dataGridView3.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox24.Text = dataGridView3.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("insert into Clients(client, bullstat, MOL, city, post_code, address, email, phone) values(@client, @bullstat, @MOL, @city, @post_code, @address, @email, @phone)", myConnection);
                    myConnection.Open();
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("insert into Suppliers(supplier, bullstat, MOL, city, post_code, address, email, phone) values(@supplier, @bullstat, @MOL, @city, @post_code, @address, @email, @phone)", myConnection);
                    myConnection.Open();
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
                    MessageBox.Show("Успешно въведен нов дистрибутор!");
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

        private void изтрийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("delete Clients where bullstat=@bullstat", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@bullstat", textBox2.Text);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Успешно изтрит клиент!");
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

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            if(textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("delete Suppliers where bullstat=@bullstat", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@bullstat", textBox10.Text);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Успешно изтрит доставчик!");
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

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            if (textBox17.Text != "")
            {
                MessageBox.Show("Не може да изтривате служители!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                MessageBox.Show("Изберете клиент или доставчик за изтриване!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}