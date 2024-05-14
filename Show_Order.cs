using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_27
{
    public partial class Show_Order : Form
    {
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
        private Order exist_order;
        private OrderStatus os;
        private Employee e;
        public Show_Order()
        {
            InitializeComponent();
            Order_Priority_ComboBox.DataSource = Enum.GetValues(typeof(Priorities));
            Order_Status_ComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            Update_Order_Show_Button.Hide();
            Save_Details_Order_Show_Button.Hide();
            Order_toArchive_button.Hide();
            Order_ID_Show_TextBox.Enabled = false;
            Date_receive_Order_DatePicker.Enabled = false;
            DeadLine_Order_DatePicker.Enabled = false;
            ProductsDits_TextBox.Enabled = false;
            Order_Status_ComboBox.Enabled = false;
            Order_Priority_ComboBox.Enabled = false;
            Order_StartPreperation_DatePicker.Enabled = false;
            Order_Profit_TextBox.Enabled = false;
            Customer_Order_TextBox.Enabled = false;
            Requierment_TextBox.Enabled = false;
            e = Program.Search_Employee(Global.currentUser);




        }

        private void SearchOrder_ByID_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Order_Show_Button_Click(object sender, EventArgs e)
        {
            if (Program.Search_Order(SearchOrder_ByID_Show_TextBox.Text) == null)
            {
                string text = "הזמנה לא נמצאת במערכת";
                MessageBox.Show(text);
            }
            else
            {
                exist_order = Program.Search_Order(SearchOrder_ByID_Show_TextBox.Text);
                Order_ID_Show_TextBox.Text = exist_order.get_OrderId();
                Date_receive_Order_DatePicker.Text = exist_order.get_DateReceived().ToString();
                DeadLine_Order_DatePicker.Text = exist_order.get_deadLine().ToString();
                Requierment_TextBox.Text = exist_order.get_requirements();
                Order_Status_ComboBox.Text = exist_order.get_status().ToString();
                Order_Priority_ComboBox.Text = exist_order.get_priority().ToString();
                Order_StartPreperation_DatePicker.Text = exist_order.get_startPreparationDate().ToString();
                Order_Profit_TextBox.Text = exist_order.get_expectedProfit().ToString();
                Customer_Order_TextBox.Text = exist_order.get_customer().get_customerId();
                ProductsDits_TextBox.Text = exist_order.get_OrderProducts();
                Update_Order_Show_Button.Show();
                Save_Details_Order_Show_Button.Show();
                os = new OrderStatus();
                os = (OrderStatus)Enum.Parse(typeof(OrderStatus), Order_Status_ComboBox.Text);
            }


        }

        private void Order_ID_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_receive_Order_DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DeadLine_Order_DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }


        private void Order_Status_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Show_Order_Load(object sender, EventArgs e)
        {

        }

        private void Order_Priority_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Order_StartPreperation_DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Order_Profit_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowOrder_BackToManagment_Button_Click(object sender, EventArgs e)
        {
            OrderManagment OM = new OrderManagment();
            OM.Show();
            this.Hide();
        }

        private void Update_Order_Show_Button_Click(object sender, EventArgs e)
        {

            Date_receive_Order_DatePicker.Enabled = true;
            DeadLine_Order_DatePicker.Enabled = true;
            ProductsDits_TextBox.Enabled = true;
            Order_Status_ComboBox.Enabled = true;
            Order_Priority_ComboBox.Enabled = true;
            Order_StartPreperation_DatePicker.Enabled = true;
            Order_Profit_TextBox.Enabled = true;
            Requierment_TextBox.Enabled = true;
            Order_toArchive_button.Show();
        }

        private void Save_Details_Order_Show_Button_Click(object sender, EventArgs e)
        {
            dateReceived = DateTime.Parse(Date_receive_Order_DatePicker.Text);
            deadLine = DateTime.Parse(DeadLine_Order_DatePicker.Text);
            requirements = Requierment_TextBox.Text;
            status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Order_Status_ComboBox.Text);
            priority = (Priorities)Enum.Parse(typeof(Priorities), Order_Priority_ComboBox.Text);
            startPreparationDate = DateTime.Parse(Order_StartPreperation_DatePicker.Text);
            expectedProfit = Order_Profit_TextBox.Text;
            OrderProducts = ProductsDits_TextBox.Text;

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

                exist_order = Program.Search_Order(SearchOrder_ByID_Show_TextBox.Text);
                exist_order.set_DateReceived(dateReceived);
                exist_order.set_deadLine(deadLine);
                exist_order.set_requirements(requirements);
                exist_order.set_status(status);
                exist_order.set_priority(priority);
                exist_order.set_startPreparationDate(startPreparationDate);
                exist_order.set_expectedProfit(double.Parse(expectedProfit));
                exist_order.set_OrderProducts(OrderProducts);
                string text = "המוצר התעדכן בהצלחה!";
                this.Hide();
                MessageBox.Show(text);
                HomePageGeneral();
            }

            if (os != (OrderStatus)Enum.Parse(typeof(OrderStatus), Order_Status_ComboBox.Text))
            {
                Role r1 = new Role();
                Role r2 = new Role();

                if (exist_order.get_status() == (OrderStatus)Enum.Parse(typeof(OrderStatus), "waitingForProducts"))
                {
                    r1 = (Role)Enum.Parse(typeof(Role), "logistic");
                    r2 = (Role)Enum.Parse(typeof(Role), "logisticManager");
                    exist_order.add_to_orderEmployees(r1);
                    exist_order.add_to_orderEmployees(r2);
                }
                else if (exist_order.get_status() == (OrderStatus)Enum.Parse(typeof(OrderStatus), "inProductionProcess"))
                {
                    r1 = (Role)Enum.Parse(typeof(Role), "production");
                    r2 = (Role)Enum.Parse(typeof(Role), "productionManager");
                    exist_order.add_to_orderEmployees(r1);
                    exist_order.add_to_orderEmployees(r2);
                }
                else if (exist_order.get_status() == (OrderStatus)Enum.Parse(typeof(OrderStatus), "packeging"))
                {
                    r1 = (Role)Enum.Parse(typeof(Role), "storeKeeper");
                    exist_order.add_to_orderEmployees(r1);
                }
            }
            exist_order.Update_Order(Order_ID_Show_TextBox.Text);

        }

        private void Order_toArchive_button_Click(object sender, EventArgs e)
        {
            exist_order = Program.Search_Order(SearchOrder_ByID_Show_TextBox.Text);
            exist_order.move_Order_To_Archive(SearchOrder_ByID_Show_TextBox.Text);
            exist_order.set_IsArchived(true);
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

        private void Customer_Order_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Order_Label_Click(object sender, EventArgs e)
        {

        }

        private void Order_requierments_TextChanged(object sender, EventArgs e)
        {

        }

        private void Order_Details_Label_Click(object sender, EventArgs e)
        {

        }

        private void Requierment_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductsDits_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}