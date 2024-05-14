namespace Group_27
{
    partial class ReceivedFromSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceivedFromSupplier));
            this.quanity_label = new System.Windows.Forms.Label();
            this.Recieved_quanity_TextBox = new System.Windows.Forms.TextBox();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            this.Add_New_Product_Label = new System.Windows.Forms.Label();
            this.Recieve_dorderFromSupplier_datePicker = new System.Windows.Forms.DateTimePicker();
            this.Supplier_ID_Label = new System.Windows.Forms.Label();
            this.Supplier_ID_TextBox = new System.Windows.Forms.TextBox();
            this.OrderFS_Details_Label = new System.Windows.Forms.Label();
            this.Order_Date_label = new System.Windows.Forms.Label();
            this.Recieved_OrderFS_Details_Textbox = new System.Windows.Forms.TextBox();
            this.OrderReceived_DataGrid = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityArrived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrived = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Recieved_DefectivePercantage_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Recieved_Input_Product = new System.Windows.Forms.Button();
            this.Finished_Received_Buton = new System.Windows.Forms.Button();
            this.Receive_Date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Received_Order_Status_label_comboBox = new System.Windows.Forms.ComboBox();
            this.Received_IntactnessStatu_ComboBox = new System.Windows.Forms.ComboBox();
            this.Received_Order_Status_label = new System.Windows.Forms.Label();
            this.Received_IntactnessStatu_label = new System.Windows.Forms.Label();
            this.Received_Show_Button = new System.Windows.Forms.Button();
            this.Back_ToCrud_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderReceived_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // quanity_label
            // 
            this.quanity_label.AutoSize = true;
            this.quanity_label.BackColor = System.Drawing.Color.Transparent;
            this.quanity_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quanity_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanity_label.Location = new System.Drawing.Point(389, 631);
            this.quanity_label.Name = "quanity_label";
            this.quanity_label.Size = new System.Drawing.Size(165, 22);
            this.quanity_label.TabIndex = 136;
            this.quanity_label.Text = ":כמות שהגיעה מפריט";
            // 
            // Recieved_quanity_TextBox
            // 
            this.Recieved_quanity_TextBox.Location = new System.Drawing.Point(166, 631);
            this.Recieved_quanity_TextBox.Name = "Recieved_quanity_TextBox";
            this.Recieved_quanity_TextBox.Size = new System.Drawing.Size(200, 20);
            this.Recieved_quanity_TextBox.TabIndex = 135;
            this.Recieved_quanity_TextBox.TextChanged += new System.EventHandler(this.Recieved_quanity_TextBox_TextChanged);
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(511, 758);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 132;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // Add_New_Product_Label
            // 
            this.Add_New_Product_Label.AutoSize = true;
            this.Add_New_Product_Label.BackColor = System.Drawing.Color.Transparent;
            this.Add_New_Product_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Add_New_Product_Label.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_Product_Label.Location = new System.Drawing.Point(74, 34);
            this.Add_New_Product_Label.Name = "Add_New_Product_Label";
            this.Add_New_Product_Label.Size = new System.Drawing.Size(448, 66);
            this.Add_New_Product_Label.TabIndex = 128;
            this.Add_New_Product_Label.Text = "קבלת הזמנה מהספק";
            // 
            // Recieve_dorderFromSupplier_datePicker
            // 
            this.Recieve_dorderFromSupplier_datePicker.Location = new System.Drawing.Point(203, 172);
            this.Recieve_dorderFromSupplier_datePicker.Name = "Recieve_dorderFromSupplier_datePicker";
            this.Recieve_dorderFromSupplier_datePicker.Size = new System.Drawing.Size(206, 20);
            this.Recieve_dorderFromSupplier_datePicker.TabIndex = 142;
            this.Recieve_dorderFromSupplier_datePicker.ValueChanged += new System.EventHandler(this.Recieve_dorderFromSupplier_datePicker_ValueChanged);
            // 
            // Supplier_ID_Label
            // 
            this.Supplier_ID_Label.AutoSize = true;
            this.Supplier_ID_Label.BackColor = System.Drawing.Color.Transparent;
            this.Supplier_ID_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supplier_ID_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_ID_Label.Location = new System.Drawing.Point(431, 131);
            this.Supplier_ID_Label.Name = "Supplier_ID_Label";
            this.Supplier_ID_Label.Size = new System.Drawing.Size(103, 22);
            this.Supplier_ID_Label.TabIndex = 141;
            this.Supplier_ID_Label.Text = ":מזהה הספק";
            // 
            // Supplier_ID_TextBox
            // 
            this.Supplier_ID_TextBox.Location = new System.Drawing.Point(204, 131);
            this.Supplier_ID_TextBox.Name = "Supplier_ID_TextBox";
            this.Supplier_ID_TextBox.Size = new System.Drawing.Size(205, 20);
            this.Supplier_ID_TextBox.TabIndex = 140;
            this.Supplier_ID_TextBox.TextChanged += new System.EventHandler(this.Supplier_ID_TextBox_TextChanged);
            // 
            // OrderFS_Details_Label
            // 
            this.OrderFS_Details_Label.AutoSize = true;
            this.OrderFS_Details_Label.BackColor = System.Drawing.Color.Transparent;
            this.OrderFS_Details_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrderFS_Details_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFS_Details_Label.Location = new System.Drawing.Point(431, 341);
            this.OrderFS_Details_Label.Name = "OrderFS_Details_Label";
            this.OrderFS_Details_Label.Size = new System.Drawing.Size(119, 22);
            this.OrderFS_Details_Label.TabIndex = 139;
            this.OrderFS_Details_Label.Text = ":תיאור ההזמנה";
            // 
            // Order_Date_label
            // 
            this.Order_Date_label.AutoSize = true;
            this.Order_Date_label.BackColor = System.Drawing.Color.Transparent;
            this.Order_Date_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Order_Date_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Date_label.Location = new System.Drawing.Point(431, 172);
            this.Order_Date_label.Name = "Order_Date_label";
            this.Order_Date_label.Size = new System.Drawing.Size(112, 22);
            this.Order_Date_label.TabIndex = 138;
            this.Order_Date_label.Text = ":תאריך הזמנה";
            // 
            // Recieved_OrderFS_Details_Textbox
            // 
            this.Recieved_OrderFS_Details_Textbox.Location = new System.Drawing.Point(204, 344);
            this.Recieved_OrderFS_Details_Textbox.Multiline = true;
            this.Recieved_OrderFS_Details_Textbox.Name = "Recieved_OrderFS_Details_Textbox";
            this.Recieved_OrderFS_Details_Textbox.Size = new System.Drawing.Size(205, 79);
            this.Recieved_OrderFS_Details_Textbox.TabIndex = 137;
            this.Recieved_OrderFS_Details_Textbox.TextChanged += new System.EventHandler(this.Recieved_OrderFS_Details_Textbox_TextChanged);
            // 
            // OrderReceived_DataGrid
            // 
            this.OrderReceived_DataGrid.AllowUserToAddRows = false;
            this.OrderReceived_DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderReceived_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderReceived_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.Quantity,
            this.QuantityArrived,
            this.Arrived});
            this.OrderReceived_DataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.OrderReceived_DataGrid.Location = new System.Drawing.Point(28, 445);
            this.OrderReceived_DataGrid.Name = "OrderReceived_DataGrid";
            this.OrderReceived_DataGrid.ReadOnly = true;
            this.OrderReceived_DataGrid.Size = new System.Drawing.Size(447, 168);
            this.OrderReceived_DataGrid.TabIndex = 143;
            this.OrderReceived_DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderReceived_DataGrid_CellContentClick);
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity Orderd";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // QuantityArrived
            // 
            this.QuantityArrived.HeaderText = "Fix Quantity Arrived";
            this.QuantityArrived.Name = "QuantityArrived";
            this.QuantityArrived.ReadOnly = true;
            // 
            // Arrived
            // 
            this.Arrived.HeaderText = "Arrived";
            this.Arrived.Name = "Arrived";
            this.Arrived.ReadOnly = true;
            this.Arrived.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Arrived.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Recieved_DefectivePercantage_Textbox
            // 
            this.Recieved_DefectivePercantage_Textbox.Location = new System.Drawing.Point(166, 661);
            this.Recieved_DefectivePercantage_Textbox.Name = "Recieved_DefectivePercantage_Textbox";
            this.Recieved_DefectivePercantage_Textbox.Size = new System.Drawing.Size(200, 20);
            this.Recieved_DefectivePercantage_Textbox.TabIndex = 144;
            this.Recieved_DefectivePercantage_Textbox.TextChanged += new System.EventHandler(this.Recieved_DefectivePercantage_Textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 661);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 145;
            this.label1.Text = ":מספר פגומים";
            // 
            // Recieved_Input_Product
            // 
            this.Recieved_Input_Product.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Recieved_Input_Product.BackColor = System.Drawing.Color.Snow;
            this.Recieved_Input_Product.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Recieved_Input_Product.BackgroundImage")));
            this.Recieved_Input_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Recieved_Input_Product.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recieved_Input_Product.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Recieved_Input_Product.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Recieved_Input_Product.Location = new System.Drawing.Point(28, 631);
            this.Recieved_Input_Product.Name = "Recieved_Input_Product";
            this.Recieved_Input_Product.Size = new System.Drawing.Size(119, 50);
            this.Recieved_Input_Product.TabIndex = 146;
            this.Recieved_Input_Product.Text = "הזן";
            this.Recieved_Input_Product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Recieved_Input_Product.UseVisualStyleBackColor = true;
            this.Recieved_Input_Product.Click += new System.EventHandler(this.Recieved_Input_Product_Click);
            // 
            // Finished_Received_Buton
            // 
            this.Finished_Received_Buton.BackColor = System.Drawing.Color.Transparent;
            this.Finished_Received_Buton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Finished_Received_Buton.BackgroundImage")));
            this.Finished_Received_Buton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Finished_Received_Buton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finished_Received_Buton.Location = new System.Drawing.Point(166, 704);
            this.Finished_Received_Buton.Name = "Finished_Received_Buton";
            this.Finished_Received_Buton.Size = new System.Drawing.Size(200, 46);
            this.Finished_Received_Buton.TabIndex = 147;
            this.Finished_Received_Buton.Text = "סיום";
            this.Finished_Received_Buton.UseVisualStyleBackColor = false;
            this.Finished_Received_Buton.Click += new System.EventHandler(this.Finished_Received_Buton_Click);
            // 
            // Receive_Date_dateTimePicker
            // 
            this.Receive_Date_dateTimePicker.Location = new System.Drawing.Point(203, 216);
            this.Receive_Date_dateTimePicker.Name = "Receive_Date_dateTimePicker";
            this.Receive_Date_dateTimePicker.Size = new System.Drawing.Size(206, 20);
            this.Receive_Date_dateTimePicker.TabIndex = 149;
            this.Receive_Date_dateTimePicker.ValueChanged += new System.EventHandler(this.Receive_Date_dateTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 148;
            this.label2.Text = ":תאריך קבלה";
            // 
            // Received_Order_Status_label_comboBox
            // 
            this.Received_Order_Status_label_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Received_Order_Status_label_comboBox.FormattingEnabled = true;
            this.Received_Order_Status_label_comboBox.Location = new System.Drawing.Point(49, 261);
            this.Received_Order_Status_label_comboBox.Name = "Received_Order_Status_label_comboBox";
            this.Received_Order_Status_label_comboBox.Size = new System.Drawing.Size(361, 21);
            this.Received_Order_Status_label_comboBox.TabIndex = 150;
            this.Received_Order_Status_label_comboBox.SelectedIndexChanged += new System.EventHandler(this.Received_Order_Status_label_comboBox_SelectedIndexChanged);
            // 
            // Received_IntactnessStatu_ComboBox
            // 
            this.Received_IntactnessStatu_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Received_IntactnessStatu_ComboBox.FormattingEnabled = true;
            this.Received_IntactnessStatu_ComboBox.Location = new System.Drawing.Point(49, 299);
            this.Received_IntactnessStatu_ComboBox.Name = "Received_IntactnessStatu_ComboBox";
            this.Received_IntactnessStatu_ComboBox.Size = new System.Drawing.Size(361, 21);
            this.Received_IntactnessStatu_ComboBox.TabIndex = 151;
            this.Received_IntactnessStatu_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Received_IntactnessStatu_ComboBox_SelectedIndexChanged);
            // 
            // Received_Order_Status_label
            // 
            this.Received_Order_Status_label.AutoSize = true;
            this.Received_Order_Status_label.BackColor = System.Drawing.Color.Transparent;
            this.Received_Order_Status_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Received_Order_Status_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Received_Order_Status_label.Location = new System.Drawing.Point(430, 260);
            this.Received_Order_Status_label.Name = "Received_Order_Status_label";
            this.Received_Order_Status_label.Size = new System.Drawing.Size(116, 22);
            this.Received_Order_Status_label.TabIndex = 152;
            this.Received_Order_Status_label.Text = ":סטטוס הזמנה";
            // 
            // Received_IntactnessStatu_label
            // 
            this.Received_IntactnessStatu_label.AutoSize = true;
            this.Received_IntactnessStatu_label.BackColor = System.Drawing.Color.Transparent;
            this.Received_IntactnessStatu_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Received_IntactnessStatu_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Received_IntactnessStatu_label.Location = new System.Drawing.Point(432, 296);
            this.Received_IntactnessStatu_label.Name = "Received_IntactnessStatu_label";
            this.Received_IntactnessStatu_label.Size = new System.Drawing.Size(117, 22);
            this.Received_IntactnessStatu_label.TabIndex = 153;
            this.Received_IntactnessStatu_label.Text = ":תקינות הזמנה";
            // 
            // Received_Show_Button
            // 
            this.Received_Show_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Received_Show_Button.BackColor = System.Drawing.Color.Snow;
            this.Received_Show_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Received_Show_Button.BackgroundImage")));
            this.Received_Show_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Received_Show_Button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Received_Show_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Received_Show_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Received_Show_Button.Location = new System.Drawing.Point(91, 131);
            this.Received_Show_Button.Name = "Received_Show_Button";
            this.Received_Show_Button.Size = new System.Drawing.Size(94, 61);
            this.Received_Show_Button.TabIndex = 154;
            this.Received_Show_Button.Text = "הצג";
            this.Received_Show_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Received_Show_Button.UseVisualStyleBackColor = true;
            this.Received_Show_Button.Click += new System.EventHandler(this.Received_Show_Button_Click);
            // 
            // Back_ToCrud_Button
            // 
            this.Back_ToCrud_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_ToCrud_Button.BackgroundImage")));
            this.Back_ToCrud_Button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_ToCrud_Button.Location = new System.Drawing.Point(511, 686);
            this.Back_ToCrud_Button.Name = "Back_ToCrud_Button";
            this.Back_ToCrud_Button.Size = new System.Drawing.Size(75, 60);
            this.Back_ToCrud_Button.TabIndex = 155;
            this.Back_ToCrud_Button.Text = "חזור";
            this.Back_ToCrud_Button.UseVisualStyleBackColor = true;
            this.Back_ToCrud_Button.Click += new System.EventHandler(this.Back_ToCrud_Button_Click);
            // 
            // ReceivedFromSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_27.Properties.Resources.רקע_לטופס;
            this.ClientSize = new System.Drawing.Size(598, 845);
            this.Controls.Add(this.Back_ToCrud_Button);
            this.Controls.Add(this.Received_Show_Button);
            this.Controls.Add(this.Received_IntactnessStatu_label);
            this.Controls.Add(this.Received_Order_Status_label);
            this.Controls.Add(this.Received_IntactnessStatu_ComboBox);
            this.Controls.Add(this.Received_Order_Status_label_comboBox);
            this.Controls.Add(this.Receive_Date_dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Finished_Received_Buton);
            this.Controls.Add(this.Recieved_Input_Product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Recieved_DefectivePercantage_Textbox);
            this.Controls.Add(this.OrderReceived_DataGrid);
            this.Controls.Add(this.Recieve_dorderFromSupplier_datePicker);
            this.Controls.Add(this.Supplier_ID_Label);
            this.Controls.Add(this.Supplier_ID_TextBox);
            this.Controls.Add(this.OrderFS_Details_Label);
            this.Controls.Add(this.Order_Date_label);
            this.Controls.Add(this.Recieved_OrderFS_Details_Textbox);
            this.Controls.Add(this.quanity_label);
            this.Controls.Add(this.Recieved_quanity_TextBox);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.Add_New_Product_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceivedFromSupplier";
            this.Text = "ReceivedFromSupplier";
            this.Load += new System.EventHandler(this.ReceivedFromSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderReceived_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quanity_label;
        private System.Windows.Forms.TextBox Recieved_quanity_TextBox;
        private System.Windows.Forms.Button Back_To_Home_Page;
        private System.Windows.Forms.Label Add_New_Product_Label;
        private System.Windows.Forms.DateTimePicker Recieve_dorderFromSupplier_datePicker;
        private System.Windows.Forms.Label Supplier_ID_Label;
        private System.Windows.Forms.TextBox Supplier_ID_TextBox;
        private System.Windows.Forms.Label OrderFS_Details_Label;
        private System.Windows.Forms.Label Order_Date_label;
        private System.Windows.Forms.TextBox Recieved_OrderFS_Details_Textbox;
        private System.Windows.Forms.DataGridView OrderReceived_DataGrid;
        private System.Windows.Forms.TextBox Recieved_DefectivePercantage_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Recieved_Input_Product;
        private System.Windows.Forms.Button Finished_Received_Buton;
        private System.Windows.Forms.DateTimePicker Receive_Date_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Received_Order_Status_label_comboBox;
        private System.Windows.Forms.ComboBox Received_IntactnessStatu_ComboBox;
        private System.Windows.Forms.Label Received_Order_Status_label;
        private System.Windows.Forms.Label Received_IntactnessStatu_label;
        private System.Windows.Forms.Button Received_Show_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityArrived;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Arrived;
        private System.Windows.Forms.Button Back_ToCrud_Button;
    }
}