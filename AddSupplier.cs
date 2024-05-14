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
    public partial class AddSupplier : Form
    {
        private string supplierId;
        private string supplierName;
        private string supplierAddress;
        private string supplierPhone;
        private Boolean flag;
        private Employee e;

        public AddSupplier()
        {
            InitializeComponent();
            e = Program.Search_Employee(Global.currentUser);

        }

        private void Supplier_ID_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Supplier_Name_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Supplier_Address_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Supplier_Phone_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input_Supplier_Button_Click(object sender, EventArgs e)
        {
            supplierId = Supplier_ID_Textbox.Text;
            supplierName = Supplier_Name_Textbox.Text;
            supplierAddress = Supplier_Address_Textbox.Text;
            supplierPhone = Supplier_Phone_Textbox.Text;
            flag = true;
            var namePattern = new Regex("[a-z A-Z]");
            var idPattern = new Regex("[0-9]");
            var phonePattern = new Regex(@"^0\d{9}$");


            //check supplierId
            if (string.IsNullOrEmpty(supplierId))
            {
                flag = false;
                string text = "הכנס בבקשה מזהה ספק!";
                MessageBox.Show(text);
            }

            //check supplier Name
            if (string.IsNullOrEmpty(supplierName))
            {
                flag = false;
                string text = "הכנס שם בבקשה !";
                MessageBox.Show(text);

            }
            else if (!namePattern.IsMatch(supplierName))
            {
                flag = false;
                string text = "הכנס בבקשה את השם באנגלית בלבד  !";
                MessageBox.Show(text);
            }
            else if (supplierName.Length > 20)
            {
                flag = false;
                string text = "הכנס בבקשה שם עד 20 תווים !";
                MessageBox.Show(text);
            }

            //check supplier Address
            if (string.IsNullOrEmpty(supplierAddress))
            {
                flag = false;
                string text = "הכנס בבקשה כתובת!";
                MessageBox.Show(text);
            }
            else if (supplierAddress.Length > 100)
            {
                flag = false;
                string text = "הכנס בבקשה כתובת עד 100 תווים !";
                MessageBox.Show(text);
            }

            //check supplie rPhone
            if (string.IsNullOrEmpty(supplierPhone))
            {
                flag = false;
                string text = "הכנס בבקשה מספר פלאפון !";
                MessageBox.Show(text);
            }
            else if (!phonePattern.IsMatch(supplierPhone))
            {
                flag = false;
                string text = "הכנס בבקשה מספר פלאפון תקין-מספר המתחיל בספרה 0 ושהמספר יכיל  10 ספרות בלבד!";
                MessageBox.Show(text);
            }

            if (flag == true)
            {
                if (Program.Search_Supplier(supplierId) == null)
                {

                    Supplier s = new Supplier(supplierId, supplierName, supplierAddress, supplierPhone, false, true);
                    string text = "הספק נוסף בהצלחה!";
                    
                    MessageBox.Show(text);
                    BackHomePageGeneral();
                }
                else
                {
                    string text = "הספק כבר קיים במערכת!";
                    this.Hide();
                    MessageBox.Show(text);
                }
            }
        }


        private void AddSupplier_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crud_Supplier CS = new Crud_Supplier();
            CS.Show();
            this.Hide();
        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.logistic)
            {
                HomePageLogistic HS = new HomePageLogistic();
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
        public void BackHomePageGeneral()
        {
            if (this.e.get_EmployeeRole() == Role.logistic)
            {
                HomePageLogistic HS = new HomePageLogistic();
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