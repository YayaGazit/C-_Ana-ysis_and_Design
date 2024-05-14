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
    public partial class ShowSupplier : Form
    {
        private string supplierId;
        private string supplierName;
        private string supplierAddress;
        private string supplierPhone;
        private Boolean flag;
        private Supplier exists_supplier;
        private Employee e;
        public ShowSupplier()
        {
            InitializeComponent();
            Save_Details_Supplier_Show_Button.Hide();
            Update_Supplier_Show_Button.Hide();
            Supplier_toArchive_button.Hide();
            Supplier_ID_Show_TextBox.Enabled = false;
            Suppler_Name_Show_TextBox.Enabled = false;
            Supplier_Address_Show_TextBox.Enabled = false;
            Supplier_Phone_Show_TextBox.Enabled = false;
            e = Program.Search_Employee(Global.currentUser);

        }

        private void Supplier_ID_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Supplier_Show_Button_Click(object sender, EventArgs e)
        {
            if (Program.Search_Supplier(Supplier_ID_TextBox.Text) == null)
            {
                string text = "ספק לא נמצא במערכת";
                MessageBox.Show(text);
            }
            else
            {
                exists_supplier = Program.Search_Supplier(Supplier_ID_TextBox.Text);
                Save_Details_Supplier_Show_Button.Show();
                Update_Supplier_Show_Button.Show();
                Supplier_ID_Show_TextBox.Text = exists_supplier.get_SupplierID();
                Suppler_Name_Show_TextBox.Text = exists_supplier.get_SupplierName();
                Supplier_Address_Show_TextBox.Text = exists_supplier.get_supplierAddress();
                Supplier_Phone_Show_TextBox.Text = exists_supplier.get_SupplierPhone();
            }

        }

        private void Supplier_ID_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Suppler_Name_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Supplier_Address_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Supplier_Phone_Show_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowSupplier_BackToCRUD_Button_Click(object sender, EventArgs e)
        {
            Crud_Supplier CS = new Crud_Supplier();
            this.Hide();
            CS.Show();
        }

        private void Update_Supplier_Show_Button_Click(object sender, EventArgs e)
        {
            //  Supplier_ID_Show_TextBox.Enabled = true;
            Suppler_Name_Show_TextBox.Enabled = true;
            Supplier_Address_Show_TextBox.Enabled = true;
            Supplier_Phone_Show_TextBox.Enabled = true;
            Supplier_toArchive_button.Show();

        }

        private void Save_Details_Supplier_Show_Button_Click(object sender, EventArgs e)
        {
            supplierId = Supplier_ID_Show_TextBox.Text;
            supplierName = Suppler_Name_Show_TextBox.Text;
            supplierAddress = Supplier_Address_Show_TextBox.Text;
            supplierPhone = Supplier_Phone_Show_TextBox.Text;
            flag = true;


            var namePattern = new Regex("[a-z A-Z]");
            var idPattern = new Regex("[0-9]");
            var phonePattern = new Regex(@"^0\d{9}$");


            //check supplierId
            if (string.IsNullOrEmpty(supplierId))
            {
                flag = false;
                string text = "הכנס בבקשה תעודת זהות!";
                MessageBox.Show(text);
            }
            else if (supplierId.Length != 9)
            {
                flag = false;
                string text = "הכנס בבקשה 9 ספרות לתעודת זהות!";
                MessageBox.Show(text);
            }
            else if (idPattern.IsMatch(supplierId) == false)
            {
                string text = "תעודת זהות מרכיבה רק ספרות !";
                MessageBox.Show(text);
            }

            //check supplier Name
            if (string.IsNullOrEmpty(supplierName))
            {
                flag = false;
                string text = "הכנס שם בבקשה !";
                MessageBox.Show(text);

            }
            else if (!namePattern.IsMatch(supplierName))
            {
                flag = false;
                string text = "הכנס בבקשה את השם באנגלית בלבד  !";
                MessageBox.Show(text);
            }
            else if (supplierName.Length > 20)
            {
                flag = false;
                string text = "הכנס בבקשה שם עד 20 תווים !";
                MessageBox.Show(text);
            }

            //check supplier Address
            if (string.IsNullOrEmpty(supplierAddress))
            {
                flag = false;
                string text = "הכנס בבקשה כתובת!";
                MessageBox.Show(text);
            }
            else if (supplierAddress.Length > 100)
            {
                flag = false;
                string text = "הכנס בבקשה כתובת עד 100 תווים !";
                MessageBox.Show(text);
            }

            //check supplie rPhone
            if (string.IsNullOrEmpty(supplierPhone))
            {
                flag = false;
                string text = "הכנס בבקשה מספר פלאפון !";
                MessageBox.Show(text);
            }
            else if (!phonePattern.IsMatch(supplierPhone))
            {
                flag = false;
                string text = "הכנס בבקשה מספר פלאפון תקין-מספר המתחיל בספרה 0 ושהמספר יכיל  10 ספרות בלבד!";
                MessageBox.Show(text);
            }
            if (flag == true)
            {
                exists_supplier = Program.Search_Supplier(Supplier_ID_TextBox.Text);
                exists_supplier.set_SupplierID(supplierId);
                exists_supplier.set_SupplierName(supplierName);
                exists_supplier.set_supplierAddress(supplierAddress);
                exists_supplier.set_SupplierPhone(supplierPhone);
                exists_supplier.Update_Supplier(Supplier_ID_Show_TextBox.Text);
                string text = "הספק התעדכן בהצלחה!";
                this.Hide();
                MessageBox.Show(text);
                HomePageGeneral();
            }
        }

        private void Supplier_toArchive_button_Click(object sender, EventArgs e)
        {
            {
                exists_supplier = Program.Search_Supplier(Supplier_ID_TextBox.Text);
                exists_supplier.move_Supplier_To_Archive(Supplier_ID_TextBox.Text);
                exists_supplier.set_IsArchived(true);
            }
        }

        private void ShowSupplier_Load(object sender, EventArgs e)
        {

        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.logistic)
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
            if (this.e.get_EmployeeRole() == Role.logistic)
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
}