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
    public partial class Show_Product : Form
    {
        private string productId;
        private string productName;
        private string DefectivePercentage;
        private string description;
        private string partNumber;
        private string price;
        private Supplier supplier;
        private int quantity;
        private Boolean flag;
        private Employee e;

        Product exist_product;
        public Show_Product()
        {
            InitializeComponent();
            Update_Product_Show_Button.Hide();
            Product_toArchive_button.Hide();
            Update_Product_Show_Button.Hide();
            Save_Details_Product_Show_Button.Hide();
            Product_ID_Show_Textbox.Enabled = false;
            Product_Name_Show_TextBox.Enabled = false;
            Product_Quantity_Show_Textbox.Enabled = false; //DefectivePercentage
            Product_Descreption_Show_Textbox.Enabled = false;
            Product_PartNumber_Show_Textbox.Enabled = false;
            Product_Price_Show_Textbox.Enabled = false;
            SupplierID_TextBox.Enabled = false;
            quanity_TextBox.Enabled = false;
            e = Program.Search_Employee(Global.currentUser);

        }

        private void SearchProduct_ByID_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Product_Show_Button_Click(object sender, EventArgs e)
        {
            if (Program.Search_Product(SearchProduct_ByID_Show_TextBox.Text) == null)
            {
                string text = "מוצר לא נמצא במערכת";
                MessageBox.Show(text);
            }
            else
            // if (SearchEmployee_ByID_Show_TextBox.Text != null)
            {
                exist_product = Program.Search_Product(SearchProduct_ByID_Show_TextBox.Text);
                Product_ID_Show_Textbox.Text = exist_product.get_productId();
                Product_Name_Show_TextBox.Text = exist_product.get_productName();
                Product_Quantity_Show_Textbox.Text = exist_product.get_DefectivePercentage().ToString();
                Product_Descreption_Show_Textbox.Text = exist_product.get_description();
                Product_PartNumber_Show_Textbox.Text = exist_product.get_partNumber();
                Product_Price_Show_Textbox.Text = exist_product.get_price().ToString();
                SupplierID_TextBox.Text = exist_product.get_supplier().get_SupplierID();
                quanity_TextBox.Text = exist_product.get_quantity().ToString();
                Update_Product_Show_Button.Show();
                Update_Product_Show_Button.Show();
                Save_Details_Product_Show_Button.Show();

            }
        }

        private void Product_ID_Show_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product_Name_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product_Quantity_Show_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_Product_Load(object sender, EventArgs e)
        {

        }


        private void Product_Descreption_Show_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product_PartNumber_Show_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product_Price_Show_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowProdcut_BackToCRUD_Button_Click(object sender, EventArgs e)
        {
            Crud_Product CP = new Crud_Product();
            CP.Show();
            this.Hide();
        }

        private void Update_Product_Show_Button_Click(object sender, EventArgs e)
        {
            // Product_ID_Show_Textbox.Enabled = true;
            Product_Name_Show_TextBox.Enabled = true;
            Product_Quantity_Show_Textbox.Enabled = true;
            Product_Descreption_Show_Textbox.Enabled = true;
            Product_PartNumber_Show_Textbox.Enabled = true;
            Product_Price_Show_Textbox.Enabled = true;
            SupplierID_TextBox.Enabled = false;
            quanity_TextBox.Enabled = true;
            Product_toArchive_button.Show();
        }

        private void Save_Details_Product_Show_Button_Click(object sender, EventArgs e)
        {
            string supplierID = SupplierID_TextBox.Text;
            productId = Product_ID_Show_Textbox.Text;
            productName = Product_Name_Show_TextBox.Text;
            DefectivePercentage = Product_Quantity_Show_Textbox.Text;
            description = Product_Descreption_Show_Textbox.Text;
            partNumber = Product_PartNumber_Show_Textbox.Text;
            price = Product_Price_Show_Textbox.Text;
            this.supplier = Program.Search_Supplier(supplierID);
            quantity = int.Parse(quanity_TextBox.Text);
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
            else if (double.Parse(partNumber) <= 0)
            {
                flag = false;
                string text = "מספר חלק לא יכול להיות שלילי !";
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


            //check DefectivePercentage
            if (string.IsNullOrEmpty(DefectivePercentage))
            {
                flag = false;
                string text = "הכנס בבקשה אחוז פגומים  !";
                MessageBox.Show(text);
            }

            else if (idPattern.IsMatch(DefectivePercentage) == false)
            {
                flag = false;
                string text = "אחוז פגומים מכילה רק ספרות !";
                MessageBox.Show(text);
            }
            else if (double.Parse(DefectivePercentage) <= 0)
            {
                flag = false;
                string text = "הכנס בבקשה אחוז פגומים הגדול מ-0 !";
                MessageBox.Show(text);
            }
            else if (double.Parse(DefectivePercentage) >= 100)
            {
                flag = false;
                string text = "הכנס בבקשה אחוז פגומים הקטן מ-100 !";
                MessageBox.Show(text);
            }



            if (flag == true)
            {

                exist_product = Program.Search_Product(SearchProduct_ByID_Show_TextBox.Text);
                exist_product.set_productId(productId);
                exist_product.set_productName(productName);
                exist_product.set_DefectivePercentage(double.Parse(DefectivePercentage));
                exist_product.set_description(description);
                exist_product.set_partNumber(partNumber);
                exist_product.set_price(double.Parse(price));
                exist_product.set_supplier(supplier);
                exist_product.set_quantity(quantity);
                exist_product.Update_Product(Product_ID_Show_Textbox.Text);
                string text = "המוצר התעדכן בהצלחה!";
                this.Hide();
                MessageBox.Show(text);
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
        }

        private void Product_toArchive_button_Click(object sender, EventArgs e)
        {
            exist_product = Program.Search_Product(SearchProduct_ByID_Show_TextBox.Text);
            exist_product.move_Product_To_Archive(SearchProduct_ByID_Show_TextBox.Text);
            exist_product.set_IsArchived(true);
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

        private void SupplierID_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quanity_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}