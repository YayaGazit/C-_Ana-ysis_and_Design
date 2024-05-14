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
    public partial class AddProduct : Form
    {
        private string productId;
        private string productName;
        private string description;
        private string partNumber;
        private string price;
        private Supplier supplierId;
        private string quantity;
        private Boolean flag;
        private Employee e;


        public AddProduct()
        {
            InitializeComponent();
            e = Program.Search_Employee(Global.currentUser);

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void Product_ID_Textbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Product_Name_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product_Descreption_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product_PartNumber_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product_Price_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input_Product_Button_Click(object sender, EventArgs e)
        {
            string supplierID = SupplierID_TextBox.Text;
            productId = Product_ID_Textbox.Text;
            productName = Product_Name_TextBox.Text;
            description = Product_Descreption_Textbox.Text;
            partNumber = Product_PartNumber_Textbox.Text;
            price = Product_Price_Textbox.Text;
            this.supplierId = Program.Search_Supplier(supplierID);
            quantity = quanity_TextBox.Text;
            flag = true;

            var idPattern = new Regex("[0-9]");

            //check Supplier
            if (Program.Search_Supplier(supplierID) == null)
            {
                flag = false;
                string text = "הכנס בבקשה ספק קיים במערכת!";
                MessageBox.Show(text);

            }
            //check productId
            if (string.IsNullOrEmpty(productId))
            {
                flag = false;
                string text = "הכנס בבקשה מזהה מוצר!";
                MessageBox.Show(text);
            }
            else if (productId.Length > 20)
            {
                flag = false;
                string text = "הכנס בבקשה מזהה מוצר עד 20 תווים !";
                MessageBox.Show(text);

            }
            //check product Name
            if (string.IsNullOrEmpty(productName))
            {
                flag = false;
                string text = "הכנס בבקשה שם מוצר !";
                MessageBox.Show(text);

            }

            else if (productName.Length > 20)
            {
                flag = false;
                string text = "הכנס בבקשה שם מוצר עד 20 תווים !";
                MessageBox.Show(text);

            }



            //check description
            if (description.Length > 100)
            {
                flag = false;
                string text = "הכנס בבקשה תיאור עד 100 תווים בלבד !";
                MessageBox.Show(text);
            }

            //check part Number
            if (string.IsNullOrEmpty(partNumber))
            {
                flag = false;
                string text = "הכנס בבקשה מספר חלק  !";
                MessageBox.Show(text);
            }

            else if (partNumber.Length > 20)
            {
                flag = false;
                string text = "הכנס בבקשה מספר חלק עד 20 תווים בלבד !";
                MessageBox.Show(text);
            }

            else if (idPattern.IsMatch(partNumber) == false)
            {
                flag = false;
                string text = "מספר חלק מכיל רק ספרות !";
                MessageBox.Show(text);
            }
           
            //check price
            if (string.IsNullOrEmpty(price))
            {
                flag = false;
                string text = "הכנס בבקשה מחיר  !";
                MessageBox.Show(text);
            }

            else if (idPattern.IsMatch(price) == false)
            {
                flag = false;
                string text = "מחיר מכילה רק ספרות !";
                MessageBox.Show(text);
            }
            else if (double.Parse(price) <= 0)
            {
                flag = false;
                string text = "הכנס בבקשה מחיר הגדול מ-0 !";
                MessageBox.Show(text);
            }

            //check quantity
            if (string.IsNullOrEmpty(quantity))
            {
                flag = false;
                string text = "הכנס בבקשה כמות  !";
                MessageBox.Show(text);
            }

            else if (idPattern.IsMatch(quantity) == false)
            {
                flag = false;
                string text = "כמות מכילה רק ספרות !";
                MessageBox.Show(text);
            }
            else if (double.Parse(quantity) <= 0)
            {
                flag = false;
                string text = "הכנס בבקשה כמות הגדולה מ-0 !";
                MessageBox.Show(text);
            }



            if (flag == true)
            {
                if (Program.Search_Product(productId) == null)
                {
                    Supplier supplier = Program.Search_Supplier(supplierID);
                    Product p = new Product(productId, productName, description, partNumber, double.Parse(price), supplier, int.Parse(quantity), false, true);
                    string text = "המוצר נוסף בהצלחה!";
                    this.Hide();
                    MessageBox.Show(text);
                    HomePageGeneral();
                }
                else
                {
                    string text = "המוצר כבר קיים במערכת!";
                    MessageBox.Show(text);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crud_Product CP = new Crud_Product();
            CP.Show();
            this.Hide();
        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.storeKeeper)
            {
                HomePageStoreKeeper HS = new HomePageStoreKeeper();
                HS.Show();
                this.Hide();
            }
            else if (this.e.get_EmployeeRole() == Role.logistic)
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

        public void HomePageGeneral()
        {
            if (this.e.get_EmployeeRole() == Role.storeKeeper)
            {
                HomePageStoreKeeper HS = new HomePageStoreKeeper();
                HS.Show();
                this.Hide();
            }
            else if (this.e.get_EmployeeRole() == Role.logistic)
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

        private void SupplierID_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quanity_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}