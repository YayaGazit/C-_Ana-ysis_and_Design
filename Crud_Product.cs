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
    public partial class Crud_Product : Form
    {
        Employee e;
        public Crud_Product()
        {
            InitializeComponent();
            e = Program.Search_Employee(Global.currentUser);

        }

        private void Show_Product_button_Click(object sender, EventArgs e)
        {
           Show_Product SP = new Show_Product();
            SP.Show();
            this.Hide();
        }

        private void Show_AllProduct_button_Click(object sender, EventArgs e)
        {
            AllProducts AP = new AllProducts();
            AP.Show();
            this.Hide();
        }

        private void AddNew_Product_button_Click(object sender, EventArgs e)
        {
            AddProduct AP = new AddProduct();
            AP.Show();
            this.Hide();
        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
          
             if (this.e.get_EmployeeRole() == Role.storeKeeper)
            {
                HomePageStoreKeeper HS = new HomePageStoreKeeper();
                HS.Show();
                this.Hide();
            }
            else if (this.e.get_EmployeeRole() == Role.logistic)
            {
                HomePageLogistic HL = new HomePageLogistic();
                HL.Show();
                this.Hide();
            }

            else
            {
                HomePageManagers HM = new HomePageManagers();
                HM.Show();
                this.Hide();
            }
        }

        private void Crud_Product_Load(object sender, EventArgs e)
        {

        }
    }
}
