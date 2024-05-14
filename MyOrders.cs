using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_27
{
    public partial class MyOrders : Form
    {
        Customer cus;
        public MyOrders()
        {
            InitializeComponent();
            cus = Program.Search_Customer(Global.currentUser);
            if (cus.get_all_orders().Count() < 1)
            {
                Order_Tracking_Button.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MyOrders_Load(object sender, EventArgs e)
        {
            foreach (Order o in Program.Orders)
            {
                if (o.get_customer().get_customerId() == cus.get_customerId())
                    dataGridView1.Rows.Add(cus.get_customerId(), o.get_OrderId(), o.get_DateReceived(), o.get_deadLine(), o.get_requirements(), o.get_startPreparationDate());
            }

        }

        private void Order_Tracking_Button_Click(object sender, EventArgs e)
        {

            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            String Orderid = dataGridView1.Rows[currentRowIndex].Cells[0].Value.ToString();

            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            string cellValue = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
            Order_Tracking OT = new Order_Tracking(cellValue);
            OT.Show();
            this.Hide();



        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            HomePage_Customers HC = new HomePage_Customers();
            HC.Show();
            this.Hide();
        }
    }
}