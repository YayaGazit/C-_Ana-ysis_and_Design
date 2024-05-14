namespace Group_27
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.Emp_ID = new System.Windows.Forms.TextBox();
            this.Input_Employee = new System.Windows.Forms.Button();
            this.Employee_FirstName = new System.Windows.Forms.TextBox();
            this.Employee_LastName = new System.Windows.Forms.TextBox();
            this.Employee_Role = new System.Windows.Forms.ComboBox();
            this.Employee_Email = new System.Windows.Forms.TextBox();
            this.Employee_Password = new System.Windows.Forms.TextBox();
            this.Employee_Gender = new System.Windows.Forms.ComboBox();
            this.Employee_Salary = new System.Windows.Forms.TextBox();
            this.Employee_ID = new System.Windows.Forms.Label();
            this.Employee_FirstN = new System.Windows.Forms.Label();
            this.Employee_LastN = new System.Windows.Forms.Label();
            this.Employee_Rol = new System.Windows.Forms.Label();
            this.Employee_mail = new System.Windows.Forms.Label();
            this.Employee_pass = new System.Windows.Forms.Label();
            this.Employee_gende = new System.Windows.Forms.Label();
            this.Employee_StartDate = new System.Windows.Forms.Label();
            this.Employee_salar = new System.Windows.Forms.Label();
            this.Employee_datePicker = new System.Windows.Forms.DateTimePicker();
            this.Add_New_Employee_Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Emp_ID
            // 
            this.Emp_ID.Location = new System.Drawing.Point(188, 162);
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.Size = new System.Drawing.Size(200, 20);
            this.Emp_ID.TabIndex = 0;
            this.Emp_ID.TextChanged += new System.EventHandler(this.Emp_ID_TextChanged);
            // 
            // Input_Employee
            // 
            this.Input_Employee.BackColor = System.Drawing.Color.Transparent;
            this.Input_Employee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Input_Employee.BackgroundImage")));
            this.Input_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Input_Employee.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Employee.Location = new System.Drawing.Point(188, 641);
            this.Input_Employee.Name = "Input_Employee";
            this.Input_Employee.Size = new System.Drawing.Size(200, 55);
            this.Input_Employee.TabIndex = 1;
            this.Input_Employee.Text = "יצירת עובד";
            this.Input_Employee.UseVisualStyleBackColor = false;
            this.Input_Employee.Click += new System.EventHandler(this.Input_Employee_Click);
            // 
            // Employee_FirstName
            // 
            this.Employee_FirstName.Location = new System.Drawing.Point(188, 213);
            this.Employee_FirstName.Name = "Employee_FirstName";
            this.Employee_FirstName.Size = new System.Drawing.Size(200, 20);
            this.Employee_FirstName.TabIndex = 2;
            this.Employee_FirstName.TextChanged += new System.EventHandler(this.Employee_FirstName_TextChanged);
            // 
            // Employee_LastName
            // 
            this.Employee_LastName.Location = new System.Drawing.Point(188, 265);
            this.Employee_LastName.Name = "Employee_LastName";
            this.Employee_LastName.Size = new System.Drawing.Size(200, 20);
            this.Employee_LastName.TabIndex = 3;
            this.Employee_LastName.TextChanged += new System.EventHandler(this.Employee_LastName_TextChanged);
            // 
            // Employee_Role
            // 
            this.Employee_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Employee_Role.FormattingEnabled = true;
            this.Employee_Role.Location = new System.Drawing.Point(188, 322);
            this.Employee_Role.Name = "Employee_Role";
            this.Employee_Role.Size = new System.Drawing.Size(200, 21);
            this.Employee_Role.TabIndex = 4;
            this.Employee_Role.SelectedIndexChanged += new System.EventHandler(this.Employee_Role_SelectedIndexChanged);
            // 
            // Employee_Email
            // 
            this.Employee_Email.Location = new System.Drawing.Point(188, 370);
            this.Employee_Email.Name = "Employee_Email";
            this.Employee_Email.Size = new System.Drawing.Size(200, 20);
            this.Employee_Email.TabIndex = 5;
            this.Employee_Email.TextChanged += new System.EventHandler(this.Employee_Email_TextChanged);
            // 
            // Employee_Password
            // 
            this.Employee_Password.Location = new System.Drawing.Point(188, 424);
            this.Employee_Password.Name = "Employee_Password";
            this.Employee_Password.Size = new System.Drawing.Size(200, 20);
            this.Employee_Password.TabIndex = 6;
            this.Employee_Password.TextChanged += new System.EventHandler(this.Employee_Password_TextChanged);
            // 
            // Employee_Gender
            // 
            this.Employee_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Employee_Gender.FormattingEnabled = true;
            this.Employee_Gender.Location = new System.Drawing.Point(188, 482);
            this.Employee_Gender.Name = "Employee_Gender";
            this.Employee_Gender.Size = new System.Drawing.Size(200, 21);
            this.Employee_Gender.TabIndex = 7;
            this.Employee_Gender.SelectedIndexChanged += new System.EventHandler(this.Employee_Gender_SelectedIndexChanged);
            // 
            // Employee_Salary
            // 
            this.Employee_Salary.Location = new System.Drawing.Point(188, 596);
            this.Employee_Salary.Name = "Employee_Salary";
            this.Employee_Salary.Size = new System.Drawing.Size(200, 20);
            this.Employee_Salary.TabIndex = 9;
            this.Employee_Salary.TextChanged += new System.EventHandler(this.Employee_Salary_TextChanged);
            // 
            // Employee_ID
            // 
            this.Employee_ID.AutoSize = true;
            this.Employee_ID.BackColor = System.Drawing.Color.Transparent;
            this.Employee_ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_ID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_ID.Location = new System.Drawing.Point(422, 162);
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.Size = new System.Drawing.Size(101, 22);
            this.Employee_ID.TabIndex = 16;
            this.Employee_ID.Text = ":תעודת זהות";
            // 
            // Employee_FirstN
            // 
            this.Employee_FirstN.AutoSize = true;
            this.Employee_FirstN.BackColor = System.Drawing.Color.Transparent;
            this.Employee_FirstN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_FirstN.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_FirstN.Location = new System.Drawing.Point(422, 213);
            this.Employee_FirstN.Name = "Employee_FirstN";
            this.Employee_FirstN.Size = new System.Drawing.Size(79, 22);
            this.Employee_FirstN.TabIndex = 17;
            this.Employee_FirstN.Text = ":שם פרטי";
            this.Employee_FirstN.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Employee_LastN
            // 
            this.Employee_LastN.AutoSize = true;
            this.Employee_LastN.BackColor = System.Drawing.Color.Transparent;
            this.Employee_LastN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_LastN.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_LastN.Location = new System.Drawing.Point(422, 265);
            this.Employee_LastN.Name = "Employee_LastN";
            this.Employee_LastN.Size = new System.Drawing.Size(100, 22);
            this.Employee_LastN.TabIndex = 18;
            this.Employee_LastN.Text = ":שם משפחה";
            this.Employee_LastN.Click += new System.EventHandler(this.Employee_LastN_Click);
            // 
            // Employee_Rol
            // 
            this.Employee_Rol.AutoSize = true;
            this.Employee_Rol.BackColor = System.Drawing.Color.Transparent;
            this.Employee_Rol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_Rol.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_Rol.Location = new System.Drawing.Point(422, 322);
            this.Employee_Rol.Name = "Employee_Rol";
            this.Employee_Rol.Size = new System.Drawing.Size(63, 22);
            this.Employee_Rol.TabIndex = 19;
            this.Employee_Rol.Text = ":תפקיד";
            // 
            // Employee_mail
            // 
            this.Employee_mail.AutoSize = true;
            this.Employee_mail.BackColor = System.Drawing.Color.Transparent;
            this.Employee_mail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_mail.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_mail.Location = new System.Drawing.Point(422, 370);
            this.Employee_mail.Name = "Employee_mail";
            this.Employee_mail.Size = new System.Drawing.Size(45, 22);
            this.Employee_mail.TabIndex = 20;
            this.Employee_mail.Text = ":מייל";
            // 
            // Employee_pass
            // 
            this.Employee_pass.AutoSize = true;
            this.Employee_pass.BackColor = System.Drawing.Color.Transparent;
            this.Employee_pass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_pass.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_pass.Location = new System.Drawing.Point(422, 422);
            this.Employee_pass.Name = "Employee_pass";
            this.Employee_pass.Size = new System.Drawing.Size(67, 22);
            this.Employee_pass.TabIndex = 21;
            this.Employee_pass.Text = ":סיסמא";
            // 
            // Employee_gende
            // 
            this.Employee_gende.AutoSize = true;
            this.Employee_gende.BackColor = System.Drawing.Color.Transparent;
            this.Employee_gende.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_gende.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_gende.Location = new System.Drawing.Point(422, 482);
            this.Employee_gende.Name = "Employee_gende";
            this.Employee_gende.Size = new System.Drawing.Size(36, 22);
            this.Employee_gende.TabIndex = 22;
            this.Employee_gende.Text = ":מין";
            // 
            // Employee_StartDate
            // 
            this.Employee_StartDate.AutoSize = true;
            this.Employee_StartDate.BackColor = System.Drawing.Color.Transparent;
            this.Employee_StartDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_StartDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_StartDate.Location = new System.Drawing.Point(422, 545);
            this.Employee_StartDate.Name = "Employee_StartDate";
            this.Employee_StartDate.Size = new System.Drawing.Size(164, 22);
            this.Employee_StartDate.TabIndex = 23;
            this.Employee_StartDate.Text = ":תאריך תחילת עבודה";
            // 
            // Employee_salar
            // 
            this.Employee_salar.AutoSize = true;
            this.Employee_salar.BackColor = System.Drawing.Color.Transparent;
            this.Employee_salar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_salar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_salar.Location = new System.Drawing.Point(422, 596);
            this.Employee_salar.Name = "Employee_salar";
            this.Employee_salar.Size = new System.Drawing.Size(46, 22);
            this.Employee_salar.TabIndex = 24;
            this.Employee_salar.Text = ":שכר";
            // 
            // Employee_datePicker
            // 
            this.Employee_datePicker.Location = new System.Drawing.Point(188, 542);
            this.Employee_datePicker.Name = "Employee_datePicker";
            this.Employee_datePicker.Size = new System.Drawing.Size(200, 20);
            this.Employee_datePicker.TabIndex = 26;
            this.Employee_datePicker.ValueChanged += new System.EventHandler(this.Employee_datePicker_ValueChanged);
            // 
            // Add_New_Employee_Label
            // 
            this.Add_New_Employee_Label.AutoSize = true;
            this.Add_New_Employee_Label.BackColor = System.Drawing.Color.Transparent;
            this.Add_New_Employee_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Add_New_Employee_Label.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_Employee_Label.Location = new System.Drawing.Point(119, 47);
            this.Add_New_Employee_Label.Name = "Add_New_Employee_Label";
            this.Add_New_Employee_Label.Size = new System.Drawing.Size(348, 66);
            this.Add_New_Employee_Label.TabIndex = 54;
            this.Add_New_Employee_Label.Text = "יצירת עובד חדש";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(508, 691);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 55);
            this.button1.TabIndex = 55;
            this.button1.Text = "חזור";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(508, 755);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 112;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(595, 842);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add_New_Employee_Label);
            this.Controls.Add(this.Employee_datePicker);
            this.Controls.Add(this.Employee_salar);
            this.Controls.Add(this.Employee_StartDate);
            this.Controls.Add(this.Employee_gende);
            this.Controls.Add(this.Employee_pass);
            this.Controls.Add(this.Employee_mail);
            this.Controls.Add(this.Employee_Rol);
            this.Controls.Add(this.Employee_LastN);
            this.Controls.Add(this.Employee_FirstN);
            this.Controls.Add(this.Employee_ID);
            this.Controls.Add(this.Employee_Salary);
            this.Controls.Add(this.Employee_Gender);
            this.Controls.Add(this.Employee_Password);
            this.Controls.Add(this.Employee_Email);
            this.Controls.Add(this.Employee_Role);
            this.Controls.Add(this.Employee_LastName);
            this.Controls.Add(this.Employee_FirstName);
            this.Controls.Add(this.Input_Employee);
            this.Controls.Add(this.Emp_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Emp_ID;
        private System.Windows.Forms.Button Input_Employee;
        private System.Windows.Forms.TextBox Employee_FirstName;
        private System.Windows.Forms.TextBox Employee_LastName;
        private System.Windows.Forms.ComboBox Employee_Role;
        private System.Windows.Forms.TextBox Employee_Email;
        private System.Windows.Forms.TextBox Employee_Password;
        private System.Windows.Forms.ComboBox Employee_Gender;
        private System.Windows.Forms.TextBox Employee_Salary;
        private System.Windows.Forms.Label Employee_ID;
        private System.Windows.Forms.Label Employee_FirstN;
        private System.Windows.Forms.Label Employee_LastN;
        private System.Windows.Forms.Label Employee_Rol;
        private System.Windows.Forms.Label Employee_mail;
        private System.Windows.Forms.Label Employee_pass;
        private System.Windows.Forms.Label Employee_gende;
        private System.Windows.Forms.Label Employee_StartDate;
        private System.Windows.Forms.Label Employee_salar;
        private System.Windows.Forms.DateTimePicker Employee_datePicker;
        private System.Windows.Forms.Label Add_New_Employee_Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Back_To_Home_Page;
    }
}