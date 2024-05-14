namespace Group_27
{
    partial class AllOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllOrders));
            this.Order_toArchive_button = new System.Windows.Forms.Button();
            this.Back_ToOrder_Managment_Button = new System.Windows.Forms.Button();
            this.All_Product_Label = new System.Windows.Forms.Label();
            this.Back_Order_ToActive_Button = new System.Windows.Forms.Button();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_27DataSet4 = new Group_27.SAD_27DataSet4();
            this.Search_by_Order_Coloumn_ComboBox = new System.Windows.Forms.TextBox();
            this.Coloumn_Order_ComboBox = new System.Windows.Forms.ComboBox();
            this.Search_label = new System.Windows.Forms.Label();
            this.Coloumn_Label = new System.Windows.Forms.Label();
            this.ordersTableAdapter = new Group_27.SAD_27DataSet4TableAdapters.OrdersTableAdapter();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            this.sAD_27DataSet8 = new Group_27.SAD_27DataSet8();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter1 = new Group_27.SAD_27DataSet8TableAdapters.OrdersTableAdapter();
            this.sAD_27DataSet9 = new Group_27.SAD_27DataSet9();
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter2 = new Group_27.SAD_27DataSet9TableAdapters.OrdersTableAdapter();
            this.sAD_27DataSet10 = new Group_27.SAD_27DataSet10();
            this.ordersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter3 = new Group_27.SAD_27DataSet10TableAdapters.OrdersTableAdapter();
            this.ordersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_27DataSet11 = new Group_27.SAD_27DataSet11();
            this.ordersTableAdapter4 = new Group_27.SAD_27DataSet11TableAdapters.OrdersTableAdapter();
            this.sAD_27DataSet12 = new Group_27.SAD_27DataSet12();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requirementsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPriorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startPreparationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isArchivedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customerOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_27DataSet13 = new Group_27.SAD_27DataSet13();
            this.ordersTableAdapter5 = new Group_27.SAD_27DataSet13TableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // Order_toArchive_button
            // 
            this.Order_toArchive_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Order_toArchive_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Order_toArchive_button.BackgroundImage")));
            this.Order_toArchive_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Order_toArchive_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Order_toArchive_button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_toArchive_button.Location = new System.Drawing.Point(776, 587);
            this.Order_toArchive_button.Name = "Order_toArchive_button";
            this.Order_toArchive_button.Size = new System.Drawing.Size(140, 60);
            this.Order_toArchive_button.TabIndex = 117;
            this.Order_toArchive_button.Text = "העברה לארכיון";
            this.Order_toArchive_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Order_toArchive_button.UseVisualStyleBackColor = false;
            this.Order_toArchive_button.Click += new System.EventHandler(this.Order_toArchive_button_Click);
            // 
            // Back_ToOrder_Managment_Button
            // 
            this.Back_ToOrder_Managment_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_ToOrder_Managment_Button.BackgroundImage")));
            this.Back_ToOrder_Managment_Button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_ToOrder_Managment_Button.Location = new System.Drawing.Point(1069, 587);
            this.Back_ToOrder_Managment_Button.Name = "Back_ToOrder_Managment_Button";
            this.Back_ToOrder_Managment_Button.Size = new System.Drawing.Size(107, 60);
            this.Back_ToOrder_Managment_Button.TabIndex = 116;
            this.Back_ToOrder_Managment_Button.Text = "חזור";
            this.Back_ToOrder_Managment_Button.UseVisualStyleBackColor = true;
            this.Back_ToOrder_Managment_Button.Click += new System.EventHandler(this.Back_ToOrder_Managment_Button_Click);
            // 
            // All_Product_Label
            // 
            this.All_Product_Label.AutoSize = true;
            this.All_Product_Label.BackColor = System.Drawing.Color.Transparent;
            this.All_Product_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.All_Product_Label.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_Product_Label.Location = new System.Drawing.Point(481, 33);
            this.All_Product_Label.Name = "All_Product_Label";
            this.All_Product_Label.Size = new System.Drawing.Size(299, 66);
            this.All_Product_Label.TabIndex = 115;
            this.All_Product_Label.Text = "טבלת הזמנות";
            // 
            // Back_Order_ToActive_Button
            // 
            this.Back_Order_ToActive_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_Order_ToActive_Button.BackgroundImage")));
            this.Back_Order_ToActive_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Back_Order_ToActive_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_Order_ToActive_Button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Order_ToActive_Button.Location = new System.Drawing.Point(588, 587);
            this.Back_Order_ToActive_Button.Name = "Back_Order_ToActive_Button";
            this.Back_Order_ToActive_Button.Size = new System.Drawing.Size(170, 60);
            this.Back_Order_ToActive_Button.TabIndex = 114;
            this.Back_Order_ToActive_Button.Text = "החזרה להזמנה פעילה";
            this.Back_Order_ToActive_Button.UseVisualStyleBackColor = true;
            this.Back_Order_ToActive_Button.Click += new System.EventHandler(this.Back_Order_ToActive_Button_Click);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.sAD_27DataSet4;
            // 
            // sAD_27DataSet4
            // 
            this.sAD_27DataSet4.DataSetName = "SAD_27DataSet4";
            this.sAD_27DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Search_by_Order_Coloumn_ComboBox
            // 
            this.Search_by_Order_Coloumn_ComboBox.Location = new System.Drawing.Point(882, 159);
            this.Search_by_Order_Coloumn_ComboBox.Name = "Search_by_Order_Coloumn_ComboBox";
            this.Search_by_Order_Coloumn_ComboBox.Size = new System.Drawing.Size(167, 20);
            this.Search_by_Order_Coloumn_ComboBox.TabIndex = 112;
            this.Search_by_Order_Coloumn_ComboBox.TextChanged += new System.EventHandler(this.Search_by_Order_Coloumn_ComboBox_TextChanged);
            this.Search_by_Order_Coloumn_ComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_by_Order_Coloumn_ComboBox_KeyDown);
            // 
            // Coloumn_Order_ComboBox
            // 
            this.Coloumn_Order_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Coloumn_Order_ComboBox.FormattingEnabled = true;
            this.Coloumn_Order_ComboBox.Items.AddRange(new object[] {
            "orderId",
            "dateReceived",
            "deadLine",
            "requirements",
            "status",
            "priority",
            "startPreparationDate",
            "expectedProfit",
            "isArchived"});
            this.Coloumn_Order_ComboBox.Location = new System.Drawing.Point(882, 126);
            this.Coloumn_Order_ComboBox.Name = "Coloumn_Order_ComboBox";
            this.Coloumn_Order_ComboBox.Size = new System.Drawing.Size(167, 21);
            this.Coloumn_Order_ComboBox.TabIndex = 111;
            this.Coloumn_Order_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Coloumn_Order_ComboBox_SelectedIndexChanged);
            // 
            // Search_label
            // 
            this.Search_label.AutoSize = true;
            this.Search_label.BackColor = System.Drawing.Color.Transparent;
            this.Search_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_label.Location = new System.Drawing.Point(1090, 159);
            this.Search_label.Name = "Search_label";
            this.Search_label.Size = new System.Drawing.Size(65, 22);
            this.Search_label.TabIndex = 110;
            this.Search_label.Text = ":חיפוש ";
            // 
            // Coloumn_Label
            // 
            this.Coloumn_Label.AutoSize = true;
            this.Coloumn_Label.BackColor = System.Drawing.Color.Transparent;
            this.Coloumn_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coloumn_Label.Location = new System.Drawing.Point(1064, 126);
            this.Coloumn_Label.Name = "Coloumn_Label";
            this.Coloumn_Label.Size = new System.Drawing.Size(112, 22);
            this.Coloumn_Label.TabIndex = 109;
            this.Coloumn_Label.Text = ":בחירת עמודה";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(1207, 620);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 118;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // sAD_27DataSet8
            // 
            this.sAD_27DataSet8.DataSetName = "SAD_27DataSet8";
            this.sAD_27DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.sAD_27DataSet8;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // sAD_27DataSet9
            // 
            this.sAD_27DataSet9.DataSetName = "SAD_27DataSet9";
            this.sAD_27DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource2
            // 
            this.ordersBindingSource2.DataMember = "Orders";
            this.ordersBindingSource2.DataSource = this.sAD_27DataSet9;
            // 
            // ordersTableAdapter2
            // 
            this.ordersTableAdapter2.ClearBeforeFill = true;
            // 
            // sAD_27DataSet10
            // 
            this.sAD_27DataSet10.DataSetName = "SAD_27DataSet10";
            this.sAD_27DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource3
            // 
            this.ordersBindingSource3.DataMember = "Orders";
            this.ordersBindingSource3.DataSource = this.sAD_27DataSet10;
            // 
            // ordersTableAdapter3
            // 
            this.ordersTableAdapter3.ClearBeforeFill = true;
            // 
            // ordersBindingSource4
            // 
            this.ordersBindingSource4.DataMember = "Orders";
            this.ordersBindingSource4.DataSource = this.sAD_27DataSet11;
            // 
            // sAD_27DataSet11
            // 
            this.sAD_27DataSet11.DataSetName = "SAD_27DataSet11";
            this.sAD_27DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter4
            // 
            this.ordersTableAdapter4.ClearBeforeFill = true;
            // 
            // sAD_27DataSet12
            // 
            this.sAD_27DataSet12.DataSetName = "SAD_27DataSet12";
            this.sAD_27DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.receivedDateDataGridViewTextBoxColumn,
            this.deadLineDataGridViewTextBoxColumn,
            this.requirementsDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn,
            this.orderPriorityDataGridViewTextBoxColumn,
            this.startPreparationDateDataGridViewTextBoxColumn,
            this.expectedProfitDataGridViewTextBoxColumn,
            this.isArchivedDataGridViewCheckBoxColumn,
            this.customerOrderDataGridViewTextBoxColumn,
            this.productsDetailsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(30, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 385);
            this.dataGridView1.TabIndex = 119;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receivedDateDataGridViewTextBoxColumn
            // 
            this.receivedDateDataGridViewTextBoxColumn.DataPropertyName = "ReceivedDate";
            this.receivedDateDataGridViewTextBoxColumn.HeaderText = "ReceivedDate";
            this.receivedDateDataGridViewTextBoxColumn.Name = "receivedDateDataGridViewTextBoxColumn";
            this.receivedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deadLineDataGridViewTextBoxColumn
            // 
            this.deadLineDataGridViewTextBoxColumn.DataPropertyName = "DeadLine";
            this.deadLineDataGridViewTextBoxColumn.HeaderText = "DeadLine";
            this.deadLineDataGridViewTextBoxColumn.Name = "deadLineDataGridViewTextBoxColumn";
            this.deadLineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requirementsDataGridViewTextBoxColumn
            // 
            this.requirementsDataGridViewTextBoxColumn.DataPropertyName = "Requirements";
            this.requirementsDataGridViewTextBoxColumn.HeaderText = "Requirements";
            this.requirementsDataGridViewTextBoxColumn.Name = "requirementsDataGridViewTextBoxColumn";
            this.requirementsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            this.orderStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderPriorityDataGridViewTextBoxColumn
            // 
            this.orderPriorityDataGridViewTextBoxColumn.DataPropertyName = "OrderPriority";
            this.orderPriorityDataGridViewTextBoxColumn.HeaderText = "OrderPriority";
            this.orderPriorityDataGridViewTextBoxColumn.Name = "orderPriorityDataGridViewTextBoxColumn";
            this.orderPriorityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startPreparationDateDataGridViewTextBoxColumn
            // 
            this.startPreparationDateDataGridViewTextBoxColumn.DataPropertyName = "StartPreparationDate";
            this.startPreparationDateDataGridViewTextBoxColumn.HeaderText = "StartPreparationDate";
            this.startPreparationDateDataGridViewTextBoxColumn.Name = "startPreparationDateDataGridViewTextBoxColumn";
            this.startPreparationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expectedProfitDataGridViewTextBoxColumn
            // 
            this.expectedProfitDataGridViewTextBoxColumn.DataPropertyName = "ExpectedProfit";
            this.expectedProfitDataGridViewTextBoxColumn.HeaderText = "ExpectedProfit";
            this.expectedProfitDataGridViewTextBoxColumn.Name = "expectedProfitDataGridViewTextBoxColumn";
            this.expectedProfitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isArchivedDataGridViewCheckBoxColumn
            // 
            this.isArchivedDataGridViewCheckBoxColumn.DataPropertyName = "IsArchived";
            this.isArchivedDataGridViewCheckBoxColumn.HeaderText = "IsArchived";
            this.isArchivedDataGridViewCheckBoxColumn.Name = "isArchivedDataGridViewCheckBoxColumn";
            this.isArchivedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // customerOrderDataGridViewTextBoxColumn
            // 
            this.customerOrderDataGridViewTextBoxColumn.DataPropertyName = "CustomerOrder";
            this.customerOrderDataGridViewTextBoxColumn.HeaderText = "CustomerOrder";
            this.customerOrderDataGridViewTextBoxColumn.Name = "customerOrderDataGridViewTextBoxColumn";
            this.customerOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productsDetailsDataGridViewTextBoxColumn
            // 
            this.productsDetailsDataGridViewTextBoxColumn.DataPropertyName = "ProductsDetails";
            this.productsDetailsDataGridViewTextBoxColumn.HeaderText = "ProductsDetails";
            this.productsDetailsDataGridViewTextBoxColumn.Name = "productsDetailsDataGridViewTextBoxColumn";
            this.productsDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordersBindingSource5
            // 
            this.ordersBindingSource5.DataMember = "Orders";
            this.ordersBindingSource5.DataSource = this.sAD_27DataSet13;
            // 
            // sAD_27DataSet13
            // 
            this.sAD_27DataSet13.DataSetName = "SAD_27DataSet13";
            this.sAD_27DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter5
            // 
            this.ordersTableAdapter5.ClearBeforeFill = true;
            // 
            // AllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1294, 707);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.Order_toArchive_button);
            this.Controls.Add(this.Back_ToOrder_Managment_Button);
            this.Controls.Add(this.All_Product_Label);
            this.Controls.Add(this.Back_Order_ToActive_Button);
            this.Controls.Add(this.Search_by_Order_Coloumn_ComboBox);
            this.Controls.Add(this.Coloumn_Order_ComboBox);
            this.Controls.Add(this.Search_label);
            this.Controls.Add(this.Coloumn_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllOrders";
            this.Text = "AllOrders";
            this.Load += new System.EventHandler(this.AllOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Order_toArchive_button;
        private System.Windows.Forms.Button Back_ToOrder_Managment_Button;
        private System.Windows.Forms.Label All_Product_Label;
        private System.Windows.Forms.Button Back_Order_ToActive_Button;
        private System.Windows.Forms.TextBox Search_by_Order_Coloumn_ComboBox;
        private System.Windows.Forms.ComboBox Coloumn_Order_ComboBox;
        private System.Windows.Forms.Label Search_label;
        private System.Windows.Forms.Label Coloumn_Label;
        private SAD_27DataSet4 sAD_27DataSet4;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private SAD_27DataSet4TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Button Back_To_Home_Page;
        private SAD_27DataSet8 sAD_27DataSet8;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private SAD_27DataSet8TableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private SAD_27DataSet9 sAD_27DataSet9;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private SAD_27DataSet9TableAdapters.OrdersTableAdapter ordersTableAdapter2;
        private SAD_27DataSet10 sAD_27DataSet10;
        private System.Windows.Forms.BindingSource ordersBindingSource3;
        private SAD_27DataSet10TableAdapters.OrdersTableAdapter ordersTableAdapter3;
        private SAD_27DataSet11 sAD_27DataSet11;
        private System.Windows.Forms.BindingSource ordersBindingSource4;
        private SAD_27DataSet11TableAdapters.OrdersTableAdapter ordersTableAdapter4;
        private SAD_27DataSet12 sAD_27DataSet12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SAD_27DataSet13 sAD_27DataSet13;
        private System.Windows.Forms.BindingSource ordersBindingSource5;
        private SAD_27DataSet13TableAdapters.OrdersTableAdapter ordersTableAdapter5;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requirementsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPriorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPreparationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isArchivedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsDetailsDataGridViewTextBoxColumn;
    }
}