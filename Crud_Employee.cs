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
    public partial class Crud_Employee : Form
    {
        private Employee e;
        public Crud_Employee()
        {
            InitializeComponent();
            e = Program.Search_Employee(Global.currentUser);

        }

        private void Show_Employee_button_Click(object sender, EventArgs e)
        {
            Show_Employee SE = new Show_Employee();
            SE.Show();
            this.Hide();
        }

        private void AddNew_Employee_button_Click(object sender, EventArgs e)
        {
            AddEmployee AE = new AddEmployee();
            AE.Show();
            this.Hide();
        }

        private void Crud_Employee_Load(object sender, EventArgs e)
        {

        }

        private void Employee_Managment_CRUD_Click(object sender, EventArgs e)
        {

        }

        private void Show_AllEmployess_button_Click(object sender, EventArgs e)
        {
            AllEmployees AE = new AllEmployees();
            AE.Show();
            this.Hide();
        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.HR)
            {
                HomePageHR HS = new HomePageHR();
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
