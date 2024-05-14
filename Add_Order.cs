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
    public partial class Add_Order : Form
    {
        private string orderId;
        private DateTime dateReceived;
        private DateTime deadLine;
        private string requirements;
        private OrderStatus status;
        private Priorities priority;
        private DateTime startPreparationDate;
        private string expectedProfit;
        private string CustomerOrder;
        private string OrderProducts;
        private Boolean flag;
        private Employee employee;
        private Employee e;
        
        public Add_Order()
        {
            InitializeComponent();
            Add_Order_Priority_ComboBox.DataSource = Enum.GetValues(typeof(Priorities));
            Add_Order_Status_ComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            e = Program.Search_Employee(Global.currentUser);


        }

        private void Add_Order_Load(object sender, EventArgs e)
        {

        }

        private void Order_ID_Add_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_receive_add_Order_DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DeadLine_Add_Order_DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Add_Order_requirements_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Order_Status_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Order_Priority_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Order_StartPreperation_DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Add_Order_Profit_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Order_BackToManagment_Button_Click(object sender, EventArgs e)
        {
   
                OrderManagment HM = new OrderManagment();
                HM.Show();
                this.Hide();
            
        
        }

        private void Add_Order_Button_Click(object sender, EventArgs e)
        {

            orderId = Order_ID_Add_TextBox.Text;
            dateReceived = DateTime.Parse(Date_receive_add_Order_DatePicker.Text);
            deadLine = DateTime.Parse(DeadLine_Add_Order_DatePicker.Text);
            requirements = Add_Order_requirements_Textbox.Text;
            status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Add_Order_Status_ComboBox.Text);
            priority = (Priorities)Enum.Parse(typeof(Priorities), Add_Order_Priority_ComboBox.Text);
            startPreparationDate = DateTime.Parse(Add_Order_StartPreperation_DatePicker.Text);
            expectedProfit = Add_Order_Profit_TextBox.Text;
            CustomerOrder = Customer_addOrder_TextBox.Text;
            OrderProducts = Order_Products_Textbox.Text;
            flag = true;

            var idPattern = new Regex("[0-9]");


            //check dates
            if (dateReceived > deadLine)
            {
                flag = false;
                string text = "תאריך קבלת הזמנה צריך להיות לפני תאריך אספקה";
                MessageBox.Show(text);
            }
            else if (dateReceived > DateTime.Now)
            {
                flag = false;
                string text = "  תאריך קבלת הזמנה לא תקין";
                MessageBox.Show(text);
            }
            else if (dateReceived > startPreparationDate)
            {
                flag = false;
                string text = "תאריך קבלת הזמנה צריך להיות לפני תאריך תחילת עבודה";
                MessageBox.Show(text);
            }
            else if (startPreparationDate > deadLine)
            {
                flag = false;
                string text = "  תאריך תחילת עבודה צריך להיות לפני תאריך אספקה";
                MessageBox.Show(text);
            }

            //check orderId
            if (string.IsNullOrEmpty(orderId))
            {
                flag = false;
                string text = "הכנס בבקשה מזהה הזמנה!";
                MessageBox.Show(text);
            }
            else if (orderId.Length > 50)
            {
                flag = false;
                string text = "הכנס בבקשה מזהה הזמנה עד 50 תווים !";
                MessageBox.Show(text);
            }

            //check requirements
            if (requirements.Length > 100)
            {
                flag = false;
                string text = "הכנס בבקשה מזהה הזמנה עד 100 תווים !";
                MessageBox.Show(text);
            }

            //check OrderProducts
            if (string.IsNullOrEmpty(OrderProducts))
            {
                flag = false;
                string text = "הכנס בבקשה פירוט מוצרים!";
                MessageBox.Show(text);
            }
            else if (OrderProducts.Length > 50)
            {
                flag = false;
                string text = "הכנס בבקשה פירוט מוצרים עד 50 תווים !";
                MessageBox.Show(text);
            }

            //check customerId

            if (string.IsNullOrEmpty(CustomerOrder))
            {
                flag = false;
                string text = "הכנס בבקשה תעודת זהות של הלקוח!";
                MessageBox.Show(text);
            }
            else if (CustomerOrder.Length != 9)
            {
                flag = false;
                string text = "הכנס בבקשה 9 ספרות לתעודת זהות!";
                MessageBox.Show(text);
            }
            else if (idPattern.IsMatch(CustomerOrder) == false)
            {
                flag = false;
                string text = "תעודת זהות מרכיבה רק ספרות !";
                MessageBox.Show(text);
            }

            if (Program.Search_Customer(CustomerOrder) == null)
            {
                flag = false;
                string text = "הלקוח לא קיים במערכת !";
                MessageBox.Show(text);
            }


            //check expectedProfit
            if (string.IsNullOrEmpty(expectedProfit))
            {
                flag = false;
                string text = "הכנס בבקשה את סכום העסקה  !";
                MessageBox.Show(text);
            }

            else if (idPattern.IsMatch(expectedProfit) == false)
            {
                flag = false;
                string text = "סכום העסקה מכילה רק ספרות !";
                MessageBox.Show(text);
            }
            else if (double.Parse(expectedProfit) <= 0)
            {
                flag = false;
                string text = "הכנס בבקשה סכום עסקה מ-0 !";
                MessageBox.Show(text);
            }


            if (flag == true)
            {
                if (Program.Search_Order(orderId) == null)
                {
                    Customer Customer = Program.Search_Customer(CustomerOrder);
                    Order O = new Order(orderId, dateReceived, deadLine, requirements, status, priority, startPreparationDate, double.Parse(expectedProfit), false, Customer, OrderProducts, true);
                    string text = "ההזמנה נוצרה בהצלחה!";
                    MessageBox.Show(text);
                    HomePageGeneral();
                }
                else
                {
                    string erorr = "ההזמנה כבר קיימת במערכת";
                    MessageBox.Show(erorr);
                }
            }
        }
        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.salesPerson)
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

        public void HomePageGeneral()
        {
            if (this.e.get_EmployeeRole() == Role.salesPerson)
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
        private void Customer_addOrder_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Order_Products_Textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}