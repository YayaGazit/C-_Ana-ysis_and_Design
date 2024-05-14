namespace Group_27
{
    partial class AllProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllProducts));
            this.Product_toArchive_button = new System.Windows.Forms.Button();
            this.Back_ToProduct_Crud_Button = new System.Windows.Forms.Button();
            this.All_Product_Label = new System.Windows.Forms.Label();
            this.Back_Product_ToActive_Button = new System.Windows.Forms.Button();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_27DataSet2 = new Group_27.SAD_27DataSet2();
            this.Search_by_Products_Coloumn_ComboBox = new System.Windows.Forms.TextBox();
            this.Coloumn_Product_ComboBox = new System.Windows.Forms.ComboBox();
            this.Search_label = new System.Windows.Forms.Label();
            this.Coloumn_Label = new System.Windows.Forms.Label();
            this.productsTableAdapter = new Group_27.SAD_27DataSet2TableAdapters.ProductsTableAdapter();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_27DataSet14 = new Group_27.SAD_27DataSet14();
            this.productsTableAdapter1 = new Group_27.SAD_27DataSet14TableAdapters.ProductsTableAdapter();
            this.AllProducts_DataGrid = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defectivePercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isArchivedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_27DataSet15 = new Group_27.SAD_27DataSet15();
            this.productsTableAdapter2 = new Group_27.SAD_27DataSet15TableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllProducts_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // Product_toArchive_button
            // 
            this.Product_toArchive_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Product_toArchive_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Product_toArchive_button.BackgroundImage")));
            this.Product_toArchive_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Product_toArchive_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Product_toArchive_button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_toArchive_button.Location = new System.Drawing.Point(508, 531);
            this.Product_toArchive_button.Name = "Product_toArchive_button";
            this.Product_toArchive_button.Size = new System.Drawing.Size(140, 60);
            this.Product_toArchive_button.TabIndex = 108;
            this.Product_toArchive_button.Text = "העברה לארכיון";
            this.Product_toArchive_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Product_toArchive_button.UseVisualStyleBackColor = false;
            this.Product_toArchive_button.Click += new System.EventHandler(this.Product_toArchive_button_Click);
            // 
            // Back_ToProduct_Crud_Button
            // 
            this.Back_ToProduct_Crud_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_ToProduct_Crud_Button.BackgroundImage")));
            this.Back_ToProduct_Crud_Button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_ToProduct_Crud_Button.Location = new System.Drawing.Point(801, 531);
            this.Back_ToProduct_Crud_Button.Name = "Back_ToProduct_Crud_Button";
            this.Back_ToProduct_Crud_Button.Size = new System.Drawing.Size(107, 60);
            this.Back_ToProduct_Crud_Button.TabIndex = 107;
            this.Back_ToProduct_Crud_Button.Text = "חזור";
            this.Back_ToProduct_Crud_Button.UseVisualStyleBackColor = true;
            this.Back_ToProduct_Crud_Button.Click += new System.EventHandler(this.Back_ToProduct_Crud_Button_Click);
            // 
            // All_Product_Label
            // 
            this.All_Product_Label.AutoSize = true;
            this.All_Product_Label.BackColor = System.Drawing.Color.Transparent;
            this.All_Product_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.All_Product_Label.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_Product_Label.Location = new System.Drawing.Point(335, 26);
            this.All_Product_Label.Name = "All_Product_Label";
            this.All_Product_Label.Size = new System.Drawing.Size(299, 66);
            this.All_Product_Label.TabIndex = 106;
            this.All_Product_Label.Text = "טבלת מוצרים";
            this.All_Product_Label.Click += new System.EventHandler(this.All_Product_Label_Click);
            // 
            // Back_Product_ToActive_Button
            // 
            this.Back_Product_ToActive_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_Product_ToActive_Button.BackgroundImage")));
            this.Back_Product_ToActive_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Back_Product_ToActive_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_Product_ToActive_Button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Product_ToActive_Button.Location = new System.Drawing.Point(320, 531);
            this.Back_Product_ToActive_Button.Name = "Back_Product_ToActive_Button";
            this.Back_Product_ToActive_Button.Size = new System.Drawing.Size(170, 60);
            this.Back_Product_ToActive_Button.TabIndex = 105;
            this.Back_Product_ToActive_Button.Text = "החזרה למוצר פעיל";
            this.Back_Product_ToActive_Button.UseVisualStyleBackColor = true;
            this.Back_Product_ToActive_Button.Click += new System.EventHandler(this.Back_Product_ToActive_Button_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.sAD_27DataSet2;
            // 
            // sAD_27DataSet2
            // 
            this.sAD_27DataSet2.DataSetName = "SAD_27DataSet2";
            this.sAD_27DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Search_by_Products_Coloumn_ComboBox
            // 
            this.Search_by_Products_Coloumn_ComboBox.Location = new System.Drawing.Point(615, 163);
            this.Search_by_Products_Coloumn_ComboBox.Name = "Search_by_Products_Coloumn_ComboBox";
            this.Search_by_Products_Coloumn_ComboBox.Size = new System.Drawing.Size(167, 20);
            this.Search_by_Products_Coloumn_ComboBox.TabIndex = 103;
            this.Search_by_Products_Coloumn_ComboBox.TextChanged += new System.EventHandler(this.Search_by_Products_Coloumn_ComboBox_TextChanged);
            this.Search_by_Products_Coloumn_ComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_by_Products_Coloumn_ComboBox_KeyDown);
            // 
            // Coloumn_Product_ComboBox
            // 
            this.Coloumn_Product_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Coloumn_Product_ComboBox.FormattingEnabled = true;
            this.Coloumn_Product_ComboBox.Items.AddRange(new object[] {
            "productId",
            "productName",
            "quantity",
            "serialNumber",
            "arrivalDate",
            "description",
            "partNumber",
            "price",
            "isArchived"});
            this.Coloumn_Product_ComboBox.Location = new System.Drawing.Point(615, 130);
            this.Coloumn_Product_ComboBox.Name = "Coloumn_Product_ComboBox";
            this.Coloumn_Product_ComboBox.Size = new System.Drawing.Size(167, 21);
            this.Coloumn_Product_ComboBox.TabIndex = 102;
            this.Coloumn_Product_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Coloumn_Product_ComboBox_SelectedIndexChanged);
            // 
            // Search_label
            // 
            this.Search_label.AutoSize = true;
            this.Search_label.BackColor = System.Drawing.Color.Transparent;
            this.Search_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_label.Location = new System.Drawing.Point(823, 163);
            this.Search_label.Name = "Search_label";
            this.Search_label.Size = new System.Drawing.Size(65, 22);
            this.Search_label.TabIndex = 101;
            this.Search_label.Text = ":חיפוש ";
            this.Search_label.Click += new System.EventHandler(this.Search_label_Click);
            // 
            // Coloumn_Label
            // 
            this.Coloumn_Label.AutoSize = true;
            this.Coloumn_Label.BackColor = System.Drawing.Color.Transparent;
            this.Coloumn_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coloumn_Label.Location = new System.Drawing.Point(797, 130);
            this.Coloumn_Label.Name = "Coloumn_Label";
            this.Coloumn_Label.Size = new System.Drawing.Size(112, 22);
            this.Coloumn_Label.TabIndex = 100;
            this.Coloumn_Label.Text = ":בחירת עמודה";
            this.Coloumn_Label.Click += new System.EventHandler(this.Coloumn_Label_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(877, 631);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 110;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.sAD_27DataSet14;
            // 
            // sAD_27DataSet14
            // 
            this.sAD_27DataSet14.DataSetName = "SAD_27DataSet14";
            this.sAD_27DataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // AllProducts_DataGrid
            // 
            this.AllProducts_DataGrid.AutoGenerateColumns = false;
            this.AllProducts_DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllProducts_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllProducts_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.defectivePercentageDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.partNumberDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.supplierIdDataGridViewTextBoxColumn,
            this.isArchivedDataGridViewCheckBoxColumn});
            this.AllProducts_DataGrid.DataSource = this.productsBindingSource2;
            this.AllProducts_DataGrid.Location = new System.Drawing.Point(64, 204);
            this.AllProducts_DataGrid.Name = "AllProducts_DataGrid";
            this.AllProducts_DataGrid.Size = new System.Drawing.Size(845, 293);
            this.AllProducts_DataGrid.TabIndex = 111;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // defectivePercentageDataGridViewTextBoxColumn
            // 
            this.defectivePercentageDataGridViewTextBoxColumn.DataPropertyName = "DefectivePercentage";
            this.defectivePercentageDataGridViewTextBoxColumn.HeaderText = "DefectivePercentage";
            this.defectivePercentageDataGridViewTextBoxColumn.Name = "defectivePercentageDataGridViewTextBoxColumn";
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            // 
            // partNumberDataGridViewTextBoxColumn
            // 
            this.partNumberDataGridViewTextBoxColumn.DataPropertyName = "PartNumber";
            this.partNumberDataGridViewTextBoxColumn.HeaderText = "PartNumber";
            this.partNumberDataGridViewTextBoxColumn.Name = "partNumberDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "supplierId";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "supplierId";
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            // 
            // isArchivedDataGridViewCheckBoxColumn
            // 
            this.isArchivedDataGridViewCheckBoxColumn.DataPropertyName = "IsArchived";
            this.isArchivedDataGridViewCheckBoxColumn.HeaderText = "IsArchived";
            this.isArchivedDataGridViewCheckBoxColumn.Name = "isArchivedDataGridViewCheckBoxColumn";
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.sAD_27DataSet15;
            // 
            // sAD_27DataSet15
            // 
            this.sAD_27DataSet15.DataSetName = "SAD_27DataSet15";
            this.sAD_27DataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter2
            // 
            this.productsTableAdapter2.ClearBeforeFill = true;
            // 
            // AllProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(964, 718);
            this.Controls.Add(this.AllProducts_DataGrid);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.Product_toArchive_button);
            this.Controls.Add(this.Back_ToProduct_Crud_Button);
            this.Controls.Add(this.All_Product_Label);
            this.Controls.Add(this.Back_Product_ToActive_Button);
            this.Controls.Add(this.Search_by_Products_Coloumn_ComboBox);
            this.Controls.Add(this.Coloumn_Product_ComboBox);
            this.Controls.Add(this.Search_label);
            this.Controls.Add(this.Coloumn_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllProducts";
            this.Text = "AllProducts";
            this.Load += new System.EventHandler(this.AllProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllProducts_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Product_toArchive_button;
        private System.Windows.Forms.Button Back_ToProduct_Crud_Button;
        private System.Windows.Forms.Label All_Product_Label;
        private System.Windows.Forms.Button Back_Product_ToActive_Button;
        private System.Windows.Forms.TextBox Search_by_Products_Coloumn_ComboBox;
        private System.Windows.Forms.ComboBox Coloumn_Product_ComboBox;
        private System.Windows.Forms.Label Search_label;
        private System.Windows.Forms.Label Coloumn_Label;
        private SAD_27DataSet2 sAD_27DataSet2;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private SAD_27DataSet2TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button Back_To_Home_Page;
        private SAD_27DataSet14 sAD_27DataSet14;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private SAD_27DataSet14TableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.DataGridView AllProducts_DataGrid;
        private SAD_27DataSet15 sAD_27DataSet15;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private SAD_27DataSet15TableAdapters.ProductsTableAdapter productsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defectivePercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isArchivedDataGridViewCheckBoxColumn;
    }
}