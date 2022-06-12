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
        public SqlConnection myconnection = default(SqlConnection);
        public SqlCommand mycommand = default(SqlCommand);

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myconnection = new SqlConnection(cs);
                mycommand = new SqlCommand("Select * from Users where username=@username and password=@password", myconnection);
                SqlParameter uUsername = new SqlParameter("@username", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@password", SqlDbType.VarChar);
                uUsername.Value = textBox1.Text;
                uPassword.Value = textBox2.Text;
                mycommand.Parameters.Add(uUsername);
                mycommand.Parameters.Add(uPassword);
                mycommand.Connection.Open();
                SqlDataReader myreader = mycommand.ExecuteReader(CommandBehavior.CloseConnection);
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

                if (myconnection.State == ConnectionState.Open)
                {
                    myconnection.Dispose();
                }

            }
            catch (ExecutionEngineException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}