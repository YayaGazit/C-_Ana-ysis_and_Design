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
    public partial class Show_Customer : Form
    {
        private string id, email, firstName, lastName, password, address, companyName, phoneNumber;
        private DateTime birthdate;
        private Gender gender = new Gender();
        private Boolean flag;
        private Customer exist_customer;
        private Employee e;
        public Show_Customer()
        {
            InitializeComponent();
            Customer_Gender_Show_ComboBox.DataSource = Enum.GetValues(typeof(Gender));
            Update_Customer_Show_Button.Hide();
            Save_Details_Customer_Show_Button.Hide();
            Customer_toArchive_button.Hide();
            Customer_ID_Show_Textbox.Enabled = false;
            Customer_FirstName_Show_Textbox.Enabled = false;
            Customer_LastName_Show_Textbox.Enabled = false;
            Company_Name_Show_TextBox.Enabled = false;
            Customer_Mail_Show_TextBox.Enabled = false;
            Customer_Phone_Show_Textbox.Enabled = false;
            Customer_Birthday_Show_datePicker.Enabled = false;
            Customer_Gender_Show_ComboBox.Enabled = false;
            Customer_Password_Show_Textbox.Enabled = false;
            Customer_Address_Show_Textbox.Enabled = false;
            e = Program.Search_Employee(Global.currentUser);

        }

        private void SearchCustomer_ByID_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Customer_Show_Button_Click(object sender, EventArgs e)
        {

            if (Program.Search_Customer(SearchCustomer_ByID_Show_TextBox.Text) == null)
            {
                string text = "לקוח לא נמצא במערכת";
                MessageBox.Show(text);
            }
            else
            // if (SearchEmployee_ByID_Show_TextBox.Text != null)
            {
                exist_customer = Program.Search_Customer(SearchCustomer_ByID_Show_TextBox.Text);
                Update_Customer_Show_Button.Show();
                Save_Details_Customer_Show_Button.Show();
                Customer_ID_Show_Textbox.Text = exist_customer.get_customerId();
                Customer_FirstName_Show_Textbox.Text = exist_customer.get_FirstName();
                Customer_LastName_Show_Textbox.Text = exist_customer.get_LastName();
                Company_Name_Show_TextBox.Text = exist_customer.get_companyName();
                Customer_Mail_Show_TextBox.Text = exist_customer.get_Email();
                Customer_Phone_Show_Textbox.Text = exist_customer.get_phoneNumber();
                Customer_Birthday_Show_datePicker.Text = exist_customer.get_birthdate().ToString();
                Customer_Gender_Show_ComboBox.Text = exist_customer.get_Gender().ToString();
                Customer_Password_Show_Textbox.Text = exist_customer.get_customerPassword();
                Customer_Address_Show_Textbox.Text = exist_customer.get_customerAddress();
                Customer_ID_Show_Textbox.Enabled = false;
                Customer_FirstName_Show_Textbox.Enabled = false;
                Customer_LastName_Show_Textbox.Enabled = false;
                Company_Name_Show_TextBox.Enabled = false;
                Customer_Mail_Show_TextBox.Enabled = false;
                Customer_Phone_Show_Textbox.Enabled = false;
                Customer_Birthday_Show_datePicker.Enabled = false;
                Customer_Gender_Show_ComboBox.Enabled = false;
                Customer_Password_Show_Textbox.Enabled = false;
                Customer_Address_Show_Textbox.Enabled = false;
            }


        }

        private void Customer_ID_Show_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_FirstName_Show_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_LastName_Show_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Company_Name_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Mail_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Phone_Show_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Birthday_Show_datePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Address_Show_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Password_Show_Textbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void ShowCustomer_BackToCRUD_Button_Click(object sender, EventArgs e)
        {
            Crud_Customer CC = new Crud_Customer();
            CC.Show();
            this.Hide();
        }

        private void Update_Customer_Show_Button_Click(object sender, EventArgs e)
        {
            //   Customer_ID_Show_Textbox.Enabled = true;
            Customer_FirstName_Show_Textbox.Enabled = true;
            Customer_LastName_Show_Textbox.Enabled = true;
            Company_Name_Show_TextBox.Enabled = true;
            Customer_Mail_Show_TextBox.Enabled = true;
            Customer_Phone_Show_Textbox.Enabled = true;
            Customer_Birthday_Show_datePicker.Enabled = true;
            Customer_Gender_Show_ComboBox.Enabled = true;
            Customer_Password_Show_Textbox.Enabled = true;
            Customer_Address_Show_Textbox.Enabled = true;
            Customer_toArchive_button.Show();
        }

        private void Save_Details_Customer_Show_Button_Click(object sender, EventArgs e)

        {

            id = Customer_ID_Show_Textbox.Text;
            firstName = Customer_FirstName_Show_Textbox.Text;
            lastName = Customer_LastName_Show_Textbox.Text;
            companyName = Company_Name_Show_TextBox.Text;
            email = Customer_Mail_Show_TextBox.Text;
            password = Customer_Password_Show_Textbox.Text;
            address = Customer_Address_Show_Textbox.Text;
            phoneNumber = Customer_Phone_Show_Textbox.Text;
            gender = (Gender)Enum.Parse(typeof(Gender), Customer_Gender_Show_ComboBox.Text);
            birthdate = DateTime.Parse(Customer_Birthday_Show_datePicker.Text);
            flag = true;

            var emailPattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,6})+)$");
            var namePattern = new Regex("[a-z A-Z]");
            var idPattern = new Regex("[0-9]");
            var phonePattern = new Regex(@"^0\d{9}$");


            //check birthday
            if (birthdate > DateTime.Now)
            {
                flag = false;
                string text = "תאריך לא תקין";
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
                exist_customer = Program.Search_Customer(SearchCustomer_ByID_Show_TextBox.Text);
                exist_customer.set_CustomerId(id);
                exist_customer.set_FirstName(firstName);
                exist_customer.set_LastName(lastName);
                exist_customer.set_companyName(companyName);
                exist_customer.set_Email(email);
                exist_customer.set_phoneNumber(phoneNumber);
                exist_customer.set_customerPassword(password);
                exist_customer.set_birthdate(birthdate);
                exist_customer.set_customerAddress(address);
                exist_customer.set_Gender(gender);
                exist_customer.update_Customer(Customer_ID_Show_Textbox.Text);
                string text = "הלקוח התעדכן בהצלחה!";
                this.Hide();
                MessageBox.Show(text);
                HomePage_Customers hc = new HomePage_Customers();
                hc.Show();
            }


        }

        private void Customer_toArchive_button_Click(object sender, EventArgs e)
        {
            exist_customer = Program.Search_Customer(SearchCustomer_ByID_Show_TextBox.Text);
            exist_customer.move_Customer_To_Archive(SearchCustomer_ByID_Show_TextBox.Text);
            exist_customer.set_IsArchived(true);
        }

        private void Show_Customer_Load(object sender, EventArgs e)
        {

        }

        private void Customer_Gender_Show_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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