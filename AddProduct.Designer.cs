namespace Group_27
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.Add_New_Product_Label = new System.Windows.Forms.Label();
            this.Product_Descreption_Label = new System.Windows.Forms.Label();
            this.Product_PartNumber_Label = new System.Windows.Forms.Label();
            this.Product_Name_Label = new System.Windows.Forms.Label();
            this.Product_ID_Label = new System.Windows.Forms.Label();
            this.Product_Descreption_Textbox = new System.Windows.Forms.TextBox();
            this.Product_PartNumber_Textbox = new System.Windows.Forms.TextBox();
            this.Product_Price_Textbox = new System.Windows.Forms.TextBox();
            this.Input_Product_Button = new System.Windows.Forms.Button();
            this.Product_ID_Textbox = new System.Windows.Forms.TextBox();
            this.Product_Price_Label = new System.Windows.Forms.Label();
            this.Product_Name_TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            this.SupplierID_Label = new System.Windows.Forms.Label();
            this.SupplierID_TextBox = new System.Windows.Forms.TextBox();
            this.quanity_label = new System.Windows.Forms.Label();
            this.quanity_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add_New_Product_Label
            // 
            this.Add_New_Product_Label.AutoSize = true;
            this.Add_New_Product_Label.BackColor = System.Drawing.Color.Transparent;
            this.Add_New_Product_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Add_New_Product_Label.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_Product_Label.Location = new System.Drawing.Point(97, 40);
            this.Add_New_Product_Label.Name = "Add_New_Product_Label";
            this.Add_New_Product_Label.Size = new System.Drawing.Size(354, 66);
            this.Add_New_Product_Label.TabIndex = 96;
            this.Add_New_Product_Label.Text = "יצירת מוצר חדש";
            // 
            // Product_Descreption_Label
            // 
            this.Product_Descreption_Label.AutoSize = true;
            this.Product_Descreption_Label.BackColor = System.Drawing.Color.Transparent;
            this.Product_Descreption_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Product_Descreption_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Descreption_Label.Location = new System.Drawing.Point(421, 247);
            this.Product_Descreption_Label.Name = "Product_Descreption_Label";
            this.Product_Descreption_Label.Size = new System.Drawing.Size(58, 22);
            this.Product_Descreption_Label.TabIndex = 94;
            this.Product_Descreption_Label.Text = ":תיאור";
            // 
            // Product_PartNumber_Label
            // 
            this.Product_PartNumber_Label.AutoSize = true;
            this.Product_PartNumber_Label.BackColor = System.Drawing.Color.Transparent;
            this.Product_PartNumber_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Product_PartNumber_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_PartNumber_Label.Location = new System.Drawing.Point(418, 302);
            this.Product_PartNumber_Label.Name = "Product_PartNumber_Label";
            this.Product_PartNumber_Label.Size = new System.Drawing.Size(78, 22);
            this.Product_PartNumber_Label.TabIndex = 91;
            this.Product_PartNumber_Label.Text = ":מס\' חלק";
            // 
            // Product_Name_Label
            // 
            this.Product_Name_Label.AutoSize = true;
            this.Product_Name_Label.BackColor = System.Drawing.Color.Transparent;
            this.Product_Name_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Product_Name_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Name_Label.Location = new System.Drawing.Point(421, 202);
            this.Product_Name_Label.Name = "Product_Name_Label";
            this.Product_Name_Label.Size = new System.Drawing.Size(89, 22);
            this.Product_Name_Label.TabIndex = 87;
            this.Product_Name_Label.Text = ":שם המוצר";
            // 
            // Product_ID_Label
            // 
            this.Product_ID_Label.AutoSize = true;
            this.Product_ID_Label.BackColor = System.Drawing.Color.Transparent;
            this.Product_ID_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Product_ID_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_ID_Label.Location = new System.Drawing.Point(421, 151);
            this.Product_ID_Label.Name = "Product_ID_Label";
            this.Product_ID_Label.Size = new System.Drawing.Size(93, 22);
            this.Product_ID_Label.TabIndex = 86;
            this.Product_ID_Label.Text = ":מזהה מוצר";
            // 
            // Product_Descreption_Textbox
            // 
            this.Product_Descreption_Textbox.Location = new System.Drawing.Point(204, 249);
            this.Product_Descreption_Textbox.Name = "Product_Descreption_Textbox";
            this.Product_Descreption_Textbox.Size = new System.Drawing.Size(201, 20);
            this.Product_Descreption_Textbox.TabIndex = 85;
            this.Product_Descreption_Textbox.TextChanged += new System.EventHandler(this.Product_Descreption_Textbox_TextChanged);
            // 
            // Product_PartNumber_Textbox
            // 
            this.Product_PartNumber_Textbox.Location = new System.Drawing.Point(204, 302);
            this.Product_PartNumber_Textbox.Name = "Product_PartNumber_Textbox";
            this.Product_PartNumber_Textbox.Size = new System.Drawing.Size(201, 20);
            this.Product_PartNumber_Textbox.TabIndex = 83;
            this.Product_PartNumber_Textbox.TextChanged += new System.EventHandler(this.Product_PartNumber_Textbox_TextChanged);
            // 
            // Product_Price_Textbox
            // 
            this.Product_Price_Textbox.Location = new System.Drawing.Point(204, 431);
            this.Product_Price_Textbox.Name = "Product_Price_Textbox";
            this.Product_Price_Textbox.Size = new System.Drawing.Size(200, 20);
            this.Product_Price_Textbox.TabIndex = 82;
            this.Product_Price_Textbox.TextChanged += new System.EventHandler(this.Product_Price_Textbox_TextChanged);
            // 
            // Input_Product_Button
            // 
            this.Input_Product_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Input_Product_Button.BackColor = System.Drawing.Color.Snow;
            this.Input_Product_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Input_Product_Button.BackgroundImage")));
            this.Input_Product_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Input_Product_Button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Product_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Input_Product_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Input_Product_Button.Location = new System.Drawing.Point(205, 477);
            this.Input_Product_Button.Name = "Input_Product_Button";
            this.Input_Product_Button.Size = new System.Drawing.Size(200, 55);
            this.Input_Product_Button.TabIndex = 79;
            this.Input_Product_Button.Text = "יצירת מוצר";
            this.Input_Product_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Input_Product_Button.UseVisualStyleBackColor = true;
            this.Input_Product_Button.Click += new System.EventHandler(this.Input_Product_Button_Click);
            // 
            // Product_ID_Textbox
            // 
            this.Product_ID_Textbox.Location = new System.Drawing.Point(204, 154);
            this.Product_ID_Textbox.Name = "Product_ID_Textbox";
            this.Product_ID_Textbox.Size = new System.Drawing.Size(201, 20);
            this.Product_ID_Textbox.TabIndex = 78;
            this.Product_ID_Textbox.TextChanged += new System.EventHandler(this.Product_ID_Textbox_TextChanged);
            // 
            // Product_Price_Label
            // 
            this.Product_Price_Label.AutoSize = true;
            this.Product_Price_Label.BackColor = System.Drawing.Color.Transparent;
            this.Product_Price_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Product_Price_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Price_Label.Location = new System.Drawing.Point(418, 430);
            this.Product_Price_Label.Name = "Product_Price_Label";
            this.Product_Price_Label.Size = new System.Drawing.Size(51, 22);
            this.Product_Price_Label.TabIndex = 100;
            this.Product_Price_Label.Text = ":מחיר";
            // 
            // Product_Name_TextBox
            // 
            this.Product_Name_TextBox.Location = new System.Drawing.Point(204, 202);
            this.Product_Name_TextBox.Name = "Product_Name_TextBox";
            this.Product_Name_TextBox.Size = new System.Drawing.Size(201, 20);
            this.Product_Name_TextBox.TabIndex = 101;
            this.Product_Name_TextBox.TextChanged += new System.EventHandler(this.Product_Name_TextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(495, 688);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 102;
            this.button1.Text = "חזור";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(495, 759);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 112;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // SupplierID_Label
            // 
            this.SupplierID_Label.AutoSize = true;
            this.SupplierID_Label.BackColor = System.Drawing.Color.Transparent;
            this.SupplierID_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SupplierID_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierID_Label.Location = new System.Drawing.Point(418, 388);
            this.SupplierID_Label.Name = "SupplierID_Label";
            this.SupplierID_Label.Size = new System.Drawing.Size(92, 22);
            this.SupplierID_Label.TabIndex = 114;
            this.SupplierID_Label.Text = ":מזהה ספק";
            // 
            // SupplierID_TextBox
            // 
            this.SupplierID_TextBox.Location = new System.Drawing.Point(205, 388);
            this.SupplierID_TextBox.Name = "SupplierID_TextBox";
            this.SupplierID_TextBox.Size = new System.Drawing.Size(200, 20);
            this.SupplierID_TextBox.TabIndex = 113;
            this.SupplierID_TextBox.TextChanged += new System.EventHandler(this.SupplierID_TextBox_TextChanged);
            // 
            // quanity_label
            // 
            this.quanity_label.AutoSize = true;
            this.quanity_label.BackColor = System.Drawing.Color.Transparent;
            this.quanity_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quanity_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanity_label.Location = new System.Drawing.Point(418, 346);
            this.quanity_label.Name = "quanity_label";
            this.quanity_label.Size = new System.Drawing.Size(52, 22);
            this.quanity_label.TabIndex = 116;
            this.quanity_label.Text = ":כמות";
            // 
            // quanity_TextBox
            // 
            this.quanity_TextBox.Location = new System.Drawing.Point(205, 346);
            this.quanity_TextBox.Name = "quanity_TextBox";
            this.quanity_TextBox.Size = new System.Drawing.Size(200, 20);
            this.quanity_TextBox.TabIndex = 115;
            this.quanity_TextBox.TextChanged += new System.EventHandler(this.quanity_TextBox_TextChanged);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 846);
            this.Controls.Add(this.quanity_label);
            this.Controls.Add(this.quanity_TextBox);
            this.Controls.Add(this.SupplierID_Label);
            this.Controls.Add(this.SupplierID_TextBox);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Product_Name_TextBox);
            this.Controls.Add(this.Product_Price_Label);
            this.Controls.Add(this.Add_New_Product_Label);
            this.Controls.Add(this.Product_Descreption_Label);
            this.Controls.Add(this.Product_PartNumber_Label);
            this.Controls.Add(this.Product_Name_Label);
            this.Controls.Add(this.Product_ID_Label);
            this.Controls.Add(this.Product_Descreption_Textbox);
            this.Controls.Add(this.Product_PartNumber_Textbox);
            this.Controls.Add(this.Product_Price_Textbox);
            this.Controls.Add(this.Input_Product_Button);
            this.Controls.Add(this.Product_ID_Textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Add_New_Product_Label;
        private System.Windows.Forms.Label Product_Descreption_Label;
        private System.Windows.Forms.Label Product_PartNumber_Label;
        private System.Windows.Forms.Label Product_Name_Label;
        private System.Windows.Forms.Label Product_ID_Label;
        private System.Windows.Forms.TextBox Product_Descreption_Textbox;
        private System.Windows.Forms.TextBox Product_PartNumber_Textbox;
        private System.Windows.Forms.TextBox Product_Price_Textbox;
        private System.Windows.Forms.Button Input_Product_Button;
        private System.Windows.Forms.TextBox Product_ID_Textbox;
        private System.Windows.Forms.Label Product_Price_Label;
        private System.Windows.Forms.TextBox Product_Name_TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Back_To_Home_Page;
        private System.Windows.Forms.Label SupplierID_Label;
        private System.Windows.Forms.TextBox SupplierID_TextBox;
        private System.Windows.Forms.Label quanity_label;
        private System.Windows.Forms.TextBox quanity_TextBox;
    }
}