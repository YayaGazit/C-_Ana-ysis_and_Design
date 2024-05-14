namespace Group_27
{
    partial class HomePageSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageSales));
            this.Add_Order_Button = new System.Windows.Forms.Button();
            this.Customers_CRUD_Button = new System.Windows.Forms.Button();
            this.Supplier_Managment_CRUD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogOut_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Order_Button
            // 
            this.Add_Order_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_Order_Button.BackgroundImage")));
            this.Add_Order_Button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Order_Button.Location = new System.Drawing.Point(37, 306);
            this.Add_Order_Button.Name = "Add_Order_Button";
            this.Add_Order_Button.Size = new System.Drawing.Size(160, 160);
            this.Add_Order_Button.TabIndex = 131;
            this.Add_Order_Button.Text = "ניהול הזמנות";
            this.Add_Order_Button.UseVisualStyleBackColor = true;
            this.Add_Order_Button.Click += new System.EventHandler(this.Add_Order_Button_Click);
            // 
            // Customers_CRUD_Button
            // 
            this.Customers_CRUD_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Customers_CRUD_Button.BackgroundImage")));
            this.Customers_CRUD_Button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers_CRUD_Button.Location = new System.Drawing.Point(234, 306);
            this.Customers_CRUD_Button.Name = "Customers_CRUD_Button";
            this.Customers_CRUD_Button.Size = new System.Drawing.Size(160, 160);
            this.Customers_CRUD_Button.TabIndex = 130;
            this.Customers_CRUD_Button.Text = "ניהול לקוחות";
            this.Customers_CRUD_Button.UseVisualStyleBackColor = true;
            this.Customers_CRUD_Button.Click += new System.EventHandler(this.Customers_CRUD_Button_Click);
            // 
            // Supplier_Managment_CRUD
            // 
            this.Supplier_Managment_CRUD.AutoSize = true;
            this.Supplier_Managment_CRUD.BackColor = System.Drawing.Color.Transparent;
            this.Supplier_Managment_CRUD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Supplier_Managment_CRUD.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_Managment_CRUD.Location = new System.Drawing.Point(132, 75);
            this.Supplier_Managment_CRUD.Name = "Supplier_Managment_CRUD";
            this.Supplier_Managment_CRUD.Size = new System.Drawing.Size(197, 66);
            this.Supplier_Managment_CRUD.TabIndex = 132;
            this.Supplier_Managment_CRUD.Text = "דף הבית";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 39);
            this.label1.TabIndex = 137;
            this.label1.Text = "ברוך הבא איש מכירות";
            // 
            // LogOut_Button
            // 
            this.LogOut_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOut_Button.BackgroundImage")));
            this.LogOut_Button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_Button.Location = new System.Drawing.Point(282, 657);
            this.LogOut_Button.Name = "LogOut_Button";
            this.LogOut_Button.Size = new System.Drawing.Size(160, 82);
            this.LogOut_Button.TabIndex = 138;
            this.LogOut_Button.Text = "התנתק";
            this.LogOut_Button.UseVisualStyleBackColor = true;
            this.LogOut_Button.Click += new System.EventHandler(this.LogOut_Button_Click);
            // 
            // HomePageSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_27.Properties.Resources.רקע_לטופס;
            this.ClientSize = new System.Drawing.Size(474, 836);
            this.Controls.Add(this.LogOut_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Supplier_Managment_CRUD);
            this.Controls.Add(this.Add_Order_Button);
            this.Controls.Add(this.Customers_CRUD_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePageSales";
            this.Text = "HomePageSales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Order_Button;
        private System.Windows.Forms.Button Customers_CRUD_Button;
        private System.Windows.Forms.Label Supplier_Managment_CRUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOut_Button;
    }
}