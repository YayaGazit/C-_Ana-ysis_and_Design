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
    public partial class Add_productionProcess : Form
    {
        private Order exist_order;
        private List<Product> products_inOrder = new List<Product>();
        private List<Circle_Product> CirclesInOrder = new List<Circle_Product>();
        private Employee e;
        public Add_productionProcess()
        {
            InitializeComponent();


            Input_ProductionProcess_Button.Hide();
            customer_Order_Products__Textbox.Hide();
            input_Product_Textbox.Hide();
            input_quantity_Textbox.Hide();
            add_product_Button.Hide();
            Supplier_Phone_Label.Hide();
            label2.Hide();
            label1.Hide();
            Format_Label.Hide();
            e = Program.Search_Employee(Global.currentUser);




        }





        private void serial_num_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Order_Id_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_to_EmployeeHomePage_Click(object sender, EventArgs e)
        {
            ProductionProcessManagment HE = new ProductionProcessManagment();
            HE.Show();
            this.Hide();
        }

        private void show_order_Button_Click(object sender, EventArgs e)
        {
            bool flag2 = true;

            if (Program.Search_productionProcess(serial_num_Textbox.Text) != null || serial_num_Textbox.Text != "")
            {
                ProductionProcess PP = Program.Search_productionProcess(serial_num_Textbox.Text);
                if (PP == null)
                {
                    exist_order = Program.Search_Order(Order_Id_Textbox.Text);



                    if (exist_order != null)
                    {
                        foreach (ProductionProcess i in Program.ProductionProcess)
                        {
                            if (i.get_order().get_OrderId() == Order_Id_Textbox.Text)
                            {
                                flag2 = false;
                            }
                        }

                        if (flag2)
                        {
                            Input_ProductionProcess_Button.Show();
                            customer_Order_Products__Textbox.Show();
                            input_Product_Textbox.Show();
                            input_quantity_Textbox.Show();
                            add_product_Button.Show();
                            Supplier_Phone_Label.Show();
                            label2.Show();
                            label1.Show();
                            Format_Label.Show();

                            customer_Order_Products__Textbox.Text = exist_order.get_OrderProducts();
                        }
                        else
                        {
                            string str = "הזמנה כבר בתהליך ייצור. הזן שנית  ";
                            MessageBox.Show(str);
                            serial_num_Textbox.Clear();
                            Order_Id_Textbox.Clear();
                        }

                    }
                    else
                    {
                        string str = "מספר הזמנה קיים או שההזמנה לא קיימת . הזן שנית  ";
                        MessageBox.Show(str);

                        Order_Id_Textbox.Clear();
                    }

                }
                else
                {
                    string str = "מספר הזמנה קיים. הזן שנית  ";
                    MessageBox.Show(str);
                }

            }
            else
            {
                string str = "מספר סידורי קיים או שההזמנה לא קיימת . הזן שנית  ";
                MessageBox.Show(str);
                serial_num_Textbox.Clear();
                Order_Id_Textbox.Clear();
            }

        }
        private void customer_Order_Products__Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_Product_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_quantity_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_product_Button_Click(object sender, EventArgs e)
        {
            if (input_Product_Textbox.Text != "" && input_quantity_Textbox.Text != "")
            {
                if (int.Parse(input_quantity_Textbox.Text.ToString()) > 0)
                {
                    Circle_Product c = Program.Search_Circle_Product(input_Product_Textbox.Text);
                    Circle_Product cp = new Circle_Product(c.get_circle_Id(), c.get_isArchived(), false);
                    if (cp != null)
                    {

                        if (!this.CirclesInOrder.Contains(cp))
                        {
                            int q = int.Parse(input_quantity_Textbox.Text);
                            List<Product> cProducts = c.get_product();

                            foreach (Product i in cProducts)
                            {
                                Product p = i;
                                Product x = new Product(p.get_productId(), p.get_productName(), p.get_description(), p.get_partNumber(), p.get_price(), p.get_supplier(), p.get_quantity(), p.get_IsArchived(), false);

                                x.set_quantity(i.get_quantity() * q);
                                cp.add_product(x);
                                this.products_inOrder.Add(x);
                            }

                            this.CirclesInOrder.Add(cp);

                            input_Product_Textbox.Clear();
                            input_quantity_Textbox.Clear();
                        }
                        else
                        {
                            string str = "מעגל זה קיים בתהליך. הזן שנית ";
                            MessageBox.Show(str);

                            input_Product_Textbox.Clear();
                            input_quantity_Textbox.Clear();
                        }
                    }
                    else
                    {
                        string str = "מעגל לא קיים במערכת. הזן שנית ";
                        MessageBox.Show(str);

                        input_Product_Textbox.Clear();
                        input_quantity_Textbox.Clear();
                    }

                }
                else
                {
                    string str = "כמות לא תקינה. הזן שנית ";
                    MessageBox.Show(str);

                    input_Product_Textbox.Clear();
                    input_quantity_Textbox.Clear();
                }
            }
            else
            {
                string str = "לא הוזן מעגלים או כמויות. הזן שנית ";
                MessageBox.Show(str);

                input_Product_Textbox.Clear();
                input_quantity_Textbox.Clear();
            }


        }

        private void Input_ProductionProcess_Button_Click(object sender, EventArgs e)
        {
            bool flag = true;

            if (input_Product_Textbox.Text != "" && input_quantity_Textbox.Text != "")
            {
                if (int.Parse(input_quantity_Textbox.Text.ToString()) > 0)
                {
                    Circle_Product c = Program.Search_Circle_Product(input_Product_Textbox.Text);
                    Circle_Product cp = new Circle_Product(c.get_circle_Id(), c.get_isArchived(), false);
                    if (cp != null)
                    {

                        if (!this.CirclesInOrder.Contains(cp))
                        {
                            int q = int.Parse(input_quantity_Textbox.Text);
                            List<Product> cProducts = c.get_product();

                            foreach (Product i in cProducts)
                            {
                                Product p = i;
                                Product x = new Product(p.get_productId(), p.get_productName(), p.get_description(), p.get_partNumber(), p.get_price(), p.get_supplier(), p.get_quantity(), p.get_IsArchived(), false);
                                x.set_quantity(i.get_quantity() * q);
                                cp.add_product(x);
                                this.products_inOrder.Add(x);

                            }
                            this.CirclesInOrder.Add(cp);
                            foreach (Circle_Product CP in this.CirclesInOrder)
                            {
                                CP.add_CirclesInOrder(exist_order);
                            }
                        }
                        else
                        {
                            string str = "מעגל זה קיים בתהליך. הזן שנית ";
                            MessageBox.Show(str);

                            input_Product_Textbox.Clear();
                            input_quantity_Textbox.Clear();
                            flag = false;
                        }

                    }
                    else
                    {
                        string str = "מעגל לא קיים במערכת. הזן שנית ";
                        MessageBox.Show(str);

                        input_Product_Textbox.Clear();
                        input_quantity_Textbox.Clear();
                        flag = false;
                    }

                }
                else
                {
                    string str = "כמות לא תקינה. הזן שנית ";
                    MessageBox.Show(str);

                    input_Product_Textbox.Clear();
                    input_quantity_Textbox.Clear();
                    flag = false;
                }
            }
            else
            {
                string str = "לא הוזן מעגלים או כמויות. הזן שנית ";
                MessageBox.Show(str);

                input_Product_Textbox.Clear();
                input_quantity_Textbox.Clear();
                flag = false;

            }




            //check





            if (flag)
            {
                if (Program.Check_inInventory(this.products_inOrder))
                {
                    foreach (Product i in this.products_inOrder)
                    {
                        Product p = Program.Search_Product(i.get_productId());
                        p.set_quantity(p.get_quantity() - i.get_quantity());
                    }


                    ProductionProcess pr = new ProductionProcess(serial_num_Textbox.Text, this.exist_order, true);
                    pr.add_to_invetory_list(this.CirclesInOrder);

                    string str = "נוצר תהליך ייצור חדש בהצלחה";

                    this.Hide();
                    MessageBox.Show(str);
                    HomePageGenral();
                }
                else
                {
                    this.Hide();
                    HomePageGenral();
                }
            }
            else
            {
                this.Hide();
                HomePageGenral();
            }




        }


        private void Supplier_Phone_Label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_productionProcess_Load(object sender, EventArgs e)
        {

        }

        private void Back_To_Home_Page_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.salesPerson)
            {
                HomePageSales HS = new HomePageSales();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.e.get_EmployeeRole() == Role.production)
            {
                HomePageProduction HP = new HomePageProduction();
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
        private void HomePageGenral()
        {
            if (this.e.get_EmployeeRole() == Role.production)
            {
                HomePageProduction HP = new HomePageProduction();
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

        private void Add_New_Supplier_Label_Click(object sender, EventArgs e)
        {

        }

        private void Format_Label_Click(object sender, EventArgs e)
        {

        }
    }
}