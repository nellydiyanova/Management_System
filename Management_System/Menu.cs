using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        Login frm = new Login();
        SqlConnection myConnection;
        SqlCommand myCommand = default(SqlCommand);
        SqlDataAdapter adapt;

        private void button1_Click(object sender, EventArgs e)
        {
            Inventory frm = new Inventory();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Filling_cabinet frm = new Filling_cabinet();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Authorization frm = new Authorization();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form6 frm = new Form6();
            //frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Form7 frm = new Form7();
            //frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Form8 frm = new Form8();
            //frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Form9 frm = new Form9();
            //frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Form10 frm = new Form10();
            //frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Form11 frm = new Form11();
            //frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Form12 frm = new Form12();
            //frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Form13 frm = new Form13();
            //frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Form14 frm = new Form14();
            //frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}