using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        Login frm = new Login();
        SqlConnection myConnection;
        SqlCommand myCommand = default(SqlCommand);

        private void check_button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "admin")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("Select * from Users where username=@username and password=@password", myConnection);
                    SqlParameter uUsername = new SqlParameter("@username", SqlDbType.VarChar);
                    SqlParameter uPassword = new SqlParameter("@password", SqlDbType.VarChar);
                    uUsername.Value = comboBox1.Text;
                    uPassword.Value = textBox1.Text;
                    myCommand.Parameters.Add(uUsername);
                    myCommand.Parameters.Add(uPassword);
                    myCommand.Connection.Open();
                    SqlDataReader myreader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    if (myreader.Read() == true)
                    {
                        MessageBox.Show("Достъп разрешен!");
                        this.Hide();
                        Passwords frm = new Passwords();
                        frm.Show();
                    }

                    else
                    if (comboBox1.Text == "" || textBox1.Text == "")
                    {
                        MessageBox.Show("Въведете празните полета!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Focus();
                    }

                    else
                    {
                        MessageBox.Show("Невалидни данни!", "Достъп отказан!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Clear();
                        textBox1.Focus();
                    }

                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }
                }

                catch (ExecutionEngineException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            else
            if (comboBox1.Text != "admin")
            {
                try
                {
                    myConnection = new SqlConnection(frm.cs);
                    myCommand = new SqlCommand("Select * from Users where username=@username and password=@password", myConnection);
                    SqlParameter uUsername = new SqlParameter("@username", SqlDbType.VarChar);
                    SqlParameter uPassword = new SqlParameter("@password", SqlDbType.VarChar);
                    uUsername.Value = comboBox1.Text;
                    uPassword.Value = textBox1.Text;
                    myCommand.Parameters.Add(uUsername);
                    myCommand.Parameters.Add(uPassword);
                    myCommand.Connection.Open();
                    SqlDataReader myreader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    if (myreader.Read() == true)
                    {
                        MessageBox.Show("Не сте оторизирано лице за този модул!", "Достъп отказан!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comboBox1.Text = "";
                        textBox1.Clear();
                        comboBox1.Focus();
                    }

                    else
                    if (comboBox1.Text == "" || textBox1.Text == "")
                    {
                        MessageBox.Show("Въведете празните полета!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Focus();
                    }

                    else
                    {
                        MessageBox.Show("Невалидни данни!", "Достъп отказан!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Clear();
                        textBox1.Focus();
                    }

                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }
                }

                catch (ExecutionEngineException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Въведете празните полета!", "Операцията не може да се осъществи!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SystemDataSet8.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.dB_SystemDataSet8.Users);

            comboBox1.Text = "";
        }
    }
}