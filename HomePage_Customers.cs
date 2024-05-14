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
    public partial class HomePage_Customers : Form
    {
        public HomePage_Customers()
        {
            Customer cus = Program.Search_Customer(Global.currentUser);
            InitializeComponent();
        }

        private void HomePage_Customers_Load(object sender, EventArgs e)
        {
            
        }

        private void Track_On_Order_Click(object sender, EventArgs e)
        {
           MyOrders MO = new MyOrders();
            MO.Show();
            this.Hide();
        }

        private void Update_MyDits_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Button_Click(object sender, EventArgs e)
        {
            {
                Global.currentUser = null;
                this.Close();
                Login log = new Login();
                log.Show();
            }
        }
    }
}
