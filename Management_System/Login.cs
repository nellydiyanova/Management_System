using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string cs = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Management_System\Management_System\DB_System.mdf;Integrated Security = True";
        public SqlConnection myConnection = default(SqlConnection);
        public SqlCommand myCommand = default(SqlCommand);

        public static string passingText;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(cs);
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
                    MessageBox.Show("Добре дошли, " + comboBox1.Text + "! :)");
                    passingText = comboBox1.Text;
                    this.Hide();
                    Menu frm = new Menu();
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

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SystemDataSet2.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dB_SystemDataSet2.Users);
        }
    }
}