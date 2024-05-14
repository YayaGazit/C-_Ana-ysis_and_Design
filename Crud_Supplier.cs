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
    public partial class Crud_Supplier : Form
    {
        private Employee e;
        public Crud_Supplier()
        {
            InitializeComponent();
            e = Program.Search_Employee(Global.currentUser);

        }

        private void Show_Supplier_button_Click(object sender, EventArgs e)
        {
            ShowSupplier SS = new ShowSupplier();
            SS.Show();
            this.Hide();
        }

        private void AddNew_Supplier_button_Click(object sender, EventArgs e)
        {
            AddSupplier AS = new AddSupplier();
            AS.Show();
            this.Hide();
        }

        private void Show_AllSuppliers_button_Click(object sender, EventArgs e)
        {
            AllSuppliers AS = new AllSuppliers();
            this.Hide();
            AS.Show();
        }

        private void Crud_Supplier_Load(object sender, EventArgs e)
        {

        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.logistic)
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

        private void Create_Order_To_Supplier_Click(object sender, EventArgs e)
        {
            CreateOrderFromSupplier COFS = new CreateOrderFromSupplier();
            COFS.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceivedFromSupplier RFS = new ReceivedFromSupplier();
            RFS.Show();
            this.Hide();
        }
    }
}
