using Group_27;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Group_27
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        /// רשימות
        public static System.Collections.Generic.List<Employee> Employees;
        public static System.Collections.Generic.List<Order> Orders;
        public static System.Collections.Generic.List<Customer> Customers;
        public static System.Collections.Generic.List<Supplier> Suppliers;   // list of all the suppliers
        public static System.Collections.Generic.List<Product> Products;    // מלאי
        public static System.Collections.Generic.List<OrderFromSupplier> OrderFromSuppliers;
        public static System.Collections.Generic.List<Step> Steps;
        public static System.Collections.Generic.List<StepInProgress> StepInProgresses;
        public static System.Collections.Generic.List<Circle_Product> Circle_Products;
        public static System.Collections.Generic.List<ProductionProcess> ProductionProcess;




        [STAThread]

        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            init_Employees();//אתחול הרשימה של העובדים
            init_Customers();
            init_Orders();//אתחול הרשימה של ההזמנות

            init_Suppliers();
            init_Products();
            init_OrderFromSupplier();

            init_Steps();
            init_StepsInProgress();
            init_Circle_Products();
            init_ProductionProcess();
        }







        public static void init_all_circleInProcess(ProductionProcess pr)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_circleInProcess @ProductionProcessId ";
            c.Parameters.AddWithValue("@ProductionProcessId", pr.get_ProductionProcessId());
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            while (rdr.Read())
            {
                Circle_Product cp = Search_Circle_Product(rdr.GetValue(1).ToString());
                int temp = int.Parse(rdr.GetValue(2).ToString());
                for (int i = 0; i < temp; i++)
                {
                    pr.add_one_circle(cp);
                }


            }

        }
        public static void init_ProductionProcess()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_ProductionProcess";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            ProductionProcess = new List<ProductionProcess>();

            while (rdr.Read())
            {
                Order o = Search_Order(rdr.GetValue(1).ToString());
                ProductionProcess pro = new ProductionProcess(rdr.GetValue(0).ToString(), o, false);
                init_all_circleInProcess(pro);
                ProductionProcess.Add(pro);
            }

        }

        public static void init_all_productFromSupplier(OrderFromSupplier ofs)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_productsFromSupplier @SupplierId, @OrderDate";
            c.Parameters.AddWithValue("@SupplierId", ofs.get_supplier().get_SupplierID());
            c.Parameters.AddWithValue("@OrderDate", ofs.get_OrderDate());
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            while (rdr.Read())
            {
                Product p = Search_Product(rdr.GetValue(2).ToString());     // נמצא את המוצר שהוזמן מרשימת המוצרים
                Product x = new Product(p.get_productId(), p.get_productName(), p.get_description(), p.get_partNumber(), p.get_price(), p.get_supplier(), p.get_quantity(), p.get_IsArchived(), false);

                x.set_quantity(int.Parse(rdr.GetValue(3).ToString()));  // תעדכן את המוצר בכמות שההזמנה דרשה
                                                                        //if (rdr.GetValue(0).ToString() == ofs.get_supplier().get_SupplierID() && rdr.GetValue(1).ToString() == ofs.get_OrderDate().ToString())
                ofs.AddProduct(x);  // תוסיף את המוצר להזמנה שלו
                x.addOrderFromSupplier(ofs);// תוסיף את ההזמנה במוצר
            }
        }

        public static void init_OrderFromSupplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_OrdersFromSuppliers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            OrderFromSuppliers = new List<OrderFromSupplier>();

            while (rdr.Read())
            {
                Supplier s = Search_Supplier(rdr.GetValue(0).ToString());
                OrderFromSupplier ofs = new OrderFromSupplier(s, DateTime.Parse(rdr.GetValue(1).ToString()), rdr.GetValue(3).ToString(), false);
                init_all_productFromSupplier(ofs);
                OrderFromSuppliers.Add(ofs);
                ofs.calcQuantity();
            }
        }


        public static void init_Employees()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Employees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Employees = new List<Employee>();

            while (rdr.Read())
            {
                Role R = (Role)Enum.Parse(typeof(Role), rdr.GetValue(3).ToString());
                Gender G = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(6).ToString());
                Employee e = new Employee(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), R, rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(), G, DateTime.Parse(rdr.GetValue(7).ToString()), double.Parse(rdr.GetValue(8).ToString()), bool.Parse(rdr.GetValue(9).ToString()), false);
                Employees.Add(e);
            }
        }



        private static void init_Orders() //מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Orders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Orders = new List<Order>();

            while (rdr.Read())
            {
                Priorities P = (Priorities)Enum.Parse(typeof(Priorities), rdr.GetValue(5).ToString());
                OrderStatus OS = (OrderStatus)Enum.Parse(typeof(OrderStatus), rdr.GetValue(4).ToString());
                Customer Customer = Search_Customer(rdr.GetValue(9).ToString());
                Order o = new Order(rdr.GetValue(0).ToString(), DateTime.Parse(rdr.GetValue(1).ToString()), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), OS, P, DateTime.Parse(rdr.GetValue(6).ToString()), double.Parse(rdr.GetValue(7).ToString()), bool.Parse(rdr.GetValue(8).ToString()), Customer, rdr.GetValue(10).ToString(), false);
                Orders.Add(o);

            }
        }
        public static void init_Customers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Customers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Customers = new List<Customer>();

            while (rdr.Read())
            {
                Gender G = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(9).ToString());
                Customer cus = new Customer(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(), DateTime.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), G, bool.Parse(rdr.GetValue(10).ToString()), false);
                Customers.Add(cus);
            }
        }

        public static void init_Suppliers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Suppliers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Suppliers = new List<Supplier>();

            while (rdr.Read())
            {
                Supplier s = new Supplier(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), bool.Parse(rdr.GetValue(4).ToString()), false);
                Suppliers.Add(s);
            }
        }

        public static void init_Products()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Products";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Products = new List<Product>();

            while (rdr.Read())
            {
                Supplier s = Search_Supplier(rdr.GetValue(6).ToString());
                Product p = new Product(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), double.Parse(rdr.GetValue(5).ToString()), s, int.Parse(rdr.GetValue(7).ToString()), bool.Parse(rdr.GetValue(8).ToString()), false);
                Products.Add(p);
            }
        }

        public static void init_OrderFromSuppliers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_OrderFromSuppliers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Employees = new List<Employee>();

            while (rdr.Read())
            {
                Supplier s = Search_Supplier(rdr.GetValue(0).ToString());
                OrderFromSupplier ofs = new OrderFromSupplier(s, DateTime.Parse(rdr.GetValue(1).ToString()), rdr.GetValue(3).ToString(), false);
                OrderFromSuppliers.Add(ofs);
            }
        }

        public static void init_Steps()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Steps";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Steps = new List<Step>();

            while (rdr.Read())
            {

                Step s = new Step((StepName)Enum.Parse(typeof(StepName), rdr.GetValue(0).ToString()), double.Parse(rdr.GetValue(1).ToString()), double.Parse(rdr.GetValue(2).ToString()), false);
                Steps.Add(s);
            }
        }
        public static void init_StepsInProgress()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_StepsInProgress";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            StepInProgresses = new List<StepInProgress>();

            while (rdr.Read())
            {
                Step sn = Search_Step(rdr.GetValue(0).ToString());
                Order o = Search_Order(rdr.GetValue(1).ToString());
                StepInProgress s = new StepInProgress(DateTime.Parse(rdr.GetValue(2).ToString()), DateTime.Parse(rdr.GetValue(3).ToString()), sn, o, false);
                StepInProgresses.Add(s);
            }
        }

        public static void init_Circle_Products()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Circle_Product";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Circle_Products = new List<Circle_Product>();

            while (rdr.Read())
            {

                Circle_Product cp = new Circle_Product(rdr.GetValue(0).ToString(), bool.Parse(rdr.GetValue(1).ToString()), false);
                init_all_productInCircle(cp);
                Circle_Products.Add(cp);
                init_all_CircleInOrder(cp);


            }
        }

        public static void init_all_CircleInOrder(Circle_Product cp)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_circlesInOrder @circle_Id";
            c.Parameters.AddWithValue("@circle_Id", cp.get_circle_Id());
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            while (rdr.Read())
            {
                Order o = Search_Order(rdr.GetValue(0).ToString());

                if (rdr.GetValue(1).ToString() == cp.get_circle_Id())
                    cp.addOrder(o);
                o.addCircleToOrder(cp);
            }
        }

        public static void init_all_productInCircle(Circle_Product cp)//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_productInCircle @circle_Id";
            c.Parameters.AddWithValue("@circle_Id", cp.get_circle_Id());
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            while (rdr.Read())
            {

                Product p = Search_Product(rdr.GetValue(1).ToString());
                Product x = new Product(p.get_productId(), p.get_productName(), p.get_description(), p.get_partNumber(), p.get_price(), p.get_supplier(), p.get_quantity(), p.get_IsArchived(), false);
                x.set_quantity(int.Parse(rdr.GetValue(2).ToString()));
                if (rdr.GetValue(0).ToString() == cp.get_circle_Id())
                    cp.add_product(x);
            }
        }

        public static ProductionProcess Search_productionProcess(string id)
        {
            foreach (ProductionProcess Pp in ProductionProcess)
            {
                if (Pp.get_ProductionProcessId() == id)
                    return Pp;
            }
            return null;
        }

        public static Employee Search_Employee(string id)
        {
            foreach (Employee emp in Employees)
            {
                if (emp.get_EmployeeId() == id)
                    return emp;
            }
            return null;
        }

        public static Customer Search_Customer(string id)
        {
            foreach (Customer cus in Customers)
            {
                if (cus.get_customerId() == id)
                    return cus;
            }
            return null;
        }

        public static Supplier Search_Supplier(string id)
        {
            foreach (Supplier sup in Suppliers)
            {
                if (sup.get_SupplierID() == id)
                    return sup;
            }
            return null;
        }

        public static Product Search_Product(string Productid)
        {
            foreach (Product pr in Products)
            {
                if (pr.get_productId() == Productid)
                    return pr;
            }
            return null;
        }

        public static Order Search_Order(string Orderid)
        {
            foreach (Order O in Orders)
            {
                if (O.get_OrderId() == Orderid)
                    return O;
            }
            return null;
        }

        public static Step Search_Step(string StepName)
        {
            foreach (Step step in Steps)
            {
                if (step.get_stepName().ToString() == StepName)
                    return step;
            }
            return null;
        }

        public static Circle_Product Search_Circle_Product(string id)
        {
            foreach (Circle_Product cp in Circle_Products)
            {
                if (cp.get_circle_Id() == id)
                    return cp;
            }
            return null;
        }

        public static OrderFromSupplier Search_OrderFromSupplier(string supplierID, DateTime orderDate)
        {
            foreach (OrderFromSupplier ofs in OrderFromSuppliers)
            {
                if (ofs.get_supplier().get_SupplierID() == supplierID && ofs.get_OrderDate() == orderDate)
                    return ofs;
            }
            return null;
        }


        public static bool Check_inInventory(List<Product> P)
        {
            bool flag = true;
            int count = 0;


            foreach (Product i in P)
            {
                Product p = Search_Product(i.get_productId());

                if (i.get_quantity() > p.get_quantity())
                {
                    count = get_coming_product(i.get_productId());

                    if (i.get_quantity() - p.get_quantity() > count)
                    {

                        int n = i.get_quantity() - p.get_quantity() - count;
                        string text = n + " ממוצר " + i.get_productId() + "  לא קיים במלאי ובהזמנות העתידיות . יש להזמין  ";
                        MessageBox.Show(text);
                        flag = false;

                    }
                    else
                    {
                        string text = i.get_productId() + "  לא קיים במלאי יגיע בימים הקרובים המוצר  ";
                        MessageBox.Show(text);
                        flag = false;

                    }
                }
            }
            return flag;
        }

        public static int get_coming_product(string Productid)
        {

            int count = 0;
            foreach (OrderFromSupplier order in OrderFromSuppliers)
            {
                if (order.get_SupplierStatus().ToString() != "arrived")
                {
                    foreach (Product temp in order.get_AllProducts())
                    {
                        if (temp.get_productId() == Productid)
                        {
                            count += temp.get_quantity();

                        }
                    }
                }
            }

            return count;
        }



        //פונקציה שמחזירה עובד על סמך שם מלא ותפקיד... צריך לסדר
        //public static Employee Search_EmployeeByNameRole(string name , string role) 
        //  {
        //      foreach (Employee emp in Employees) 
        //       {
        //           if (emp.get_FirstName().Equals(name) && emp.get_EmployeeRole().Equals(role))
        //               return emp;
        //      }
        //         return null;
        //     }


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();
            //     Application.Run(new AddEmployee());
            //OrderStatus OS = OrderStatus.InDelivery;
            //   DateTime dateReceived = new DateTime(2015, 12, 12, 9, 0, 0);
            // DateTime deadLine = new DateTime(2022, 12, 12, 9, 0, 0);
            //DateTime startPreparationDate = new DateTime(2021, 12, 12, 9, 0, 0);

            //   Order o = new Order("2413", dateReceived, deadLine, "tttt", OS, 20, startPreparationDate, 25, false, true);
            //      DateTime JoinDate = new DateTime(2021, 12, 12, 9, 0, 0);
            //          Role R = Role.LogisticManager;
            //        Gender G = Gender.Other;
            //      Employee e = new Employee("21saa4", "yari", "moki", R, "daf@", "425", G, JoinDate, 2000, false, true);
            //   Application.Run(new Crud_Employee());
            //  Application.Run(new Add_Customer());
            // Application.Run(new AddSupplier());
            //  Application.Run(new AddProduct());
            //  Application.Run(new Login());
            // Application.Run(new CreateOrderFromSupplier());
            //   Application.Run(new ReceivedFromSupplier());
            Application.Run(new Login());

          //  Application.Run(new Login());
            // StepInProgress p = new StepInProgress(start,end, st, "123321", true);
            //  Console.WriteLine(StepInProgresses.ElementAt(1).get_startTime());
            //Application.Run(new Show_Order());
        }

    }
}