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
    public partial class Login : Form
    {
        HomePageManagers HM = new HomePageManagers();
        HomePage_Customers HC = new HomePage_Customers();
        HomePageCustomerService HCS = new HomePageCustomerService();
        HomePageHR HR = new HomePageHR();
        HomePageLogistic HL = new HomePageLogistic();
        HomePageProduction HP = new HomePageProduction();
        HomePageSales HPS = new HomePageSales();
        HomePageStoreKeeper HPK = new HomePageStoreKeeper();


        public Login()
        {
            InitializeComponent();
            //       Show_Password.Hide();

            Password_Textbox.PasswordChar = '*';
            Show_Password.BringToFront();
        }

        private void Show_Password_Click(object sender, EventArgs e)
        {
            if (Password_Textbox.PasswordChar == '*')
            {
                Hide_Passwrod.BringToFront();
                Password_Textbox.PasswordChar = '\0';
            }
        }

        private void Hide_Passwrod_Click(object sender, EventArgs e)
        {

            if (Password_Textbox.PasswordChar == '\0')
            {
                Show_Password.BringToFront();
                Password_Textbox.PasswordChar = '*';
            }
        }

        private void UserName_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Password_Textbox_TextChanged(object sender, EventArgs e)
        {
            Password_Textbox.MaxLength = 30;
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            Customer cus = Program.Search_Customer(UserName_TextBox.Text);
            Employee emp = Program.Search_Employee(UserName_TextBox.Text);
            if (cus != null)
            {
                Program.Search_Customer(UserName_TextBox.Text);
                if (UserName_TextBox.Text.Equals(cus.get_customerId()))
                {

                    if (Password_Textbox.Text.Equals(cus.get_customerPassword()))
                    {
                        Global.currentUser = cus.get_customerId();
                        HomePage_Customers HC = new HomePage_Customers();
                        HC.Show();
                        this.Hide();
                    }
                    else
                    {
                        string text = "סיסמא לא נכונה";
                        MessageBox.Show(text);
                    }

                }
            }
            else if (emp != null)
            {
                if (UserName_TextBox.Text.Equals(emp.get_EmployeeId()))
                {
                    if (Password_Textbox.Text.Equals(emp.get_EmployeePassword()))
                    {
                        Global.currentUser = emp.get_EmployeeId();
                        if (emp.get_EmployeeRole() == Role.CEO || emp.get_EmployeeRole() == Role.HRManager || emp.get_EmployeeRole() == Role.productionManager || emp.get_EmployeeRole() == Role.logisticManager)
                        {
                            HomePageManagers HM = new HomePageManagers();
                            HM.Show();
                            this.Hide();
                        }
                        else if (emp.get_EmployeeRole() == Role.customerService)
                        {
                            HCS.Show();
                            this.Hide();
                        }
                        else if (emp.get_EmployeeRole() == Role.HR)
                        {
                            HR.Show();
                            this.Hide();
                        }
                        else if (emp.get_EmployeeRole() == Role.logistic)
                        {
                            HL.Show();
                            this.Hide();
                        }
                        else if (emp.get_EmployeeRole() == Role.production)
                        {
                            HP.Show();
                            this.Hide();
                        }
                        else if (emp.get_EmployeeRole() == Role.salesPerson)
                        {
                            HPS.Show();
                            this.Hide();
                        }
                        else if (emp.get_EmployeeRole() == Role.storeKeeper)
                        {
                            HPK.Show();
                            this.Hide();
                        }







                    }
                    else
                    {
                        string text = "סיסמא לא נכונה";
                        MessageBox.Show(text);
                    }
                }
            }
            else
            {
                string text = "משתמש לא נמצא";
                MessageBox.Show(text);
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }
    }

}
