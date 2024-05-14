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
    public partial class HomePageManagers : Form
    {
        private Employee Manager;
        public HomePageManagers()
        {
            InitializeComponent();
            this.Manager = Program.Search_Employee(Global.currentUser);

        }

        private void Employee_CRUD_Button_Click(object sender, EventArgs e)
        {
            Crud_Employee CE = new Crud_Employee();
            CE.Show();
            this.Hide();
        }

        private void Orders_Managment_Button_Click(object sender, EventArgs e)
        {
            OrderManagment OM = new OrderManagment();
            OM.Show();
            this.Hide();
        }

        private void ProductProcess_Mange_Button_Click(object sender, EventArgs e)
        {
            ProductionProcessManagment PPM = new ProductionProcessManagment();
            PPM.Show();
            this.Hide();
        }

        private void Customers_CRUD_Button_Click(object sender, EventArgs e)
        {
            Crud_Customer CC = new Crud_Customer();
            CC.Show();
            this.Hide();
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

        private void HomePageManagers_Load(object sender, EventArgs e)
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
