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
    public partial class HomePageStoreKeeper : Form
    {
        public HomePageStoreKeeper()
        {
            InitializeComponent();
        }

        private void Products_CRUD_Button_Click(object sender, EventArgs e)
        {
            Crud_Product CP = new Crud_Product();
            CP.Show();
            this.Hide();
        }

        private void Create_OFS_Button_Click(object sender, EventArgs e)
        {
            CreateOrderFromSupplier COFS = new CreateOrderFromSupplier();
            COFS.Show();
            this.Hide();
        }

        private void AllSuppliers_Button_Click(object sender, EventArgs e)
        {
            AllSuppliers AS = new AllSuppliers();
            AS.Show();
            this.Hide();
        }

        private void AllOrders_button_Click(object sender, EventArgs e)
        {
            AllOrders allOrders = new AllOrders();
            allOrders.Show();
            this.Hide();
        }

        private void HomePageStoreKeeper_Load(object sender, EventArgs e)
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
