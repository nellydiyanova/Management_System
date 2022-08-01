using System;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Filling_cabinet : Form
    {
        public Filling_cabinet()
        {
            InitializeComponent();
        }

        private void Filling_cabinet_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void клиентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            // TODO: This line of code loads data into the 'dB_SystemDataSet3.Companies' table. You can move, or remove it, as needed.
            this.companiesTableAdapter.Fill(this.dB_SystemDataSet3.Companies);
        }

        private void дистрибуториToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            // TODO: This line of code loads data into the 'dB_SystemDataSet4.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.dB_SystemDataSet4.Suppliers);
        }

        private void служителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            // TODO: This line of code loads data into the 'dB_SystemDataSet5.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dB_SystemDataSet5.Users);
        }
    }
}
