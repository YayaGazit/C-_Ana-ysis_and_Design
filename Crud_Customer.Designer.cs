namespace Group_27
{
    partial class Crud_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crud_Customer));
            this.Customers_Managment_CRUD = new System.Windows.Forms.Label();
            this.Show_AllCustomers_button = new System.Windows.Forms.Button();
            this.AddNew_Customer_button = new System.Windows.Forms.Button();
            this.Show_Customer_button = new System.Windows.Forms.Button();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customers_Managment_CRUD
            // 
            this.Customers_Managment_CRUD.AutoSize = true;
            this.Customers_Managment_CRUD.BackColor = System.Drawing.Color.Transparent;
            this.Customers_Managment_CRUD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Customers_Managment_CRUD.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers_Managment_CRUD.Location = new System.Drawing.Point(121, 83);
            this.Customers_Managment_CRUD.Name = "Customers_Managment_CRUD";
            this.Customers_Managment_CRUD.Size = new System.Drawing.Size(290, 66);
            this.Customers_Managment_CRUD.TabIndex = 57;
            this.Customers_Managment_CRUD.Text = "ניהול לקוחות";
            // 
            // Show_AllCustomers_button
            // 
            this.Show_AllCustomers_button.BackColor = System.Drawing.Color.Transparent;
            this.Show_AllCustomers_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Show_AllCustomers_button.BackgroundImage")));
            this.Show_AllCustomers_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_AllCustomers_button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_AllCustomers_button.Location = new System.Drawing.Point(205, 260);
            this.Show_AllCustomers_button.Name = "Show_AllCustomers_button";
            this.Show_AllCustomers_button.Size = new System.Drawing.Size(160, 160);
            this.Show_AllCustomers_button.TabIndex = 58;
            this.Show_AllCustomers_button.Text = "הצגת לקוחות";
            this.Show_AllCustomers_button.UseVisualStyleBackColor = false;
            this.Show_AllCustomers_button.Click += new System.EventHandler(this.Show_AllCustomers_button_Click);
            // 
            // AddNew_Customer_button
            // 
            this.AddNew_Customer_button.BackColor = System.Drawing.Color.Transparent;
            this.AddNew_Customer_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddNew_Customer_button.BackgroundImage")));
            this.AddNew_Customer_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddNew_Customer_button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNew_Customer_button.Location = new System.Drawing.Point(27, 260);
            this.AddNew_Customer_button.Name = "AddNew_Customer_button";
            this.AddNew_Customer_button.Size = new System.Drawing.Size(160, 160);
            this.AddNew_Customer_button.TabIndex = 56;
            this.AddNew_Customer_button.Text = "הוספת לקוח חדש";
            this.AddNew_Customer_button.UseVisualStyleBackColor = false;
            this.AddNew_Customer_button.Click += new System.EventHandler(this.AddNew_Customer_button_Click);
            // 
            // Show_Customer_button
            // 
            this.Show_Customer_button.BackColor = System.Drawing.Color.Transparent;
            this.Show_Customer_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Show_Customer_button.BackgroundImage")));
            this.Show_Customer_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_Customer_button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Customer_button.Location = new System.Drawing.Point(384, 260);
            this.Show_Customer_button.Name = "Show_Customer_button";
            this.Show_Customer_button.Size = new System.Drawing.Size(160, 160);
            this.Show_Customer_button.TabIndex = 55;
            this.Show_Customer_button.Text = "פרטי לקוח";
            this.Show_Customer_button.UseVisualStyleBackColor = false;
            this.Show_Customer_button.Click += new System.EventHandler(this.Show_Customer_button_Click);
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(485, 760);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 59;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // Crud_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(572, 847);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.Show_AllCustomers_button);
            this.Controls.Add(this.Customers_Managment_CRUD);
            this.Controls.Add(this.AddNew_Customer_button);
            this.Controls.Add(this.Show_Customer_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crud_Customer";
            this.Text = "Crud_Customer";
            this.Load += new System.EventHandler(this.Crud_Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Show_AllCustomers_button;
        private System.Windows.Forms.Label Customers_Managment_CRUD;
        private System.Windows.Forms.Button AddNew_Customer_button;
        private System.Windows.Forms.Button Show_Customer_button;
        private System.Windows.Forms.Button Back_To_Home_Page;
    }
}