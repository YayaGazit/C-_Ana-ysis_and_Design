namespace Group_27
{
    partial class Crud_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crud_Employee));
            this.AddNew_Employee_button = new System.Windows.Forms.Button();
            this.Show_Employee_button = new System.Windows.Forms.Button();
            this.Employee_Managment_CRUD = new System.Windows.Forms.Label();
            this.Show_AllEmployess_button = new System.Windows.Forms.Button();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNew_Employee_button
            // 
            this.AddNew_Employee_button.BackColor = System.Drawing.Color.Transparent;
            this.AddNew_Employee_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddNew_Employee_button.BackgroundImage")));
            this.AddNew_Employee_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddNew_Employee_button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNew_Employee_button.Location = new System.Drawing.Point(21, 272);
            this.AddNew_Employee_button.Name = "AddNew_Employee_button";
            this.AddNew_Employee_button.Size = new System.Drawing.Size(160, 160);
            this.AddNew_Employee_button.TabIndex = 6;
            this.AddNew_Employee_button.Text = "הוספת עובד חדש";
            this.AddNew_Employee_button.UseVisualStyleBackColor = false;
            this.AddNew_Employee_button.Click += new System.EventHandler(this.AddNew_Employee_button_Click);
            // 
            // Show_Employee_button
            // 
            this.Show_Employee_button.BackColor = System.Drawing.Color.Transparent;
            this.Show_Employee_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Show_Employee_button.BackgroundImage")));
            this.Show_Employee_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_Employee_button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Employee_button.Location = new System.Drawing.Point(403, 272);
            this.Show_Employee_button.Name = "Show_Employee_button";
            this.Show_Employee_button.Size = new System.Drawing.Size(160, 160);
            this.Show_Employee_button.TabIndex = 5;
            this.Show_Employee_button.Text = "פרטי עובד";
            this.Show_Employee_button.UseVisualStyleBackColor = false;
            this.Show_Employee_button.Click += new System.EventHandler(this.Show_Employee_button_Click);
            // 
            // Employee_Managment_CRUD
            // 
            this.Employee_Managment_CRUD.AutoSize = true;
            this.Employee_Managment_CRUD.BackColor = System.Drawing.Color.Transparent;
            this.Employee_Managment_CRUD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Employee_Managment_CRUD.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_Managment_CRUD.Location = new System.Drawing.Point(144, 115);
            this.Employee_Managment_CRUD.Name = "Employee_Managment_CRUD";
            this.Employee_Managment_CRUD.Size = new System.Drawing.Size(278, 66);
            this.Employee_Managment_CRUD.TabIndex = 53;
            this.Employee_Managment_CRUD.Text = "ניהול עובדים";
            this.Employee_Managment_CRUD.Click += new System.EventHandler(this.Employee_Managment_CRUD_Click);
            // 
            // Show_AllEmployess_button
            // 
            this.Show_AllEmployess_button.BackColor = System.Drawing.Color.Transparent;
            this.Show_AllEmployess_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Show_AllEmployess_button.BackgroundImage")));
            this.Show_AllEmployess_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_AllEmployess_button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_AllEmployess_button.Location = new System.Drawing.Point(210, 272);
            this.Show_AllEmployess_button.Name = "Show_AllEmployess_button";
            this.Show_AllEmployess_button.Size = new System.Drawing.Size(160, 160);
            this.Show_AllEmployess_button.TabIndex = 54;
            this.Show_AllEmployess_button.Text = "הצגת עובדים";
            this.Show_AllEmployess_button.UseVisualStyleBackColor = false;
            this.Show_AllEmployess_button.Click += new System.EventHandler(this.Show_AllEmployess_button_Click);
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(485, 760);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 60;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // Crud_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(585, 848);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.Show_AllEmployess_button);
            this.Controls.Add(this.Employee_Managment_CRUD);
            this.Controls.Add(this.AddNew_Employee_button);
            this.Controls.Add(this.Show_Employee_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crud_Employee";
            this.Text = "Crud_Employee";
            this.Load += new System.EventHandler(this.Crud_Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNew_Employee_button;
        private System.Windows.Forms.Button Show_Employee_button;
        private System.Windows.Forms.Label Employee_Managment_CRUD;
        private System.Windows.Forms.Button Show_AllEmployess_button;
        private System.Windows.Forms.Button Back_To_Home_Page;
    }
}