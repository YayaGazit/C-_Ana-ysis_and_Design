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
    public partial class OrderManagment : Form
    {
        private Employee e;
        public OrderManagment()
        {
            InitializeComponent();
            e = Program.Search_Employee(Global.currentUser);

        }

        private void OrderManagment_button_Click(object sender, EventArgs e)
        {
            Show_Order SO = new Show_Order();
            SO.Show();
            this.Hide();
        }

        private void AddNew_Order_button_Click(object sender, EventArgs e)
        {
            Add_Order AD = new Add_Order();
            AD.Show();
            this.Hide();
        }

        private void Show_AllOrders_button_Click(object sender, EventArgs e)
        {
            AllOrders AO = new AllOrders();
            AO.Show();
            this.Hide();
        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.salesPerson)
            {
                HomePageSales HS = new HomePageSales();
                HS.Show();
                this.Hide();
            }

            else
            {
                HomePageManagers HM = new HomePageManagers();
                HM.Show();
                this.Hide();
            }
        }

        private void OrderManagment_Load(object sender, EventArgs e)
        {

        }
    }
}
