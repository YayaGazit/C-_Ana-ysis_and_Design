using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Group_27
{

    public class Order
    {
        private string orderId;
        private DateTime dateReceived;
        private DateTime deadLine;
        private string requirements;
        private OrderStatus status;
        private Priorities priority;
        private DateTime startPreparationDate;
        private double expectedProfit;
        private bool isArchived;
        private Customer customer;
        private string OrderProducts;
        public List<Employee> orderEmployees;
        private List<Employee> temp_employees;
        public List<StepInProgress> StepsInProgress;
        public List<Circle_Product> Circles_inOrder;



        public Order(string orderId, DateTime dateReceived, DateTime deadLine, string requirements, OrderStatus status, Priorities priority, DateTime startPreparationDate, double expectedProfit, bool isArchived, Customer customer, string OrderProducts, bool is_new)
        {
            this.orderId = orderId;
            this.dateReceived = dateReceived;
            this.deadLine = deadLine;
            this.requirements = requirements;
            this.status = status;
            this.priority = priority;
            this.startPreparationDate = startPreparationDate;
            this.expectedProfit = expectedProfit;
            this.isArchived = isArchived;
            this.customer = customer;
            this.OrderProducts = OrderProducts;
            this.orderEmployees = new List<Employee>();
            this.temp_employees = new List<Employee>();
            this.Circles_inOrder = new List<Circle_Product>();
            this.StepsInProgress = new List<StepInProgress>();
            this.customer.add_order_to_myOrder(this);
            Add_orderEmployee();

            if (is_new)
            {
                this.create_Order();
                // w.AddOrders(this);
                Program.Orders.Add(this);
            }

        }

        public string get_OrderId()
        {
            return this.orderId;
        }
        public DateTime get_DateReceived()
        {
            return this.dateReceived;
        }
        public DateTime get_deadLine()
        {
            return this.deadLine;
        }

        public string get_requirements()
        {
            return this.requirements;
        }
        public OrderStatus get_status()
        {
            return this.status;
        }
        public Priorities get_priority()
        {
            return this.priority;
        }

        public DateTime get_startPreparationDate()
        {
            return this.startPreparationDate;
        }

        public double get_expectedProfit()
        {
            return this.expectedProfit;
        }
        public Customer get_customer()
        {
            return this.customer;
        }

        public bool get_IsArchived()
        {
            return this.isArchived;
        }

        public string get_OrderProducts()
        {
            return this.OrderProducts;
        }
        public string set_OrderId(string id)
        {
            this.orderId = id;
            return this.orderId;
        }

        public DateTime set_DateReceived(DateTime date)
        {
            this.dateReceived = date;
            return this.dateReceived;
        }
        public DateTime set_deadLine(DateTime date)
        {
            this.deadLine = date;
            return this.deadLine;
        }

        public string set_requirements(string requirements)
        {
            this.requirements = requirements;
            return this.requirements;
        }
        public OrderStatus set_status(OrderStatus status)
        {
            this.status = status;
            return this.status;
        }
        public Priorities set_priority(Priorities priority)
        {
            this.priority = priority;
            return this.priority;
        }
        public DateTime set_startPreparationDate(DateTime startPreparationDate)
        {
            this.startPreparationDate = startPreparationDate;
            return this.startPreparationDate;
        }

        public double set_expectedProfit(double expectedProfit)
        {
            this.expectedProfit = expectedProfit;
            return this.expectedProfit;
        }
        public bool set_IsArchived(bool IsArchived)
        {
            this.isArchived = IsArchived;
            return this.isArchived;
        }

        public string set_OrderProducts(string OrderProducts)
        {
            this.OrderProducts = OrderProducts;
            return this.OrderProducts;
        }
        public void set_orderEmployees(Employee emp)
        {
            this.orderEmployees.Add(emp);
            emp.set_EmployeeOrder(this);

        }

        /* public Order SearchOrderbyCustomerID(string CustomerId)
         {
             foreach (Order o in Program.Orders)
             {
                 if (o.get_CustomerOrder() == CustomerId)
                     return o;
             }
             return null;
         }*/

       

        public void addStepInProgress(StepInProgress sip)
        {
            this.StepsInProgress.Add(sip);
        }

        public void create_Order()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Order @OrderId, @dateReceived, @deadLine,@requirements,@status,@priority,@startPreparationDate,@expectedProfit,@isarchived,@Customer,@ProductsDetails";
            c.Parameters.AddWithValue("@OrderId", this.orderId);
            c.Parameters.AddWithValue("@dateReceived", this.dateReceived);
            c.Parameters.AddWithValue("@deadLine", this.deadLine);
            c.Parameters.AddWithValue("@requirements", this.requirements);
            c.Parameters.AddWithValue("@status", this.status.ToString());
            c.Parameters.AddWithValue("@priority", this.priority.ToString());
            c.Parameters.AddWithValue("@startPreparationDate", this.startPreparationDate);
            c.Parameters.AddWithValue("@expectedProfit", this.expectedProfit);
            c.Parameters.AddWithValue("@isarchived", this.isArchived);
            c.Parameters.AddWithValue("@Customer", this.customer.get_customerId());
            c.Parameters.AddWithValue("@ProductsDetails", this.OrderProducts);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);


            Role R = (Role)Enum.Parse(typeof(Role), "CEO");
            foreach (Employee emp in Program.Employees)
            {
                if (emp.get_EmployeeRole() == R)
                {
                    //         מכניס את כל העובדים לSQL              
                    SqlCommand c1 = new SqlCommand();
                    c1.CommandText = "EXECUTE SP_add_TeamInOrder @OrderId, @id";
                    c1.Parameters.AddWithValue("@OrderId", this.orderId);
                    c1.Parameters.AddWithValue("@id", emp.get_EmployeeId());
                    SQL_CON SC1 = new SQL_CON();
                    SC1.execute_non_query(c1);

                }
            }

        }
        public void Update_Order(string id)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Update_Order @OrderId, @dateReceived, @deadLine,@requirements,@status,@priority,@startPreparationDate,@expectedProfit,@ProductsDetails";
            c.Parameters.AddWithValue("@OrderId", this.orderId);
            c.Parameters.AddWithValue("@dateReceived", this.dateReceived);
            c.Parameters.AddWithValue("@deadLine", this.deadLine);
            c.Parameters.AddWithValue("@requirements", this.requirements);
            c.Parameters.AddWithValue("@status", this.status.ToString());
            c.Parameters.AddWithValue("@priority", this.priority.ToString());
            c.Parameters.AddWithValue("@startPreparationDate", this.startPreparationDate);
            c.Parameters.AddWithValue("@expectedProfit", this.expectedProfit);
            c.Parameters.AddWithValue("@ProductsDetails", this.OrderProducts);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

            foreach (Employee emp in this.temp_employees)     // add employee to teamInOrder table in the sql
            {
                if (!this.orderEmployees.Contains(emp))
                {
                    SqlCommand c1 = new SqlCommand();
                    //         מכניס את כל העובדים לSQL              

                    c1.CommandText = "EXECUTE SP_add_TeamInOrder @OrderId, @id";
                    c1.Parameters.AddWithValue("@OrderId", this.orderId);
                    c1.Parameters.AddWithValue("@id", emp.get_EmployeeId());
                    SQL_CON SC1 = new SQL_CON();
                    SC1.execute_non_query(c1);

                    this.orderEmployees.Add(emp);

                }
            }
            temp_employees.Clear();
        }

        public void move_Order_To_Archive(string id)//להוסיף תנאי אם הוא בארכיון
        {
            if (Program.Search_Order(id).get_IsArchived() == false)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE SP_OrderToArchive @id";
                c.Parameters.AddWithValue("@id", this.orderId);
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);

            }
            else
            {
                string text = "ההזמנה כבר נמצאת בארכיון";
                MessageBox.Show(text);
            }


        }
        public void move_Order_From_Archive(string id)//להוסיף תנאי בדיקה אם הוא כבר עובד פעיל
        {
            if (Program.Search_Order(id).get_IsArchived() == true)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE SP_OrderFromArchive @id";
                c.Parameters.AddWithValue("@id", this.orderId);
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);
            }
            else
            {
                string text = "ההזמנה לא נמצאת בארכיון";
                MessageBox.Show(text);
            }
        }

        public void add_to_orderEmployees(Role r)             // add employees with that role to order_employees
        {
            foreach (Employee emp in Program.Employees)
            {
                if (emp.get_EmployeeRole() == r)
                {
                    this.temp_employees.Add(emp);
                    emp.set_EmployeeOrder(this);
                }

            }
        }




        public void Add_orderEmployee()
        {
            Role r1 = new Role();
            Role r2 = new Role();
            Role r3 = new Role();
            Role r4 = new Role();
            Role r5 = new Role();


            if (this.status == (OrderStatus)Enum.Parse(typeof(OrderStatus), "waitingForProducts"))
            {

                r1 = (Role)Enum.Parse(typeof(Role), "logistic");
                r2 = (Role)Enum.Parse(typeof(Role), "logisticManager");
                r5 = (Role)Enum.Parse(typeof(Role), "CEO");
                this.add_to_orderEmployees(r1);
                this.add_to_orderEmployees(r2);
                this.add_to_orderEmployees(r5);
            }
            else if (this.status == (OrderStatus)Enum.Parse(typeof(OrderStatus), "inProductionProcess"))
            {

                r1 = (Role)Enum.Parse(typeof(Role), "logistic");
                r2 = (Role)Enum.Parse(typeof(Role), "logistic");
                r3 = (Role)Enum.Parse(typeof(Role), "production");
                r4 = (Role)Enum.Parse(typeof(Role), "productionManager");
                r5 = (Role)Enum.Parse(typeof(Role), "CEO");
                this.add_to_orderEmployees(r1);
                this.add_to_orderEmployees(r2);
                this.add_to_orderEmployees(r5);
            }
            else if (this.status == (OrderStatus)Enum.Parse(typeof(OrderStatus), "packeging"))
            {
                r1 = (Role)Enum.Parse(typeof(Role), "storeKeeper");
                r2 = (Role)Enum.Parse(typeof(Role), "logistic");
                r3 = (Role)Enum.Parse(typeof(Role), "logisticManager");
                r4 = (Role)Enum.Parse(typeof(Role), "production");
                r5 = (Role)Enum.Parse(typeof(Role), "productionManager");
                r5 = (Role)Enum.Parse(typeof(Role), "CEO");
                this.add_to_orderEmployees(r1);
                this.add_to_orderEmployees(r2);
                this.add_to_orderEmployees(r3);
                this.add_to_orderEmployees(r4);
                this.add_to_orderEmployees(r5);
            }
        }
        public void addCircleToOrder(Circle_Product c)
        {
            this.Circles_inOrder.Add(c);

        }
    }



}