namespace Group_27
{
    partial class Crud_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crud_Product));
            this.Show_AllProduct_button = new System.Windows.Forms.Button();
            this.Product_Managment_CRUD = new System.Windows.Forms.Label();
            this.AddNew_Product_button = new System.Windows.Forms.Button();
            this.Show_Product_button = new System.Windows.Forms.Button();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Show_AllProduct_button
            // 
            this.Show_AllProduct_button.BackColor = System.Drawing.Color.Transparent;
            this.Show_AllProduct_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Show_AllProduct_button.BackgroundImage")));
            this.Show_AllProduct_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_AllProduct_button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_AllProduct_button.Location = new System.Drawing.Point(207, 216);
            this.Show_AllProduct_button.Name = "Show_AllProduct_button";
            this.Show_AllProduct_button.Size = new System.Drawing.Size(160, 160);
            this.Show_AllProduct_button.TabIndex = 58;
            this.Show_AllProduct_button.Text = "הצגת מוצרים";
            this.Show_AllProduct_button.UseVisualStyleBackColor = false;
            this.Show_AllProduct_button.Click += new System.EventHandler(this.Show_AllProduct_button_Click);
            // 
            // Product_Managment_CRUD
            // 
            this.Product_Managment_CRUD.AutoSize = true;
            this.Product_Managment_CRUD.BackColor = System.Drawing.Color.Transparent;
            this.Product_Managment_CRUD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Product_Managment_CRUD.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Managment_CRUD.Location = new System.Drawing.Point(124, 89);
            this.Product_Managment_CRUD.Name = "Product_Managment_CRUD";
            this.Product_Managment_CRUD.Size = new System.Drawing.Size(284, 66);
            this.Product_Managment_CRUD.TabIndex = 57;
            this.Product_Managment_CRUD.Text = "ניהול מוצרים";
            // 
            // AddNew_Product_button
            // 
            this.AddNew_Product_button.BackColor = System.Drawing.Color.Transparent;
            this.AddNew_Product_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddNew_Product_button.BackgroundImage")));
            this.AddNew_Product_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddNew_Product_button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNew_Product_button.Location = new System.Drawing.Point(27, 216);
            this.AddNew_Product_button.Name = "AddNew_Product_button";
            this.AddNew_Product_button.Size = new System.Drawing.Size(160, 160);
            this.AddNew_Product_button.TabIndex = 56;
            this.AddNew_Product_button.Text = "הוספת מוצר חדש";
            this.AddNew_Product_button.UseVisualStyleBackColor = false;
            this.AddNew_Product_button.Click += new System.EventHandler(this.AddNew_Product_button_Click);
            // 
            // Show_Product_button
            // 
            this.Show_Product_button.BackColor = System.Drawing.Color.Transparent;
            this.Show_Product_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Show_Product_button.BackgroundImage")));
            this.Show_Product_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_Product_button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Product_button.Location = new System.Drawing.Point(394, 216);
            this.Show_Product_button.Name = "Show_Product_button";
            this.Show_Product_button.Size = new System.Drawing.Size(160, 160);
            this.Show_Product_button.TabIndex = 55;
            this.Show_Product_button.Text = "פרטי מוצר";
            this.Show_Product_button.UseVisualStyleBackColor = false;
            this.Show_Product_button.Click += new System.EventHandler(this.Show_Product_button_Click);
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(503, 754);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 60;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // Crud_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(590, 841);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.Show_AllProduct_button);
            this.Controls.Add(this.Product_Managment_CRUD);
            this.Controls.Add(this.AddNew_Product_button);
            this.Controls.Add(this.Show_Product_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crud_Product";
            this.Text = "Crud_Product";
            this.Load += new System.EventHandler(this.Crud_Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Show_AllProduct_button;
        private System.Windows.Forms.Label Product_Managment_CRUD;
        private System.Windows.Forms.Button AddNew_Product_button;
        private System.Windows.Forms.Button Show_Product_button;
        private System.Windows.Forms.Button Back_To_Home_Page;
    }
}