namespace Group_27
{
    partial class HomePageProduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageProduction));
            this.Supplier_Managment_CRUD = new System.Windows.Forms.Label();
            this.ProductProcess_Mange_Button = new System.Windows.Forms.Button();
            this.Show_Order_Button = new System.Windows.Forms.Button();
            this.Show_Product_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogOut_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Supplier_Managment_CRUD
            // 
            this.Supplier_Managment_CRUD.AutoSize = true;
            this.Supplier_Managment_CRUD.BackColor = System.Drawing.Color.Transparent;
            this.Supplier_Managment_CRUD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Supplier_Managment_CRUD.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_Managment_CRUD.Location = new System.Drawing.Point(196, 67);
            this.Supplier_Managment_CRUD.Name = "Supplier_Managment_CRUD";
            this.Supplier_Managment_CRUD.Size = new System.Drawing.Size(197, 66);
            this.Supplier_Managment_CRUD.TabIndex = 131;
            this.Supplier_Managment_CRUD.Text = "דף הבית";
            // 
            // ProductProcess_Mange_Button
            // 
            this.ProductProcess_Mange_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProductProcess_Mange_Button.BackgroundImage")));
            this.ProductProcess_Mange_Button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductProcess_Mange_Button.Location = new System.Drawing.Point(17, 264);
            this.ProductProcess_Mange_Button.Name = "ProductProcess_Mange_Button";
            this.ProductProcess_Mange_Button.Size = new System.Drawing.Size(160, 160);
            this.ProductProcess_Mange_Button.TabIndex = 134;
            this.ProductProcess_Mange_Button.Text = "ניהול תהליכי ייצור";
            this.ProductProcess_Mange_Button.UseVisualStyleBackColor = true;
            this.ProductProcess_Mange_Button.Click += new System.EventHandler(this.ProductProcess_Mange_Button_Click);
            // 
            // Show_Order_Button
            // 
            this.Show_Order_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Show_Order_Button.BackgroundImage")));
            this.Show_Order_Button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Order_Button.Location = new System.Drawing.Point(210, 264);
            this.Show_Order_Button.Name = "Show_Order_Button";
            this.Show_Order_Button.Size = new System.Drawing.Size(160, 160);
            this.Show_Order_Button.TabIndex = 133;
            this.Show_Order_Button.Text = "צפייה בהזמנות";
            this.Show_Order_Button.UseVisualStyleBackColor = true;
            this.Show_Order_Button.Click += new System.EventHandler(this.Show_Order_Button_Click);
            // 
            // Show_Product_Button
            // 
            this.Show_Product_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Show_Product_Button.BackgroundImage")));
            this.Show_Product_Button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Product_Button.Location = new System.Drawing.Point(405, 264);
            this.Show_Product_Button.Name = "Show_Product_Button";
            this.Show_Product_Button.Size = new System.Drawing.Size(160, 160);
            this.Show_Product_Button.TabIndex = 132;
            this.Show_Product_Button.Text = "צפייה במוצרים";
            this.Show_Product_Button.UseVisualStyleBackColor = true;
            this.Show_Product_Button.Click += new System.EventHandler(this.Show_Product_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 39);
            this.label1.TabIndex = 136;
            this.label1.Text = "ברוך הבא עובד ייצור";
            // 
            // LogOut_Button
            // 
            this.LogOut_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOut_Button.BackgroundImage")));
            this.LogOut_Button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_Button.Location = new System.Drawing.Point(210, 591);
            this.LogOut_Button.Name = "LogOut_Button";
            this.LogOut_Button.Size = new System.Drawing.Size(160, 82);
            this.LogOut_Button.TabIndex = 137;
            this.LogOut_Button.Text = "התנתק";
            this.LogOut_Button.UseVisualStyleBackColor = true;
            this.LogOut_Button.Click += new System.EventHandler(this.LogOut_Button_Click);
            // 
            // HomePageProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_27.Properties.Resources.רקע_לטופס;
            this.ClientSize = new System.Drawing.Size(595, 849);
            this.Controls.Add(this.LogOut_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductProcess_Mange_Button);
            this.Controls.Add(this.Show_Order_Button);
            this.Controls.Add(this.Show_Product_Button);
            this.Controls.Add(this.Supplier_Managment_CRUD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePageProduction";
            this.Text = "HomePageProduction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Supplier_Managment_CRUD;
        private System.Windows.Forms.Button ProductProcess_Mange_Button;
        private System.Windows.Forms.Button Show_Order_Button;
        private System.Windows.Forms.Button Show_Product_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOut_Button;
    }
}