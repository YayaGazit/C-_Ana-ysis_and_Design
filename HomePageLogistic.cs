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
    public partial class HomePageLogistic : Form
    {
        public HomePageLogistic()
        {
            InitializeComponent();
        }

        private void Products_CRUD_Button_Click(object sender, EventArgs e)
        {
            Crud_Product CP = new Crud_Product();
            CP.Show();
            this.Hide();
        }

        private void Suppliers_CRUD_Button_Click(object sender, EventArgs e)
        {
            Crud_Supplier CS = new Crud_Supplier();
            CS.Show();
            this.Hide();
        }

        private void All_Orders_Button_Click(object sender, EventArgs e)
        {
            AllOrders allOrders = new AllOrders();
            allOrders.Show();
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
