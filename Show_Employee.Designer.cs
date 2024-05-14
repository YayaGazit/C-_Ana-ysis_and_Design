namespace Group_27
{
    partial class Show_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Employee));
            this.Employee_datePicker_Show = new System.Windows.Forms.DateTimePicker();
            this.Employee_salar = new System.Windows.Forms.Label();
            this.Employee_StartDate = new System.Windows.Forms.Label();
            this.Employee_gende = new System.Windows.Forms.Label();
            this.Employee_pass = new System.Windows.Forms.Label();
            this.Employee_mail = new System.Windows.Forms.Label();
            this.Employee_Rol = new System.Windows.Forms.Label();
            this.Employee_LastN = new System.Windows.Forms.Label();
            this.Employee_FirstN = new System.Windows.Forms.Label();
            this.Employee_ID = new System.Windows.Forms.Label();
            this.Employee_Salary_Show_TextBox = new System.Windows.Forms.TextBox();
            this.Employee_Gender_Show_ComboBox = new System.Windows.Forms.ComboBox();
            this.Employee_Password_Show_TextBox = new System.Windows.Forms.TextBox();
            this.Employee_Email_Show_TextBox = new System.Windows.Forms.TextBox();
            this.Employee_Role_Show_ComboBox = new System.Windows.Forms.ComboBox();
            this.Employee_LastName_Show_TextBox = new System.Windows.Forms.TextBox();
            this.Employee_FirstName_Show_TextBox = new System.Windows.Forms.TextBox();
            this.Emp_ID_Show_TextBox = new System.Windows.Forms.TextBox();
            this.Update_Employee_Show_Button = new System.Windows.Forms.Button();
            this.Save_Details_Employee_Show_Button = new System.Windows.Forms.Button();
            this.SearchEmployee_ByID_Show_TextBox = new System.Windows.Forms.TextBox();
            this.Search_Employee_Show_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowEmployee_BackToCRUD_Button = new System.Windows.Forms.Button();
            this.Employee_Details_Show = new System.Windows.Forms.Label();
            this.Employee_toArchive_button = new System.Windows.Forms.Button();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Employee_datePicker_Show
            // 
            this.Employee_datePicker_Show.Location = new System.Drawing.Point(175, 546);
            this.Employee_datePicker_Show.Name = "Employee_datePicker_Show";
            this.Employee_datePicker_Show.Size = new System.Drawing.Size(200, 20);
            this.Employee_datePicker_Show.TabIndex = 44;
            this.Employee_datePicker_Show.ValueChanged += new System.EventHandler(this.Employee_datePicker_Show_ValueChanged);
            // 
            // Employee_salar
            // 
            this.Employee_salar.AutoSize = true;
            this.Employee_salar.BackColor = System.Drawing.Color.Transparent;
            this.Employee_salar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_salar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_salar.Location = new System.Drawing.Point(408, 600);
            this.Employee_salar.Name = "Employee_salar";
            this.Employee_salar.Size = new System.Drawing.Size(46, 22);
            this.Employee_salar.TabIndex = 43;
            this.Employee_salar.Text = ":שכר";
            // 
            // Employee_StartDate
            // 
            this.Employee_StartDate.AutoSize = true;
            this.Employee_StartDate.BackColor = System.Drawing.Color.Transparent;
            this.Employee_StartDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_StartDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_StartDate.Location = new System.Drawing.Point(408, 549);
            this.Employee_StartDate.Name = "Employee_StartDate";
            this.Employee_StartDate.Size = new System.Drawing.Size(164, 22);
            this.Employee_StartDate.TabIndex = 42;
            this.Employee_StartDate.Text = ":תאריך תחילת עבודה";
            // 
            // Employee_gende
            // 
            this.Employee_gende.AutoSize = true;
            this.Employee_gende.BackColor = System.Drawing.Color.Transparent;
            this.Employee_gende.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_gende.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_gende.Location = new System.Drawing.Point(408, 490);
            this.Employee_gende.Name = "Employee_gende";
            this.Employee_gende.Size = new System.Drawing.Size(36, 22);
            this.Employee_gende.TabIndex = 41;
            this.Employee_gende.Text = ":מין";
            // 
            // Employee_pass
            // 
            this.Employee_pass.AutoSize = true;
            this.Employee_pass.BackColor = System.Drawing.Color.Transparent;
            this.Employee_pass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_pass.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_pass.Location = new System.Drawing.Point(408, 426);
            this.Employee_pass.Name = "Employee_pass";
            this.Employee_pass.Size = new System.Drawing.Size(67, 22);
            this.Employee_pass.TabIndex = 40;
            this.Employee_pass.Text = ":סיסמא";
            // 
            // Employee_mail
            // 
            this.Employee_mail.AutoSize = true;
            this.Employee_mail.BackColor = System.Drawing.Color.Transparent;
            this.Employee_mail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_mail.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_mail.Location = new System.Drawing.Point(408, 377);
            this.Employee_mail.Name = "Employee_mail";
            this.Employee_mail.Size = new System.Drawing.Size(45, 22);
            this.Employee_mail.TabIndex = 39;
            this.Employee_mail.Text = ":מייל";
            // 
            // Employee_Rol
            // 
            this.Employee_Rol.AutoSize = true;
            this.Employee_Rol.BackColor = System.Drawing.Color.Transparent;
            this.Employee_Rol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_Rol.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_Rol.Location = new System.Drawing.Point(408, 326);
            this.Employee_Rol.Name = "Employee_Rol";
            this.Employee_Rol.Size = new System.Drawing.Size(63, 22);
            this.Employee_Rol.TabIndex = 38;
            this.Employee_Rol.Text = ":תפקיד";
            // 
            // Employee_LastN
            // 
            this.Employee_LastN.AutoSize = true;
            this.Employee_LastN.BackColor = System.Drawing.Color.Transparent;
            this.Employee_LastN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_LastN.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_LastN.Location = new System.Drawing.Point(408, 269);
            this.Employee_LastN.Name = "Employee_LastN";
            this.Employee_LastN.Size = new System.Drawing.Size(100, 22);
            this.Employee_LastN.TabIndex = 37;
            this.Employee_LastN.Text = ":שם משפחה";
            // 
            // Employee_FirstN
            // 
            this.Employee_FirstN.AutoSize = true;
            this.Employee_FirstN.BackColor = System.Drawing.Color.Transparent;
            this.Employee_FirstN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_FirstN.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_FirstN.Location = new System.Drawing.Point(408, 217);
            this.Employee_FirstN.Name = "Employee_FirstN";
            this.Employee_FirstN.Size = new System.Drawing.Size(79, 22);
            this.Employee_FirstN.TabIndex = 36;
            this.Employee_FirstN.Text = ":שם פרטי";
            // 
            // Employee_ID
            // 
            this.Employee_ID.AutoSize = true;
            this.Employee_ID.BackColor = System.Drawing.Color.Transparent;
            this.Employee_ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_ID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_ID.Location = new System.Drawing.Point(408, 166);
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.Size = new System.Drawing.Size(101, 22);
            this.Employee_ID.TabIndex = 35;
            this.Employee_ID.Text = ":תעודת זהות";
            // 
            // Employee_Salary_Show_TextBox
            // 
            this.Employee_Salary_Show_TextBox.Location = new System.Drawing.Point(175, 600);
            this.Employee_Salary_Show_TextBox.Name = "Employee_Salary_Show_TextBox";
            this.Employee_Salary_Show_TextBox.Size = new System.Drawing.Size(200, 20);
            this.Employee_Salary_Show_TextBox.TabIndex = 34;
            this.Employee_Salary_Show_TextBox.TextChanged += new System.EventHandler(this.Employee_Salary_Show_TextBox_TextChanged);
            // 
            // Employee_Gender_Show_ComboBox
            // 
            this.Employee_Gender_Show_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Employee_Gender_Show_ComboBox.FormattingEnabled = true;
            this.Employee_Gender_Show_ComboBox.Location = new System.Drawing.Point(175, 490);
            this.Employee_Gender_Show_ComboBox.Name = "Employee_Gender_Show_ComboBox";
            this.Employee_Gender_Show_ComboBox.Size = new System.Drawing.Size(200, 21);
            this.Employee_Gender_Show_ComboBox.TabIndex = 33;
            this.Employee_Gender_Show_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Employee_Gender_Show_ComboBox_SelectedIndexChanged);
            // 
            // Employee_Password_Show_TextBox
            // 
            this.Employee_Password_Show_TextBox.Location = new System.Drawing.Point(175, 428);
            this.Employee_Password_Show_TextBox.Name = "Employee_Password_Show_TextBox";
            this.Employee_Password_Show_TextBox.Size = new System.Drawing.Size(200, 20);
            this.Employee_Password_Show_TextBox.TabIndex = 32;
            this.Employee_Password_Show_TextBox.TextChanged += new System.EventHandler(this.Employee_Password_Show_TextBox_TextChanged);
            // 
            // Employee_Email_Show_TextBox
            // 
            this.Employee_Email_Show_TextBox.Location = new System.Drawing.Point(175, 377);
            this.Employee_Email_Show_TextBox.Name = "Employee_Email_Show_TextBox";
            this.Employee_Email_Show_TextBox.Size = new System.Drawing.Size(200, 20);
            this.Employee_Email_Show_TextBox.TabIndex = 31;
            this.Employee_Email_Show_TextBox.TextChanged += new System.EventHandler(this.Employee_Email_Show_TextBox_TextChanged);
            // 
            // Employee_Role_Show_ComboBox
            // 
            this.Employee_Role_Show_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Employee_Role_Show_ComboBox.FormattingEnabled = true;
            this.Employee_Role_Show_ComboBox.Location = new System.Drawing.Point(175, 326);
            this.Employee_Role_Show_ComboBox.Name = "Employee_Role_Show_ComboBox";
            this.Employee_Role_Show_ComboBox.Size = new System.Drawing.Size(200, 21);
            this.Employee_Role_Show_ComboBox.TabIndex = 30;
            this.Employee_Role_Show_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Employee_Role_Show_ComboBox_SelectedIndexChanged);
            // 
            // Employee_LastName_Show_TextBox
            // 
            this.Employee_LastName_Show_TextBox.Location = new System.Drawing.Point(175, 271);
            this.Employee_LastName_Show_TextBox.Name = "Employee_LastName_Show_TextBox";
            this.Employee_LastName_Show_TextBox.Size = new System.Drawing.Size(200, 20);
            this.Employee_LastName_Show_TextBox.TabIndex = 29;
            this.Employee_LastName_Show_TextBox.TextChanged += new System.EventHandler(this.Employee_LastName_Show_TextBox_TextChanged);
            // 
            // Employee_FirstName_Show_TextBox
            // 
            this.Employee_FirstName_Show_TextBox.Location = new System.Drawing.Point(175, 217);
            this.Employee_FirstName_Show_TextBox.Name = "Employee_FirstName_Show_TextBox";
            this.Employee_FirstName_Show_TextBox.Size = new System.Drawing.Size(200, 20);
            this.Employee_FirstName_Show_TextBox.TabIndex = 28;
            this.Employee_FirstName_Show_TextBox.TextChanged += new System.EventHandler(this.Employee_FirstName_Show_TextBox_TextChanged);
            // 
            // Emp_ID_Show_TextBox
            // 
            this.Emp_ID_Show_TextBox.Location = new System.Drawing.Point(175, 166);
            this.Emp_ID_Show_TextBox.Name = "Emp_ID_Show_TextBox";
            this.Emp_ID_Show_TextBox.Size = new System.Drawing.Size(200, 20);
            this.Emp_ID_Show_TextBox.TabIndex = 27;
            this.Emp_ID_Show_TextBox.TextChanged += new System.EventHandler(this.Emp_ID_Show_TextBox_TextChanged);
            // 
            // Update_Employee_Show_Button
            // 
            this.Update_Employee_Show_Button.BackColor = System.Drawing.Color.Transparent;
            this.Update_Employee_Show_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Update_Employee_Show_Button.BackgroundImage")));
            this.Update_Employee_Show_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Update_Employee_Show_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Update_Employee_Show_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Update_Employee_Show_Button.FlatAppearance.BorderSize = 10;
            this.Update_Employee_Show_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update_Employee_Show_Button.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Employee_Show_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Update_Employee_Show_Button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Update_Employee_Show_Button.Location = new System.Drawing.Point(348, 653);
            this.Update_Employee_Show_Button.Name = "Update_Employee_Show_Button";
            this.Update_Employee_Show_Button.Size = new System.Drawing.Size(139, 51);
            this.Update_Employee_Show_Button.TabIndex = 45;
            this.Update_Employee_Show_Button.Text = "עדכן";
            this.Update_Employee_Show_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Update_Employee_Show_Button.UseVisualStyleBackColor = false;
            this.Update_Employee_Show_Button.Click += new System.EventHandler(this.Update_Employee_Show_Button_Click);
            // 
            // Save_Details_Employee_Show_Button
            // 
            this.Save_Details_Employee_Show_Button.BackColor = System.Drawing.Color.Transparent;
            this.Save_Details_Employee_Show_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save_Details_Employee_Show_Button.BackgroundImage")));
            this.Save_Details_Employee_Show_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save_Details_Employee_Show_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Save_Details_Employee_Show_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Save_Details_Employee_Show_Button.FlatAppearance.BorderSize = 10;
            this.Save_Details_Employee_Show_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_Details_Employee_Show_Button.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Details_Employee_Show_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Save_Details_Employee_Show_Button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Save_Details_Employee_Show_Button.Location = new System.Drawing.Point(179, 653);
            this.Save_Details_Employee_Show_Button.Name = "Save_Details_Employee_Show_Button";
            this.Save_Details_Employee_Show_Button.Size = new System.Drawing.Size(139, 51);
            this.Save_Details_Employee_Show_Button.TabIndex = 46;
            this.Save_Details_Employee_Show_Button.Text = "שמור";
            this.Save_Details_Employee_Show_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save_Details_Employee_Show_Button.UseVisualStyleBackColor = false;
            this.Save_Details_Employee_Show_Button.Click += new System.EventHandler(this.Save_Details_Employee_Show_Button_Click);
            // 
            // SearchEmployee_ByID_Show_TextBox
            // 
            this.SearchEmployee_ByID_Show_TextBox.Location = new System.Drawing.Point(169, 111);
            this.SearchEmployee_ByID_Show_TextBox.Name = "SearchEmployee_ByID_Show_TextBox";
            this.SearchEmployee_ByID_Show_TextBox.Size = new System.Drawing.Size(205, 20);
            this.SearchEmployee_ByID_Show_TextBox.TabIndex = 48;
            this.SearchEmployee_ByID_Show_TextBox.TextChanged += new System.EventHandler(this.SearchEmployee_ByID_Show_TextBox_TextChanged);
            // 
            // Search_Employee_Show_Button
            // 
            this.Search_Employee_Show_Button.BackColor = System.Drawing.Color.Transparent;
            this.Search_Employee_Show_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search_Employee_Show_Button.BackgroundImage")));
            this.Search_Employee_Show_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search_Employee_Show_Button.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Employee_Show_Button.Location = new System.Drawing.Point(66, 105);
            this.Search_Employee_Show_Button.Name = "Search_Employee_Show_Button";
            this.Search_Employee_Show_Button.Size = new System.Drawing.Size(82, 31);
            this.Search_Employee_Show_Button.TabIndex = 49;
            this.Search_Employee_Show_Button.Text = "חפש";
            this.Search_Employee_Show_Button.UseVisualStyleBackColor = false;
            this.Search_Employee_Show_Button.Click += new System.EventHandler(this.Search_Employee_Show_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = ":תעודת זהות";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ShowEmployee_BackToCRUD_Button
            // 
            this.ShowEmployee_BackToCRUD_Button.BackColor = System.Drawing.Color.Transparent;
            this.ShowEmployee_BackToCRUD_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowEmployee_BackToCRUD_Button.BackgroundImage")));
            this.ShowEmployee_BackToCRUD_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ShowEmployee_BackToCRUD_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShowEmployee_BackToCRUD_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ShowEmployee_BackToCRUD_Button.FlatAppearance.BorderSize = 50;
            this.ShowEmployee_BackToCRUD_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowEmployee_BackToCRUD_Button.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEmployee_BackToCRUD_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowEmployee_BackToCRUD_Button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ShowEmployee_BackToCRUD_Button.Location = new System.Drawing.Point(508, 693);
            this.ShowEmployee_BackToCRUD_Button.Name = "ShowEmployee_BackToCRUD_Button";
            this.ShowEmployee_BackToCRUD_Button.Size = new System.Drawing.Size(75, 51);
            this.ShowEmployee_BackToCRUD_Button.TabIndex = 51;
            this.ShowEmployee_BackToCRUD_Button.Text = "חזור";
            this.ShowEmployee_BackToCRUD_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShowEmployee_BackToCRUD_Button.UseVisualStyleBackColor = false;
            this.ShowEmployee_BackToCRUD_Button.Click += new System.EventHandler(this.ShowEmployee_BackToCRUD_Button_Click);
            // 
            // Employee_Details_Show
            // 
            this.Employee_Details_Show.AutoSize = true;
            this.Employee_Details_Show.BackColor = System.Drawing.Color.Transparent;
            this.Employee_Details_Show.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Employee_Details_Show.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_Details_Show.Location = new System.Drawing.Point(166, 9);
            this.Employee_Details_Show.Name = "Employee_Details_Show";
            this.Employee_Details_Show.Size = new System.Drawing.Size(277, 66);
            this.Employee_Details_Show.TabIndex = 52;
            this.Employee_Details_Show.Text = "פרטי עובדים";
            // 
            // Employee_toArchive_button
            // 
            this.Employee_toArchive_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Employee_toArchive_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Employee_toArchive_button.BackgroundImage")));
            this.Employee_toArchive_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Employee_toArchive_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_toArchive_button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_toArchive_button.Location = new System.Drawing.Point(18, 653);
            this.Employee_toArchive_button.Name = "Employee_toArchive_button";
            this.Employee_toArchive_button.Size = new System.Drawing.Size(140, 51);
            this.Employee_toArchive_button.TabIndex = 53;
            this.Employee_toArchive_button.Text = "העברה לארכיון";
            this.Employee_toArchive_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Employee_toArchive_button.UseVisualStyleBackColor = false;
            this.Employee_toArchive_button.Click += new System.EventHandler(this.Employee_toArchive_button_Click);
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(508, 750);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 108;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // Show_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 837);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.Employee_toArchive_button);
            this.Controls.Add(this.Employee_Details_Show);
            this.Controls.Add(this.ShowEmployee_BackToCRUD_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_Employee_Show_Button);
            this.Controls.Add(this.SearchEmployee_ByID_Show_TextBox);
            this.Controls.Add(this.Save_Details_Employee_Show_Button);
            this.Controls.Add(this.Update_Employee_Show_Button);
            this.Controls.Add(this.Employee_datePicker_Show);
            this.Controls.Add(this.Employee_salar);
            this.Controls.Add(this.Employee_StartDate);
            this.Controls.Add(this.Employee_gende);
            this.Controls.Add(this.Employee_pass);
            this.Controls.Add(this.Employee_mail);
            this.Controls.Add(this.Employee_Rol);
            this.Controls.Add(this.Employee_LastN);
            this.Controls.Add(this.Employee_FirstN);
            this.Controls.Add(this.Employee_ID);
            this.Controls.Add(this.Employee_Salary_Show_TextBox);
            this.Controls.Add(this.Employee_Gender_Show_ComboBox);
            this.Controls.Add(this.Employee_Password_Show_TextBox);
            this.Controls.Add(this.Employee_Email_Show_TextBox);
            this.Controls.Add(this.Employee_Role_Show_ComboBox);
            this.Controls.Add(this.Employee_LastName_Show_TextBox);
            this.Controls.Add(this.Employee_FirstName_Show_TextBox);
            this.Controls.Add(this.Emp_ID_Show_TextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Show_Employee";
            this.Text = "Show_Employee";
            this.Load += new System.EventHandler(this.Show_Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Employee_datePicker_Show;
        private System.Windows.Forms.Label Employee_salar;
        private System.Windows.Forms.Label Employee_StartDate;
        private System.Windows.Forms.Label Employee_gende;
        private System.Windows.Forms.Label Employee_pass;
        private System.Windows.Forms.Label Employee_mail;
        private System.Windows.Forms.Label Employee_Rol;
        private System.Windows.Forms.Label Employee_LastN;
        private System.Windows.Forms.Label Employee_FirstN;
        private System.Windows.Forms.Label Employee_ID;
        private System.Windows.Forms.TextBox Employee_Salary_Show_TextBox;
        private System.Windows.Forms.ComboBox Employee_Gender_Show_ComboBox;
        private System.Windows.Forms.TextBox Employee_Password_Show_TextBox;
        private System.Windows.Forms.TextBox Employee_Email_Show_TextBox;
        private System.Windows.Forms.ComboBox Employee_Role_Show_ComboBox;
        private System.Windows.Forms.TextBox Employee_LastName_Show_TextBox;
        private System.Windows.Forms.TextBox Employee_FirstName_Show_TextBox;
        private System.Windows.Forms.TextBox Emp_ID_Show_TextBox;
        private System.Windows.Forms.TextBox SearchEmployee_ByID_Show_TextBox;
        private System.Windows.Forms.Button Search_Employee_Show_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update_Employee_Show_Button;
        private System.Windows.Forms.Button Save_Details_Employee_Show_Button;
        private System.Windows.Forms.Button ShowEmployee_BackToCRUD_Button;
        private System.Windows.Forms.Label Employee_Details_Show;
        private System.Windows.Forms.Button Employee_toArchive_button;
        private System.Windows.Forms.Button Back_To_Home_Page;
    }
}