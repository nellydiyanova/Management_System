using System;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Stock_reference : Form
    {
        public Stock_reference()
        {
            InitializeComponent();
        }

        private void Stock_reference_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SystemDataSet1.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.dB_SystemDataSet1.Inventory);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
