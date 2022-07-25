using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Filing_cabinet : Form
    {
        public Filing_cabinet()
        {
            InitializeComponent();
        }

        private void Filing_cabinet_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
        }

        private void клиентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            // TODO: This line of code loads data into the 'dB_SystemDataSet3.Companies' table. You can move, or remove it, as needed.
            this.companiesTableAdapter.Fill(this.dB_SystemDataSet3.Companies);
        }

        private void дистрибуториToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            // TODO: This line of code loads data into the 'dB_SystemDataSet4.Suppliers' table. You can move, or remove it, as needed.
                this.suppliersTableAdapter.Fill(this.dB_SystemDataSet4.Suppliers);
        }
    }
}
