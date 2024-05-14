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
    public partial class ProductionProcessManagment : Form
    {
        Employee e;
        public ProductionProcessManagment()
        {
            InitializeComponent();
            e = Program.Search_Employee(Global.currentUser);

        }

        private void Show_Product_button_Click(object sender, EventArgs e)
        {
            SortProdutionProcess SPP = new SortProdutionProcess();
            SPP.Show();
            this.Hide();
        }

       
        private void ProductionProcessManagment_Load(object sender, EventArgs e)
        {

        }

        private void Create_ProductionPRocess_Buttton_Click(object sender, EventArgs e)
        {
            Add_productionProcess APP = new Add_productionProcess();
            APP.Show();
            this.Hide();
        }

        private void set_WorkTime_Button_Click(object sender, EventArgs e)
        {
            setTimeForWork STF = new setTimeForWork();
            STF.Show();
            this.Hide();
        }

        private void Set_StandardTime_button_Click(object sender, EventArgs e)
        {
            StandardTime ST = new StandardTime();
            ST.Show();
            this.Hide();
        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.production)
            {
                HomePageProduction HS = new HomePageProduction();
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
