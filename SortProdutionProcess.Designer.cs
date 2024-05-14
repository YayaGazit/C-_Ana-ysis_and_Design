namespace Group_27
{
    partial class SortProdutionProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortProdutionProcess));
            this.Sort_Production_Process_LAbel = new System.Windows.Forms.Label();
            this.sAD_27DataSet16 = new Group_27.SAD_27DataSet16();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Group_27.SAD_27DataSet16TableAdapters.OrdersTableAdapter();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            this.Sort_Orders_Button = new System.Windows.Forms.Button();
            this.OrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requirements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartPreparationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FFinalOrders_DataGrid = new System.Windows.Forms.DataGridView();
            this.Order_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Received_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dead_Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RRequirements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SStartPreparationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expected_Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urgency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowOrder_BackToManagment_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FFinalOrders_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Sort_Production_Process_LAbel
            // 
            this.Sort_Production_Process_LAbel.AutoSize = true;
            this.Sort_Production_Process_LAbel.BackColor = System.Drawing.Color.Transparent;
            this.Sort_Production_Process_LAbel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Sort_Production_Process_LAbel.Font = new System.Drawing.Font("Microsoft YaHei", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sort_Production_Process_LAbel.Location = new System.Drawing.Point(376, 29);
            this.Sort_Production_Process_LAbel.Name = "Sort_Production_Process_LAbel";
            this.Sort_Production_Process_LAbel.Size = new System.Drawing.Size(504, 74);
            this.Sort_Production_Process_LAbel.TabIndex = 107;
            this.Sort_Production_Process_LAbel.Text = "תעדוף תהליכי ייצור";
            // 
            // sAD_27DataSet16
            // 
            this.sAD_27DataSet16.DataSetName = "SAD_27DataSet16";
            this.sAD_27DataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.sAD_27DataSet16;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(1214, 620);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 120;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // Sort_Orders_Button
            // 
            this.Sort_Orders_Button.BackColor = System.Drawing.Color.Transparent;
            this.Sort_Orders_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sort_Orders_Button.BackgroundImage")));
            this.Sort_Orders_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sort_Orders_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Sort_Orders_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Sort_Orders_Button.FlatAppearance.BorderSize = 10;
            this.Sort_Orders_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sort_Orders_Button.Font = new System.Drawing.Font("Microsoft YaHei", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sort_Orders_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sort_Orders_Button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Sort_Orders_Button.Location = new System.Drawing.Point(53, 455);
            this.Sort_Orders_Button.Name = "Sort_Orders_Button";
            this.Sort_Orders_Button.Size = new System.Drawing.Size(1045, 82);
            this.Sort_Orders_Button.TabIndex = 121;
            this.Sort_Orders_Button.Text = "מיין";
            this.Sort_Orders_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sort_Orders_Button.UseVisualStyleBackColor = false;
            this.Sort_Orders_Button.Click += new System.EventHandler(this.Sort_Orders_Button_Click);
            // 
            // OrdersDataGrid
            // 
            this.OrdersDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.ReceivedDate,
            this.DeadLine,
            this.Requirements,
            this.OrderStatus,
            this.OrderPriority,
            this.StartPreparationDate,
            this.ExpectedProfit,
            this.CustomerId});
            this.OrdersDataGrid.Location = new System.Drawing.Point(96, 151);
            this.OrdersDataGrid.Name = "OrdersDataGrid";
            this.OrdersDataGrid.Size = new System.Drawing.Size(953, 279);
            this.OrdersDataGrid.TabIndex = 122;
            this.OrdersDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersDataGrid_CellContentClick);
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "OrderId";
            this.OrderId.Name = "OrderId";
            // 
            // ReceivedDate
            // 
            this.ReceivedDate.HeaderText = "Received Date";
            this.ReceivedDate.Name = "ReceivedDate";
            // 
            // DeadLine
            // 
            this.DeadLine.HeaderText = "Dead Line";
            this.DeadLine.Name = "DeadLine";
            // 
            // Requirements
            // 
            this.Requirements.HeaderText = "Requirements";
            this.Requirements.Name = "Requirements";
            // 
            // OrderStatus
            // 
            this.OrderStatus.HeaderText = "Order Status";
            this.OrderStatus.Name = "OrderStatus";
            // 
            // OrderPriority
            // 
            this.OrderPriority.HeaderText = "Order Priority";
            this.OrderPriority.Name = "OrderPriority";
            // 
            // StartPreparationDate
            // 
            this.StartPreparationDate.HeaderText = "Preparation Date";
            this.StartPreparationDate.Name = "StartPreparationDate";
            // 
            // ExpectedProfit
            // 
            this.ExpectedProfit.HeaderText = "Expected Profit";
            this.ExpectedProfit.Name = "ExpectedProfit";
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "Customer Id";
            this.CustomerId.Name = "CustomerId";
            // 
            // FFinalOrders_DataGrid
            // 
            this.FFinalOrders_DataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.FFinalOrders_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FFinalOrders_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_ID,
            this.Received_Date,
            this.Dead_Line,
            this.RRequirements,
            this.Order_Status,
            this.Order_Priority,
            this.SStartPreparationDate,
            this.Expected_Profit,
            this.Customer_Id,
            this.Urgency});
            this.FFinalOrders_DataGrid.Location = new System.Drawing.Point(53, 151);
            this.FFinalOrders_DataGrid.Name = "FFinalOrders_DataGrid";
            this.FFinalOrders_DataGrid.ReadOnly = true;
            this.FFinalOrders_DataGrid.Size = new System.Drawing.Size(1045, 279);
            this.FFinalOrders_DataGrid.TabIndex = 124;
            // 
            // Order_ID
            // 
            this.Order_ID.HeaderText = "Order_ID";
            this.Order_ID.Name = "Order_ID";
            this.Order_ID.ReadOnly = true;
            // 
            // Received_Date
            // 
            this.Received_Date.HeaderText = "Received_Date";
            this.Received_Date.Name = "Received_Date";
            this.Received_Date.ReadOnly = true;
            // 
            // Dead_Line
            // 
            this.Dead_Line.HeaderText = "Dead_Line";
            this.Dead_Line.Name = "Dead_Line";
            this.Dead_Line.ReadOnly = true;
            // 
            // RRequirements
            // 
            this.RRequirements.HeaderText = "Requirements";
            this.RRequirements.Name = "RRequirements";
            this.RRequirements.ReadOnly = true;
            // 
            // Order_Status
            // 
            this.Order_Status.HeaderText = "Order_Status";
            this.Order_Status.Name = "Order_Status";
            this.Order_Status.ReadOnly = true;
            // 
            // Order_Priority
            // 
            this.Order_Priority.HeaderText = "Order_Priority";
            this.Order_Priority.Name = "Order_Priority";
            this.Order_Priority.ReadOnly = true;
            // 
            // SStartPreparationDate
            // 
            this.SStartPreparationDate.HeaderText = "PreparationDate";
            this.SStartPreparationDate.Name = "SStartPreparationDate";
            this.SStartPreparationDate.ReadOnly = true;
            // 
            // Expected_Profit
            // 
            this.Expected_Profit.HeaderText = "Expected_Profit";
            this.Expected_Profit.Name = "Expected_Profit";
            this.Expected_Profit.ReadOnly = true;
            // 
            // Customer_Id
            // 
            this.Customer_Id.HeaderText = "Customer_Id";
            this.Customer_Id.Name = "Customer_Id";
            this.Customer_Id.ReadOnly = true;
            // 
            // Urgency
            // 
            this.Urgency.HeaderText = "Urgency";
            this.Urgency.Name = "Urgency";
            this.Urgency.ReadOnly = true;
            // 
            // ShowOrder_BackToManagment_Button
            // 
            this.ShowOrder_BackToManagment_Button.BackColor = System.Drawing.Color.Transparent;
            this.ShowOrder_BackToManagment_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowOrder_BackToManagment_Button.BackgroundImage")));
            this.ShowOrder_BackToManagment_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ShowOrder_BackToManagment_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShowOrder_BackToManagment_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ShowOrder_BackToManagment_Button.FlatAppearance.BorderSize = 50;
            this.ShowOrder_BackToManagment_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowOrder_BackToManagment_Button.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowOrder_BackToManagment_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowOrder_BackToManagment_Button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ShowOrder_BackToManagment_Button.Location = new System.Drawing.Point(1214, 563);
            this.ShowOrder_BackToManagment_Button.Name = "ShowOrder_BackToManagment_Button";
            this.ShowOrder_BackToManagment_Button.Size = new System.Drawing.Size(75, 51);
            this.ShowOrder_BackToManagment_Button.TabIndex = 125;
            this.ShowOrder_BackToManagment_Button.Text = "חזור";
            this.ShowOrder_BackToManagment_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShowOrder_BackToManagment_Button.UseVisualStyleBackColor = false;
            this.ShowOrder_BackToManagment_Button.Click += new System.EventHandler(this.ShowOrder_BackToManagment_Button_Click);
            // 
            // SortProdutionProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1301, 707);
            this.Controls.Add(this.ShowOrder_BackToManagment_Button);
            this.Controls.Add(this.FFinalOrders_DataGrid);
            this.Controls.Add(this.OrdersDataGrid);
            this.Controls.Add(this.Sort_Orders_Button);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.Sort_Production_Process_LAbel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SortProdutionProcess";
            this.Text = "SortProdutionProcess";
            this.Load += new System.EventHandler(this.SortProdutionProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FFinalOrders_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sort_Production_Process_LAbel;
        private SAD_27DataSet16 sAD_27DataSet16;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private SAD_27DataSet16TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Button Back_To_Home_Page;
        private System.Windows.Forms.Button Sort_Orders_Button;
        private System.Windows.Forms.DataGridView OrdersDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requirements;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartPreparationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectedProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridView FFinalOrders_DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Received_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dead_Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn RRequirements;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn SStartPreparationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expected_Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urgency;
        private System.Windows.Forms.Button ShowOrder_BackToManagment_Button;
    }
}