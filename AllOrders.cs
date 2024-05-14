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
    public partial class AllOrders : Form
    {
        private Order exist_order;
        private Employee e;
        public AllOrders()
        {
            InitializeComponent();
            dataGridView1.Refresh();
            e = Program.Search_Employee(Global.currentUser);
        }

        private void Coloumn_Order_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_by_Order_Coloumn_ComboBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void Back_ToOrder_Managment_Button_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.logistic|| this.e.get_EmployeeRole() == Role.storeKeeper || this.e.get_EmployeeRole() == Role.production)
            {
                if(this.e.get_EmployeeRole() == Role.logistic)
                {
                    HomePageLogistic HL = new HomePageLogistic();
                    HL.Show();
                    this.Hide();
                }
                else if (this.e.get_EmployeeRole() == Role.storeKeeper)
                {
                    HomePageStoreKeeper HS = new HomePageStoreKeeper();
                    HS.Show();
                    this.Hide();
                }
                else if (this.e.get_EmployeeRole() == Role.production)
                {
                    HomePageProduction HP = new HomePageProduction();
                    HP.Show();
                    this.Hide();
                }

            }
            else
            { 
            OrderManagment OM = new OrderManagment();
            OM.Show();
            this.Hide();
        }
            }

        private void Order_toArchive_button_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            String id = dataGridView1.Rows[currentRowIndex].Cells[0].Value.ToString();
            exist_order = Program.Search_Order(id);
            exist_order.move_Order_To_Archive(id);
            exist_order.set_IsArchived(true);
            dataGridView1.Refresh();
        }

        private void Back_Order_ToActive_Button_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            String id = dataGridView1.Rows[currentRowIndex].Cells[0].Value.ToString();
            exist_order = Program.Search_Order(id);
            exist_order.move_Order_From_Archive(id);
            exist_order.set_IsArchived(false);
            dataGridView1.Refresh();


        }

        private void Search_by_Order_Coloumn_ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(Search_by_Order_Coloumn_ComboBox.Text))
                    ordersBindingSource5.Filter = string.Empty;
                else
                    ordersBindingSource5.Filter = string.Format("{0}='{1}'", Coloumn_Order_ComboBox.Text, Search_by_Order_Coloumn_ComboBox.Text);
            }
        }

        private void AllOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_27DataSet13.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter5.Fill(this.sAD_27DataSet13.Orders);
            // TODO: This line of code loads data into the 'sAD_27DataSet12.Orders' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'sAD_27DataSet11.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter4.Fill(this.sAD_27DataSet11.Orders);
            // TODO: This line of code loads data into the 'sAD_27DataSet10.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter3.Fill(this.sAD_27DataSet10.Orders);
            // TODO: This line of code loads data into the 'sAD_27DataSet9.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter2.Fill(this.sAD_27DataSet9.Orders);
            // TODO: This line of code loads data into the 'sAD_27DataSet8.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.sAD_27DataSet8.Orders);
            // TODO: This line of code loads data into the 'sAD_27DataSet4.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.sAD_27DataSet4.Orders);

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
                HomePageStoreKeeper HS = new HomePageStoreKeeper();
                HS.Show();
                this.Hide();
            }
            else if (this.e.get_EmployeeRole() == Role.production)
            {
                HomePageProduction HP = new HomePageProduction();
                HP.Show();
                this.Hide();
            }
            else if (this.e.get_EmployeeRole() == Role.salesPerson)
            {
                HomePageSales HP = new HomePageSales();
                HP.Show();
                this.Hide();
            }

            else 
            {
                HomePageManagers HM = new HomePageManagers();
                HM.Show();
                this.Hide();
            }

        }

        private void AllOrder_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}