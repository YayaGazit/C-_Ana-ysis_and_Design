namespace Group_27
{
    partial class AddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplier));
            this.Supplier_Phone_Label = new System.Windows.Forms.Label();
            this.Supplier_Phone_Textbox = new System.Windows.Forms.TextBox();
            this.Add_New_Supplier_Label = new System.Windows.Forms.Label();
            this.Supplier_Address_Label = new System.Windows.Forms.Label();
            this.Supplier_Name_Label = new System.Windows.Forms.Label();
            this.Supplier_ID_Label = new System.Windows.Forms.Label();
            this.Supplier_Address_Textbox = new System.Windows.Forms.TextBox();
            this.Supplier_Name_Textbox = new System.Windows.Forms.TextBox();
            this.Input_Supplier_Button = new System.Windows.Forms.Button();
            this.Supplier_ID_Textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Supplier_Phone_Label
            // 
            this.Supplier_Phone_Label.AutoSize = true;
            this.Supplier_Phone_Label.BackColor = System.Drawing.Color.Transparent;
            this.Supplier_Phone_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supplier_Phone_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_Phone_Label.Location = new System.Drawing.Point(427, 360);
            this.Supplier_Phone_Label.Name = "Supplier_Phone_Label";
            this.Supplier_Phone_Label.Size = new System.Drawing.Size(88, 22);
            this.Supplier_Phone_Label.TabIndex = 99;
            this.Supplier_Phone_Label.Text = ":מס\' טלפון";
            // 
            // Supplier_Phone_Textbox
            // 
            this.Supplier_Phone_Textbox.Location = new System.Drawing.Point(221, 363);
            this.Supplier_Phone_Textbox.Name = "Supplier_Phone_Textbox";
            this.Supplier_Phone_Textbox.Size = new System.Drawing.Size(181, 20);
            this.Supplier_Phone_Textbox.TabIndex = 98;
            this.Supplier_Phone_Textbox.TextChanged += new System.EventHandler(this.Supplier_Phone_Textbox_TextChanged);
            // 
            // Add_New_Supplier_Label
            // 
            this.Add_New_Supplier_Label.AutoSize = true;
            this.Add_New_Supplier_Label.BackColor = System.Drawing.Color.Transparent;
            this.Add_New_Supplier_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Add_New_Supplier_Label.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_Supplier_Label.Location = new System.Drawing.Point(117, 59);
            this.Add_New_Supplier_Label.Name = "Add_New_Supplier_Label";
            this.Add_New_Supplier_Label.Size = new System.Drawing.Size(377, 66);
            this.Add_New_Supplier_Label.TabIndex = 96;
            this.Add_New_Supplier_Label.Text = "הכנסת ספק חדש";
            // 
            // Supplier_Address_Label
            // 
            this.Supplier_Address_Label.AutoSize = true;
            this.Supplier_Address_Label.BackColor = System.Drawing.Color.Transparent;
            this.Supplier_Address_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supplier_Address_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_Address_Label.Location = new System.Drawing.Point(427, 297);
            this.Supplier_Address_Label.Name = "Supplier_Address_Label";
            this.Supplier_Address_Label.Size = new System.Drawing.Size(63, 22);
            this.Supplier_Address_Label.TabIndex = 94;
            this.Supplier_Address_Label.Text = ":כתובת";
            // 
            // Supplier_Name_Label
            // 
            this.Supplier_Name_Label.AutoSize = true;
            this.Supplier_Name_Label.BackColor = System.Drawing.Color.Transparent;
            this.Supplier_Name_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supplier_Name_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_Name_Label.Location = new System.Drawing.Point(427, 238);
            this.Supplier_Name_Label.Name = "Supplier_Name_Label";
            this.Supplier_Name_Label.Size = new System.Drawing.Size(88, 22);
            this.Supplier_Name_Label.TabIndex = 87;
            this.Supplier_Name_Label.Text = ":שם הספק";
            // 
            // Supplier_ID_Label
            // 
            this.Supplier_ID_Label.AutoSize = true;
            this.Supplier_ID_Label.BackColor = System.Drawing.Color.Transparent;
            this.Supplier_ID_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supplier_ID_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_ID_Label.Location = new System.Drawing.Point(427, 175);
            this.Supplier_ID_Label.Name = "Supplier_ID_Label";
            this.Supplier_ID_Label.Size = new System.Drawing.Size(92, 22);
            this.Supplier_ID_Label.TabIndex = 86;
            this.Supplier_ID_Label.Text = ":מזהה ספק";
            // 
            // Supplier_Address_Textbox
            // 
            this.Supplier_Address_Textbox.Location = new System.Drawing.Point(223, 297);
            this.Supplier_Address_Textbox.Name = "Supplier_Address_Textbox";
            this.Supplier_Address_Textbox.Size = new System.Drawing.Size(181, 20);
            this.Supplier_Address_Textbox.TabIndex = 85;
            this.Supplier_Address_Textbox.TextChanged += new System.EventHandler(this.Supplier_Address_Textbox_TextChanged);
            // 
            // Supplier_Name_Textbox
            // 
            this.Supplier_Name_Textbox.Location = new System.Drawing.Point(221, 238);
            this.Supplier_Name_Textbox.Name = "Supplier_Name_Textbox";
            this.Supplier_Name_Textbox.Size = new System.Drawing.Size(181, 20);
            this.Supplier_Name_Textbox.TabIndex = 80;
            this.Supplier_Name_Textbox.TextChanged += new System.EventHandler(this.Supplier_Name_Textbox_TextChanged);
            // 
            // Input_Supplier_Button
            // 
            this.Input_Supplier_Button.BackColor = System.Drawing.Color.Silver;
            this.Input_Supplier_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Input_Supplier_Button.BackgroundImage")));
            this.Input_Supplier_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Input_Supplier_Button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Supplier_Button.Location = new System.Drawing.Point(221, 400);
            this.Input_Supplier_Button.Name = "Input_Supplier_Button";
            this.Input_Supplier_Button.Size = new System.Drawing.Size(183, 55);
            this.Input_Supplier_Button.TabIndex = 79;
            this.Input_Supplier_Button.Text = "יצירת ספק";
            this.Input_Supplier_Button.UseVisualStyleBackColor = false;
            this.Input_Supplier_Button.Click += new System.EventHandler(this.Input_Supplier_Button_Click);
            // 
            // Supplier_ID_Textbox
            // 
            this.Supplier_ID_Textbox.Location = new System.Drawing.Point(223, 177);
            this.Supplier_ID_Textbox.Name = "Supplier_ID_Textbox";
            this.Supplier_ID_Textbox.Size = new System.Drawing.Size(181, 20);
            this.Supplier_ID_Textbox.TabIndex = 78;
            this.Supplier_ID_Textbox.TextChanged += new System.EventHandler(this.Supplier_ID_Textbox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(505, 679);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 100;
            this.button1.Text = "חזור";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(505, 755);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 111;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(592, 842);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Supplier_Phone_Label);
            this.Controls.Add(this.Supplier_Phone_Textbox);
            this.Controls.Add(this.Add_New_Supplier_Label);
            this.Controls.Add(this.Supplier_Address_Label);
            this.Controls.Add(this.Supplier_Name_Label);
            this.Controls.Add(this.Supplier_ID_Label);
            this.Controls.Add(this.Supplier_Address_Textbox);
            this.Controls.Add(this.Supplier_Name_Textbox);
            this.Controls.Add(this.Input_Supplier_Button);
            this.Controls.Add(this.Supplier_ID_Textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSupplier";
            this.Text = "AddSupplier";
            this.Load += new System.EventHandler(this.AddSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Supplier_Phone_Label;
        private System.Windows.Forms.TextBox Supplier_Phone_Textbox;
        private System.Windows.Forms.Label Add_New_Supplier_Label;
        private System.Windows.Forms.Label Supplier_Address_Label;
        private System.Windows.Forms.Label Supplier_Name_Label;
        private System.Windows.Forms.Label Supplier_ID_Label;
        private System.Windows.Forms.TextBox Supplier_Address_Textbox;
        private System.Windows.Forms.TextBox Supplier_Name_Textbox;
        private System.Windows.Forms.Button Input_Supplier_Button;
        private System.Windows.Forms.TextBox Supplier_ID_Textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Back_To_Home_Page;
    }
}