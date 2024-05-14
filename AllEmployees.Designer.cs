namespace Group_27
{
    partial class AllEmployees
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllEmployees));
            this.Coloumn_Label = new System.Windows.Forms.Label();
            this.Search_label = new System.Windows.Forms.Label();
            this.Coloumn_ComboBox = new System.Windows.Forms.ComboBox();
            this.AllEmployess_DataGrid = new System.Windows.Forms.DataGridView();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isArchivedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_27DataSet = new Group_27.SAD_27DataSet();
            this.employeesTableAdapter = new Group_27.SAD_27DataSetTableAdapters.EmployeesTableAdapter();
            this.Search_by_Coloumn_ComboBox = new System.Windows.Forms.TextBox();
            this.Back_EmployeeToActive_Button = new System.Windows.Forms.Button();
            this.Add_New_Product_Label = new System.Windows.Forms.Label();
            this.Back_ToCrud_Button = new System.Windows.Forms.Button();
            this.Employee_toArchive_button = new System.Windows.Forms.Button();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployess_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Coloumn_Label
            // 
            this.Coloumn_Label.AutoSize = true;
            this.Coloumn_Label.BackColor = System.Drawing.Color.Transparent;
            this.Coloumn_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coloumn_Label.Location = new System.Drawing.Point(1017, 131);
            this.Coloumn_Label.Name = "Coloumn_Label";
            this.Coloumn_Label.Size = new System.Drawing.Size(112, 22);
            this.Coloumn_Label.TabIndex = 0;
            this.Coloumn_Label.Text = ":בחירת עמודה";
            // 
            // Search_label
            // 
            this.Search_label.AutoSize = true;
            this.Search_label.BackColor = System.Drawing.Color.Transparent;
            this.Search_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_label.Location = new System.Drawing.Point(1043, 164);
            this.Search_label.Name = "Search_label";
            this.Search_label.Size = new System.Drawing.Size(65, 22);
            this.Search_label.TabIndex = 1;
            this.Search_label.Text = ":חיפוש ";
            // 
            // Coloumn_ComboBox
            // 
            this.Coloumn_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Coloumn_ComboBox.FormattingEnabled = true;
            this.Coloumn_ComboBox.Items.AddRange(new object[] {
            "EmployeeID",
            "FirstName",
            "LastName",
            "EmployeeRole",
            "Email",
            "EmployeePassword",
            "Gender",
            "JoinDate",
            "Salary",
            "IsArchived"});
            this.Coloumn_ComboBox.Location = new System.Drawing.Point(835, 131);
            this.Coloumn_ComboBox.Name = "Coloumn_ComboBox";
            this.Coloumn_ComboBox.Size = new System.Drawing.Size(167, 21);
            this.Coloumn_ComboBox.TabIndex = 2;
            this.Coloumn_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Coloumn_ComboBox_SelectedIndexChanged);
            // 
            // AllEmployess_DataGrid
            // 
            this.AllEmployess_DataGrid.AllowUserToAddRows = false;
            this.AllEmployess_DataGrid.AllowUserToDeleteRows = false;
            this.AllEmployess_DataGrid.AutoGenerateColumns = false;
            this.AllEmployess_DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllEmployess_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllEmployess_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.employeeRoleDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.employeePasswordDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.joinDateDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.isArchivedDataGridViewCheckBoxColumn});
            this.AllEmployess_DataGrid.DataSource = this.employeesBindingSource;
            this.AllEmployess_DataGrid.Location = new System.Drawing.Point(72, 205);
            this.AllEmployess_DataGrid.Name = "AllEmployess_DataGrid";
            this.AllEmployess_DataGrid.ReadOnly = true;
            this.AllEmployess_DataGrid.Size = new System.Drawing.Size(1046, 366);
            this.AllEmployess_DataGrid.TabIndex = 4;
            this.AllEmployess_DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllEmployess_DataGrid_CellContentClick);
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeRoleDataGridViewTextBoxColumn
            // 
            this.employeeRoleDataGridViewTextBoxColumn.DataPropertyName = "EmployeeRole";
            this.employeeRoleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.employeeRoleDataGridViewTextBoxColumn.Name = "employeeRoleDataGridViewTextBoxColumn";
            this.employeeRoleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeePasswordDataGridViewTextBoxColumn
            // 
            this.employeePasswordDataGridViewTextBoxColumn.DataPropertyName = "EmployeePassword";
            this.employeePasswordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.employeePasswordDataGridViewTextBoxColumn.Name = "employeePasswordDataGridViewTextBoxColumn";
            this.employeePasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // joinDateDataGridViewTextBoxColumn
            // 
            this.joinDateDataGridViewTextBoxColumn.DataPropertyName = "JoinDate";
            this.joinDateDataGridViewTextBoxColumn.HeaderText = "Join Date";
            this.joinDateDataGridViewTextBoxColumn.Name = "joinDateDataGridViewTextBoxColumn";
            this.joinDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isArchivedDataGridViewCheckBoxColumn
            // 
            this.isArchivedDataGridViewCheckBoxColumn.DataPropertyName = "IsArchived";
            this.isArchivedDataGridViewCheckBoxColumn.HeaderText = "Is Archived";
            this.isArchivedDataGridViewCheckBoxColumn.Name = "isArchivedDataGridViewCheckBoxColumn";
            this.isArchivedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.sAD_27DataSet;
            // 
            // sAD_27DataSet
            // 
            this.sAD_27DataSet.DataSetName = "SAD_27DataSet";
            this.sAD_27DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Search_by_Coloumn_ComboBox
            // 
            this.Search_by_Coloumn_ComboBox.Location = new System.Drawing.Point(835, 164);
            this.Search_by_Coloumn_ComboBox.Name = "Search_by_Coloumn_ComboBox";
            this.Search_by_Coloumn_ComboBox.Size = new System.Drawing.Size(167, 20);
            this.Search_by_Coloumn_ComboBox.TabIndex = 3;
            this.Search_by_Coloumn_ComboBox.TextChanged += new System.EventHandler(this.Search_by_Coloumn_ComboBox_TextChanged);
            this.Search_by_Coloumn_ComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_by_Coloumn_ComboBox_KeyDown);
            // 
            // Back_EmployeeToActive_Button
            // 
            this.Back_EmployeeToActive_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_EmployeeToActive_Button.BackgroundImage")));
            this.Back_EmployeeToActive_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Back_EmployeeToActive_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_EmployeeToActive_Button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_EmployeeToActive_Button.Location = new System.Drawing.Point(530, 586);
            this.Back_EmployeeToActive_Button.Name = "Back_EmployeeToActive_Button";
            this.Back_EmployeeToActive_Button.Size = new System.Drawing.Size(170, 60);
            this.Back_EmployeeToActive_Button.TabIndex = 5;
            this.Back_EmployeeToActive_Button.Text = "החזרה לעובד פעיל";
            this.Back_EmployeeToActive_Button.UseVisualStyleBackColor = true;
            this.Back_EmployeeToActive_Button.Click += new System.EventHandler(this.Back_EmployeeToActive_Button_Click);
            // 
            // Add_New_Product_Label
            // 
            this.Add_New_Product_Label.AutoSize = true;
            this.Add_New_Product_Label.BackColor = System.Drawing.Color.Transparent;
            this.Add_New_Product_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Add_New_Product_Label.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_Product_Label.Location = new System.Drawing.Point(491, 41);
            this.Add_New_Product_Label.Name = "Add_New_Product_Label";
            this.Add_New_Product_Label.Size = new System.Drawing.Size(293, 66);
            this.Add_New_Product_Label.TabIndex = 97;
            this.Add_New_Product_Label.Text = "טבלת עובדים";
            // 
            // Back_ToCrud_Button
            // 
            this.Back_ToCrud_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_ToCrud_Button.BackgroundImage")));
            this.Back_ToCrud_Button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_ToCrud_Button.Location = new System.Drawing.Point(1011, 586);
            this.Back_ToCrud_Button.Name = "Back_ToCrud_Button";
            this.Back_ToCrud_Button.Size = new System.Drawing.Size(107, 60);
            this.Back_ToCrud_Button.TabIndex = 98;
            this.Back_ToCrud_Button.Text = "חזור";
            this.Back_ToCrud_Button.UseVisualStyleBackColor = true;
            this.Back_ToCrud_Button.Click += new System.EventHandler(this.Back_ToCrud_Button_Click);
            // 
            // Employee_toArchive_button
            // 
            this.Employee_toArchive_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Employee_toArchive_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Employee_toArchive_button.BackgroundImage")));
            this.Employee_toArchive_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Employee_toArchive_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employee_toArchive_button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_toArchive_button.Location = new System.Drawing.Point(718, 586);
            this.Employee_toArchive_button.Name = "Employee_toArchive_button";
            this.Employee_toArchive_button.Size = new System.Drawing.Size(140, 60);
            this.Employee_toArchive_button.TabIndex = 99;
            this.Employee_toArchive_button.Text = "העברה לארכיון";
            this.Employee_toArchive_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Employee_toArchive_button.UseVisualStyleBackColor = false;
            this.Employee_toArchive_button.Click += new System.EventHandler(this.Employee_toArchive_button_Click);
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(1161, 627);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 111;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // AllEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1248, 714);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.Employee_toArchive_button);
            this.Controls.Add(this.Back_ToCrud_Button);
            this.Controls.Add(this.Add_New_Product_Label);
            this.Controls.Add(this.Back_EmployeeToActive_Button);
            this.Controls.Add(this.AllEmployess_DataGrid);
            this.Controls.Add(this.Search_by_Coloumn_ComboBox);
            this.Controls.Add(this.Coloumn_ComboBox);
            this.Controls.Add(this.Search_label);
            this.Controls.Add(this.Coloumn_Label);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllEmployees";
            this.Text = "AllEmployees";
            this.Load += new System.EventHandler(this.AllEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployess_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Coloumn_Label;
        private System.Windows.Forms.Label Search_label;
        private System.Windows.Forms.ComboBox Coloumn_ComboBox;
        private System.Windows.Forms.DataGridView AllEmployess_DataGrid;
        private SAD_27DataSet sAD_27DataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private SAD_27DataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isArchivedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox Search_by_Coloumn_ComboBox;
        private System.Windows.Forms.Button Back_EmployeeToActive_Button;
        private System.Windows.Forms.Label Add_New_Product_Label;
        private System.Windows.Forms.Button Back_ToCrud_Button;
        private System.Windows.Forms.Button Employee_toArchive_button;
        private System.Windows.Forms.Button Back_To_Home_Page;
    }
}