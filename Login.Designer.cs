namespace Group_27
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UserName_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.UserName_TextBox = new System.Windows.Forms.TextBox();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.Enter_Button = new System.Windows.Forms.Button();
            this.Show_Password = new System.Windows.Forms.Button();
            this.Hide_Passwrod = new System.Windows.Forms.Button();
            this.Employee_Managment_CRUD = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName_Label
            // 
            this.UserName_Label.AutoSize = true;
            this.UserName_Label.BackColor = System.Drawing.Color.Transparent;
            this.UserName_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_Label.Location = new System.Drawing.Point(432, 139);
            this.UserName_Label.Name = "UserName_Label";
            this.UserName_Label.Size = new System.Drawing.Size(103, 22);
            this.UserName_Label.TabIndex = 101;
            this.UserName_Label.Text = ":שם משתמש";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.BackColor = System.Drawing.Color.Transparent;
            this.Password_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.Location = new System.Drawing.Point(432, 186);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(67, 22);
            this.Password_Label.TabIndex = 102;
            this.Password_Label.Text = ":סיסמא";
            // 
            // UserName_TextBox
            // 
            this.UserName_TextBox.Location = new System.Drawing.Point(245, 142);
            this.UserName_TextBox.Name = "UserName_TextBox";
            this.UserName_TextBox.Size = new System.Drawing.Size(168, 20);
            this.UserName_TextBox.TabIndex = 103;
            this.UserName_TextBox.TextChanged += new System.EventHandler(this.UserName_TextBox_TextChanged);
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Location = new System.Drawing.Point(245, 186);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(168, 20);
            this.Password_Textbox.TabIndex = 104;
            this.Password_Textbox.TextChanged += new System.EventHandler(this.Password_Textbox_TextChanged);
            // 
            // Enter_Button
            // 
            this.Enter_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Enter_Button.BackgroundImage")));
            this.Enter_Button.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_Button.Location = new System.Drawing.Point(245, 229);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(290, 44);
            this.Enter_Button.TabIndex = 105;
            this.Enter_Button.Text = "כניסה";
            this.Enter_Button.UseVisualStyleBackColor = true;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            // 
            // Show_Password
            // 
            this.Show_Password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Show_Password.BackgroundImage")));
            this.Show_Password.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_Password.Location = new System.Drawing.Point(222, 186);
            this.Show_Password.Name = "Show_Password";
            this.Show_Password.Size = new System.Drawing.Size(24, 20);
            this.Show_Password.TabIndex = 106;
            this.Show_Password.UseVisualStyleBackColor = true;
            this.Show_Password.Click += new System.EventHandler(this.Show_Password_Click);
            // 
            // Hide_Passwrod
            // 
            this.Hide_Passwrod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hide_Passwrod.BackgroundImage")));
            this.Hide_Passwrod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hide_Passwrod.Location = new System.Drawing.Point(222, 186);
            this.Hide_Passwrod.Name = "Hide_Passwrod";
            this.Hide_Passwrod.Size = new System.Drawing.Size(24, 20);
            this.Hide_Passwrod.TabIndex = 107;
            this.Hide_Passwrod.UseVisualStyleBackColor = true;
            this.Hide_Passwrod.Click += new System.EventHandler(this.Hide_Passwrod_Click);
            // 
            // Employee_Managment_CRUD
            // 
            this.Employee_Managment_CRUD.AutoSize = true;
            this.Employee_Managment_CRUD.BackColor = System.Drawing.Color.Transparent;
            this.Employee_Managment_CRUD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Employee_Managment_CRUD.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_Managment_CRUD.Location = new System.Drawing.Point(191, 27);
            this.Employee_Managment_CRUD.Name = "Employee_Managment_CRUD";
            this.Employee_Managment_CRUD.Size = new System.Drawing.Size(311, 66);
            this.Employee_Managment_CRUD.TabIndex = 108;
            this.Employee_Managment_CRUD.Text = "ברוכים הבאים";
            // 
            // exit_button
            // 
            this.exit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_button.BackgroundImage")));
            this.exit_button.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(35, 142);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(110, 131);
            this.exit_button.TabIndex = 109;
            this.exit_button.Text = "יציאה";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(646, 399);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.Employee_Managment_CRUD);
            this.Controls.Add(this.Hide_Passwrod);
            this.Controls.Add(this.Show_Password);
            this.Controls.Add(this.Enter_Button);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.UserName_TextBox);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.UserName_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox UserName_TextBox;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.Button Enter_Button;
        private System.Windows.Forms.Button Show_Password;
        private System.Windows.Forms.Button Hide_Passwrod;
        private System.Windows.Forms.Label Employee_Managment_CRUD;
        private System.Windows.Forms.Button exit_button;
    }
}