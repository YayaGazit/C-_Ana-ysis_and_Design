namespace Group_27
{
    partial class OrderManagment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagment));
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            this.Show_AllOrders_button = new System.Windows.Forms.Button();
            this.Orders_Managment_CRUD = new System.Windows.Forms.Label();
            this.AddNew_Order_button = new System.Windows.Forms.Button();
            this.OrderManagment_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(502, 744);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 64;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // Show_AllOrders_button
            // 
            this.Show_AllOrders_button.BackColor = System.Drawing.Color.Transparent;
            this.Show_AllOrders_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Show_AllOrders_button.BackgroundImage")));
            this.Show_AllOrders_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_AllOrders_button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_AllOrders_button.Location = new System.Drawing.Point(420, 270);
            this.Show_AllOrders_button.Name = "Show_AllOrders_button";
            this.Show_AllOrders_button.Size = new System.Drawing.Size(160, 160);
            this.Show_AllOrders_button.TabIndex = 63;
            this.Show_AllOrders_button.Text = "הצגת הזמנות";
            this.Show_AllOrders_button.UseVisualStyleBackColor = false;
            this.Show_AllOrders_button.Click += new System.EventHandler(this.Show_AllOrders_button_Click);
            // 
            // Orders_Managment_CRUD
            // 
            this.Orders_Managment_CRUD.AutoSize = true;
            this.Orders_Managment_CRUD.BackColor = System.Drawing.Color.Transparent;
            this.Orders_Managment_CRUD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Orders_Managment_CRUD.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orders_Managment_CRUD.Location = new System.Drawing.Point(138, 67);
            this.Orders_Managment_CRUD.Name = "Orders_Managment_CRUD";
            this.Orders_Managment_CRUD.Size = new System.Drawing.Size(284, 66);
            this.Orders_Managment_CRUD.TabIndex = 62;
            this.Orders_Managment_CRUD.Text = "ניהול הזמנות";
            // 
            // AddNew_Order_button
            // 
            this.AddNew_Order_button.BackColor = System.Drawing.Color.Transparent;
            this.AddNew_Order_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddNew_Order_button.BackgroundImage")));
            this.AddNew_Order_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddNew_Order_button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNew_Order_button.Location = new System.Drawing.Point(30, 270);
            this.AddNew_Order_button.Name = "AddNew_Order_button";
            this.AddNew_Order_button.Size = new System.Drawing.Size(160, 160);
            this.AddNew_Order_button.TabIndex = 61;
            this.AddNew_Order_button.Text = "הוספת הזמנה חדשה";
            this.AddNew_Order_button.UseVisualStyleBackColor = false;
            this.AddNew_Order_button.Click += new System.EventHandler(this.AddNew_Order_button_Click);
            // 
            // OrderManagment_button
            // 
            this.OrderManagment_button.BackColor = System.Drawing.Color.Transparent;
            this.OrderManagment_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrderManagment_button.BackgroundImage")));
            this.OrderManagment_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrderManagment_button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderManagment_button.Location = new System.Drawing.Point(226, 270);
            this.OrderManagment_button.Name = "OrderManagment_button";
            this.OrderManagment_button.Size = new System.Drawing.Size(160, 160);
            this.OrderManagment_button.TabIndex = 60;
            this.OrderManagment_button.Text = "פרטי הזמנה";
            this.OrderManagment_button.UseVisualStyleBackColor = false;
            this.OrderManagment_button.Click += new System.EventHandler(this.OrderManagment_button_Click);
            // 
            // OrderManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(596, 832);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.Show_AllOrders_button);
            this.Controls.Add(this.Orders_Managment_CRUD);
            this.Controls.Add(this.AddNew_Order_button);
            this.Controls.Add(this.OrderManagment_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderManagment";
            this.Text = "OrderManagment";
            this.Load += new System.EventHandler(this.OrderManagment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_To_Home_Page;
        private System.Windows.Forms.Button Show_AllOrders_button;
        private System.Windows.Forms.Label Orders_Managment_CRUD;
        private System.Windows.Forms.Button AddNew_Order_button;
        private System.Windows.Forms.Button OrderManagment_button;
    }
}