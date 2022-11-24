using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
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

        private void displayData()
        {
            myConnection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select * from Users", myConnection);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void Passwords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SystemDataSet9.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dB_SystemDataSet9.Users);

            update_user.BackColor = System.Drawing.Color.LightGreen;
            create_user.BackColor = System.Drawing.Color.LightGreen;
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

            update_user.Enabled = true;
            create_user.Enabled = false;
        }

        private void newUser_Click(object sender, EventArgs e)
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
            update_user.Enabled = false;
            create_user.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void update_user_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("update Users set username=@username, password=@password, name=@name, personal_number=@personal_number, city=@city, address=@address, phone=@phone, email=@email where username=@username", myConnection);
                    myConnection.Open();
                    if ((IsValidPhone(textBox7.Text) == true || textBox7.Text == "") && (IsValidEmail(textBox8.Text) == true || textBox8.Text == ""))
                    {
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

                    else
                    if (IsValidPhone(textBox7.Text) == false && textBox7.Text != "")
                    {
                        MessageBox.Show("Телефонният номер не е коректен!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    if (IsValidEmail(textBox8.Text) == false && textBox8.Text != "")
                    {
                        MessageBox.Show("Имейл адресът не е коректен!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void create_user_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("insert into Users(username, password, name, personal_number, city, address, phone, email) values(@username, @password, @name, @personal_number, @city, @address, @phone, @email)", myConnection);
                    myConnection.Open();
                    if ((IsValidPhone(textBox7.Text) == true || textBox7.Text == "") && (IsValidEmail(textBox8.Text) == true || textBox8.Text == ""))
                    {
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

                    else
                    if (IsValidPhone(textBox7.Text) == false && textBox7.Text != "")
                    {
                        MessageBox.Show("Телефонният номер не е коректен!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    if (IsValidEmail(textBox8.Text) == false && textBox8.Text != "")
                    {
                        MessageBox.Show("Имейл адресът не е коректен!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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