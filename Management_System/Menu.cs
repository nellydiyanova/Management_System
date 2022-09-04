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

        private void inventory_button1_Click(object sender, EventArgs e)
        {
            Inventory frm = new Inventory();
            frm.Show();
        }

        private void filling_cabinet_button2_Click(object sender, EventArgs e)
        {
            Filling_cabinet frm = new Filling_cabinet();
            frm.Show();
        }

        private void passwords_button3_Click(object sender, EventArgs e)
        {
            Authorization frm = new Authorization();
            frm.Show();
        }

        private void new_order_button4_Click(object sender, EventArgs e)
        {
            New_order frm = new New_order();
            frm.Show();
        }

        private void orders_button5_Click(object sender, EventArgs e)
        {
            Orders frm = new Orders();
            frm.Show();
        }

        private void new_delivery_button6_Click(object sender, EventArgs e)
        {
            New_delivery frm = new New_delivery();
            frm.Show();
        }

        private void deliveries_button7_Click(object sender, EventArgs e)
        {
            Deliveries frm = new Deliveries();
            frm.Show();
        }

        private void transfer_button8_Click(object sender, EventArgs e)
        {
            Transfer frm = new Transfer();
            frm.Show();
        }

        private void revision_button9_Click(object sender, EventArgs e)
        {
            Revision frm = new Revision();
            frm.Show();
        }

        private void exit_button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Довиждане, " + Login.passingText + "! " + "Приятна почивка! ☺", "Изход");
            Application.Exit();
        }
    }
}