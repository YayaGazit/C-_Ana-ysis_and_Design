namespace Group_27
{
    partial class StandardTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardTime));
            this.Add_New_Supplier_Label = new System.Windows.Forms.Label();
            this.Standrardtime_label = new System.Windows.Forms.Label();
            this.Supplier_ID_Label = new System.Windows.Forms.Label();
            this.Standrardtime_TextBox = new System.Windows.Forms.TextBox();
            this.Calc_Standrad_Time_Button = new System.Windows.Forms.Button();
            this.StepName_ComboBox = new System.Windows.Forms.ComboBox();
            this.STDV_label = new System.Windows.Forms.Label();
            this.STDV_TextBox = new System.Windows.Forms.TextBox();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            this.ShowOrder_BackToManagment_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_New_Supplier_Label
            // 
            this.Add_New_Supplier_Label.AutoSize = true;
            this.Add_New_Supplier_Label.BackColor = System.Drawing.Color.Transparent;
            this.Add_New_Supplier_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Add_New_Supplier_Label.Font = new System.Drawing.Font("Microsoft YaHei", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_Supplier_Label.Location = new System.Drawing.Point(8, 27);
            this.Add_New_Supplier_Label.Name = "Add_New_Supplier_Label";
            this.Add_New_Supplier_Label.Size = new System.Drawing.Size(577, 59);
            this.Add_New_Supplier_Label.TabIndex = 108;
            this.Add_New_Supplier_Label.Text = "חישוב זמן וסטיית תקן לתהליך";
            this.Add_New_Supplier_Label.Click += new System.EventHandler(this.Add_New_Supplier_Label_Click);
            // 
            // Standrardtime_label
            // 
            this.Standrardtime_label.AutoSize = true;
            this.Standrardtime_label.BackColor = System.Drawing.Color.Transparent;
            this.Standrardtime_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Standrardtime_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Standrardtime_label.Location = new System.Drawing.Point(404, 213);
            this.Standrardtime_label.Name = "Standrardtime_label";
            this.Standrardtime_label.Size = new System.Drawing.Size(128, 22);
            this.Standrardtime_label.TabIndex = 106;
            this.Standrardtime_label.Text = ":זמן תקן לתהליך";
            // 
            // Supplier_ID_Label
            // 
            this.Supplier_ID_Label.AutoSize = true;
            this.Supplier_ID_Label.BackColor = System.Drawing.Color.Transparent;
            this.Supplier_ID_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supplier_ID_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_ID_Label.Location = new System.Drawing.Point(404, 150);
            this.Supplier_ID_Label.Name = "Supplier_ID_Label";
            this.Supplier_ID_Label.Size = new System.Drawing.Size(99, 22);
            this.Supplier_ID_Label.TabIndex = 105;
            this.Supplier_ID_Label.Text = ":תהליך ייצור";
            // 
            // Standrardtime_TextBox
            // 
            this.Standrardtime_TextBox.Location = new System.Drawing.Point(198, 213);
            this.Standrardtime_TextBox.Name = "Standrardtime_TextBox";
            this.Standrardtime_TextBox.Size = new System.Drawing.Size(181, 20);
            this.Standrardtime_TextBox.TabIndex = 103;
            this.Standrardtime_TextBox.TextChanged += new System.EventHandler(this.Standrardtime_TextBox_TextChanged);
            // 
            // Calc_Standrad_Time_Button
            // 
            this.Calc_Standrad_Time_Button.BackColor = System.Drawing.Color.Silver;
            this.Calc_Standrad_Time_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calc_Standrad_Time_Button.BackgroundImage")));
            this.Calc_Standrad_Time_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Calc_Standrad_Time_Button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calc_Standrad_Time_Button.Location = new System.Drawing.Point(200, 350);
            this.Calc_Standrad_Time_Button.Name = "Calc_Standrad_Time_Button";
            this.Calc_Standrad_Time_Button.Size = new System.Drawing.Size(355, 55);
            this.Calc_Standrad_Time_Button.TabIndex = 102;
            this.Calc_Standrad_Time_Button.Text = "חישוב זמן תקן";
            this.Calc_Standrad_Time_Button.UseVisualStyleBackColor = false;
            this.Calc_Standrad_Time_Button.Click += new System.EventHandler(this.Calc_Standrad_Time_Button_Click);
            // 
            // StepName_ComboBox
            // 
            this.StepName_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StepName_ComboBox.FormattingEnabled = true;
            this.StepName_ComboBox.Location = new System.Drawing.Point(200, 153);
            this.StepName_ComboBox.Name = "StepName_ComboBox";
            this.StepName_ComboBox.Size = new System.Drawing.Size(179, 21);
            this.StepName_ComboBox.TabIndex = 112;
            this.StepName_ComboBox.SelectedIndexChanged += new System.EventHandler(this.StepName_ComboBox_SelectedIndexChanged);
            // 
            // STDV_label
            // 
            this.STDV_label.AutoSize = true;
            this.STDV_label.BackColor = System.Drawing.Color.Transparent;
            this.STDV_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.STDV_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STDV_label.Location = new System.Drawing.Point(404, 286);
            this.STDV_label.Name = "STDV_label";
            this.STDV_label.Size = new System.Drawing.Size(151, 22);
            this.STDV_label.TabIndex = 114;
            this.STDV_label.Text = ":סטיית תקן לתהליך";
            // 
            // STDV_TextBox
            // 
            this.STDV_TextBox.Location = new System.Drawing.Point(198, 286);
            this.STDV_TextBox.Name = "STDV_TextBox";
            this.STDV_TextBox.Size = new System.Drawing.Size(181, 20);
            this.STDV_TextBox.TabIndex = 113;
            this.STDV_TextBox.TextChanged += new System.EventHandler(this.STDV_TextBox_TextChanged);
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(506, 756);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 116;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
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
            this.ShowOrder_BackToManagment_Button.Location = new System.Drawing.Point(507, 698);
            this.ShowOrder_BackToManagment_Button.Name = "ShowOrder_BackToManagment_Button";
            this.ShowOrder_BackToManagment_Button.Size = new System.Drawing.Size(75, 51);
            this.ShowOrder_BackToManagment_Button.TabIndex = 126;
            this.ShowOrder_BackToManagment_Button.Text = "חזור";
            this.ShowOrder_BackToManagment_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShowOrder_BackToManagment_Button.UseVisualStyleBackColor = false;
            this.ShowOrder_BackToManagment_Button.Click += new System.EventHandler(this.ShowOrder_BackToManagment_Button_Click);
            // 
            // StandardTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_27.Properties.Resources.רקע_לטופס;
            this.ClientSize = new System.Drawing.Size(593, 843);
            this.Controls.Add(this.ShowOrder_BackToManagment_Button);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.STDV_label);
            this.Controls.Add(this.STDV_TextBox);
            this.Controls.Add(this.StepName_ComboBox);
            this.Controls.Add(this.Add_New_Supplier_Label);
            this.Controls.Add(this.Standrardtime_label);
            this.Controls.Add(this.Supplier_ID_Label);
            this.Controls.Add(this.Standrardtime_TextBox);
            this.Controls.Add(this.Calc_Standrad_Time_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StandardTime";
            this.Text = "StandardTime";
            this.Load += new System.EventHandler(this.StandardTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Add_New_Supplier_Label;
        private System.Windows.Forms.Label Standrardtime_label;
        private System.Windows.Forms.Label Supplier_ID_Label;
        private System.Windows.Forms.TextBox Standrardtime_TextBox;
        private System.Windows.Forms.Button Calc_Standrad_Time_Button;
        private System.Windows.Forms.ComboBox StepName_ComboBox;
        private System.Windows.Forms.Label STDV_label;
        private System.Windows.Forms.TextBox STDV_TextBox;
        private System.Windows.Forms.Button Back_To_Home_Page;
        private System.Windows.Forms.Button ShowOrder_BackToManagment_Button;
    }
}