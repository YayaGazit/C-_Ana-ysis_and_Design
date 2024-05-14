namespace Group_27
{
    partial class CreateOrderFromSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrderFromSupplier));
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            this.Create_Order_FroM_supplier_Label = new System.Windows.Forms.Label();
            this.Supplier_ID_Label = new System.Windows.Forms.Label();
            this.Supplier_ID_TextBox = new System.Windows.Forms.TextBox();
            this.finish_Button = new System.Windows.Forms.Button();
            this.OrderFS_AddProducts_label = new System.Windows.Forms.Label();
            this.OrderFS_Details_Label = new System.Windows.Forms.Label();
            this.Order_Date_label = new System.Windows.Forms.Label();
            this.OrderFS_Details_Textbox = new System.Windows.Forms.TextBox();
            this.Product_Id_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_Product_ToORS_DataGrid = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_Product_OFS_Button = new System.Windows.Forms.Button();
            this.add_quantity_label = new System.Windows.Forms.Label();
            this.add_quantity_textbox = new System.Windows.Forms.TextBox();
            this.orderFromSupplier_datePicker = new System.Windows.Forms.DateTimePicker();
            this.Delete_Product_OFS_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.add_Product_ToORS_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(510, 761);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 126;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // Create_Order_FroM_supplier_Label
            // 
            this.Create_Order_FroM_supplier_Label.AutoSize = true;
            this.Create_Order_FroM_supplier_Label.BackColor = System.Drawing.Color.Transparent;
            this.Create_Order_FroM_supplier_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Create_Order_FroM_supplier_Label.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Order_FroM_supplier_Label.Location = new System.Drawing.Point(77, 24);
            this.Create_Order_FroM_supplier_Label.Name = "Create_Order_FroM_supplier_Label";
            this.Create_Order_FroM_supplier_Label.Size = new System.Drawing.Size(410, 66);
            this.Create_Order_FroM_supplier_Label.TabIndex = 124;
            this.Create_Order_FroM_supplier_Label.Text = "יצירת הזמנה לספק";
            // 
            // Supplier_ID_Label
            // 
            this.Supplier_ID_Label.AutoSize = true;
            this.Supplier_ID_Label.BackColor = System.Drawing.Color.Transparent;
            this.Supplier_ID_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supplier_ID_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_ID_Label.Location = new System.Drawing.Point(408, 126);
            this.Supplier_ID_Label.Name = "Supplier_ID_Label";
            this.Supplier_ID_Label.Size = new System.Drawing.Size(103, 22);
            this.Supplier_ID_Label.TabIndex = 122;
            this.Supplier_ID_Label.Text = ":מזהה הספק";
            // 
            // Supplier_ID_TextBox
            // 
            this.Supplier_ID_TextBox.Location = new System.Drawing.Point(177, 129);
            this.Supplier_ID_TextBox.Name = "Supplier_ID_TextBox";
            this.Supplier_ID_TextBox.Size = new System.Drawing.Size(205, 20);
            this.Supplier_ID_TextBox.TabIndex = 120;
            this.Supplier_ID_TextBox.TextChanged += new System.EventHandler(this.Supplier_ID_TextBox_TextChanged_1);
            // 
            // finish_Button
            // 
            this.finish_Button.BackColor = System.Drawing.Color.Transparent;
            this.finish_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finish_Button.BackgroundImage")));
            this.finish_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finish_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.finish_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.finish_Button.FlatAppearance.BorderSize = 10;
            this.finish_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finish_Button.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.finish_Button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.finish_Button.Location = new System.Drawing.Point(162, 676);
            this.finish_Button.Name = "finish_Button";
            this.finish_Button.Size = new System.Drawing.Size(245, 58);
            this.finish_Button.TabIndex = 119;
            this.finish_Button.Text = "סיום";
            this.finish_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.finish_Button.UseVisualStyleBackColor = false;
            this.finish_Button.Click += new System.EventHandler(this.finish_Button_Click_1);
            // 
            // OrderFS_AddProducts_label
            // 
            this.OrderFS_AddProducts_label.AutoSize = true;
            this.OrderFS_AddProducts_label.BackColor = System.Drawing.Color.Transparent;
            this.OrderFS_AddProducts_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFS_AddProducts_label.Location = new System.Drawing.Point(408, 283);
            this.OrderFS_AddProducts_label.Name = "OrderFS_AddProducts_label";
            this.OrderFS_AddProducts_label.Size = new System.Drawing.Size(116, 22);
            this.OrderFS_AddProducts_label.TabIndex = 116;
            this.OrderFS_AddProducts_label.Text = "הוספת מוצרים";
            // 
            // OrderFS_Details_Label
            // 
            this.OrderFS_Details_Label.AutoSize = true;
            this.OrderFS_Details_Label.BackColor = System.Drawing.Color.Transparent;
            this.OrderFS_Details_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrderFS_Details_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFS_Details_Label.Location = new System.Drawing.Point(408, 219);
            this.OrderFS_Details_Label.Name = "OrderFS_Details_Label";
            this.OrderFS_Details_Label.Size = new System.Drawing.Size(119, 22);
            this.OrderFS_Details_Label.TabIndex = 115;
            this.OrderFS_Details_Label.Text = ":תיאור ההזמנה";
            // 
            // Order_Date_label
            // 
            this.Order_Date_label.AutoSize = true;
            this.Order_Date_label.BackColor = System.Drawing.Color.Transparent;
            this.Order_Date_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Order_Date_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Date_label.Location = new System.Drawing.Point(408, 175);
            this.Order_Date_label.Name = "Order_Date_label";
            this.Order_Date_label.Size = new System.Drawing.Size(112, 22);
            this.Order_Date_label.TabIndex = 114;
            this.Order_Date_label.Text = ":תאריך הזמנה";
            // 
            // OrderFS_Details_Textbox
            // 
            this.OrderFS_Details_Textbox.Location = new System.Drawing.Point(176, 219);
            this.OrderFS_Details_Textbox.Multiline = true;
            this.OrderFS_Details_Textbox.Name = "OrderFS_Details_Textbox";
            this.OrderFS_Details_Textbox.Size = new System.Drawing.Size(206, 65);
            this.OrderFS_Details_Textbox.TabIndex = 111;
            // 
            // Product_Id_Textbox
            // 
            this.Product_Id_Textbox.Location = new System.Drawing.Point(176, 317);
            this.Product_Id_Textbox.Name = "Product_Id_Textbox";
            this.Product_Id_Textbox.Size = new System.Drawing.Size(206, 20);
            this.Product_Id_Textbox.TabIndex = 127;
            this.Product_Id_Textbox.TextChanged += new System.EventHandler(this.Product_Id_Textbox_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 128;
            this.label1.Text = ":הזן מזהה מוצר";
            // 
            // add_Product_ToORS_DataGrid
            // 
            this.add_Product_ToORS_DataGrid.AllowUserToAddRows = false;
            this.add_Product_ToORS_DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_Product_ToORS_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.add_Product_ToORS_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.Quantity});
            this.add_Product_ToORS_DataGrid.Location = new System.Drawing.Point(162, 418);
            this.add_Product_ToORS_DataGrid.Name = "add_Product_ToORS_DataGrid";
            this.add_Product_ToORS_DataGrid.ReadOnly = true;
            this.add_Product_ToORS_DataGrid.Size = new System.Drawing.Size(245, 170);
            this.add_Product_ToORS_DataGrid.TabIndex = 129;
            this.add_Product_ToORS_DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.add_Product_ToORS_DataGrid_CellContentClick_1);
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Add_Product_OFS_Button
            // 
            this.Add_Product_OFS_Button.BackColor = System.Drawing.Color.Transparent;
            this.Add_Product_OFS_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_Product_OFS_Button.BackgroundImage")));
            this.Add_Product_OFS_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_Product_OFS_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Add_Product_OFS_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Add_Product_OFS_Button.FlatAppearance.BorderSize = 10;
            this.Add_Product_OFS_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Product_OFS_Button.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Product_OFS_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add_Product_OFS_Button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Add_Product_OFS_Button.Location = new System.Drawing.Point(86, 317);
            this.Add_Product_OFS_Button.Name = "Add_Product_OFS_Button";
            this.Add_Product_OFS_Button.Size = new System.Drawing.Size(77, 72);
            this.Add_Product_OFS_Button.TabIndex = 130;
            this.Add_Product_OFS_Button.Text = "הוספת מוצר";
            this.Add_Product_OFS_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add_Product_OFS_Button.UseVisualStyleBackColor = false;
            this.Add_Product_OFS_Button.Click += new System.EventHandler(this.Add_Product_OFS_Button_Click_1);
            // 
            // add_quantity_label
            // 
            this.add_quantity_label.AutoSize = true;
            this.add_quantity_label.BackColor = System.Drawing.Color.Transparent;
            this.add_quantity_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_quantity_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_quantity_label.Location = new System.Drawing.Point(409, 367);
            this.add_quantity_label.Name = "add_quantity_label";
            this.add_quantity_label.Size = new System.Drawing.Size(78, 22);
            this.add_quantity_label.TabIndex = 132;
            this.add_quantity_label.Text = ":הזן כמות";
            // 
            // add_quantity_textbox
            // 
            this.add_quantity_textbox.Location = new System.Drawing.Point(176, 369);
            this.add_quantity_textbox.Name = "add_quantity_textbox";
            this.add_quantity_textbox.Size = new System.Drawing.Size(206, 20);
            this.add_quantity_textbox.TabIndex = 131;
            this.add_quantity_textbox.TextChanged += new System.EventHandler(this.add_quantity_textbox_TextChanged_1);
            // 
            // orderFromSupplier_datePicker
            // 
            this.orderFromSupplier_datePicker.Location = new System.Drawing.Point(176, 175);
            this.orderFromSupplier_datePicker.Name = "orderFromSupplier_datePicker";
            this.orderFromSupplier_datePicker.Size = new System.Drawing.Size(206, 20);
            this.orderFromSupplier_datePicker.TabIndex = 133;
            this.orderFromSupplier_datePicker.ValueChanged += new System.EventHandler(this.orderFromSupplier_datePicker_ValueChanged_1);
            // 
            // Delete_Product_OFS_Button
            // 
            this.Delete_Product_OFS_Button.BackColor = System.Drawing.Color.Transparent;
            this.Delete_Product_OFS_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_Product_OFS_Button.BackgroundImage")));
            this.Delete_Product_OFS_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete_Product_OFS_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Delete_Product_OFS_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Delete_Product_OFS_Button.FlatAppearance.BorderSize = 10;
            this.Delete_Product_OFS_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete_Product_OFS_Button.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Product_OFS_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Delete_Product_OFS_Button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Delete_Product_OFS_Button.Location = new System.Drawing.Point(203, 594);
            this.Delete_Product_OFS_Button.Name = "Delete_Product_OFS_Button";
            this.Delete_Product_OFS_Button.Size = new System.Drawing.Size(139, 58);
            this.Delete_Product_OFS_Button.TabIndex = 134;
            this.Delete_Product_OFS_Button.Text = "מחק מוצר";
            this.Delete_Product_OFS_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Delete_Product_OFS_Button.UseVisualStyleBackColor = false;
            this.Delete_Product_OFS_Button.Click += new System.EventHandler(this.Delete_Product_OFS_Button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(510, 700);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 135;
            this.button1.Text = "חזור";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateOrderFromSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_27.Properties.Resources.רקע_לטופס;
            this.ClientSize = new System.Drawing.Size(597, 848);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Delete_Product_OFS_Button);
            this.Controls.Add(this.orderFromSupplier_datePicker);
            this.Controls.Add(this.add_quantity_label);
            this.Controls.Add(this.add_quantity_textbox);
            this.Controls.Add(this.Add_Product_OFS_Button);
            this.Controls.Add(this.add_Product_ToORS_DataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Product_Id_Textbox);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.Create_Order_FroM_supplier_Label);
            this.Controls.Add(this.Supplier_ID_Label);
            this.Controls.Add(this.Supplier_ID_TextBox);
            this.Controls.Add(this.finish_Button);
            this.Controls.Add(this.OrderFS_AddProducts_label);
            this.Controls.Add(this.OrderFS_Details_Label);
            this.Controls.Add(this.Order_Date_label);
            this.Controls.Add(this.OrderFS_Details_Textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateOrderFromSupplier";
            this.Text = "CreateOrderFromSupplier";
            this.Load += new System.EventHandler(this.CreateOrderFromSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.add_Product_ToORS_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_To_Home_Page;
        private System.Windows.Forms.Label Create_Order_FroM_supplier_Label;
        private System.Windows.Forms.Label Supplier_ID_Label;
        private System.Windows.Forms.TextBox Supplier_ID_TextBox;
        private System.Windows.Forms.Button finish_Button;
        private System.Windows.Forms.Label OrderFS_AddProducts_label;
        private System.Windows.Forms.Label OrderFS_Details_Label;
        private System.Windows.Forms.Label Order_Date_label;
        private System.Windows.Forms.TextBox OrderFS_Details_Textbox;
        private System.Windows.Forms.TextBox Product_Id_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView add_Product_ToORS_DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button Add_Product_OFS_Button;
        private System.Windows.Forms.Label add_quantity_label;
        private System.Windows.Forms.TextBox add_quantity_textbox;
        private System.Windows.Forms.DateTimePicker orderFromSupplier_datePicker;
        private System.Windows.Forms.Button Delete_Product_OFS_Button;
        private System.Windows.Forms.Button button1;
    }
}