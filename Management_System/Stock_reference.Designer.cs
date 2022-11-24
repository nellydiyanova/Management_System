
namespace Management_System
{
    partial class Stock_reference
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_reference));
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SystemDataSet1 = new Management_System.DB_SystemDataSet1();
            this.inventoryTableAdapter = new Management_System.DB_SystemDataSet1TableAdapters.InventoryTableAdapter();
            this.dB_SystemDataSet33 = new Management_System.DB_SystemDataSet33();
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter1 = new Management_System.DB_SystemDataSet33TableAdapters.InventoryTableAdapter();
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
            this.inventoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SystemDataSet34 = new Management_System.DB_SystemDataSet34();
            this.inventoryTableAdapter2 = new Management_System.DB_SystemDataSet34TableAdapters.InventoryTableAdapter();
            this.ok = new System.Windows.Forms.Button();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SystemDataSet35 = new Management_System.DB_SystemDataSet35();
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SystemDataSet36 = new Management_System.DB_SystemDataSet36();
            this.inventoryBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SystemDataSet37 = new Management_System.DB_SystemDataSet37();
            this.suppliersTableAdapter = new Management_System.DB_SystemDataSet35TableAdapters.SuppliersTableAdapter();
            this.warehousesTableAdapter = new Management_System.DB_SystemDataSet36TableAdapters.WarehousesTableAdapter();
            this.inventoryTableAdapter3 = new Management_System.DB_SystemDataSet37TableAdapters.InventoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet37)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.dB_SystemDataSet1;
            // 
            // dB_SystemDataSet1
            // 
            this.dB_SystemDataSet1.DataSetName = "DB_SystemDataSet1";
            this.dB_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // dB_SystemDataSet33
            // 
            this.dB_SystemDataSet33.DataSetName = "DB_SystemDataSet33";
            this.dB_SystemDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataMember = "Inventory";
            this.inventoryBindingSource1.DataSource = this.dB_SystemDataSet33;
            // 
            // inventoryTableAdapter1
            // 
            this.inventoryTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.dataGridView1.DataSource = this.inventoryBindingSource2;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            // 
            // idproductDataGridViewTextBoxColumn
            // 
            this.idproductDataGridViewTextBoxColumn.DataPropertyName = "id_product";
            resources.ApplyResources(this.idproductDataGridViewTextBoxColumn, "idproductDataGridViewTextBoxColumn");
            this.idproductDataGridViewTextBoxColumn.Name = "idproductDataGridViewTextBoxColumn";
            this.idproductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            resources.ApplyResources(this.productnameDataGridViewTextBoxColumn, "productnameDataGridViewTextBoxColumn");
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliverypriceDataGridViewTextBoxColumn
            // 
            this.deliverypriceDataGridViewTextBoxColumn.DataPropertyName = "delivery_price";
            resources.ApplyResources(this.deliverypriceDataGridViewTextBoxColumn, "deliverypriceDataGridViewTextBoxColumn");
            this.deliverypriceDataGridViewTextBoxColumn.Name = "deliverypriceDataGridViewTextBoxColumn";
            this.deliverypriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salepriceDataGridViewTextBoxColumn
            // 
            this.salepriceDataGridViewTextBoxColumn.DataPropertyName = "sale_price";
            resources.ApplyResources(this.salepriceDataGridViewTextBoxColumn, "salepriceDataGridViewTextBoxColumn");
            this.salepriceDataGridViewTextBoxColumn.Name = "salepriceDataGridViewTextBoxColumn";
            this.salepriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // measureDataGridViewTextBoxColumn
            // 
            this.measureDataGridViewTextBoxColumn.DataPropertyName = "measure";
            resources.ApplyResources(this.measureDataGridViewTextBoxColumn, "measureDataGridViewTextBoxColumn");
            this.measureDataGridViewTextBoxColumn.Name = "measureDataGridViewTextBoxColumn";
            this.measureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            resources.ApplyResources(this.quantityDataGridViewTextBoxColumn, "quantityDataGridViewTextBoxColumn");
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "supplier";
            resources.ApplyResources(this.supplierDataGridViewTextBoxColumn, "supplierDataGridViewTextBoxColumn");
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // warehouseDataGridViewTextBoxColumn
            // 
            this.warehouseDataGridViewTextBoxColumn.DataPropertyName = "warehouse";
            resources.ApplyResources(this.warehouseDataGridViewTextBoxColumn, "warehouseDataGridViewTextBoxColumn");
            this.warehouseDataGridViewTextBoxColumn.Name = "warehouseDataGridViewTextBoxColumn";
            this.warehouseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            resources.ApplyResources(this.statusDataGridViewTextBoxColumn, "statusDataGridViewTextBoxColumn");
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventoryBindingSource2
            // 
            this.inventoryBindingSource2.DataMember = "Inventory";
            this.inventoryBindingSource2.DataSource = this.dB_SystemDataSet34;
            // 
            // dB_SystemDataSet34
            // 
            this.dB_SystemDataSet34.DataSetName = "DB_SystemDataSet34";
            this.dB_SystemDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter2
            // 
            this.inventoryTableAdapter2.ClearBeforeFill = true;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.ok, "ok");
            this.ok.Name = "ok";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.dB_SystemDataSet35;
            // 
            // dB_SystemDataSet35
            // 
            this.dB_SystemDataSet35.DataSetName = "DB_SystemDataSet35";
            this.dB_SystemDataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.DataMember = "Warehouses";
            this.warehousesBindingSource.DataSource = this.dB_SystemDataSet36;
            // 
            // dB_SystemDataSet36
            // 
            this.dB_SystemDataSet36.DataSetName = "DB_SystemDataSet36";
            this.dB_SystemDataSet36.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource3
            // 
            this.inventoryBindingSource3.DataMember = "Inventory";
            this.inventoryBindingSource3.DataSource = this.dB_SystemDataSet37;
            // 
            // dB_SystemDataSet37
            // 
            this.dB_SystemDataSet37.DataSetName = "DB_SystemDataSet37";
            this.dB_SystemDataSet37.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // warehousesTableAdapter
            // 
            this.warehousesTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryTableAdapter3
            // 
            this.inventoryTableAdapter3.ClearBeforeFill = true;
            // 
            // Stock_reference
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.ok);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Stock_reference";
            this.Load += new System.EventHandler(this.Stock_reference_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SystemDataSet37)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DB_SystemDataSet1 dB_SystemDataSet1;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private DB_SystemDataSet1TableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private DB_SystemDataSet33 dB_SystemDataSet33;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
        private DB_SystemDataSet33TableAdapters.InventoryTableAdapter inventoryTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_SystemDataSet34 dB_SystemDataSet34;
        private System.Windows.Forms.BindingSource inventoryBindingSource2;
        private DB_SystemDataSet34TableAdapters.InventoryTableAdapter inventoryTableAdapter2;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverypriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DB_SystemDataSet35 dB_SystemDataSet35;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private DB_SystemDataSet35TableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private DB_SystemDataSet36 dB_SystemDataSet36;
        private System.Windows.Forms.BindingSource warehousesBindingSource;
        private DB_SystemDataSet36TableAdapters.WarehousesTableAdapter warehousesTableAdapter;
        private DB_SystemDataSet37 dB_SystemDataSet37;
        private System.Windows.Forms.BindingSource inventoryBindingSource3;
        private DB_SystemDataSet37TableAdapters.InventoryTableAdapter inventoryTableAdapter3;
    }
}