using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;



namespace Group_27
{
    public partial class AddEmployee : Form
    {
        private string id, email, firstName, lastName, password;
        private string salary;
        private DateTime joinDate;
        private Role role = new Role();
        private Gender gender = new Gender();
        private Boolean flag;
        private Employee e;

        public AddEmployee()
        {
            InitializeComponent();
            Employee_Role.DataSource = Enum.GetValues(typeof(Role));
            Employee_Gender.DataSource = Enum.GetValues(typeof(Gender));
            e = Program.Search_Employee(Global.currentUser);


        }

        private void Emp_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input_Employee_Click(object sender, EventArgs e)
        {
            id = Emp_ID.Text;
            firstName = Employee_FirstName.Text;
            lastName = Employee_LastName.Text;
            role = (Role)Enum.Parse(typeof(Role), Employee_Role.Text);
            email = Employee_Email.Text;
            password = Employee_Password.Text;
            gender = (Gender)Enum.Parse(typeof(Gender), Employee_Gender.Text);
            joinDate = DateTime.Parse(Employee_datePicker.Text);
            salary = (Employee_Salary.Text);
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
                if (Program.Search_Employee(id) == null)
                {
                    Employee emp = new Employee(id, firstName, lastName, role, email, password, gender, joinDate, double.Parse(salary), false, true);
                    string text = "העובד נוסף בהצלחה!";
                    
                    MessageBox.Show(text);
                    HomePage();
                }
                else
                {
                    string text = "העובד כבר קיים במערכת!";
                    MessageBox.Show(text);
                }
            }
        }


        private void Employee_LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Employee_LastN_Click(object sender, EventArgs e)
        {

        }

        private void Employee_datePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crud_Employee CE = new Crud_Employee();
            CE.Show();
            this.Hide();
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
        public void HomePage()
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