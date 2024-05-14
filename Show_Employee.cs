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

    public partial class Show_Employee : Form
    {
        private string email, firstName, lastName, password, salary;
        private DateTime joinDate;
        private Role role = new Role();
        private Gender gender = new Gender();
        private Boolean flag;
        private Employee exist_employee;
        private Employee e;
        public Show_Employee()
        {
            InitializeComponent();
            Employee_Role_Show_ComboBox.DataSource = Enum.GetValues(typeof(Role));
            Employee_Gender_Show_ComboBox.DataSource = Enum.GetValues(typeof(Gender));
            Update_Employee_Show_Button.Hide();
            Save_Details_Employee_Show_Button.Hide();
            Employee_toArchive_button.Hide();
            Emp_ID_Show_TextBox.Enabled = false;
            Employee_FirstName_Show_TextBox.Enabled = false;
            Employee_LastName_Show_TextBox.Enabled = false;
            Employee_Role_Show_ComboBox.Enabled = false;
            Employee_Email_Show_TextBox.Enabled = false;
            Employee_Gender_Show_ComboBox.Enabled = false;
            Employee_Password_Show_TextBox.Enabled = false;
            Employee_datePicker_Show.Enabled = false;
            Employee_Salary_Show_TextBox.Enabled = false;
            e = Program.Search_Employee(Global.currentUser);

        }

        private void SearchEmployee_ByID_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emp_ID_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_FirstName_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_LastName_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Role_Show_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Email_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Password_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Gender_Show_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Employee_datePicker_Show_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Salary_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Employee_Show_Button_Click(object sender, EventArgs e)
        {
            // Emp_ID_Show_TextBox.Enabled = true;
            Employee_FirstName_Show_TextBox.Enabled = true;
            Employee_LastName_Show_TextBox.Enabled = true;
            Employee_Role_Show_ComboBox.Enabled = true;
            Employee_Email_Show_TextBox.Enabled = true;
            Employee_Gender_Show_ComboBox.Enabled = true;
            Employee_Password_Show_TextBox.Enabled = true;
            Employee_datePicker_Show.Enabled = true;
            Employee_Salary_Show_TextBox.Enabled = true;
            Employee_toArchive_button.Show();

        }

        private void Save_Details_Employee_Show_Button_Click(object sender, EventArgs e)
        {
            firstName = Employee_FirstName_Show_TextBox.Text;
            lastName = Employee_LastName_Show_TextBox.Text;
            role = (Role)Enum.Parse(typeof(Role), Employee_Role_Show_ComboBox.Text);
            email = Employee_Email_Show_TextBox.Text;
            password = Employee_Password_Show_TextBox.Text;
            gender = (Gender)Enum.Parse(typeof(Gender), Employee_Gender_Show_ComboBox.Text);
            joinDate = DateTime.Parse(Employee_datePicker_Show.Text);
            salary = (Employee_Salary_Show_TextBox.Text);
            flag = true;

            var emailPattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,6})+)$");
            var namePattern = new Regex("[a-z A-Z]");
            var idPattern = new Regex("[0-9]");

            //check joinDate
            if (joinDate > DateTime.Now)
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
                string text = "הכנס בבקשה איימיל עד 50 תווים !";
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
                string text = "הכנס בבקשה שם פרטי עד 20 תווים בלבד !";
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
                string text = "הכנס בבקשה שם משפחה עד 20 תווים בלבד !";
                MessageBox.Show(text);
            }

            //check salary
            if (string.IsNullOrEmpty(salary))
            {
                flag = false;
                string text = "הכנס בבקשה משכורת  !";
                MessageBox.Show(text);
            }

            else if (idPattern.IsMatch(salary) == false)
            {
                flag = false;
                string text = "משכורת מכילה רק ספרות !";
                MessageBox.Show(text);
            }
            else if (double.Parse(salary) <= 0)
            {
                flag = false;
                string text = "הכנס בבקשה משכורת הגדולה מ-0 !";
                MessageBox.Show(text);
            }
            //check password
            if (string.IsNullOrEmpty(password))
            {
                flag = false;
                string text = "הכנס בבקשה סיסמא!";
                MessageBox.Show(text);
            }



            if (flag == true)
            {
                exist_employee = Program.Search_Employee(SearchEmployee_ByID_Show_TextBox.Text);
                exist_employee.set_EmployeeID(Emp_ID_Show_TextBox.Text);
                exist_employee.set_FirstName(firstName);
                exist_employee.set_LastName(lastName);
                exist_employee.set_EmployeeRole(role);
                exist_employee.set_Email(email);
                exist_employee.set_Gender(gender);
                exist_employee.set_EmployeePassword(password);
                exist_employee.set_JoinDate(joinDate);
                exist_employee.set_Salary(double.Parse(salary));
                exist_employee.Update_Employee(Emp_ID_Show_TextBox.Text);
                string text = "העובד התעדכן בהצלחה!";
                this.Hide();
                MessageBox.Show(text);
                HomePageGeneral();
            }
            /*
            else  להחליט אם רוצים את ההערה הזאת כי גם מופיע ההערה של השדה שלא בסדר 
            {
                string text = "העובד לא התעדכן!";
                MessageBox.Show(text);
            }
  
        
    */

        }

        private void Search_Employee_Show_Button_Click(object sender, EventArgs e)
        {
            if (Program.Search_Employee(SearchEmployee_ByID_Show_TextBox.Text) == null)
            {
                string text = "עובד לא נמצא במערכת";
                MessageBox.Show(text);
            }
            else

            {
                exist_employee = Program.Search_Employee(SearchEmployee_ByID_Show_TextBox.Text);
                Emp_ID_Show_TextBox.Text = exist_employee.get_EmployeeId();
                Employee_FirstName_Show_TextBox.Text = exist_employee.get_FirstName();
                Employee_LastName_Show_TextBox.Text = exist_employee.get_LastName();
                Employee_Role_Show_ComboBox.Text = exist_employee.get_EmployeeRole().ToString();
                Employee_Email_Show_TextBox.Text = exist_employee.get_Email();
                Employee_Gender_Show_ComboBox.Text = exist_employee.get_Gender().ToString();
                Employee_Password_Show_TextBox.Text = exist_employee.get_EmployeePassword().ToString();
                Employee_datePicker_Show.Text = exist_employee.get_JoinDate().ToString();
                Employee_Salary_Show_TextBox.Text = exist_employee.get_Salary().ToString();
                Emp_ID_Show_TextBox.Enabled = false;
                Employee_FirstName_Show_TextBox.Enabled = false;
                Employee_LastName_Show_TextBox.Enabled = false;
                Employee_Role_Show_ComboBox.Enabled = false;
                Employee_Email_Show_TextBox.Enabled = false;
                Employee_Gender_Show_ComboBox.Enabled = false;
                Employee_Password_Show_TextBox.Enabled = false;
                Employee_datePicker_Show.Enabled = false;
                Employee_Salary_Show_TextBox.Enabled = false;

                Update_Employee_Show_Button.Show();
                Save_Details_Employee_Show_Button.Show();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowEmployee_BackToCRUD_Button_Click(object sender, EventArgs e)
        {
            Crud_Employee CE = new Crud_Employee();
            CE.Show();
            this.Hide();
        }

        private void Show_Employee_Load(object sender, EventArgs e)
        {

        }

        private void Employee_toArchive_button_Click(object sender, EventArgs e)
        {
            exist_employee = Program.Search_Employee(SearchEmployee_ByID_Show_TextBox.Text);
            exist_employee.move_Employee_To_Archive(SearchEmployee_ByID_Show_TextBox.Text);
            exist_employee.set_IsArchived(true);
        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.HR)
            {
                HomePageHR HR = new HomePageHR();
                HR.Show();
                this.Hide();
            }

            else
            {
                HomePageManagers HM = new HomePageManagers();
                HM.Show();
                this.Hide();
            }
        }

        public void HomePageGeneral()
        {
            if (this.e.get_EmployeeRole() == Role.HR)
            {
                HomePageHR HR = new HomePageHR();
                HR.Show();
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