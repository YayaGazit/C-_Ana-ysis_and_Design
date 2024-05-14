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
    public partial class Order_Tracking : Form
    {
        Customer cus;
        Order o;
        public Order_Tracking(string Orderid)
        {
            InitializeComponent();
            o = Program.Search_Order(Orderid);
            label5.Hide();
            V1_Picture.Hide();
            V2_Picture.Hide();
            V3_Picture.Hide();
            V4_Picture.Hide();
            V5_Picture.Hide();
            Arrow1.Hide();
            Arrow2.Hide();
            Arrow3.Hide();
            Arrow4.Hide();
            Arrow5.Hide();
            cancel_order_Label.Hide();
            if (o.get_status().ToString().Equals("waitingForProducts") || (o.get_status().ToString().Equals("orderAnalayze"))) 
            {
                Arrow1.Show();
            }
            else if (o.get_status().ToString().Equals("inProductionProcess")) 
            {
               
                Arrow2.Show();
                V1_Picture.Show();
            }
            else if (o.get_status().ToString().Equals("assembling")|| o.get_status().ToString().Equals("inQA"))
            {
                Arrow3.Show();
                V1_Picture.Show();
                V2_Picture.Show();
            }
            else if (o.get_status().ToString().Equals("packeging"))
            {
                Arrow4.Show();
                V1_Picture.Show();
                V2_Picture.Show();
                V3_Picture.Show();
            }
            else if (o.get_status().ToString().Equals("inDelivery"))
            {
                Arrow5.Show();
                V1_Picture.Show();
                V2_Picture.Show();
                V3_Picture.Show();
                V4_Picture.Show();
            }
            else if (o.get_status().ToString().Equals("done"))
            {
                V1_Picture.Show();
                V2_Picture.Show();
                V3_Picture.Show();
                V4_Picture.Show();
                V5_Picture.Show();
                label5.Show();
            }
            else if (o.get_status().ToString().Equals("inInventory"))
            {
                V1_Picture.Hide();
                V2_Picture.Hide();
                V3_Picture.Hide();
                V4_Picture.Hide();
                V5_Picture.Hide();
                Arrow1.Hide();
                Arrow2.Hide();
                Arrow3.Hide();
                Arrow4.Hide();
                Arrow5.Hide();
                cancel_order_Label.Show();

            }


        }

        private void Order_Tracking_Load(object sender, EventArgs e)
        {

        }

        private void V1_Picture_Click(object sender, EventArgs e)
        {
          
        }

        private void V2_Picture_Click(object sender, EventArgs e)
        {

        }

        private void V3_Picture_Click(object sender, EventArgs e)
        {

        }

        private void V4_Picture_Click(object sender, EventArgs e)
        {

        }

        private void V5_Picture_Click(object sender, EventArgs e)
        {

        }

        private void Arrow1_Click(object sender, EventArgs e)
        {

        }

        private void Arrow2_Click(object sender, EventArgs e)
        {

        }

        private void Arrow3_Click(object sender, EventArgs e)
        {

        }

        private void Arrow4_Click(object sender, EventArgs e)
        {

        }

        private void Arrow5_Click(object sender, EventArgs e)
        {

        }

        private void backToOrderManagment_Click(object sender, EventArgs e)
        {
            MyOrders MO = new MyOrders();
            MO.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            HomePage_Customers HC = new HomePage_Customers();
            HC.Show();
            this.Hide();
        }

        private void cancel_order_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
