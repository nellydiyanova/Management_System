
namespace Management_System
{
    partial class Authorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SystemDataSet7 = new Management_System.DB_SystemDataSet7();
            this.check_button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usersTableAdapter = new Management_System.DB_SystemDataSet7TableAdapters.UsersTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SystemDataSet8 = new Management_System.DB_SystemDataSet8();
            this.usersTableAdapter1 = new Management_System.DB_SystemDataSet8TableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dB_SystemDataSet7;
            // 
            // dB_SystemDataSet7
            // 
            this.dB_SystemDataSet7.DataSetName = "DB_SystemDataSet7";
            this.dB_SystemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // check_button1
            // 
            this.check_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.check_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.check_button1, "check_button1");
            this.check_button1.Name = "check_button1";
            this.check_button1.UseVisualStyleBackColor = false;
            this.check_button1.Click += new System.EventHandler(this.check_button1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.usersBindingSource1;
            this.comboBox1.DisplayMember = "username";
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.ValueMember = "username";
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.dB_SystemDataSet8;
            // 
            // dB_SystemDataSet8
            // 
            this.dB_SystemDataSet8.DataSetName = "DB_SystemDataSet8";
            this.dB_SystemDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // Authorization
            // 
            this.AcceptButton = this.check_button1;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.check_button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button check_button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private DB_SystemDataSet7 dB_SystemDataSet7;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DB_SystemDataSet7TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private DB_SystemDataSet8 dB_SystemDataSet8;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private DB_SystemDataSet8TableAdapters.UsersTableAdapter usersTableAdapter1;
    }
}