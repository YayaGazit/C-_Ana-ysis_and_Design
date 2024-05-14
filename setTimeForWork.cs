using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Group_27
{

    public partial class setTimeForWork : Form
    {
        private Employee emp = Program.Search_Employee(Global.currentUser);
        private StepInProgress stepIP;
        private Step step;
        private Order order;
        private bool flag1; //order
        private bool flag2; //enum
        bool flagForLoop;
        private double workTime;
        private bool flagforexception;
        private Employee e;
        private string starTime;
        private string endTime;
        string orderid;
        string stepname;
        public setTimeForWork()
        {
            InitializeComponent();
            Customer_Gender_Show_ComboBox.DataSource = Enum.GetValues(typeof(StepName));
            Set_Standard_Time_START.Enabled = false;
            Set_Standard_Time_END.Enabled = false;
            e = Program.Search_Employee(Global.currentUser);
            flag1 = false;
            flag2 = false;
        }

        private void Customer_Gender_Show_ComboBox_SelectedIndexChanged(object sender, EventArgs e)//step name
        {
            flag2 = true;
            if (flag1 == true && flag2 == true)
            {
                Set_Standard_Time_START.Enabled = true;
                Set_Standard_Time_END.Enabled = true;
            }
        }

        private void Set_Standard_Time_START_TextChanged(object sender, EventArgs e)
        {

        }

        private void Set_Standard_Time_END_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Customer_Show_Button_Click(object sender, EventArgs e)
        {
            orderid = Order_ID_StepInProgress_TextBox.Text;
            stepname = Customer_Gender_Show_ComboBox.Text;
            flagForLoop = true;
            flagforexception = true;
            starTime = Set_Standard_Time_START.Text;
            endTime = Set_Standard_Time_END.Text;

            var datePattern = new Regex(@"(\d |\d\d)/(\d |\d\d)/(\d\d(\d\d) ?) (\d |\d\d):(\d |\d\d):(\d |\d\d)");
            //check order
            if (string.IsNullOrEmpty(orderid))
            {
                flagForLoop = false;
                flagforexception = false;
                string text = "הכנס בבקשה מספר הזמנה !";
                MessageBox.Show(text);
            }
            else if (Program.Search_Order(orderid) == null)
            {
                flagForLoop = false;

                flagforexception = false;
                string text = " הכנס בבקשה מספר הזמנה קיימת !";
                MessageBox.Show(text);
            }

            if (flagForLoop == true)
            {


                step = Program.Search_Step(stepname);
                order = Program.Search_Order(orderid);
                foreach (StepInProgress st in Program.StepInProgresses)
                {
                    if (st.get_Order().get_OrderId() == order.get_OrderId() && st.get_Step().get_stepName() == step.get_stepName())
                    {
                        flagforexception = false;
                        string text = "תהליך הייצור בהזמנה זו קיים!";
                        MessageBox.Show(text);
                    }


                }
                if (flagforexception == true)
                {


                    //check starttime
                    if (string.IsNullOrEmpty(starTime))
                    {
                        flagforexception = false;
                        string text = "הכנס בבקשה זמן התחלה!";
                        MessageBox.Show(text);

                    }

                    else if (!datePattern.IsMatch(starTime))
                    {
                        flagforexception = false;
                        string text = "הזן בבקשה תאריך ושעה לפי הפורמט הנדרש בזמן התחלה!";
                        MessageBox.Show(text);
                    }

                    //check endtime 
                    if (string.IsNullOrEmpty(endTime))
                    {
                        flagforexception = false;
                        string text = "הכנס בבקשה זמן סיום!";
                        MessageBox.Show(text);

                    }

                    else if (!datePattern.IsMatch(endTime))
                    {
                        flagforexception = false;
                        string text = "הזן בבקשה תאריך ושעה לפי הפורמט הנדרש בזמן סיום!";
                        MessageBox.Show(text);
                    }
                    //check endtime>startime
                    else if (DateTime.Parse(endTime) < DateTime.Parse(starTime))
                    {
                        flagforexception = false;
                        string text = "הזן בבקשה זמן סיום מאוחר מזמן התחלה!";
                        MessageBox.Show(text);
                    }


                    if (flagforexception == true)
                    {

                        stepIP = new StepInProgress(DateTime.Parse(starTime), DateTime.Parse(endTime), step, order, true);
                        workTime = stepIP.get_workTime();
                        string text = workTime.ToString();
                        MessageBox.Show(text);
                    }
                }
            }
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

        private void setTimeForWork_Load(object sender, EventArgs e)
        {

        }

        private void Order_ID_StepInProgress_TextBox_TextChanged(object sender, EventArgs e)
        {
            flag1 = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ShowOrder_BackToManagment_Button_Click(object sender, EventArgs e)
        {
            ProductionProcessManagment OM = new ProductionProcessManagment();
            OM.Show();
            this.Hide();
        }
    }
}