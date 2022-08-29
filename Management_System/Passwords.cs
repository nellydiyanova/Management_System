using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Passwords : Form
    {
        public Passwords()
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
            adapt = new SqlDataAdapter("select * from Users", myConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void Passwords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SystemDataSet9.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dB_SystemDataSet9.Users);
            
            button1.BackColor = System.Drawing.Color.LightGreen;
            button2.BackColor = System.Drawing.Color.LightGreen;
            textBox1.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Enabled = false;
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
        }

        private void новСлужителToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            groupBox1.Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            button1.Enabled = false;
            button2.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Focus();
            
            // TODO: This line of code loads data into the 'dB_SystemDataSet9.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dB_SystemDataSet9.Users);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("update Users set username=@username, password=@password, name=@name, personal_number=@personal_number, city=@city, address=@address, phone=@phone, email=@email where username=@username", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@username", textBox1.Text);
                    myCommand.Parameters.AddWithValue("@password", textBox2.Text);
                    myCommand.Parameters.AddWithValue("@name", textBox3.Text);
                    myCommand.Parameters.AddWithValue("@personal_number", textBox4.Text);
                    myCommand.Parameters.AddWithValue("@city", textBox5.Text);
                    myCommand.Parameters.AddWithValue("@address", textBox6.Text);
                    myCommand.Parameters.AddWithValue("@phone", textBox7.Text);
                    myCommand.Parameters.AddWithValue("@email", textBox8.Text);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Успешно редактиран служител!");
                    displayData();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("insert into Users(username, password, name, personal_number, city, address, phone, email) values(@username, @password, @name, @personal_number, @city, @address, @phone, @email)", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@username", textBox1.Text);
                    myCommand.Parameters.AddWithValue("@password", textBox2.Text);
                    myCommand.Parameters.AddWithValue("@name", textBox3.Text);
                    myCommand.Parameters.AddWithValue("@personal_number", textBox4.Text);
                    myCommand.Parameters.AddWithValue("@city", textBox5.Text);
                    myCommand.Parameters.AddWithValue("@address", textBox6.Text);
                    myCommand.Parameters.AddWithValue("@phone", textBox7.Text);
                    myCommand.Parameters.AddWithValue("@email", textBox8.Text);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    displayData();
                    MessageBox.Show("Успешно въведен нов служител!");
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }

                    textBox1.Enabled = false;
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

        private void изтрийСлужителToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("delete Users where username=@username", myConnection);
                    myConnection.Open();
                    myCommand.Parameters.AddWithValue("@username", textBox1.Text);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Успешно изтрит служител!");
                    displayData();
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
                MessageBox.Show("Изберете служител за изтриване!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}