
namespace Management_System
{
    partial class Revision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Revision));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.report = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverypriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SystemDataSet32 = new Management_System.DB_SystemDataSet32();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.update_quantity = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SystemDataSet29 = new Management_System.DB_SystemDataSet29();
            this.suppliersTableAdapter = new Management_System.DB_SystemDataSet6TableAdapters.SuppliersTableAdapter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.warehousesTableAdapter = new Management_System.DB_SystemDataSet29TableAdapters.WarehousesTableAdapter();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SystemDataSet6 = new Management_System.DB_SystemDataSet6();
            this.search = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.inventoryTableAdapter = new Management_System.DB_SystemDataSet32TableAdapters.InventoryTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.report);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.update_quantity);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(249, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 398);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ревизия";
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.report.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.report.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.report.Location = new System.Drawing.Point(213, 226);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(103, 35);
            this.report.TabIndex = 47;
            this.report.Text = "Справка";
            this.report.UseVisualStyleBackColor = false;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.deliverypriceDataGridViewTextBoxColumn,
            this.salepriceDataGridViewTextBoxColumn,
            this.measureDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.warehouseDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(371, 122);
            this.dataGridView1.TabIndex = 46;
            // 
            // idproductDataGridViewTextBoxColumn
            // 
            this.idproductDataGridViewTextBoxColumn.DataPropertyName = "id_product";
            this.idproductDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idproductDataGridViewTextBoxColumn.Name = "idproductDataGridViewTextBoxColumn";
            this.idproductDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproductDataGridViewTextBoxColumn.Width = 40;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliverypriceDataGridViewTextBoxColumn
            // 
            this.deliverypriceDataGridViewTextBoxColumn.DataPropertyName = "delivery_price";
            this.deliverypriceDataGridViewTextBoxColumn.HeaderText = "Доставна цена";
            this.deliverypriceDataGridViewTextBoxColumn.Name = "deliverypriceDataGridViewTextBoxColumn";
            this.deliverypriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliverypriceDataGridViewTextBoxColumn.Width = 70;
            // 
            // salepriceDataGridViewTextBoxColumn
            // 
            this.salepriceDataGridViewTextBoxColumn.DataPropertyName = "sale_price";
            this.salepriceDataGridViewTextBoxColumn.HeaderText = "Продажна цена";
            this.salepriceDataGridViewTextBoxColumn.Name = "salepriceDataGridViewTextBoxColumn";
            this.salepriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.salepriceDataGridViewTextBoxColumn.Width = 70;
            // 
            // measureDataGridViewTextBoxColumn
            // 
            this.measureDataGridViewTextBoxColumn.DataPropertyName = "measure";
            this.measureDataGridViewTextBoxColumn.HeaderText = "Мярка";
            this.measureDataGridViewTextBoxColumn.Name = "measureDataGridViewTextBoxColumn";
            this.measureDataGridViewTextBoxColumn.ReadOnly = true;
            this.measureDataGridViewTextBoxColumn.Width = 50;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 90;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Доставчик";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierDataGridViewTextBoxColumn.Width = 80;
            // 
            // warehouseDataGridViewTextBoxColumn
            // 
            this.warehouseDataGridViewTextBoxColumn.DataPropertyName = "warehouse";
            this.warehouseDataGridViewTextBoxColumn.HeaderText = "Склад";
            this.warehouseDataGridViewTextBoxColumn.Name = "warehouseDataGridViewTextBoxColumn";
            this.warehouseDataGridViewTextBoxColumn.ReadOnly = true;
            this.warehouseDataGridViewTextBoxColumn.Width = 80;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 80;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.dB_SystemDataSet32;
            // 
            // dB_SystemDataSet32
            // 
            this.dB_SystemDataSet32.DataSetName = "DB_SystemDataSet32";
            this.dB_SystemDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(281, 142);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(80, 26);
            this.textBox7.TabIndex = 42;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(281, 104);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(80, 26);
            this.textBox6.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(225, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "К-во:";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(160, 185);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(115, 26);
            this.textBox8.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(80, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "Доставчик:";
            // 
            // update_quantity
            // 
            this.update_quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.update_quantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_quantity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.update_quantity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.update_quantity.Location = new System.Drawing.Point(55, 226);
            this.update_quantity.Name = "update_quantity";
            this.update_quantity.Size = new System.Drawing.Size(109, 35);
            this.update_quantity.TabIndex = 31;
            this.update_quantity.Text = "Актуализирай";
            this.update_quantity.UseVisualStyleBackColor = false;
            this.update_quantity.Click += new System.EventHandler(this.update_quantity_Click);
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(111, 136);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(82, 26);
            this.textBox5.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(225, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Мярка:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(111, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(82, 26);
            this.textBox4.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(5, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Продажна цена:";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(66, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(295, 26);
            this.textBox3.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(5, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Доставна цена:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(261, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(5, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "*Стока:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(208, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Склад:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "*ID:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(66, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 26);
            this.textBox1.TabIndex = 27;
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.DataMember = "Warehouses";
            this.warehousesBindingSource.DataSource = this.dB_SystemDataSet29;
            // 
            // dB_SystemDataSet29
            // 
            this.dB_SystemDataSet29.DataSetName = "DB_SystemDataSet29";
            this.dB_SystemDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Warehouse 2.png");
            this.imageList1.Images.SetKeyName(1, "Book.png");
            this.imageList1.Images.SetKeyName(2, "Inventory.png");
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 30);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(233, 399);
            this.treeView1.TabIndex = 46;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // warehousesTableAdapter
            // 
            this.warehousesTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.dB_SystemDataSet6;
            // 
            // dB_SystemDataSet6
            // 
            this.dB_SystemDataSet6.DataSetName = "DB_SystemDataSet6";
            this.dB_SystemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.search.Location = new System.Drawing.Point(162, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(71, 27);
            this.search.TabIndex = 47;
            this.search.Text = "Търси";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(0, 1);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(156, 26);
            this.textBox9.TabIndex = 46;
            this.textBox9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox9_KeyUp);
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // Revision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(627, 440);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.search);
            this.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Revision";
            this.Text = "Ревизия";
            this.Load += new System.EventHandler(this.Revision_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource warehousesBindingSource;
        private DB_SystemDataSet29 dB_SystemDataSet29;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button update_quantity;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private DB_SystemDataSet6TableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
        private DB_SystemDataSet29TableAdapters.WarehousesTableAdapter warehousesTableAdapter;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private DB_SystemDataSet6 dB_SystemDataSet6;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_SystemDataSet32 dB_SystemDataSet32;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private DB_SystemDataSet32TableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverypriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}