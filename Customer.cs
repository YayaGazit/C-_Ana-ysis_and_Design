using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Group_27
{
    public class Customer
    {
        private string customerId;
        private string firstName;
        private string lastName;
        private string companyName;
        private string email;
        private string phoneNumber;
        private DateTime birthdate;
        private string customerAddress;
        private string customerPassword;
        private Gender gender;
        private bool isArchived;
        private List<Order> myOrders;


        public Customer(string customerId, string firstName, string lastName, string companyName, string email, string phoneNumber, DateTime birthdate, string customerAddress, string customerPassword, Gender gender, bool isArchived, bool is_new)
        {
            this.customerId = customerId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.companyName = companyName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.birthdate = birthdate;
            this.customerAddress = customerAddress;
            this.customerPassword = customerPassword;
            this.gender = gender;
            this.isArchived = isArchived;
            this.myOrders = new List<Order>();
            if (is_new)
            {
                this.create_Customer();
                Program.Customers.Add(this);

            }
        }

        public string get_customerId()
        {
            return this.customerId;
        }
        public string get_FirstName()
        {
            return this.firstName;
        }
        public string get_LastName()
        {
            return this.lastName;
        }
        public string get_companyName()
        {
            return this.companyName;
        }

        public string get_Email()
        {
            return this.email;
        }

        public string get_phoneNumber()
        {
            return this.phoneNumber;
        }

        public DateTime get_birthdate()
        {
            return this.birthdate;
        }
        public string get_customerAddress()
        {
            return this.customerAddress;
        }
        public string get_customerPassword()
        {
            return this.customerPassword;
        }
        public Gender get_Gender()
        {
            return this.gender;
        }
        public bool get_IsArchived()
        {
            return this.isArchived;
        }

        public string set_CustomerId(string id)
        {
            this.customerId = id;

            return this.customerId;
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
        public string set_companyName(string companyName)
        {
            this.companyName = companyName;

            return this.companyName;
        }
        public string set_Email(string Email)
        {
            this.email = Email;

            return this.email;
        }

        public string set_phoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;

            return this.phoneNumber;
        }

        public DateTime set_birthdate(DateTime birthdate)
        {
            this.birthdate = birthdate;

            return this.birthdate;
        }

        public string set_customerAddress(string customerAddress)
        {
            this.customerAddress = customerAddress;

            return this.customerAddress;
        }
        public string set_customerPassword(string customerPassword)
        {
            this.customerPassword = customerPassword;

            return this.customerPassword;
        }

        public Gender set_Gender(Gender gender)
        {
            this.gender = gender;

            return this.gender;
        }
        public bool set_IsArchived(bool IsArchived)
        {
            this.isArchived = IsArchived;

            return this.isArchived;
        }

        public void add_order_to_myOrder(Order o)
        {
            this.myOrders.Add(o);
        }

        public List<Order> get_all_orders()
        {
            return this.myOrders;
        }
        public void create_Customer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Customer @id, @Firstname, @Lastname,@CompanyName,@email,@phonenumber,@birthday,@address,@password,@gender,@isarchived";
            c.Parameters.AddWithValue("@id", this.customerId);
            c.Parameters.AddWithValue("@firstname", this.firstName);
            c.Parameters.AddWithValue("@lastname", this.lastName);
            c.Parameters.AddWithValue("@CompanyName", this.companyName);
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@phonenumber", this.phoneNumber);
            c.Parameters.AddWithValue("@birthday", this.birthdate);
            c.Parameters.AddWithValue("@address", this.customerAddress);
            c.Parameters.AddWithValue("@password", this.customerPassword);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            c.Parameters.AddWithValue("@isarchived", this.isArchived);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void update_Customer(string id)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Update_Customer @id, @Firstname, @Lastname,@CompanyName,@email,@phonenumber,@birthday,@address,@password,@gender";
            c.Parameters.AddWithValue("@id", this.customerId);
            c.Parameters.AddWithValue("@firstname", this.firstName);
            c.Parameters.AddWithValue("@lastname", this.lastName);
            c.Parameters.AddWithValue("@CompanyName", this.companyName);
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@phonenumber", this.phoneNumber);
            c.Parameters.AddWithValue("@birthday", this.birthdate);
            c.Parameters.AddWithValue("@address", this.customerAddress);
            c.Parameters.AddWithValue("@password", this.customerPassword);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            //  c.Parameters.AddWithValue("@isarchived", this.IsArchived);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void move_Customer_To_Archive(string id)//להוסיף תנאי אם הוא בארכיון
        {
            if (Program.Search_Customer(id).get_IsArchived() == false)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE SP_CustomerToArchive @id";
                c.Parameters.AddWithValue("@id", this.customerId);
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);

            }
            else
            {
                string text = "הלקוח כבר נמצא בארכיון";
                MessageBox.Show(text);
            }


        }
        public void move_Customer_From_Archive(string id)//להוסיף תנאי בדיקה אם הוא כבר עובד פעיל
        {
            if (Program.Search_Customer(id).get_IsArchived() == true)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE SP_CustomerFromArchive @id";
                c.Parameters.AddWithValue("@id", this.customerId);
                c.Parameters.AddWithValue("@isarchived", this.isArchived);
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);
            }
            else
            {
                string text = "הלקוח לא נמצא בארכיון";
                MessageBox.Show(text);
            }
        }
    }
}