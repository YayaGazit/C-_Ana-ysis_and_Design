namespace Group_27
{
    partial class MyOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyOrders));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requirements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartPreperationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyOrders_Customer_Label = new System.Windows.Forms.Label();
            this.Order_Tracking_Button = new System.Windows.Forms.Button();
            this.Back_To_Home_Page = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.OrderId,
            this.ReceivedDate,
            this.DeadLine,
            this.Requirements,
            this.StartPreperationDate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "OrderId";
            this.OrderId.Name = "OrderId";
            // 
            // ReceivedDate
            // 
            this.ReceivedDate.HeaderText = "ReceivedDate";
            this.ReceivedDate.Name = "ReceivedDate";
            // 
            // DeadLine
            // 
            this.DeadLine.HeaderText = "DeadLine";
            this.DeadLine.Name = "DeadLine";
            // 
            // Requirements
            // 
            this.Requirements.HeaderText = "Requirements";
            this.Requirements.Name = "Requirements";
            // 
            // StartPreperationDate
            // 
            this.StartPreperationDate.HeaderText = "PreperationDate";
            this.StartPreperationDate.Name = "StartPreperationDate";
            // 
            // MyOrders_Customer_Label
            // 
            this.MyOrders_Customer_Label.AutoSize = true;
            this.MyOrders_Customer_Label.BackColor = System.Drawing.Color.Transparent;
            this.MyOrders_Customer_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MyOrders_Customer_Label.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyOrders_Customer_Label.Location = new System.Drawing.Point(215, 50);
            this.MyOrders_Customer_Label.Name = "MyOrders_Customer_Label";
            this.MyOrders_Customer_Label.Size = new System.Drawing.Size(288, 66);
            this.MyOrders_Customer_Label.TabIndex = 107;
            this.MyOrders_Customer_Label.Text = "ההזמנות שלי";
            // 
            // Order_Tracking_Button
            // 
            this.Order_Tracking_Button.BackColor = System.Drawing.Color.Transparent;
            this.Order_Tracking_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Order_Tracking_Button.BackgroundImage")));
            this.Order_Tracking_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Order_Tracking_Button.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Tracking_Button.Location = new System.Drawing.Point(12, 367);
            this.Order_Tracking_Button.Name = "Order_Tracking_Button";
            this.Order_Tracking_Button.Size = new System.Drawing.Size(643, 77);
            this.Order_Tracking_Button.TabIndex = 108;
            this.Order_Tracking_Button.Text = "מעקב אחר הזמנה";
            this.Order_Tracking_Button.UseVisualStyleBackColor = false;
            this.Order_Tracking_Button.Click += new System.EventHandler(this.Order_Tracking_Button_Click);
            // 
            // Back_To_Home_Page
            // 
            this.Back_To_Home_Page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_To_Home_Page.BackgroundImage")));
            this.Back_To_Home_Page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_To_Home_Page.Location = new System.Drawing.Point(660, 634);
            this.Back_To_Home_Page.Name = "Back_To_Home_Page";
            this.Back_To_Home_Page.Size = new System.Drawing.Size(75, 75);
            this.Back_To_Home_Page.TabIndex = 109;
            this.Back_To_Home_Page.UseVisualStyleBackColor = true;
            this.Back_To_Home_Page.Click += new System.EventHandler(this.Back_To_Home_Page_Click);
            // 
            // MyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(747, 721);
            this.Controls.Add(this.Back_To_Home_Page);
            this.Controls.Add(this.Order_Tracking_Button);
            this.Controls.Add(this.MyOrders_Customer_Label);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyOrders";
            this.Text = "MyOrders";
            this.Load += new System.EventHandler(this.MyOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label MyOrders_Customer_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requirements;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartPreperationDate;
        private System.Windows.Forms.Button Order_Tracking_Button;
        private System.Windows.Forms.Button Back_To_Home_Page;
    }
}