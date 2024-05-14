using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_27
{
    public partial class CreateOrderFromSupplier : Form
    {
        private Boolean flag;
        private Boolean flagFinish;//להבין מה עושים איתו
        private List<Product> listProductsTemp;
        private OrderFromSupplier orderFromSupplier;
        private DateTime orderDate;
        private string supplierDescription;
        private Product product;
        private Supplier supplier;
        private Product newp;
        private Employee e;
        private string supplierID;
        private string productID;
        private string productName;
        private string productDescription;
        private string productPartNumber;
        private double productPrice;
        private string productQuantity;
        public CreateOrderFromSupplier()
        {
            InitializeComponent();
            e = Program.Search_Employee(Global.currentUser);
            listProductsTemp = new List<Product>();

        }

        private void CreateOrderFromSupplier_Load(object sender, EventArgs e)
        {

        }

        private void getProduct()
        {
            foreach (Product P in Program.Products)
            {
                if (P.get_productId() == Product_Id_Textbox.Text)
                    add_Product_ToORS_DataGrid.Rows.Add(this.productID, this.productQuantity);
            }
        }


        private void Supplier_ID_TextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Add_Product_OFS_Button_Click_1(object sender, EventArgs e)
        {

            flag = true;
            this.supplierID = Supplier_ID_TextBox.Text;
            this.orderDate = DateTime.Parse(orderFromSupplier_datePicker.Text); // לשנות להזנת תאריך מלוח שנה
            this.supplierDescription = OrderFS_Details_Textbox.Text;
            this.productID = Product_Id_Textbox.Text;
            this.productQuantity = add_quantity_textbox.Text;


            if (string.IsNullOrEmpty(supplierID))
            {
                flag = false;
                string text = "הכנס בבקשה מזהה ספק !";
                MessageBox.Show(text);
            }

            else if (Program.Search_Supplier(supplierID) == null)
            {
                flag = false;
                string text = "ספק זה אינו קיים,אנא הכנס ספק אחר !";
                MessageBox.Show(text);
            }

            if (string.IsNullOrEmpty(productID))
            {
                flag = false;
                string text = "הכנס בבקשה מזהה מוצר !";
                MessageBox.Show(text);
            }

            else if (Program.Search_Product(productID) == null)
            {
                flag = false;
                string text = "מוצר זה אינו קיים,אנא הכנס מוצר אחר !";
                MessageBox.Show(text);
            }


            if (string.IsNullOrEmpty(productQuantity))
            {
                flag = false;
                string text = "הכנס בבקשה כמות יחידות ממוצר זה !";
                MessageBox.Show(text);
            }
            else if (int.Parse(productQuantity) <= 0)
            {
                flag = false;
                string text = "הכנס בבקשה כמות יחידות גדולה מ-0 !";
                MessageBox.Show(text);
            }

            if (flag == true)
            {
                this.supplier = Program.Search_Supplier(supplierID);
                this.product = Program.Search_Product(productID);
                productName = product.get_productName();
                productDescription = product.get_description();
                productPartNumber = product.get_partNumber();
                productPrice = product.get_price();
            }
            //בודק אם הספק מספק את המוצר
            if (flag == true)
            {
                if (product.get_supplier().get_SupplierID() != supplierID)
                {
                    flag = false;
                    string text = "ספק זה אינו מספק את המוצר שבחרת,אנא בחר מוצר אחר !";
                    MessageBox.Show(text);
                }

                //לבדוק האם המוצר שמנסים להזמין קיים ברשימת המוצרים של הספק
                else if (!supplier.get_ListProducts().Contains(product))
                {
                    flag = false;
                    string text = "ספק זה אינו מספק את המוצר,בחר מוצר חדש או החלף ספק !";
                    MessageBox.Show(text);
                }
            }

            // חריגה שהוא מנסה לצרף את אותו מוצר פעמיים להזמנה הזאת
            foreach (Product P in listProductsTemp)
            {
                if (P.get_productId() == Product_Id_Textbox.Text)
                {
                    flag = false;
                    string text = "מוצר זה נמצא כבר בהזמנה,אנא בחר מוצר אחר או מחק מוצר והוסף מחדש עם כמות רצויה !";
                    MessageBox.Show(text);
                }

            }
            if (flag == true)
            {
                this.newp = new Product(productID, ProductName, productDescription, productPartNumber, productPrice, supplier, int.Parse(productQuantity), false, false);
                listProductsTemp.Add(newp);
                getProduct();
                Product_Id_Textbox.Clear();
                add_quantity_textbox.Clear();

            }

        }

        private void Product_Id_Textbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void add_quantity_textbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void add_Product_ToORS_DataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderFromSupplier_datePicker_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void finish_Button_Click_1(object sender, EventArgs e)
        {
            flag = true;
            flagFinish = true;
            //אם התאריך הזמנה קיים כבר בהזמנה מספק זה אז להוציא חריגה

            if (string.IsNullOrEmpty(supplierID))
            {
                flag = false;
                string text = "הכנס בבקשה מזהה ספק !";
                MessageBox.Show(text);
            }

            else if (Program.Search_Supplier(supplierID) == null)
            {
                flag = false;
                string text = "ספק זה אינו קיים,אנא הכנס ספק אחר !";
                MessageBox.Show(text);
            }

            if (string.IsNullOrEmpty(productID))
            {
                flag = false;
                string text = "הכנס בבקשה מזהה מוצר !";
                MessageBox.Show(text);
            }

            else if (Program.Search_Product(productID) == null)
            {
                flag = false;
                string text = "מוצר זה אינו קיים,אנא הכנס מוצר אחר !";
                MessageBox.Show(text);
            }


            if (string.IsNullOrEmpty(productQuantity))
            {
                flag = false;
                string text = "הכנס בבקשה כמות יחידות ממוצר זה !";
                MessageBox.Show(text);
            }
            else if (int.Parse(productQuantity) <= 0)
            {
                flag = false;
                string text = "הכנס בבקשה כמות יחידות גדולה מ-0 !";
                MessageBox.Show(text);
            }







            if (flag == true)
            {
                if (Program.Search_OrderFromSupplier(supplierID, orderDate) != null)
                {
                    flagFinish = false;
                    string text = "תאריך הזמנה מספק זה קיים,הכנס בבקשה תאריך אחר או ספק אחר !";
                    MessageBox.Show(text);

                }
                if (orderDate > DateTime.Now)
                {
                    flagFinish = false;
                    string text = "  תאריך יצירת הזמנה לא יכול להיות תאריך עתידי";
                    MessageBox.Show(text);
                }
                //לבדוק חריגת סיום עם הדגל סיום
                if (flagFinish == true)
                {
                    this.orderFromSupplier = new OrderFromSupplier(supplier, orderDate, supplierDescription, true);
                    //orderFromSupplier.AddProduct(this.newp);


                    foreach (Product P in listProductsTemp)
                    {
                        this.orderFromSupplier.get_AllProducts().Add(P);
                    }
                    this.orderFromSupplier.createProductsToSupplier();
                    string text = "ההזמנה לספק בוצעה בהצלחה!";
                    MessageBox.Show(text);

                    if (this.e.get_EmployeeRole() == Role.logistic)
                    {
                        HomePageLogistic HL = new HomePageLogistic();
                        HL.Show();
                        this.Hide();
                    }
                    else if (this.e.get_EmployeeRole() == Role.storeKeeper)
                    {
                        HomePageStoreKeeper HL = new HomePageStoreKeeper();
                        HL.Show();
                        this.Hide();
                    }


                    else
                    {
                        HomePageManagers HM = new HomePageManagers();
                        HM.Show();
                        this.Hide();
                    }
                }
                else
                {
                    string text = "ההזמנה לספק לא בוצעה!";
                    MessageBox.Show(text);
                }
            }
        }



        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.logistic)
            {
                HomePageLogistic HL = new HomePageLogistic();
                HL.Show();
                this.Hide();
            }
            else if (this.e.get_EmployeeRole() == Role.storeKeeper)
            {
                HomePageStoreKeeper HL = new HomePageStoreKeeper();
                HL.Show();
                this.Hide();
            }


            else
            {
                HomePageManagers HM = new HomePageManagers();
                HM.Show();
                this.Hide();
            }
        }

        private void Delete_Product_OFS_Button_Click(object sender, EventArgs e)
        {
            //לבחור פה רשומה מהדאטה גריד ולמחוק אותה מהרשימה של הטמפפרודקט
            int currentRowIndex = add_Product_ToORS_DataGrid.CurrentCell.RowIndex;
            String ProductID = add_Product_ToORS_DataGrid.Rows[currentRowIndex].Cells[0].Value.ToString();
            int RowIndex = add_Product_ToORS_DataGrid.CurrentRow.Index;
            for (int i = 0; i < listProductsTemp.Count; i++)
            {
                if (listProductsTemp.ElementAt(i).get_productId() == ProductID)
                {
                    listProductsTemp.RemoveAt(i);
                    int r = add_Product_ToORS_DataGrid.CurrentCell.RowIndex;
                    add_Product_ToORS_DataGrid.Rows.RemoveAt(r);
                    add_Product_ToORS_DataGrid.Refresh();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.storeKeeper)
            {
                HomePageStoreKeeper HL = new HomePageStoreKeeper();
                HL.Show();
                this.Hide();
            }
            else
            {
                Crud_Supplier cs = new Crud_Supplier();
                cs.Show();
                this.Hide();
            }
        }
    }
}