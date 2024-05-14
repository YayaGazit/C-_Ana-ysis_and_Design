namespace Group_27
{
    partial class setTimeForWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setTimeForWork));
            this.Customer_ID_label1 = new System.Windows.Forms.Label();
            this.Set_Standard_Time_START = new System.Windows.Forms.TextBox();
            this.Customer_ID_Label = new System.Windows.Forms.Label();
            this.Set_Standard_Time_END = new System.Windows.Forms.TextBox();
            this.Add_New_Customer_Label = new System.Windows.Forms.Label();
            this.Customer_Gender_Show_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Search_Customer_Show_Button = new System.Windows.Forms.Button();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            this.Order_ID_StepInProgress_label = new System.Windows.Forms.Label();
            this.Order_ID_StepInProgress_TextBox = new System.Windows.Forms.TextBox();
            this.ShowOrder_BackToManagment_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customer_ID_label1
            // 
            this.Customer_ID_label1.AutoSize = true;
            this.Customer_ID_label1.BackColor = System.Drawing.Color.Transparent;
            this.Customer_ID_label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Customer_ID_label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_ID_label1.Location = new System.Drawing.Point(457, 296);
            this.Customer_ID_label1.Name = "Customer_ID_label1";
            this.Customer_ID_label1.Size = new System.Drawing.Size(95, 22);
            this.Customer_ID_label1.TabIndex = 107;
            this.Customer_ID_label1.Text = ":זמן התחלה";
            // 
            // Set_Standard_Time_START
            // 
            this.Set_Standard_Time_START.Location = new System.Drawing.Point(245, 296);
            this.Set_Standard_Time_START.Name = "Set_Standard_Time_START";
            this.Set_Standard_Time_START.Size = new System.Drawing.Size(205, 20);
            this.Set_Standard_Time_START.TabIndex = 106;
            this.Set_Standard_Time_START.TextChanged += new System.EventHandler(this.Set_Standard_Time_START_TextChanged);
            // 
            // Customer_ID_Label
            // 
            this.Customer_ID_Label.AutoSize = true;
            this.Customer_ID_Label.BackColor = System.Drawing.Color.Transparent;
            this.Customer_ID_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Customer_ID_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_ID_Label.Location = new System.Drawing.Point(457, 355);
            this.Customer_ID_Label.Name = "Customer_ID_Label";
            this.Customer_ID_Label.Size = new System.Drawing.Size(74, 22);
            this.Customer_ID_Label.TabIndex = 105;
            this.Customer_ID_Label.Text = ":זמן סיום";
            // 
            // Set_Standard_Time_END
            // 
            this.Set_Standard_Time_END.Location = new System.Drawing.Point(245, 355);
            this.Set_Standard_Time_END.Name = "Set_Standard_Time_END";
            this.Set_Standard_Time_END.Size = new System.Drawing.Size(205, 20);
            this.Set_Standard_Time_END.TabIndex = 104;
            this.Set_Standard_Time_END.TextChanged += new System.EventHandler(this.Set_Standard_Time_END_TextChanged);
            // 
            // Add_New_Customer_Label
            // 
            this.Add_New_Customer_Label.AutoSize = true;
            this.Add_New_Customer_Label.BackColor = System.Drawing.Color.Transparent;
            this.Add_New_Customer_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Add_New_Customer_Label.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_Customer_Label.Location = new System.Drawing.Point(65, 44);
            this.Add_New_Customer_Label.Name = "Add_New_Customer_Label";
            this.Add_New_Customer_Label.Size = new System.Drawing.Size(466, 48);
            this.Add_New_Customer_Label.TabIndex = 108;
            this.Add_New_Customer_Label.Text = "הזנת זמן תקן לתהליך ייצור חדש";
            // 
            // Customer_Gender_Show_ComboBox
            // 
            this.Customer_Gender_Show_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Customer_Gender_Show_ComboBox.FormattingEnabled = true;
            this.Customer_Gender_Show_ComboBox.Location = new System.Drawing.Point(245, 186);
            this.Customer_Gender_Show_ComboBox.Name = "Customer_Gender_Show_ComboBox";
            this.Customer_Gender_Show_ComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Customer_Gender_Show_ComboBox.Size = new System.Drawing.Size(205, 21);
            this.Customer_Gender_Show_ComboBox.TabIndex = 109;
            this.Customer_Gender_Show_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Customer_Gender_Show_ComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 110;
            this.label1.Text = ":שלב ייצור";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 22);
            this.label2.TabIndex = 111;
            this.label2.Text = ":הזן תאריך וזמן בפורמט הבא";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 22);
            this.label3.TabIndex = 112;
            this.label3.Text = "DD/MM/YYYY HH:MM:SS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Search_Customer_Show_Button
            // 
            this.Search_Customer_Show_Button.BackColor = System.Drawing.Color.Transparent;
            this.Search_Customer_Show_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search_Customer_Show_Button.BackgroundImage")));
            this.Search_Customer_Show_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search_Customer_Show_Button.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Customer_Show_Button.Location = new System.Drawing.Point(245, 397);
            this.Search_Customer_Show_Button.Name = "Search_Customer_Show_Button";
            this.Search_Customer_Show_Button.Size = new System.Drawing.Size(205, 44);
            this.Search_Customer_Show_Button.TabIndex = 113;
            this.Search_Customer_Show_Button.Text = "הזן זמן תקן";
            this.Search_Customer_Show_Button.UseVisualStyleBackColor = false;
            this.Search_Customer_Show_Button.Click += new System.EventHandler(this.Search_Customer_Show_Button_Click);
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(510, 758);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 114;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // Order_ID_StepInProgress_label
            // 
            this.Order_ID_StepInProgress_label.AutoSize = true;
            this.Order_ID_StepInProgress_label.BackColor = System.Drawing.Color.Transparent;
            this.Order_ID_StepInProgress_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Order_ID_StepInProgress_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_ID_StepInProgress_label.Location = new System.Drawing.Point(457, 143);
            this.Order_ID_StepInProgress_label.Name = "Order_ID_StepInProgress_label";
            this.Order_ID_StepInProgress_label.Size = new System.Drawing.Size(104, 22);
            this.Order_ID_StepInProgress_label.TabIndex = 116;
            this.Order_ID_StepInProgress_label.Text = ":מזהה הזמנה";
            // 
            // Order_ID_StepInProgress_TextBox
            // 
            this.Order_ID_StepInProgress_TextBox.Location = new System.Drawing.Point(245, 143);
            this.Order_ID_StepInProgress_TextBox.Name = "Order_ID_StepInProgress_TextBox";
            this.Order_ID_StepInProgress_TextBox.Size = new System.Drawing.Size(205, 20);
            this.Order_ID_StepInProgress_TextBox.TabIndex = 115;
            this.Order_ID_StepInProgress_TextBox.TextChanged += new System.EventHandler(this.Order_ID_StepInProgress_TextBox_TextChanged);
            // 
            // ShowOrder_BackToManagment_Button
            // 
            this.ShowOrder_BackToManagment_Button.BackColor = System.Drawing.Color.Transparent;
            this.ShowOrder_BackToManagment_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowOrder_BackToManagment_Button.BackgroundImage")));
            this.ShowOrder_BackToManagment_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ShowOrder_BackToManagment_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShowOrder_BackToManagment_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ShowOrder_BackToManagment_Button.FlatAppearance.BorderSize = 50;
            this.ShowOrder_BackToManagment_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowOrder_BackToManagment_Button.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowOrder_BackToManagment_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowOrder_BackToManagment_Button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ShowOrder_BackToManagment_Button.Location = new System.Drawing.Point(510, 700);
            this.ShowOrder_BackToManagment_Button.Name = "ShowOrder_BackToManagment_Button";
            this.ShowOrder_BackToManagment_Button.Size = new System.Drawing.Size(75, 51);
            this.ShowOrder_BackToManagment_Button.TabIndex = 117;
            this.ShowOrder_BackToManagment_Button.Text = "חזור";
            this.ShowOrder_BackToManagment_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShowOrder_BackToManagment_Button.UseVisualStyleBackColor = false;
            this.ShowOrder_BackToManagment_Button.Click += new System.EventHandler(this.ShowOrder_BackToManagment_Button_Click);
            // 
            // setTimeForWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_27.Properties.Resources.רקע_לטופס;
            this.ClientSize = new System.Drawing.Size(597, 845);
            this.Controls.Add(this.ShowOrder_BackToManagment_Button);
            this.Controls.Add(this.Order_ID_StepInProgress_label);
            this.Controls.Add(this.Order_ID_StepInProgress_TextBox);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.Search_Customer_Show_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Customer_Gender_Show_ComboBox);
            this.Controls.Add(this.Add_New_Customer_Label);
            this.Controls.Add(this.Customer_ID_label1);
            this.Controls.Add(this.Set_Standard_Time_START);
            this.Controls.Add(this.Customer_ID_Label);
            this.Controls.Add(this.Set_Standard_Time_END);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "setTimeForWork";
            this.Text = "setTimeForWork";
            this.Load += new System.EventHandler(this.setTimeForWork_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Customer_ID_label1;
        private System.Windows.Forms.TextBox Set_Standard_Time_START;
        private System.Windows.Forms.Label Customer_ID_Label;
        private System.Windows.Forms.TextBox Set_Standard_Time_END;
        private System.Windows.Forms.Label Add_New_Customer_Label;
        private System.Windows.Forms.ComboBox Customer_Gender_Show_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Search_Customer_Show_Button;
        private System.Windows.Forms.Button Back_To_Home_Page;
        private System.Windows.Forms.Label Order_ID_StepInProgress_label;
        private System.Windows.Forms.TextBox Order_ID_StepInProgress_TextBox;
        private System.Windows.Forms.Button ShowOrder_BackToManagment_Button;
    }
}