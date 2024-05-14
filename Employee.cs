using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Group_27
{
    public class Employee
    {
        private string employeeId;
        private string firstName;
        private string lastName;
        private Role employeeRole;
        private string email;
        private string employeePassword;
        private Gender gender;
        private DateTime joinDate;
        private double salary;
        private bool isArchived;
        List<Order> EmployeeOrder;


        public Employee(string EmployeeId, string FirstName, string LastName, Role EmployeeRole, string Email, string EmployeePassword, Gender Gender, DateTime JoinDate, double Salary, bool IsArchived, bool is_new)
        {
            this.employeeId = EmployeeId;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.employeeRole = EmployeeRole;
            this.email = Email;
            this.employeePassword = EmployeePassword;
            this.gender = Gender;
            this.joinDate = JoinDate;
            this.salary = Salary;
            this.isArchived = IsArchived;
            this.EmployeeOrder = new List<Order>();
            if (is_new)
            {
                this.create_Employee();
                Program.Employees.Add(this);

            }
        }



        public string get_EmployeeId()
        {
            return this.employeeId;
        }
        public string get_FirstName()
        {
            return this.firstName;
        }
        public string get_LastName()
        {
            return this.lastName;
        }

        public Role get_EmployeeRole()
        {
            return this.employeeRole;
        }
        public string get_Email()
        {
            return this.email;
        }
        public string get_EmployeePassword()
        {
            return this.employeePassword;
        }

        public Gender get_Gender()
        {
            return this.gender;
        }

        public DateTime get_JoinDate()
        {
            return this.joinDate;
        }
        public double get_Salary()
        {
            return this.salary;
        }

        public bool get_IsArchived()
        {
            return this.isArchived;
        }

        public string set_EmployeeID(string id)
        {
            this.employeeId = id;
            return this.employeeId;
        }

        public string set_FirstName(string FirstName)
        {
            this.firstName = FirstName;
            return this.firstName;
        }

        public string set_LastName(string LastName)
        {
            this.lastName = LastName;
            return this.lastName;
        }
        public Role set_EmployeeRole(Role role)
        {
            this.employeeRole = role;
            return this.employeeRole;
        }
        public string set_Email(string Email)
        {
            this.email = Email;
            return this.email;
        }

        public string set_EmployeePassword(string password)
        {
            this.employeePassword = password;
            return this.employeePassword;
        }

        public Gender set_Gender(Gender gender)
        {
            this.gender = gender;
            return this.gender;
        }
        public DateTime set_JoinDate(DateTime date)
        {
            this.joinDate = date;
            return this.joinDate;
        }

        public double set_Salary(double salary)
        {
            this.salary = salary;
            return this.salary;
        }
        public bool set_IsArchived(bool IsArchived)
        {
            this.isArchived = IsArchived;
            return this.isArchived;
        }

        public void set_EmployeeOrder (Order O)
        {
            if(!this.EmployeeOrder.Contains(O))
            this.EmployeeOrder.Add(O);
        }
        public void Update_Employee(string id)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Update_employee @id, @firstname, @lastname,@role,@email,@password,@gender,@joindate,@salary";
            c.Parameters.AddWithValue("@id", this.employeeId);
            c.Parameters.AddWithValue("@firstname", this.firstName);
            c.Parameters.AddWithValue("@lastname", this.lastName);
            c.Parameters.AddWithValue("@role", this.employeeRole.ToString());
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@password", this.employeePassword);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            c.Parameters.AddWithValue("@joindate", this.joinDate);
            c.Parameters.AddWithValue("@salary", this.salary);
            //  c.Parameters.AddWithValue("@isarchived", this.IsArchived);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void create_Employee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_employee @id, @firstname, @lastname,@role,@email,@password,@gender,@joindate,@salary,@isarchived";
            c.Parameters.AddWithValue("@id", this.employeeId);
            c.Parameters.AddWithValue("@firstname", this.firstName);
            c.Parameters.AddWithValue("@lastname", this.lastName);
            c.Parameters.AddWithValue("@role", this.employeeRole.ToString());
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@password", this.employeePassword);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            c.Parameters.AddWithValue("@joindate", this.joinDate);
            c.Parameters.AddWithValue("@salary", this.salary);
            c.Parameters.AddWithValue("@isarchived", this.isArchived);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void move_Employee_To_Archive(string id)//להוסיף תנאי אם הוא בארכיון
        {
            if (Program.Search_Employee(id).get_IsArchived() == false)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE SP_EmployeeToArchive @id, @isarchived";
                c.Parameters.AddWithValue("@id", this.employeeId);
                c.Parameters.AddWithValue("@isarchived", this.isArchived);
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);

            }
            else
            {
                string text = "העובד כבר נמצא בארכיון";
                MessageBox.Show(text);
            }
               
           
        }
        public void move_Employee_From_Archive(string id)//להוסיף תנאי בדיקה אם הוא כבר עובד פעיל
        {
            if (Program.Search_Employee(id).get_IsArchived() == true)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE SP_move_Employee_From_Archive @id, @isarchived";
                c.Parameters.AddWithValue("@id", this.employeeId);
                c.Parameters.AddWithValue("@isarchived", this.isArchived);
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);
            }
            else
            {
                string text = "העובד לא נמצא בארכיון";
                MessageBox.Show(text);
            }
        }
    }
}