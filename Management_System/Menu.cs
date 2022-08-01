using System;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory frm = new Inventory();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Filling_cabinet frm = new Filling_cabinet();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form5 frm = new Form5();
            //frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form6 frm = new Form6();
            //frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form7 frm = new Form7();
            //frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form8 frm = new Form8();
            //frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form9 frm = new Form9();
            //frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form10 frm = new Form10();
            //frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form11 frm = new Form11();
            //frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form12 frm = new Form12();
            //frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form13 frm = new Form13();
            //frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form14 frm = new Form14();
            //frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
