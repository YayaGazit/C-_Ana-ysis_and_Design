using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Group_27
{
    class ProductionProcess
    {
        private string ProductionProcessId;
        private Order order;
        private List<Circle_Product> ProductionProcess_circles;


        public ProductionProcess(string id, Order o, bool is_new)
        {
            this.ProductionProcessId = id;
            this.order = o;
            this.ProductionProcess_circles = new List<Circle_Product>();

            if (is_new)
            {
                createProductionProcess();
                Program.ProductionProcess.Add(this);
            }
        }

        public void add_to_invetory_list(List<Circle_Product> I)
        {

            for (int i = 0; i < I.Count(); i++)
            {
                Circle_Product cp = Program.Search_Circle_Product(I.ElementAt(i).get_circle_Id());
                int q = I.ElementAt(i).get_product().ElementAt(0).get_quantity() / cp.get_product().ElementAt(0).get_quantity();
                for (int t = 0; t < q; t++)
                {
                    this.ProductionProcess_circles.Add(cp);
                }

            }
            add_to_circleInprocess();
        }

        public void add_one_circle(Circle_Product c)
        {
            this.ProductionProcess_circles.Add(c);
        }


        public Order get_order()
        {
            return this.order;
        }

        public void set_order(Order o)
        {
            this.order = o;
        }
        public string get_ProductionProcessId()
        {
            return this.ProductionProcessId;
        }



        public void set_ProductionProcessId(string id)
        {
            this.ProductionProcessId = id;
        }

        public List<Circle_Product> get_Allproducts()
        {
            return this.ProductionProcess_circles;
        }

        public void createProductionProcess()
        {

            {
                SqlCommand c1 = new SqlCommand();
                c1.CommandText = "EXECUTE dbo.SP_add_ProductionProcess @ProductionProcessId , @OrderId ";
                c1.Parameters.AddWithValue("@ProductionProcessId", this.ProductionProcessId);
                c1.Parameters.AddWithValue("@OrderId", this.order.get_OrderId());
                SQL_CON SC1 = new SQL_CON();
                SC1.execute_non_query(c1);

            }

        }

        public void add_to_circleInprocess()
        {
            for (int i = 0; i < this.ProductionProcess_circles.Count(); i++)
            {

                Circle_Product cp = Program.Search_Circle_Product(this.ProductionProcess_circles.ElementAt(i).get_circle_Id());
                int q = this.ProductionProcess_circles.ElementAt(i).get_product().ElementAt(0).get_quantity() / cp.get_product().ElementAt(0).get_quantity();
                SqlCommand c1 = new SqlCommand();
                c1.CommandText = "EXECUTE dbo.SP_add_circleInProcess @ProductionProcessId , @circle_Id  , @quantity";
                c1.Parameters.AddWithValue("@ProductionProcessId", this.ProductionProcessId);
                c1.Parameters.AddWithValue("@circle_Id", this.ProductionProcess_circles.ElementAt(i).get_circle_Id());
                c1.Parameters.AddWithValue("@quantity", q);
                SQL_CON SC1 = new SQL_CON();
                SC1.execute_non_query(c1);
            }
        }
    }
}