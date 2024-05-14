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
    public partial class HomePageProduction : Form
    {
        public HomePageProduction()
        {
            InitializeComponent();
        }

        private void Show_Product_Button_Click(object sender, EventArgs e)
        {
            AllProducts allProducts = new AllProducts();
            allProducts.Show();
            this.Hide();
        }

        private void Show_Order_Button_Click(object sender, EventArgs e)
        {
            AllOrders allOrders = new AllOrders();
            allOrders.Show();
            this.Hide();
        }

        private void ProductProcess_Mange_Button_Click(object sender, EventArgs e)
        {
            ProductionProcessManagment PPM = new ProductionProcessManagment();
            PPM.Show();
            this.Hide();
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
