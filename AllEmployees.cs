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
    public partial class AllEmployees : Form
    {
        private Employee existEmployee;
        private Employee e;
        public AllEmployees()
        {
            InitializeComponent();
            e = Program.Search_Employee(Global.currentUser);

        }

        private void AllEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_27DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.sAD_27DataSet.Employees);
            Coloumn_ComboBox.SelectedIndex = 1;

        }

        private void Search_by_Coloumn_ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (string.IsNullOrEmpty(Search_by_Coloumn_ComboBox.Text))
                        employeesBindingSource.Filter = string.Empty;
                    else
                        employeesBindingSource.Filter = string.Format("{0}='{1}'", Coloumn_ComboBox.Text, Search_by_Coloumn_ComboBox.Text);
                }
            }
        }

        private void Coloumn_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AllEmployess_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_by_Coloumn_ComboBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_EmployeeToActive_Button_Click(object sender, EventArgs e)
        {
            int currentRowIndex = AllEmployess_DataGrid.CurrentCell.RowIndex;
            String id = AllEmployess_DataGrid.Rows[currentRowIndex].Cells[0].Value.ToString();
            existEmployee = Program.Search_Employee(id);
            existEmployee = Program.Search_Employee(id);
            existEmployee.move_Employee_From_Archive(id);
            existEmployee.set_IsArchived(false);
            AllEmployess_DataGrid.Refresh();
        }

        private void Back_ToCrud_Button_Click(object sender, EventArgs e)
        {
            Crud_Employee CE = new Crud_Employee();
            CE.Show();
            this.Hide();
        }

        private void Employee_toArchive_button_Click(object sender, EventArgs e)
        {
            int currentRowIndex = AllEmployess_DataGrid.CurrentCell.RowIndex;
            String id = AllEmployess_DataGrid.Rows[currentRowIndex].Cells[0].Value.ToString();
            existEmployee = Program.Search_Employee(id);
            existEmployee.move_Employee_To_Archive(id);
            existEmployee.set_IsArchived(true);
            AllEmployess_DataGrid.Refresh();

        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.HR)
            {
                HomePageHR HR = new HomePageHR();
                HR.Show();
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