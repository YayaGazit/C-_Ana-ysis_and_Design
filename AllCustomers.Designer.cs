namespace Group_27
{
    partial class AllCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllCustomers));
            this.Customer_toArchive_button = new System.Windows.Forms.Button();
            this.Back_ToCrud_Customers_Button = new System.Windows.Forms.Button();
            this.Add_New_Customer_Label = new System.Windows.Forms.Label();
            this.Back_CustomerToActive_Button = new System.Windows.Forms.Button();
            this.AllCustomers_DataGrid = new System.Windows.Forms.DataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isArchivedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_27DataSet3 = new Group_27.SAD_27DataSet3();
            this.Search_by_Coloumn_Customer_ComboBox = new System.Windows.Forms.TextBox();
            this.Coloumn_Customer_ComboBox = new System.Windows.Forms.ComboBox();
            this.Search_label = new System.Windows.Forms.Label();
            this.Coloumn_Label = new System.Windows.Forms.Label();
            this.customersTableAdapter = new Group_27.SAD_27DataSet3TableAdapters.CustomersTableAdapter();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllCustomers_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer_toArchive_button
            // 
            this.Customer_toArchive_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Customer_toArchive_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Customer_toArchive_button.BackgroundImage")));
            this.Customer_toArchive_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Customer_toArchive_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Customer_toArchive_button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_toArchive_button.Location = new System.Drawing.Point(890, 574);
            this.Customer_toArchive_button.Name = "Customer_toArchive_button";
            this.Customer_toArchive_button.Size = new System.Drawing.Size(140, 60);
            this.Customer_toArchive_button.TabIndex = 108;
            this.Customer_toArchive_button.Text = "העברה לארכיון";
            this.Customer_toArchive_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Customer_toArchive_button.UseVisualStyleBackColor = false;
            this.Customer_toArchive_button.Click += new System.EventHandler(this.Customer_toArchive_button_Click);
            // 
            // Back_ToCrud_Customers_Button
            // 
            this.Back_ToCrud_Customers_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_ToCrud_Customers_Button.BackgroundImage")));
            this.Back_ToCrud_Customers_Button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_ToCrud_Customers_Button.Location = new System.Drawing.Point(1088, 574);
            this.Back_ToCrud_Customers_Button.Name = "Back_ToCrud_Customers_Button";
            this.Back_ToCrud_Customers_Button.Size = new System.Drawing.Size(107, 60);
            this.Back_ToCrud_Customers_Button.TabIndex = 107;
            this.Back_ToCrud_Customers_Button.Text = "חזור";
            this.Back_ToCrud_Customers_Button.UseVisualStyleBackColor = true;
            this.Back_ToCrud_Customers_Button.Click += new System.EventHandler(this.Back_ToCrud_Customers_Button_Click);
            // 
            // Add_New_Customer_Label
            // 
            this.Add_New_Customer_Label.AutoSize = true;
            this.Add_New_Customer_Label.BackColor = System.Drawing.Color.Transparent;
            this.Add_New_Customer_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Add_New_Customer_Label.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_Customer_Label.Location = new System.Drawing.Point(485, 33);
            this.Add_New_Customer_Label.Name = "Add_New_Customer_Label";
            this.Add_New_Customer_Label.Size = new System.Drawing.Size(305, 66);
            this.Add_New_Customer_Label.TabIndex = 106;
            this.Add_New_Customer_Label.Text = "טבלת לקוחות";
            // 
            // Back_CustomerToActive_Button
            // 
            this.Back_CustomerToActive_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_CustomerToActive_Button.BackgroundImage")));
            this.Back_CustomerToActive_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Back_CustomerToActive_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_CustomerToActive_Button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_CustomerToActive_Button.Location = new System.Drawing.Point(702, 574);
            this.Back_CustomerToActive_Button.Name = "Back_CustomerToActive_Button";
            this.Back_CustomerToActive_Button.Size = new System.Drawing.Size(170, 60);
            this.Back_CustomerToActive_Button.TabIndex = 105;
            this.Back_CustomerToActive_Button.Text = "החזרה ללקוח פעיל";
            this.Back_CustomerToActive_Button.UseVisualStyleBackColor = true;
            this.Back_CustomerToActive_Button.Click += new System.EventHandler(this.Back_CustomerToActive_Button_Click);
            // 
            // AllCustomers_DataGrid
            // 
            this.AllCustomers_DataGrid.AllowUserToAddRows = false;
            this.AllCustomers_DataGrid.AllowUserToDeleteRows = false;
            this.AllCustomers_DataGrid.AutoGenerateColumns = false;
            this.AllCustomers_DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllCustomers_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllCustomers_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerPasswordDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.isArchivedDataGridViewCheckBoxColumn});
            this.AllCustomers_DataGrid.DataSource = this.customersBindingSource;
            this.AllCustomers_DataGrid.Location = new System.Drawing.Point(51, 188);
            this.AllCustomers_DataGrid.Name = "AllCustomers_DataGrid";
            this.AllCustomers_DataGrid.ReadOnly = true;
            this.AllCustomers_DataGrid.Size = new System.Drawing.Size(1144, 366);
            this.AllCustomers_DataGrid.TabIndex = 104;
            this.AllCustomers_DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllCustomers_DataGrid_CellContentClick);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "Customer Id";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company Name";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            this.customerAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerPasswordDataGridViewTextBoxColumn
            // 
            this.customerPasswordDataGridViewTextBoxColumn.DataPropertyName = "CustomerPassword";
            this.customerPasswordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.customerPasswordDataGridViewTextBoxColumn.Name = "customerPasswordDataGridViewTextBoxColumn";
            this.customerPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isArchivedDataGridViewCheckBoxColumn
            // 
            this.isArchivedDataGridViewCheckBoxColumn.DataPropertyName = "IsArchived";
            this.isArchivedDataGridViewCheckBoxColumn.HeaderText = "IsArchived";
            this.isArchivedDataGridViewCheckBoxColumn.Name = "isArchivedDataGridViewCheckBoxColumn";
            this.isArchivedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.sAD_27DataSet3;
            // 
            // sAD_27DataSet3
            // 
            this.sAD_27DataSet3.DataSetName = "SAD_27DataSet3";
            this.sAD_27DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Search_by_Coloumn_Customer_ComboBox
            // 
            this.Search_by_Coloumn_Customer_ComboBox.Location = new System.Drawing.Point(902, 148);
            this.Search_by_Coloumn_Customer_ComboBox.Name = "Search_by_Coloumn_Customer_ComboBox";
            this.Search_by_Coloumn_Customer_ComboBox.Size = new System.Drawing.Size(167, 20);
            this.Search_by_Coloumn_Customer_ComboBox.TabIndex = 103;
            this.Search_by_Coloumn_Customer_ComboBox.TextChanged += new System.EventHandler(this.Search_by_Coloumn_Customer_ComboBox_TextChanged);
            this.Search_by_Coloumn_Customer_ComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_by_Coloumn_Customer_ComboBox_KeyDown);
            // 
            // Coloumn_Customer_ComboBox
            // 
            this.Coloumn_Customer_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Coloumn_Customer_ComboBox.FormattingEnabled = true;
            this.Coloumn_Customer_ComboBox.Items.AddRange(new object[] {
            "customerID",
            "firstName",
            "lastName",
            "companyName",
            "email",
            "phoneNumber",
            "birthdate",
            "customerAddress",
            "customerPassword",
            "gender",
            "isArchived"});
            this.Coloumn_Customer_ComboBox.Location = new System.Drawing.Point(902, 115);
            this.Coloumn_Customer_ComboBox.Name = "Coloumn_Customer_ComboBox";
            this.Coloumn_Customer_ComboBox.Size = new System.Drawing.Size(167, 21);
            this.Coloumn_Customer_ComboBox.TabIndex = 102;
            this.Coloumn_Customer_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Coloumn_Customer_ComboBox_SelectedIndexChanged);
            // 
            // Search_label
            // 
            this.Search_label.AutoSize = true;
            this.Search_label.BackColor = System.Drawing.Color.Transparent;
            this.Search_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_label.Location = new System.Drawing.Point(1110, 148);
            this.Search_label.Name = "Search_label";
            this.Search_label.Size = new System.Drawing.Size(65, 22);
            this.Search_label.TabIndex = 101;
            this.Search_label.Text = ":חיפוש ";
            // 
            // Coloumn_Label
            // 
            this.Coloumn_Label.AutoSize = true;
            this.Coloumn_Label.BackColor = System.Drawing.Color.Transparent;
            this.Coloumn_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coloumn_Label.Location = new System.Drawing.Point(1084, 115);
            this.Coloumn_Label.Name = "Coloumn_Label";
            this.Coloumn_Label.Size = new System.Drawing.Size(112, 22);
            this.Coloumn_Label.TabIndex = 100;
            this.Coloumn_Label.Text = ":בחירת עמודה";
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(1215, 631);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 111;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // AllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1302, 718);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.Customer_toArchive_button);
            this.Controls.Add(this.Back_ToCrud_Customers_Button);
            this.Controls.Add(this.Add_New_Customer_Label);
            this.Controls.Add(this.Back_CustomerToActive_Button);
            this.Controls.Add(this.AllCustomers_DataGrid);
            this.Controls.Add(this.Search_by_Coloumn_Customer_ComboBox);
            this.Controls.Add(this.Coloumn_Customer_ComboBox);
            this.Controls.Add(this.Search_label);
            this.Controls.Add(this.Coloumn_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllCustomers";
            this.Text = "AllCustomers";
            this.Load += new System.EventHandler(this.AllCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllCustomers_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_27DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Customer_toArchive_button;
        private System.Windows.Forms.Button Back_ToCrud_Customers_Button;
        private System.Windows.Forms.Label Add_New_Customer_Label;
        private System.Windows.Forms.Button Back_CustomerToActive_Button;
        private System.Windows.Forms.DataGridView AllCustomers_DataGrid;
        private System.Windows.Forms.TextBox Search_by_Coloumn_Customer_ComboBox;
        private System.Windows.Forms.ComboBox Coloumn_Customer_ComboBox;
        private System.Windows.Forms.Label Search_label;
        private System.Windows.Forms.Label Coloumn_Label;
        private SAD_27DataSet3 sAD_27DataSet3;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private SAD_27DataSet3TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isArchivedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button Back_To_Home_Page;
    }
}