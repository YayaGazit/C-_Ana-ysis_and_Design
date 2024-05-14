namespace Group_27
{
    partial class Add_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Order));
            this.Add_Order_Priority_ComboBox = new System.Windows.Forms.ComboBox();
            this.Add_Order_Status_ComboBox = new System.Windows.Forms.ComboBox();
            this.DeadLine_Add_Order_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.DeadLine_Add_Order_Label = new System.Windows.Forms.Label();
            this.Date_receive_add_Order_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.add_Date_receive_Order_Label = new System.Windows.Forms.Label();
            this.AddOrder_Label = new System.Windows.Forms.Label();
            this.Add_Order_BackToManagment_Button = new System.Windows.Forms.Button();
            this.Add_Order_Button = new System.Windows.Forms.Button();
            this.Add_Order_StartPreperation_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.Add_Order_Profit_label = new System.Windows.Forms.Label();
            this.Add_Order_StartPreperation_Label = new System.Windows.Forms.Label();
            this.Add_Order_Priority_Label = new System.Windows.Forms.Label();
            this.Add_Order_Status_Label = new System.Windows.Forms.Label();
            this.Add_Order_requierments_Label = new System.Windows.Forms.Label();
            this.Order_add_ID = new System.Windows.Forms.Label();
            this.Add_Order_Profit_TextBox = new System.Windows.Forms.TextBox();
            this.Add_Order_requirements_Textbox = new System.Windows.Forms.TextBox();
            this.Order_ID_Add_TextBox = new System.Windows.Forms.TextBox();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            this.Customer_Order_Label = new System.Windows.Forms.Label();
            this.Customer_addOrder_TextBox = new System.Windows.Forms.TextBox();
            this.Order_Details_Label = new System.Windows.Forms.Label();
            this.Order_Products_Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add_Order_Priority_ComboBox
            // 
            this.Add_Order_Priority_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Add_Order_Priority_ComboBox.FormattingEnabled = true;
            this.Add_Order_Priority_ComboBox.Location = new System.Drawing.Point(178, 435);
            this.Add_Order_Priority_ComboBox.Name = "Add_Order_Priority_ComboBox";
            this.Add_Order_Priority_ComboBox.Size = new System.Drawing.Size(202, 21);
            this.Add_Order_Priority_ComboBox.TabIndex = 109;
            this.Add_Order_Priority_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Add_Order_Priority_ComboBox_SelectedIndexChanged);
            // 
            // Add_Order_Status_ComboBox
            // 
            this.Add_Order_Status_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Add_Order_Status_ComboBox.FormattingEnabled = true;
            this.Add_Order_Status_ComboBox.Location = new System.Drawing.Point(178, 391);
            this.Add_Order_Status_ComboBox.Name = "Add_Order_Status_ComboBox";
            this.Add_Order_Status_ComboBox.Size = new System.Drawing.Size(202, 21);
            this.Add_Order_Status_ComboBox.TabIndex = 108;
            this.Add_Order_Status_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Add_Order_Status_ComboBox_SelectedIndexChanged);
            // 
            // DeadLine_Add_Order_DatePicker
            // 
            this.DeadLine_Add_Order_DatePicker.Location = new System.Drawing.Point(177, 250);
            this.DeadLine_Add_Order_DatePicker.Name = "DeadLine_Add_Order_DatePicker";
            this.DeadLine_Add_Order_DatePicker.Size = new System.Drawing.Size(203, 20);
            this.DeadLine_Add_Order_DatePicker.TabIndex = 107;
            this.DeadLine_Add_Order_DatePicker.ValueChanged += new System.EventHandler(this.DeadLine_Add_Order_DatePicker_ValueChanged);
            // 
            // DeadLine_Add_Order_Label
            // 
            this.DeadLine_Add_Order_Label.AutoSize = true;
            this.DeadLine_Add_Order_Label.BackColor = System.Drawing.Color.Transparent;
            this.DeadLine_Add_Order_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeadLine_Add_Order_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadLine_Add_Order_Label.Location = new System.Drawing.Point(410, 253);
            this.DeadLine_Add_Order_Label.Name = "DeadLine_Add_Order_Label";
            this.DeadLine_Add_Order_Label.Size = new System.Drawing.Size(123, 22);
            this.DeadLine_Add_Order_Label.TabIndex = 106;
            this.DeadLine_Add_Order_Label.Text = ":תאריך אספקה";
            // 
            // Date_receive_add_Order_DatePicker
            // 
            this.Date_receive_add_Order_DatePicker.Location = new System.Drawing.Point(177, 193);
            this.Date_receive_add_Order_DatePicker.Name = "Date_receive_add_Order_DatePicker";
            this.Date_receive_add_Order_DatePicker.Size = new System.Drawing.Size(203, 20);
            this.Date_receive_add_Order_DatePicker.TabIndex = 105;
            this.Date_receive_add_Order_DatePicker.ValueChanged += new System.EventHandler(this.Date_receive_add_Order_DatePicker_ValueChanged);
            // 
            // add_Date_receive_Order_Label
            // 
            this.add_Date_receive_Order_Label.AutoSize = true;
            this.add_Date_receive_Order_Label.BackColor = System.Drawing.Color.Transparent;
            this.add_Date_receive_Order_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_Date_receive_Order_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Date_receive_Order_Label.Location = new System.Drawing.Point(410, 196);
            this.add_Date_receive_Order_Label.Name = "add_Date_receive_Order_Label";
            this.add_Date_receive_Order_Label.Size = new System.Drawing.Size(158, 22);
            this.add_Date_receive_Order_Label.TabIndex = 104;
            this.add_Date_receive_Order_Label.Text = ":תאריך קבלת הזמנה";
            // 
            // AddOrder_Label
            // 
            this.AddOrder_Label.AutoSize = true;
            this.AddOrder_Label.BackColor = System.Drawing.Color.Transparent;
            this.AddOrder_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddOrder_Label.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrder_Label.Location = new System.Drawing.Point(85, 20);
            this.AddOrder_Label.Name = "AddOrder_Label";
            this.AddOrder_Label.Size = new System.Drawing.Size(412, 66);
            this.AddOrder_Label.TabIndex = 102;
            this.AddOrder_Label.Text = "יצירת הזמנה חדשה";
            // 
            // Add_Order_BackToManagment_Button
            // 
            this.Add_Order_BackToManagment_Button.BackColor = System.Drawing.Color.Transparent;
            this.Add_Order_BackToManagment_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_Order_BackToManagment_Button.BackgroundImage")));
            this.Add_Order_BackToManagment_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Add_Order_BackToManagment_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Add_Order_BackToManagment_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Add_Order_BackToManagment_Button.FlatAppearance.BorderSize = 50;
            this.Add_Order_BackToManagment_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Order_BackToManagment_Button.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Order_BackToManagment_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add_Order_BackToManagment_Button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Add_Order_BackToManagment_Button.Location = new System.Drawing.Point(501, 684);
            this.Add_Order_BackToManagment_Button.Name = "Add_Order_BackToManagment_Button";
            this.Add_Order_BackToManagment_Button.Size = new System.Drawing.Size(75, 51);
            this.Add_Order_BackToManagment_Button.TabIndex = 101;
            this.Add_Order_BackToManagment_Button.Text = "חזור";
            this.Add_Order_BackToManagment_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add_Order_BackToManagment_Button.UseVisualStyleBackColor = false;
            this.Add_Order_BackToManagment_Button.Click += new System.EventHandler(this.Add_Order_BackToManagment_Button_Click);
            // 
            // Add_Order_Button
            // 
            this.Add_Order_Button.BackColor = System.Drawing.Color.Transparent;
            this.Add_Order_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_Order_Button.BackgroundImage")));
            this.Add_Order_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_Order_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Add_Order_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Add_Order_Button.FlatAppearance.BorderSize = 10;
            this.Add_Order_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Order_Button.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Order_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add_Order_Button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Add_Order_Button.Location = new System.Drawing.Point(180, 607);
            this.Add_Order_Button.Name = "Add_Order_Button";
            this.Add_Order_Button.Size = new System.Drawing.Size(197, 51);
            this.Add_Order_Button.TabIndex = 96;
            this.Add_Order_Button.Text = "יצירת הזמנה";
            this.Add_Order_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add_Order_Button.UseVisualStyleBackColor = false;
            this.Add_Order_Button.Click += new System.EventHandler(this.Add_Order_Button_Click);
            // 
            // Add_Order_StartPreperation_DatePicker
            // 
            this.Add_Order_StartPreperation_DatePicker.Location = new System.Drawing.Point(177, 525);
            this.Add_Order_StartPreperation_DatePicker.Name = "Add_Order_StartPreperation_DatePicker";
            this.Add_Order_StartPreperation_DatePicker.Size = new System.Drawing.Size(200, 20);
            this.Add_Order_StartPreperation_DatePicker.TabIndex = 95;
            this.Add_Order_StartPreperation_DatePicker.ValueChanged += new System.EventHandler(this.Add_Order_StartPreperation_DatePicker_ValueChanged);
            // 
            // Add_Order_Profit_label
            // 
            this.Add_Order_Profit_label.AutoSize = true;
            this.Add_Order_Profit_label.BackColor = System.Drawing.Color.Transparent;
            this.Add_Order_Profit_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Order_Profit_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Order_Profit_label.Location = new System.Drawing.Point(411, 569);
            this.Add_Order_Profit_label.Name = "Add_Order_Profit_label";
            this.Add_Order_Profit_label.Size = new System.Drawing.Size(111, 22);
            this.Add_Order_Profit_label.TabIndex = 94;
            this.Add_Order_Profit_label.Text = ":סכום העסקה";
            // 
            // Add_Order_StartPreperation_Label
            // 
            this.Add_Order_StartPreperation_Label.AutoSize = true;
            this.Add_Order_StartPreperation_Label.BackColor = System.Drawing.Color.Transparent;
            this.Add_Order_StartPreperation_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Order_StartPreperation_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Order_StartPreperation_Label.Location = new System.Drawing.Point(410, 525);
            this.Add_Order_StartPreperation_Label.Name = "Add_Order_StartPreperation_Label";
            this.Add_Order_StartPreperation_Label.Size = new System.Drawing.Size(164, 22);
            this.Add_Order_StartPreperation_Label.TabIndex = 93;
            this.Add_Order_StartPreperation_Label.Text = ":תאריך תחילת עבודה";
            // 
            // Add_Order_Priority_Label
            // 
            this.Add_Order_Priority_Label.AutoSize = true;
            this.Add_Order_Priority_Label.BackColor = System.Drawing.Color.Transparent;
            this.Add_Order_Priority_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Order_Priority_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Order_Priority_Label.Location = new System.Drawing.Point(410, 433);
            this.Add_Order_Priority_Label.Name = "Add_Order_Priority_Label";
            this.Add_Order_Priority_Label.Size = new System.Drawing.Size(67, 22);
            this.Add_Order_Priority_Label.TabIndex = 92;
            this.Add_Order_Priority_Label.Text = ":עדיפות";
            // 
            // Add_Order_Status_Label
            // 
            this.Add_Order_Status_Label.AutoSize = true;
            this.Add_Order_Status_Label.BackColor = System.Drawing.Color.Transparent;
            this.Add_Order_Status_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Order_Status_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Order_Status_Label.Location = new System.Drawing.Point(410, 389);
            this.Add_Order_Status_Label.Name = "Add_Order_Status_Label";
            this.Add_Order_Status_Label.Size = new System.Drawing.Size(66, 22);
            this.Add_Order_Status_Label.TabIndex = 91;
            this.Add_Order_Status_Label.Text = ":סטטוס";
            // 
            // Add_Order_requierments_Label
            // 
            this.Add_Order_requierments_Label.AutoSize = true;
            this.Add_Order_requierments_Label.BackColor = System.Drawing.Color.Transparent;
            this.Add_Order_requierments_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Order_requierments_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Order_requierments_Label.Location = new System.Drawing.Point(409, 300);
            this.Add_Order_requierments_Label.Name = "Add_Order_requierments_Label";
            this.Add_Order_requierments_Label.Size = new System.Drawing.Size(68, 22);
            this.Add_Order_requierments_Label.TabIndex = 90;
            this.Add_Order_requierments_Label.Text = ":דרישות";
            // 
            // Order_add_ID
            // 
            this.Order_add_ID.AutoSize = true;
            this.Order_add_ID.BackColor = System.Drawing.Color.Transparent;
            this.Order_add_ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Order_add_ID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_add_ID.Location = new System.Drawing.Point(409, 140);
            this.Order_add_ID.Name = "Order_add_ID";
            this.Order_add_ID.Size = new System.Drawing.Size(104, 22);
            this.Order_add_ID.TabIndex = 89;
            this.Order_add_ID.Text = ":מזהה הזמנה";
            // 
            // Add_Order_Profit_TextBox
            // 
            this.Add_Order_Profit_TextBox.Location = new System.Drawing.Point(178, 569);
            this.Add_Order_Profit_TextBox.Name = "Add_Order_Profit_TextBox";
            this.Add_Order_Profit_TextBox.Size = new System.Drawing.Size(200, 20);
            this.Add_Order_Profit_TextBox.TabIndex = 88;
            this.Add_Order_Profit_TextBox.TextChanged += new System.EventHandler(this.Add_Order_Profit_TextBox_TextChanged);
            // 
            // Add_Order_requirements_Textbox
            // 
            this.Add_Order_requirements_Textbox.Location = new System.Drawing.Point(177, 302);
            this.Add_Order_requirements_Textbox.Name = "Add_Order_requirements_Textbox";
            this.Add_Order_requirements_Textbox.Size = new System.Drawing.Size(203, 20);
            this.Add_Order_requirements_Textbox.TabIndex = 87;
            this.Add_Order_requirements_Textbox.TextChanged += new System.EventHandler(this.Add_Order_requirements_Textbox_TextChanged);
            // 
            // Order_ID_Add_TextBox
            // 
            this.Order_ID_Add_TextBox.Location = new System.Drawing.Point(176, 140);
            this.Order_ID_Add_TextBox.Name = "Order_ID_Add_TextBox";
            this.Order_ID_Add_TextBox.Size = new System.Drawing.Size(204, 20);
            this.Order_ID_Add_TextBox.TabIndex = 86;
            this.Order_ID_Add_TextBox.TextChanged += new System.EventHandler(this.Order_ID_Add_TextBox_TextChanged);
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(501, 757);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 113;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // Customer_Order_Label
            // 
            this.Customer_Order_Label.AutoSize = true;
            this.Customer_Order_Label.BackColor = System.Drawing.Color.Transparent;
            this.Customer_Order_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Customer_Order_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Order_Label.Location = new System.Drawing.Point(411, 477);
            this.Customer_Order_Label.Name = "Customer_Order_Label";
            this.Customer_Order_Label.Size = new System.Drawing.Size(133, 22);
            this.Customer_Order_Label.TabIndex = 115;
            this.Customer_Order_Label.Text = ":הוזמן על ידי (תז)";
            // 
            // Customer_addOrder_TextBox
            // 
            this.Customer_addOrder_TextBox.Location = new System.Drawing.Point(179, 479);
            this.Customer_addOrder_TextBox.Name = "Customer_addOrder_TextBox";
            this.Customer_addOrder_TextBox.Size = new System.Drawing.Size(200, 20);
            this.Customer_addOrder_TextBox.TabIndex = 114;
            this.Customer_addOrder_TextBox.TextChanged += new System.EventHandler(this.Customer_addOrder_TextBox_TextChanged);
            // 
            // Order_Details_Label
            // 
            this.Order_Details_Label.AutoSize = true;
            this.Order_Details_Label.BackColor = System.Drawing.Color.Transparent;
            this.Order_Details_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Order_Details_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Details_Label.Location = new System.Drawing.Point(410, 345);
            this.Order_Details_Label.Name = "Order_Details_Label";
            this.Order_Details_Label.Size = new System.Drawing.Size(111, 22);
            this.Order_Details_Label.TabIndex = 117;
            this.Order_Details_Label.Text = ":פירוט מוצרים";
            // 
            // Order_Products_Textbox
            // 
            this.Order_Products_Textbox.Location = new System.Drawing.Point(180, 345);
            this.Order_Products_Textbox.Name = "Order_Products_Textbox";
            this.Order_Products_Textbox.Size = new System.Drawing.Size(200, 20);
            this.Order_Products_Textbox.TabIndex = 116;
            this.Order_Products_Textbox.TextChanged += new System.EventHandler(this.Order_Products_Textbox_TextChanged);
            // 
            // Add_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(588, 844);
            this.Controls.Add(this.Order_Details_Label);
            this.Controls.Add(this.Order_Products_Textbox);
            this.Controls.Add(this.Customer_Order_Label);
            this.Controls.Add(this.Customer_addOrder_TextBox);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.Add_Order_Priority_ComboBox);
            this.Controls.Add(this.Add_Order_Status_ComboBox);
            this.Controls.Add(this.DeadLine_Add_Order_DatePicker);
            this.Controls.Add(this.DeadLine_Add_Order_Label);
            this.Controls.Add(this.Date_receive_add_Order_DatePicker);
            this.Controls.Add(this.add_Date_receive_Order_Label);
            this.Controls.Add(this.AddOrder_Label);
            this.Controls.Add(this.Add_Order_BackToManagment_Button);
            this.Controls.Add(this.Add_Order_Button);
            this.Controls.Add(this.Add_Order_StartPreperation_DatePicker);
            this.Controls.Add(this.Add_Order_Profit_label);
            this.Controls.Add(this.Add_Order_StartPreperation_Label);
            this.Controls.Add(this.Add_Order_Priority_Label);
            this.Controls.Add(this.Add_Order_Status_Label);
            this.Controls.Add(this.Add_Order_requierments_Label);
            this.Controls.Add(this.Order_add_ID);
            this.Controls.Add(this.Add_Order_Profit_TextBox);
            this.Controls.Add(this.Add_Order_requirements_Textbox);
            this.Controls.Add(this.Order_ID_Add_TextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Order";
            this.Text = "Add_Order";
            this.Load += new System.EventHandler(this.Add_Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Add_Order_Priority_ComboBox;
        private System.Windows.Forms.ComboBox Add_Order_Status_ComboBox;
        private System.Windows.Forms.DateTimePicker DeadLine_Add_Order_DatePicker;
        private System.Windows.Forms.Label DeadLine_Add_Order_Label;
        private System.Windows.Forms.DateTimePicker Date_receive_add_Order_DatePicker;
        private System.Windows.Forms.Label add_Date_receive_Order_Label;
        private System.Windows.Forms.Label AddOrder_Label;
        private System.Windows.Forms.Button Add_Order_BackToManagment_Button;
        private System.Windows.Forms.Button Add_Order_Button;
        private System.Windows.Forms.DateTimePicker Add_Order_StartPreperation_DatePicker;
        private System.Windows.Forms.Label Add_Order_Profit_label;
        private System.Windows.Forms.Label Add_Order_StartPreperation_Label;
        private System.Windows.Forms.Label Add_Order_Priority_Label;
        private System.Windows.Forms.Label Add_Order_Status_Label;
        private System.Windows.Forms.Label Add_Order_requierments_Label;
        private System.Windows.Forms.Label Order_add_ID;
        private System.Windows.Forms.TextBox Add_Order_Profit_TextBox;
        private System.Windows.Forms.TextBox Add_Order_requirements_Textbox;
        private System.Windows.Forms.TextBox Order_ID_Add_TextBox;
        private System.Windows.Forms.Button Back_To_Home_Page;
        private System.Windows.Forms.Label Customer_Order_Label;
        private System.Windows.Forms.TextBox Customer_addOrder_TextBox;
        private System.Windows.Forms.Label Order_Details_Label;
        private System.Windows.Forms.TextBox Order_Products_Textbox;
    }
}