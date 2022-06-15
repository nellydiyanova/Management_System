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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(cs);
                myCommand = new SqlCommand("Select * from Users where username=@username and password=@password", myConnection);
                SqlParameter uUsername = new SqlParameter("@username", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@password", SqlDbType.VarChar);
                uUsername.Value = textBox1.Text;
                uPassword.Value = textBox2.Text;
                myCommand.Parameters.Add(uUsername);
                myCommand.Parameters.Add(uPassword);
                myCommand.Connection.Open();
                SqlDataReader myreader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (myreader.Read() == true)
                {
                    MessageBox.Show("Добре дошли, " + textBox1.Text + "!");
                    this.Hide();
                    Menu frm = new Menu();
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Невалидни данни!", "Достъп отказан", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
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
    }
}