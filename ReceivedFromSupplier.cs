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
    public partial class ReceivedFromSupplier : Form
    {
        private Boolean flagFinish, flagInput;
        private Dictionary<Product, double> savePercentageForP;//שומר את האחוז הפגומים לכל מוצר בהזמנה
        private Dictionary<Product, int> saveQuantityForP;
        private OrderFromSupplier orderFromSupplier;
        private DateTime orderDate;
        private DateTime receivedOrderDate;
        private string supplierID;
        private string supplierDescription;
        private string productQuantity;
        private string defectiveQuantity;
        private SupplierStatus supplierStatus;
        private IntactnessStatus IntactStatus;
        private Employee e;


        public ReceivedFromSupplier()
        {

            InitializeComponent();
            Finished_Received_Buton.Hide();
            Received_Order_Status_label_comboBox.DataSource = Enum.GetValues(typeof(SupplierStatus));
            Received_IntactnessStatu_ComboBox.DataSource = Enum.GetValues(typeof(IntactnessStatus));
            Received_Order_Status_label_comboBox.Enabled = false;
            Received_IntactnessStatu_ComboBox.Enabled = false;
            Receive_Date_dateTimePicker.Enabled = false;
            Recieved_OrderFS_Details_Textbox.Enabled = false;
            Recieved_quanity_TextBox.Enabled = false;
            Recieved_DefectivePercantage_Textbox.Enabled = false;
            Recieved_Input_Product.Hide();
            savePercentageForP = new Dictionary<Product, double>();
            saveQuantityForP = new Dictionary<Product, int>();
            e = Program.Search_Employee(Global.currentUser);

        }

        private void ReceivedFromSupplier_Load(object sender, EventArgs e)
        {

        }

        private void Supplier_ID_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Recieve_dorderFromSupplier_datePicker_ValueChanged(object sender, EventArgs e)
        {
            Finished_Received_Buton.Show();
        }

        private void Recieved_OrderFS_Details_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Recieved_Product_ID_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Recieved_Product_Descreption_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderReceived_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void inputDataGrid()
        {
            foreach (Product p in orderFromSupplier.get_AllProducts())
            {

                OrderReceived_DataGrid.Rows.Add(p.get_productId(), p.get_quantity());
                OrderReceived_DataGrid.Refresh();

            }
            Recieved_OrderFS_Details_Textbox.Text = orderFromSupplier.get_SupplierDescription();

        }

        private void Recieved_quanity_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Recieved_DefectivePercantage_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Recieved_Input_Product_Click(object sender, EventArgs e)
        {

            flagInput = true;
            productQuantity = Recieved_quanity_TextBox.Text;
            defectiveQuantity = Recieved_DefectivePercantage_Textbox.Text;
            var idPattern = new Regex("[0-9]");
            int currentRowIndex = OrderReceived_DataGrid.CurrentCell.RowIndex;
            String productID = OrderReceived_DataGrid.Rows[currentRowIndex].Cells[0].Value.ToString();
            Product product = Program.Search_Product(productID);

            if (string.IsNullOrEmpty(defectiveQuantity))
            {
                flagInput = false;
                string text = "הזן בבקשה מספר פגומים,אם אין פגומים הזן 0 !";
                MessageBox.Show(text);
            }

            else if (idPattern.IsMatch(defectiveQuantity) == false)
            {
                flagInput = false;
                string text = "מספר פגומים מכילה רק ספרות !";
                MessageBox.Show(text);
            }

            else if (int.Parse(defectiveQuantity) < 0)
            {
                flagInput = false;
                string text = "הזן בבקשה מספר פגומים,אם אין פגומים הזן 0 !";
                MessageBox.Show(text);
            }

            if (string.IsNullOrEmpty(productQuantity))
            {
                flagInput = false;
                string text = "הזן בבקשה כמות שהגיע מפריט ,אם אין בכלל הזן 0 !";
                MessageBox.Show(text);
            }

            else if (idPattern.IsMatch(productQuantity) == false)
            {
                flagInput = false;
                string text = " כמות שהגיע מפריט מכילה רק ספרות !";
                MessageBox.Show(text);
            }

            else if (int.Parse(productQuantity) < 0)
            {
                flagInput = false;
                string text = "הזן בבקשהכמות שהגיע מפריט,אם אין פגומים הזן 0 !";
                MessageBox.Show(text);
            }

            else if (int.Parse(productQuantity) < 0 || string.IsNullOrEmpty(productQuantity))
            {
                flagInput = false;
                string text = "לא ניתן לקבל כמות פריטים שלילית,אנא הכנס כמות תקינה !";
                MessageBox.Show(text);
            }

            else if (int.Parse(OrderReceived_DataGrid.CurrentRow.Cells[1].Value.ToString()) < int.Parse(productQuantity))
            {
                flagInput = false;
                string text = "לא ניתן לקבל יותר פריטים ממה שהוזמן,אנא הכנס כמות תקינה !";
                MessageBox.Show(text);
            }


            if (flagInput == true)
            {
                if (saveQuantityForP.ContainsKey(product) == true)
                {
                    saveQuantityForP.Remove(product);
                }

                if (savePercentageForP.ContainsKey(product) == true)
                {
                    savePercentageForP.Remove(product);
                }

                int notArrivedProducts = (int.Parse(OrderReceived_DataGrid.CurrentRow.Cells[1].Value.ToString()) - int.Parse(productQuantity));  //פריטים שלא הגיעו בכלל
                int fixProducts = int.Parse(productQuantity) - int.Parse(defectiveQuantity);   //arrived-defective
                OrderReceived_DataGrid.CurrentRow.Cells[2].Value = fixProducts;//arrived-defective (update datagrid)
                saveQuantityForP.Add(product, int.Parse(productQuantity));
                if (int.Parse(OrderReceived_DataGrid.CurrentRow.Cells[1].Value.ToString()) == (int.Parse(OrderReceived_DataGrid.CurrentRow.Cells[2].Value.ToString())))//check if oreded=arrive
                {
                    OrderReceived_DataGrid.CurrentRow.Cells[3].Value = true; //update datagrid in checkbox
                }
                else if (notArrivedProducts > 0)//orderd-arrived-defective
                {

                    //string text = " :שים לב,הגיעו לך ממוצר זה" + fixProducts + " ,תקינים" + " :לא הגיעו בכלל ממוצר זה" + notArrivedProducts + " :הפגומים שהגיעו" + int.Parse(defectiveQuantity) + "אנא רשום הכל בתיאור ההזמנה";
                    // MessageBox.Show(text);

                    string text3 = "prodct arrived: " + fixProducts + " Not arrived at all: " + notArrivedProducts + " the defective are: " + int.Parse(defectiveQuantity) + " write all in the order descreption ";
                    MessageBox.Show(text3);


                }


                calcDefectivePrecentage(product);//מחשב את אחוז הפגומים למוצר ספציפי
            }

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
        private void check()
        {
            flagInput = true;
            productQuantity = Recieved_quanity_TextBox.Text;
            defectiveQuantity = Recieved_DefectivePercantage_Textbox.Text;
            var idPattern = new Regex("[0-9]");
            if (OrderReceived_DataGrid.Rows.Count > 0)
            {

                int currentRowIndex = OrderReceived_DataGrid.CurrentCell.RowIndex;
                String productID = OrderReceived_DataGrid.Rows[currentRowIndex].Cells[0].Value.ToString();
                Product product = Program.Search_Product(productID);
            }
            if (string.IsNullOrEmpty(defectiveQuantity))
            {
                flagInput = false;
                string text = "הזן בבקשה מספר פגומים,אם אין פגומים הזן 0 !";
                MessageBox.Show(text);
            }

            else if (idPattern.IsMatch(defectiveQuantity) == false)
            {
                flagInput = false;
                string text = "מספר פגומים מכילה רק ספרות !";
                MessageBox.Show(text);
            }

            else if (int.Parse(defectiveQuantity) < 0)
            {
                flagInput = false;
                string text = "הזן בבקשה מספר פגומים,אם אין פגומים הזן 0 !";
                MessageBox.Show(text);
            }

            if (string.IsNullOrEmpty(productQuantity))
            {
                flagInput = false;
                string text = "הזן בבקשה כמות שהגיע מפריט ,אם אין בכלל הזן 0 !";
                MessageBox.Show(text);
            }

            else if (idPattern.IsMatch(productQuantity) == false)
            {
                flagInput = false;
                string text = " כמות שהגיע מפריט מכילה רק ספרות !";
                MessageBox.Show(text);
            }

            else if (int.Parse(productQuantity) < 0)
            {
                flagInput = false;
                string text = "הזן בבקשהכמות שהגיע מפריט,אם אין פגומים הזן 0 !";
                MessageBox.Show(text);
            }

            else if (int.Parse(productQuantity) < 0 || string.IsNullOrEmpty(productQuantity))
            {
                flagInput = false;
                string text = "לא ניתן לקבל כמות פריטים שלילית,אנא הכנס כמות תקינה !";
                MessageBox.Show(text);
            }

            else if (int.Parse(OrderReceived_DataGrid.CurrentRow.Cells[1].Value.ToString()) < int.Parse(productQuantity))
            {
                flagInput = false;
                string text = "לא ניתן לקבל יותר פריטים ממה שהוזמן,אנא הכנס כמות תקינה !";
                MessageBox.Show(text);
            }
        }
        private void Finished_Received_Buton_Click(object sender, EventArgs e)
        {
            check();
            if (!string.IsNullOrEmpty(Supplier_ID_TextBox.Text))
                flagFinish = true;
            this.receivedOrderDate = DateTime.Parse(Receive_Date_dateTimePicker.Text);
            this.supplierDescription = Recieved_OrderFS_Details_Textbox.Text;
            this.supplierStatus = (SupplierStatus)Enum.Parse(typeof(SupplierStatus), Received_Order_Status_label_comboBox.Text);
            this.IntactStatus = (IntactnessStatus)Enum.Parse(typeof(IntactnessStatus), Received_IntactnessStatu_ComboBox.Text);

            if (receivedOrderDate < orderDate)
            {
                flagFinish = false;
                string text = " תאריך קבלה לא יכול להיות לפני תאריך הזמנה,אנא בחר תאריך אחר!";
                MessageBox.Show(text);

            }

            if (flagFinish == true)
            {


                orderFromSupplier.set_SupplierDescription(supplierDescription);
                orderFromSupplier.set_ReceiveDate(receivedOrderDate);
                orderFromSupplier.set_intactness(IntactStatus);
                orderFromSupplier.set_SuplierStatus(supplierStatus);
                orderFromSupplier.Update_OrderFromSupplier(this.orderDate, this.supplierID);


                Update_Product();    //שיטה שמעדכנת את המלאי
                string text = " ההזמנה התקבלה בהצלחה,הפריטים עודכנו במלאי!";
                MessageBox.Show(text);
                this.Hide();
                Crud_Supplier s = new Crud_Supplier();
                s.Show();
            }
            //   tempCalcDefect = new Dictionary<Product, double>();
        }

        private void Update_Product()   //שיטה שעוברת על כל הדאטה גריד ומעדכנת את המלאי
        {
            foreach (Product p in Program.Products)
            {
                // foreach (DataGridViewRow row in OrderReceived_DataGrid.Rows)
                for (int i = 0; i < OrderReceived_DataGrid.RowCount - 1; i++)
                {
                    string productidGrid = OrderReceived_DataGrid.Rows[i].Cells[0].Value.ToString();
                    {
                        //  if (p.get_productId() == row.Cells[0].ToString())
                        if (p.get_productId() == productidGrid)
                        {
                            updateDefective(p); //שיטה שמעדכנת את האחוז פגומים החדש-חייב להיות לפני עדכון המלאי
                                                // p.set_quantity(p.get_quantity() + int.Parse(row.Cells[2].ToString()));

                            int oldQuantity = p.get_quantity();
                            int newQuantity = int.Parse(OrderReceived_DataGrid.Rows[i].Cells[2].Value.ToString());
                            p.set_quantity(oldQuantity + newQuantity);
                            // p.Update_Product_Quantity();
                            //  p.set_quantity(int.Parse(p.get_quantity() + int.Parse(OrderReceived_DataGrid.Rows[i].Cells[2].Value.ToString())));

                        }
                    }


                }
            }
        }


        private void Receive_Date_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Received_IntactnessStatu_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Received_Order_Status_label_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Received_Show_Button_Click(object sender, EventArgs e)
        {
            this.supplierID = Supplier_ID_TextBox.Text;
            this.orderDate = DateTime.Parse(Recieve_dorderFromSupplier_datePicker.Text);

            OrderReceived_DataGrid.Rows.Clear();
            Received_Order_Status_label_comboBox.Enabled = true;
            Received_IntactnessStatu_ComboBox.Enabled = true;
            Receive_Date_dateTimePicker.Enabled = true;
            Recieved_OrderFS_Details_Textbox.Enabled = true;
            Recieved_quanity_TextBox.Enabled = true;
            Recieved_DefectivePercantage_Textbox.Enabled = true;
            Recieved_Input_Product.Show();

            if (!string.IsNullOrEmpty(Supplier_ID_TextBox.Text) && Program.Search_OrderFromSupplier(supplierID, orderDate) != null)
            {
                //לבדוק שקיים הזמנה כזאת+כל החריגות המתאימות

                orderFromSupplier = Program.Search_OrderFromSupplier(supplierID, orderDate);

                inputDataGrid();
            }
            else
            {
                string text = "לא נמצא הזמנה מתאימה למזהה הספק והתאריך שהוזנו,אנא הזן פרטי הזמנה נכונים !";
                MessageBox.Show(text);
            }

        }
        private void calcDefectivePrecentage(Product p)//חישוב אחוז חריגים למוצר ספציפי
        {

            if (!string.IsNullOrEmpty(this.defectiveQuantity))
            {
                double precentageOrder = (((double.Parse(defectiveQuantity)) * 100) / double.Parse(productQuantity)) / 100;
                savePercentageForP.Add(p, precentageOrder);
            }

        }

        private void Back_ToCrud_Button_Click(object sender, EventArgs e)
        {

            if (this.e.get_EmployeeRole() == Role.logistic)
            {
                Crud_Supplier HS = new Crud_Supplier();
                HS.Show();
                this.Hide();
            }
            else
            {
                ProductionProcessManagment OM = new ProductionProcessManagment();
                OM.Show();
                this.Hide();
            }
        }

        public void updateDefective(Product p)
        {
            
            double totalProduct = saveQuantityForP[p] + p.get_quantity();
            double oldPrecentage = p.get_DefectivePercentage();
            double newPrecentage = savePercentageForP[p];//לבדוק שזה מחזיר את הערך

            double newPrecentageDefective = (double.Parse(saveQuantityForP[p].ToString()) / totalProduct) * savePercentageForP[p] + (double.Parse(p.get_quantity().ToString()) / totalProduct) * oldPrecentage;//חישוב תוחלת של אחוז הפגומים
            p.set_DefectivePercentage(newPrecentageDefective);
            p.Update_Product(p.get_productId());
        }

    }
}