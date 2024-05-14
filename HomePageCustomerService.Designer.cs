namespace Group_27
{
    partial class HomePageCustomerService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageCustomerService));
            this.Supplier_Managment_CRUD = new System.Windows.Forms.Label();
            this.Customers_CRUD = new System.Windows.Forms.Button();
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
            this.Supplier_Managment_CRUD.Location = new System.Drawing.Point(113, 77);
            this.Supplier_Managment_CRUD.Name = "Supplier_Managment_CRUD";
            this.Supplier_Managment_CRUD.Size = new System.Drawing.Size(197, 66);
            this.Supplier_Managment_CRUD.TabIndex = 123;
            this.Supplier_Managment_CRUD.Text = "דף הבית";
            // 
            // Customers_CRUD
            // 
            this.Customers_CRUD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Customers_CRUD.BackgroundImage")));
            this.Customers_CRUD.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers_CRUD.Location = new System.Drawing.Point(133, 259);
            this.Customers_CRUD.Name = "Customers_CRUD";
            this.Customers_CRUD.Size = new System.Drawing.Size(160, 160);
            this.Customers_CRUD.TabIndex = 122;
            this.Customers_CRUD.Text = "ניהול לקוחות";
            this.Customers_CRUD.UseVisualStyleBackColor = true;
            this.Customers_CRUD.Click += new System.EventHandler(this.Customers_CRUD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 39);
            this.label1.TabIndex = 124;
            this.label1.Text = "ברוך הבא שירות לקוחות";
            // 
            // LogOut_Button
            // 
            this.LogOut_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOut_Button.BackgroundImage")));
            this.LogOut_Button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_Button.Location = new System.Drawing.Point(133, 602);
            this.LogOut_Button.Name = "LogOut_Button";
            this.LogOut_Button.Size = new System.Drawing.Size(160, 82);
            this.LogOut_Button.TabIndex = 126;
            this.LogOut_Button.Text = "התנתק";
            this.LogOut_Button.UseVisualStyleBackColor = true;
            this.LogOut_Button.Click += new System.EventHandler(this.LogOut_Button_Click);
            // 
            // HomePageCustomerService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_27.Properties.Resources.רקע_לטופס;
            this.ClientSize = new System.Drawing.Size(442, 846);
            this.Controls.Add(this.LogOut_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Supplier_Managment_CRUD);
            this.Controls.Add(this.Customers_CRUD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePageCustomerService";
            this.Text = "HomePageCustomerService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Supplier_Managment_CRUD;
        private System.Windows.Forms.Button Customers_CRUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOut_Button;
    }
}