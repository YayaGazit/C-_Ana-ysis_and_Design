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
    public partial class StandardTime : Form
    {
        public List<StepInProgress> StepsInProgress = Program.StepInProgresses;
        private double standardTime;
        private double STDV;
        private Employee e;

        public StandardTime()
        {
            InitializeComponent();
            StepName_ComboBox.DataSource = Enum.GetValues(typeof(StepName));
            Standrardtime_TextBox.Enabled = false;
            STDV_TextBox.Enabled = false;
            e = Program.Search_Employee(Global.currentUser);

        }

        private void StepName_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StandardTime_Load(object sender, EventArgs e)
        {

        }

        private void Standrardtime_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calc_Standrad_Time_Button_Click(object sender, EventArgs e)
        {
            Standrardtime_TextBox.Text = calcStandartTime(StepName_ComboBox.Text).ToString();
            standardTime = calcStandartTime(StepName_ComboBox.Text);
            STDV = calcSTDV(StepName_ComboBox.Text);
            STDV_TextBox.Text = calcSTDV(StepName_ComboBox.Text).ToString();


        }
        public double calcStandartTime(string stepName)
        {

            double sum = 0;
            int counter = 0;
            foreach (StepInProgress s in StepsInProgress)
            {
                if (stepName == s.get_Step().get_stepName().ToString())
                {
                    sum = sum + s.get_workTime();
                    counter++;
                }
            }
            if (counter == 0)
                return 0;
            else
            {
                standardTime = sum / counter;
                Step step = Program.Search_Step(stepName);
                step.set_standardTime(standardTime);
                step.Update_StandradTime_Step(stepName, standardTime);
                return standardTime;

            }
        }
        public double calcSTDV(string stepName)
        {
            List<double> values = new List<double>();
            foreach (StepInProgress s in StepsInProgress)
            {
                if (stepName == s.get_Step().get_stepName().ToString())
                {
                    values.Add(s.get_workTime());
                }

            }
            if (values.Count == 0)
            {

                return 0;
            }
            else
            {


                var mean = values.Average();
                var sumOfSquaresOfDifferences = values.Select(val => (val - mean) * (val - mean)).Sum();
                var stdDev = Math.Sqrt(sumOfSquaresOfDifferences / values.Count);
                Step step = Program.Search_Step(stepName);
                step.Update_STDV_Step(stepName, stdDev);
                step.set_standardDeviation(stdDev);

                return stdDev;
            }
        }
        private void STDV_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_New_Supplier_Label_Click(object sender, EventArgs e)
        {

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

        private void ShowOrder_BackToManagment_Button_Click(object sender, EventArgs e)
        {
            ProductionProcessManagment OM = new ProductionProcessManagment();
            OM.Show();
            this.Hide();
        }
    }
}