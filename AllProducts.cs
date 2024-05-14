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
    public partial class AllProducts : Form
    {
        private Employee e;
        private Product exist_product;
        public AllProducts()
        {
            InitializeComponent();
            e = Program.Search_Employee(Global.currentUser);
        }

        private void Coloumn_Product_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_by_Products_Coloumn_ComboBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AllProducts_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_27DataSet15.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter2.Fill(this.sAD_27DataSet15.Products);
            // TODO: This line of code loads data into the 'sAD_27DataSet14.Products' table. You can move, or remove it, as needed.



        }

        private void Product_toArchive_button_Click(object sender, EventArgs e)
        {
            int currentRowIndex = AllProducts_DataGrid.CurrentCell.RowIndex;
            String id = AllProducts_DataGrid.Rows[currentRowIndex].Cells[0].Value.ToString();
            exist_product = Program.Search_Product(id);
            exist_product.move_Product_To_Archive(id);
            exist_product.set_IsArchived(true);
            AllProducts_DataGrid.Refresh();
        }

        private void Back_Product_ToActive_Button_Click(object sender, EventArgs e)
        {
            //  לבדוק אם יש אפשרות ללחוץ על התא מסויים בשורה ושהוא יזהה את האידי המתאים 
            int currentRowIndex = AllProducts_DataGrid.CurrentCell.RowIndex;
            String Productid = AllProducts_DataGrid.Rows[currentRowIndex].Cells[0].Value.ToString();
            exist_product = Program.Search_Product(Productid);
            exist_product.move_Product_From_Archive(Productid);
            exist_product.set_IsArchived(false);
            AllProducts_DataGrid.Refresh();

        }

        private void Back_ToProduct_Crud_Button_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.production)
            {
                HomePageProduction HP = new HomePageProduction();
                HP.Show();
                this.Hide();
            }

            else
            {
                Crud_Product CP = new Crud_Product();
                this.Hide();
                CP.Show();
            }
           
        }

        private void Search_by_Products_Coloumn_ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(Search_by_Products_Coloumn_ComboBox.Text))
                    productsBindingSource2.Filter = string.Empty;
                else
                    productsBindingSource2.Filter = string.Format("{0}='{1}'", Coloumn_Product_ComboBox.Text, Search_by_Products_Coloumn_ComboBox.Text);
            }
        }

        private void All_Product_Label_Click(object sender, EventArgs e)
        {

        }

        private void Search_label_Click(object sender, EventArgs e)
        {

        }

        private void Coloumn_Label_Click(object sender, EventArgs e)
        {

        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.production)
            {
                HomePageProduction HP = new HomePageProduction();
                HP.Show();
                this.Hide();
            }
           else if (this.e.get_EmployeeRole() == Role.storeKeeper)
            {
                HomePageStoreKeeper HS = new HomePageStoreKeeper();
                HS.Show();
                this.Hide();
            }
          else if (this.e.get_EmployeeRole() == Role.logistic)
            {
                HomePageLogistic HL = new HomePageLogistic();
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
        private void AllProducts_DataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}