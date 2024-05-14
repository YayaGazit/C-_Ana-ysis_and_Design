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
    public partial class SortProdutionProcess : Form
    {
        private Dictionary<string, int> SortedbyMoney;
        private Dictionary<string, int> SortedbyPriority;
        private Dictionary<string, DateTime> SortedbyDeadLine;
        private Dictionary<string, double> final;
        private Employee e;
        public SortProdutionProcess()
        {
            InitializeComponent();
            FFinalOrders_DataGrid.Hide();
            e = Program.Search_Employee(Global.currentUser);
            
        }

        private void SortProdutionProcess_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_27DataSet16.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.sAD_27DataSet16.Orders);
            foreach (Order o in Program.Orders)
            {
                if (o.get_status().ToString() == "waitingForProducts" || o.get_status().ToString() == "inProductionProcess") //הזמנות שטרם התחילו או שרק התחילו ממש עכשיו
                    OrdersDataGrid.Rows.Add(o.get_OrderId(), o.get_DateReceived(), o.get_deadLine(), o.get_requirements(), o.get_status(), o.get_priority(), o.get_startPreparationDate(), o.get_expectedProfit(), o.get_customer().get_customerId());
            }

        }



        private void OrdersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.production)
            {
                HomePageProduction HS = new HomePageProduction();
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

        private void Sort_Orders_Button_Click(object sender, EventArgs e)
        {
            this.SortedbyMoney = new Dictionary<string, int>();
            this.SortedbyPriority = new Dictionary<string, int>();
            this.SortedbyDeadLine = new Dictionary<string, DateTime>();
            this.final = new Dictionary<string, double>();


            for (int i = 0; i < OrdersDataGrid.RowCount - 1; i++)
            {

                int Money = int.Parse(OrdersDataGrid.Rows[i].Cells[7].Value.ToString());
                string Priority = OrdersDataGrid.Rows[i].Cells[5].Value.ToString();
                int NewPriority = ConvertPriorityToINT(Priority);
                DateTime DeadLine = DateTime.Parse(OrdersDataGrid.Rows[i].Cells[2].Value.ToString());
                this.SortedbyMoney.Add(OrdersDataGrid.Rows[i].Cells[0].Value.ToString(), Money);
                this.SortedbyPriority.Add(OrdersDataGrid.Rows[i].Cells[0].Value.ToString(), NewPriority);
                this.SortedbyDeadLine.Add(OrdersDataGrid.Rows[i].Cells[0].Value.ToString(), DeadLine);
            }
            var sortedMoney = from data in SortedbyMoney orderby data.Value select data;
            var sortedPriority = from data in SortedbyPriority orderby data.Value select data;
            var sortedDeadLine = SortedbyDeadLine.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);



            Dictionary<string, int> MMoney = new Dictionary<string, int>();
            Dictionary<string, int> PPriority = new Dictionary<string, int>();
            Dictionary<string, DateTime> DDeadLine = new Dictionary<string, DateTime>();

            for (int i = sortedMoney.Count() - 1; i >= 0; i--)
            {
                MMoney.Add(sortedMoney.ElementAt(i).Key, sortedMoney.ElementAt(i).Value);
            }
            for (int i = sortedPriority.Count() - 1; i >= 0; i--)
            {
                PPriority.Add(sortedPriority.ElementAt(i).Key, sortedPriority.ElementAt(i).Value);
            }
            for (int i = 0; i < sortedDeadLine.Count(); i++)
            {
                DDeadLine.Add(sortedDeadLine.ElementAt(i).Key, sortedDeadLine.ElementAt(i).Value);
            }


            for (int i = 0; i < OrdersDataGrid.RowCount - 1; i++)
            {
                string orderId = OrdersDataGrid.Rows[i].Cells[0].Value.ToString();
                int temp1 = MMoney.Keys.ToList().IndexOf(orderId);
                int temp2 = PPriority[orderId];
                int temp3 = DDeadLine.Keys.ToList().IndexOf(orderId);

                double x = 0.333 * ((MMoney.Count() - 1) - temp1) + 0.333 * temp2 + 0.333 * ((DDeadLine.Count() - 1) - temp3);
                final.Add(orderId, x);

            }

            var sortedFinal = from data in final orderby data.Value select data;

            Dictionary<string, double> FFinal = new Dictionary<string, double>();

            for (int i = sortedFinal.Count() - 1; i >= 0; i--)
            {
                FFinal.Add(sortedFinal.ElementAt(i).Key, sortedFinal.ElementAt(i).Value);
            }
            OrdersDataGrid.Hide();

            for (int i = 0; i < FFinal.Count; i++)
            {
                string o = FFinal.Keys.ElementAt(i);
                double urgency = FFinal.Values.ElementAt(i);
                Order order = Program.Search_Order(o);
                FFinalOrders_DataGrid.Rows.Add(order.get_OrderId(), order.get_DateReceived(), order.get_deadLine(), order.get_requirements(), order.get_status(), order.get_priority(), order.get_startPreparationDate(), order.get_expectedProfit(), order.get_customer().get_customerId(), urgency);
            }
            FFinalOrders_DataGrid.Show();
            Sort_Orders_Button.Hide();
        }



        private int ConvertPriorityToINT(string Priority)
        {
            if (Priority == "critical")
                return 8;
            else if (Priority == "high")
                return 6;
            else if (Priority == "medium")
                return 4;
            else
                return 2;

        }

        private void ShowOrder_BackToManagment_Button_Click(object sender, EventArgs e)
        {
            ProductionProcessManagment OM = new ProductionProcessManagment();
            OM.Show();
            this.Hide();
        }
    }


}
