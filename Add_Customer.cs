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
    public partial class Add_Customer : Form
        
    {
        private string id, email, firstName, lastName, password, address, companyName, phoneNumber;
        private DateTime birthday;
        private Gender gender = new Gender();
        private Boolean flag;
       private  Employee e;
        private Customer existCustomer;
        public Add_Customer()
        {
            InitializeComponent();
            e = Program.Search_Employee(Global.currentUser);
            Customer_Gender_TextBox.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void Customer_ID_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_FirstName_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_LastName_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Company_Name_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Mail_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Phone_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Birthday_datePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Address_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Password_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Gender_TextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Input_Customer_Button_Click(object sender, EventArgs e)
        {
            id = Customer_ID_Textbox.Text;
            firstName = Customer_FirstName_Textbox.Text;
            lastName = Customer_LastName_Textbox.Text;
            companyName = Company_Name_TextBox.Text;
            email = Customer_Mail_TextBox.Text;
            password = Customer_Password_Textbox.Text;
            address = Customer_Address_Textbox.Text;
            phoneNumber = Customer_Phone_Textbox.Text;
            gender = (Gender)Enum.Parse(typeof(Gender), Customer_Gender_TextBox.Text);
            birthday = DateTime.Parse(Customer_Birthday_datePicker.Text);
            flag = true;

            var emailPattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,6})+)$");
            var namePattern = new Regex("[a-z A-Z]");
            var idPattern = new Regex("[0-9]");
            var phonePattern = new Regex(@"^0\d{9}$");


            //check birthday
            if (birthday > DateTime.Now)
            {
                flag = false;
                string text = "תאריך לא תקין";
                MessageBox.Show(text);
            }

            //check ID
            if (string.IsNullOrEmpty(id))
            {
                flag = false;
                string text = "הכנס בבקשה תעודת זהות!";
                MessageBox.Show(text);
            }
            else if (id.Length != 9)
            {
                flag = false;
                string text = "הכנס בבקשה 9 ספרות לתעודת זהות!";
                MessageBox.Show(text);
            }
            else if (idPattern.IsMatch(id) == false)
            {
                string text = "תעודת זהות מרכיבה רק ספרות !";
                MessageBox.Show(text);
            }


            //check email
            if (string.IsNullOrEmpty(email))
            {
                flag = false;
                string text = "הכנס בבקשה איימיל !";
                MessageBox.Show(text);

            }
            else if (!emailPattern.IsMatch(email))
            {
                flag = false;
                string text = "הכנס בבקשה איימל בפורמט הבא:word@word.word !";
                MessageBox.Show(text);
            }
            else if (email.Length > 50)
            {
                flag = false;
                string text = "הכנס בבקשה מייל עד 50 תווים !";
                MessageBox.Show(text);
            }


            //check first name
            if (string.IsNullOrEmpty(firstName))
            {
                flag = false;
                string text = "הכנס שם פרטי בבקשה !";
                MessageBox.Show(text);

            }
            else if (!namePattern.IsMatch(firstName))
            {
                flag = false;
                string text = "הכנס בבקשה את השם פרטי באנגלית בלבד  !";
                MessageBox.Show(text);
            }
            else if (firstName.Length > 20)
            {
                flag = false;
                string text = "הכנס בבקשה שם פרטי עד 20 תווים !";
                MessageBox.Show(text);
            }



            //check last name
            if (string.IsNullOrEmpty(lastName))
            {
                flag = false;
                string text = "הכנס בבקשה שם משפחה !";
                MessageBox.Show(text);
            }
            else if (!namePattern.IsMatch(lastName))
            {
                flag = false;
                string text = "הכנס בבקשה שם משפחה באנגלית בלבד !";
                MessageBox.Show(text);
            }
            else if (lastName.Length > 20)
            {
                flag = false;
                string text = "הכנס בבקשה שם משפחה עד 20 תווים !";
                MessageBox.Show(text);
            }

            //check company name
            if (string.IsNullOrEmpty(companyName))
            {
                flag = false;
                string text = "הכנס בבקשה כתובת!";
                MessageBox.Show(text);
            }
            else if (companyName.Length > 20)
            {
                flag = false;
                string text = "הכנס בבקשה שם חברה עד 20 תווים !";
                MessageBox.Show(text);
            }


            //check address
            if (string.IsNullOrEmpty(address))
            {
                flag = false;
                string text = "הכנס בבקשה כתובת!";
                MessageBox.Show(text);
            }
            else if (address.Length > 50)
            {
                flag = false;
                string text = "הכנס בבקשה כתובת עד 50 תווים !";
                MessageBox.Show(text);
            }

            //check password
            if (string.IsNullOrEmpty(password))
            {
                flag = false;
                string text = "הכנס בבקשה סיסמא!";
                MessageBox.Show(text);
            }
            else if (password.Length > 50)
            {
                flag = false;
                string text = "הכנס בבקשה סיסמא עד 50 תווים !";
                MessageBox.Show(text);
            }

            //check phone number
            if (string.IsNullOrEmpty(phoneNumber))
            {
                flag = false;
                string text = "הכנס בבקשה מספר פלאפון !";
                MessageBox.Show(text);
            }
            else if (!phonePattern.IsMatch(phoneNumber))
            {
                flag = false;
                string text = "הכנס בבקשה מספר פלאפון תקין-מספר המתחיל בספרה 0 ושהמספר יכיל  10 ספרות בלבד!";
                MessageBox.Show(text);
            }

            if (flag == true)
            {
                if (Program.Search_Customer(id) == null)
                {
                    Customer cus = new Customer(id, firstName, lastName, companyName, email, phoneNumber, birthday, address, password, gender, false, true);
                    string text = "הלקוח נוסף בהצלחה!";
                    this.Hide();
                    MessageBox.Show(text);
                    HomePage_Customers hc = new HomePage_Customers();
                    hc.Show();
                }
                else
                {
                    string text = "הלקוח כבר קיים במערכת!";
                    this.Hide();
                    MessageBox.Show(text);
                }
            }
        }

        private void Add_Customer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Crud_Customer CC = new Crud_Customer();
            CC.Show();
            this.Hide();
        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.customerService)
            {
                HomePageCustomerService HCS = new HomePageCustomerService();
                HCS.Show();
                this.Hide();
            }
            else if (this.e.get_EmployeeRole() == Role.salesPerson)
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
    }
}