namespace Group_27
{
    partial class AllSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllSuppliers));
            this.AllSupplier_Label = new System.Windows.Forms.Label();
            this.AllSupplier_DataGrid = new System.Windows.Forms.DataGridView();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isArchivedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_27DataSet1 = new Group_27.SAD_27DataSet1();
            this.Search_by_Coloumn_Supplier_ComboBox = new System.Windows.Forms.TextBox();
            this.Coloumn_ComboBox_Supplier = new System.Windows.Forms.ComboBox();
            this.Search_label = new System.Windows.Forms.Label();
            this.Coloumn_Label_Supplier = new System.Windows.Forms.Label();
            this.Supplier_toArchive_button = new System.Windows.Forms.Button();
            this.Back_ToCrudSupplier_Button = new System.Windows.Forms.Button();
            this.Back_SupplierToActive_Button = new System.Windows.Forms.Button();
            this.suppliersTableAdapter = new Group_27.SAD_27DataSet1TableAdapters.SuppliersTableAdapter();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllSupplier_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // AllSupplier_Label
            // 
            this.AllSupplier_Label.AutoSize = true;
            this.AllSupplier_Label.BackColor = System.Drawing.Color.Transparent;
            this.AllSupplier_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AllSupplier_Label.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllSupplier_Label.Location = new System.Drawing.Point(241, 9);
            this.AllSupplier_Label.Name = "AllSupplier_Label";
            this.AllSupplier_Label.Size = new System.Drawing.Size(295, 66);
            this.AllSupplier_Label.TabIndex = 106;
            this.AllSupplier_Label.Text = "טבלת ספקים";
            // 
            // AllSupplier_DataGrid
            // 
            this.AllSupplier_DataGrid.AllowUserToAddRows = false;
            this.AllSupplier_DataGrid.AllowUserToDeleteRows = false;
            this.AllSupplier_DataGrid.AutoGenerateColumns = false;
            this.AllSupplier_DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllSupplier_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllSupplier_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierIdDataGridViewTextBoxColumn,
            this.suppliersNameDataGridViewTextBoxColumn,
            this.suppliersAddressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.isArchivedDataGridViewCheckBoxColumn});
            this.AllSupplier_DataGrid.DataSource = this.suppliersBindingSource;
            this.AllSupplier_DataGrid.Location = new System.Drawing.Point(77, 176);
            this.AllSupplier_DataGrid.Name = "AllSupplier_DataGrid";
            this.AllSupplier_DataGrid.ReadOnly = true;
            this.AllSupplier_DataGrid.Size = new System.Drawing.Size(588, 366);
            this.AllSupplier_DataGrid.TabIndex = 104;
            this.AllSupplier_DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllSupplier_DataGrid_CellContentClick);
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            this.supplierIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suppliersNameDataGridViewTextBoxColumn
            // 
            this.suppliersNameDataGridViewTextBoxColumn.DataPropertyName = "SuppliersName";
            this.suppliersNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.suppliersNameDataGridViewTextBoxColumn.Name = "suppliersNameDataGridViewTextBoxColumn";
            this.suppliersNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suppliersAddressDataGridViewTextBoxColumn
            // 
            this.suppliersAddressDataGridViewTextBoxColumn.DataPropertyName = "SuppliersAddress";
            this.suppliersAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.suppliersAddressDataGridViewTextBoxColumn.Name = "suppliersAddressDataGridViewTextBoxColumn";
            this.suppliersAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isArchivedDataGridViewCheckBoxColumn
            // 
            this.isArchivedDataGridViewCheckBoxColumn.DataPropertyName = "IsArchived";
            this.isArchivedDataGridViewCheckBoxColumn.HeaderText = "Is Archived";
            this.isArchivedDataGridViewCheckBoxColumn.Name = "isArchivedDataGridViewCheckBoxColumn";
            this.isArchivedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.sAD_27DataSet1;
            // 
            // sAD_27DataSet1
            // 
            this.sAD_27DataSet1.DataSetName = "SAD_27DataSet1";
            this.sAD_27DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Search_by_Coloumn_Supplier_ComboBox
            // 
            this.Search_by_Coloumn_Supplier_ComboBox.Location = new System.Drawing.Point(392, 130);
            this.Search_by_Coloumn_Supplier_ComboBox.Name = "Search_by_Coloumn_Supplier_ComboBox";
            this.Search_by_Coloumn_Supplier_ComboBox.Size = new System.Drawing.Size(167, 20);
            this.Search_by_Coloumn_Supplier_ComboBox.TabIndex = 103;
            this.Search_by_Coloumn_Supplier_ComboBox.TextChanged += new System.EventHandler(this.Search_by_Coloumn_Supplier_ComboBox_TextChanged);
            this.Search_by_Coloumn_Supplier_ComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_by_Coloumn_Supplier_ComboBox_KeyDown);
            // 
            // Coloumn_ComboBox_Supplier
            // 
            this.Coloumn_ComboBox_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Coloumn_ComboBox_Supplier.FormattingEnabled = true;
            this.Coloumn_ComboBox_Supplier.Items.AddRange(new object[] {
            "SupplierID",
            "SuppliersName",
            "SupplierAddress",
            "PhoneNumber",
            "isArchived"});
            this.Coloumn_ComboBox_Supplier.Location = new System.Drawing.Point(392, 97);
            this.Coloumn_ComboBox_Supplier.Name = "Coloumn_ComboBox_Supplier";
            this.Coloumn_ComboBox_Supplier.Size = new System.Drawing.Size(167, 21);
            this.Coloumn_ComboBox_Supplier.TabIndex = 102;
            this.Coloumn_ComboBox_Supplier.SelectedIndexChanged += new System.EventHandler(this.Coloumn_ComboBox_Supplier_SelectedIndexChanged);
            // 
            // Search_label
            // 
            this.Search_label.AutoSize = true;
            this.Search_label.BackColor = System.Drawing.Color.Transparent;
            this.Search_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_label.Location = new System.Drawing.Point(600, 130);
            this.Search_label.Name = "Search_label";
            this.Search_label.Size = new System.Drawing.Size(65, 22);
            this.Search_label.TabIndex = 101;
            this.Search_label.Text = ":חיפוש ";
            // 
            // Coloumn_Label_Supplier
            // 
            this.Coloumn_Label_Supplier.AutoSize = true;
            this.Coloumn_Label_Supplier.BackColor = System.Drawing.Color.Transparent;
            this.Coloumn_Label_Supplier.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coloumn_Label_Supplier.Location = new System.Drawing.Point(574, 97);
            this.Coloumn_Label_Supplier.Name = "Coloumn_Label_Supplier";
            this.Coloumn_Label_Supplier.Size = new System.Drawing.Size(112, 22);
            this.Coloumn_Label_Supplier.TabIndex = 100;
            this.Coloumn_Label_Supplier.Text = ":בחירת עמודה";
            // 
            // Supplier_toArchive_button
            // 
            this.Supplier_toArchive_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Supplier_toArchive_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Supplier_toArchive_button.BackgroundImage")));
            this.Supplier_toArchive_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Supplier_toArchive_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supplier_toArchive_button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_toArchive_button.Location = new System.Drawing.Point(265, 564);
            this.Supplier_toArchive_button.Name = "Supplier_toArchive_button";
            this.Supplier_toArchive_button.Size = new System.Drawing.Size(140, 60);
            this.Supplier_toArchive_button.TabIndex = 108;
            this.Supplier_toArchive_button.Text = "העברה לארכיון";
            this.Supplier_toArchive_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Supplier_toArchive_button.UseVisualStyleBackColor = false;
            this.Supplier_toArchive_button.Click += new System.EventHandler(this.Supplier_toArchive_button_Click);
            // 
            // Back_ToCrudSupplier_Button
            // 
            this.Back_ToCrudSupplier_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_ToCrudSupplier_Button.BackgroundImage")));
            this.Back_ToCrudSupplier_Button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_ToCrudSupplier_Button.Location = new System.Drawing.Point(558, 564);
            this.Back_ToCrudSupplier_Button.Name = "Back_ToCrudSupplier_Button";
            this.Back_ToCrudSupplier_Button.Size = new System.Drawing.Size(107, 60);
            this.Back_ToCrudSupplier_Button.TabIndex = 107;
            this.Back_ToCrudSupplier_Button.Text = "חזור";
            this.Back_ToCrudSupplier_Button.UseVisualStyleBackColor = true;
            this.Back_ToCrudSupplier_Button.Click += new System.EventHandler(this.Back_ToCrudSupplier_Button_Click);
            // 
            // Back_SupplierToActive_Button
            // 
            this.Back_SupplierToActive_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_SupplierToActive_Button.BackgroundImage")));
            this.Back_SupplierToActive_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Back_SupplierToActive_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_SupplierToActive_Button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_SupplierToActive_Button.Location = new System.Drawing.Point(77, 564);
            this.Back_SupplierToActive_Button.Name = "Back_SupplierToActive_Button";
            this.Back_SupplierToActive_Button.Size = new System.Drawing.Size(170, 60);
            this.Back_SupplierToActive_Button.TabIndex = 105;
            this.Back_SupplierToActive_Button.Text = "הפיכה לספק פעיל";
            this.Back_SupplierToActive_Button.UseVisualStyleBackColor = true;
            this.Back_SupplierToActive_Button.Click += new System.EventHandler(this.Back_SupplierToActive_Button_Click);
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(697, 634);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 109;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // AllSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 721);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.Supplier_toArchive_button);
            this.Controls.Add(this.Back_ToCrudSupplier_Button);
            this.Controls.Add(this.AllSupplier_Label);
            this.Controls.Add(this.Back_SupplierToActive_Button);
            this.Controls.Add(this.AllSupplier_DataGrid);
            this.Controls.Add(this.Search_by_Coloumn_Supplier_ComboBox);
            this.Controls.Add(this.Coloumn_ComboBox_Supplier);
            this.Controls.Add(this.Search_label);
            this.Controls.Add(this.Coloumn_Label_Supplier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllSuppliers";
            this.Text = "AllSuppliers";
            this.Load += new System.EventHandler(this.AllSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllSupplier_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Supplier_toArchive_button;
        private System.Windows.Forms.Button Back_ToCrudSupplier_Button;
        private System.Windows.Forms.Label AllSupplier_Label;
        private System.Windows.Forms.Button Back_SupplierToActive_Button;
        private System.Windows.Forms.DataGridView AllSupplier_DataGrid;
        private System.Windows.Forms.TextBox Search_by_Coloumn_Supplier_ComboBox;
        private System.Windows.Forms.ComboBox Coloumn_ComboBox_Supplier;
        private System.Windows.Forms.Label Search_label;
        private System.Windows.Forms.Label Coloumn_Label_Supplier;
        private SAD_27DataSet1 sAD_27DataSet1;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private SAD_27DataSet1TableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliersNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliersAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isArchivedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button Back_To_Home_Page;
    }
}