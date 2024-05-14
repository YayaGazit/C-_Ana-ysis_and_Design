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
    public partial class AllCustomers : Form
    {
        private Customer exist_customer;
        private Employee e;
        public AllCustomers()
        {
            InitializeComponent();
            e = Program.Search_Employee(Global.currentUser);

        }

        private void Coloumn_Customer_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_by_Coloumn_Customer_ComboBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AllCustomers_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_ToCrud_Customers_Button_Click(object sender, EventArgs e)
        {
            Crud_Customer CC = new Crud_Customer();
            CC.Show();
            this.Hide();
        }

        private void Customer_toArchive_button_Click(object sender, EventArgs e)
        {
            int currentRowIndex = AllCustomers_DataGrid.CurrentCell.RowIndex;
            String id = AllCustomers_DataGrid.Rows[currentRowIndex].Cells[0].Value.ToString();
            exist_customer = Program.Search_Customer(id);
            exist_customer.move_Customer_To_Archive(id);
            exist_customer.set_IsArchived(true);
            AllCustomers_DataGrid.Refresh();
        }

        private void Back_CustomerToActive_Button_Click(object sender, EventArgs e)
        {
            //  לבדוק אם יש אפשרות ללחוץ על התא מסויים בשורה ושהוא יזהה את האידי המתאים 
            int currentRowIndex = AllCustomers_DataGrid.CurrentCell.RowIndex;
            String id = AllCustomers_DataGrid.Rows[currentRowIndex].Cells[0].Value.ToString();
            exist_customer = Program.Search_Customer(id);
            exist_customer.move_Customer_From_Archive(id);
            exist_customer.set_IsArchived(false);
            AllCustomers_DataGrid.Refresh();

        }

        private void AllCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_27DataSet3.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.sAD_27DataSet3.Customers);

        }

        private void Search_by_Coloumn_Customer_ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(Search_by_Coloumn_Customer_ComboBox.Text))
                    customersBindingSource.Filter = string.Empty;
                else
                    customersBindingSource.Filter = string.Format("{0}='{1}'", Coloumn_Customer_ComboBox.Text, Search_by_Coloumn_Customer_ComboBox.Text);
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
            else if (this.e.get_EmployeeRole() == Role.customerService)
            {
                HomePageCustomerService HCS = new HomePageCustomerService();
                HCS.Show();
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