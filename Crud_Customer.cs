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
    public partial class Crud_Customer : Form
    {
        Employee e;
        public Crud_Customer()
        {
            InitializeComponent();
            e = Program.Search_Employee(Global.currentUser);

        }

        private void Show_Customer_button_Click(object sender, EventArgs e)
        {
            Show_Customer SC = new Show_Customer();
            SC.Show();
            this.Hide();
        }

        private void AddNew_Customer_button_Click(object sender, EventArgs e)
        {
            Add_Customer AC = new Add_Customer();
            AC.Show();
            this.Hide();
        }

        private void Show_AllCustomers_button_Click(object sender, EventArgs e)
        {
            AllCustomers AC = new AllCustomers();
            AC.Show();
            this.Hide();
        }

        private void Crud_Customer_Load(object sender, EventArgs e)
        {

        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.salesPerson)
            {
                HomePageSales HS = new HomePageSales();
                HS.Show();
                this.Hide();
            }
            else if (this.e.get_EmployeeRole() == Role.customerService)
            {
                HomePageCustomerService HS = new HomePageCustomerService();
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
    }
}
