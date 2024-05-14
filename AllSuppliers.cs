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
    public partial class AllSuppliers : Form
    {
        private Supplier exist_supplier;
        private Employee e;
        public AllSuppliers()
        {
            InitializeComponent();
            e = Program.Search_Employee(Global.currentUser);

        }

        private void Coloumn_ComboBox_Supplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_by_Coloumn_Supplier_ComboBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AllSupplier_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_ToCrudSupplier_Button_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.storeKeeper)
            {
                HomePageStoreKeeper HS = new HomePageStoreKeeper();
                HS.Show();
                this.Hide();
            }
            else
            {
                Crud_Supplier CS = new Crud_Supplier();
                this.Hide();
                CS.Show();
            }
        }
        private void Supplier_toArchive_button_Click(object sender, EventArgs e)
        {
            int currentRowIndex = AllSupplier_DataGrid.CurrentCell.RowIndex;
            String id = AllSupplier_DataGrid.Rows[currentRowIndex].Cells[0].Value.ToString();
            exist_supplier = Program.Search_Supplier(id);
            exist_supplier.move_Supplier_To_Archive(id);
            exist_supplier.set_IsArchived(true);
            AllSupplier_DataGrid.Refresh();

        }

        private void Back_SupplierToActive_Button_Click(object sender, EventArgs e)
        {
            //  לבדוק אם יש אפשרות ללחוץ על התא מסויים בשורה ושהוא יזהה את האידי המתאים 
            int currentRowIndex = AllSupplier_DataGrid.CurrentCell.RowIndex;
            String id = AllSupplier_DataGrid.Rows[currentRowIndex].Cells[0].Value.ToString();
            exist_supplier = Program.Search_Supplier(id);
            exist_supplier.move_Supplier_From_Archive(id);
            exist_supplier.set_IsArchived(false);
            AllSupplier_DataGrid.Refresh();
        }

        private void AllSuppliers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_27DataSet1.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.sAD_27DataSet1.Suppliers);
            Coloumn_ComboBox_Supplier.SelectedIndex = 1;
        }

        private void Search_by_Coloumn_Supplier_ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (string.IsNullOrEmpty(Search_by_Coloumn_Supplier_ComboBox.Text))
                        suppliersBindingSource.Filter = string.Empty;
                    else
                        suppliersBindingSource.Filter = string.Format("{0}='{1}'", Coloumn_ComboBox_Supplier.Text, Search_by_Coloumn_Supplier_ComboBox.Text);
                }
            }
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
    }
}