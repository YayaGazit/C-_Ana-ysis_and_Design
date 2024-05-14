using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Group_27
{
    public class Circle_Product
    {
        private string circle_Id;
        private List<Product> Products;
        private bool isArchived;
        private List<Order> CircleOrders;



        public Circle_Product(string circle_Id, bool isArchived, bool is_new)
        {
            this.circle_Id = circle_Id;
            this.Products = new List<Product>();
            this.isArchived = isArchived;
            this.CircleOrders = new List<Order>();

            if (is_new)
            {
                this.create_Circle_Product();
             
                Program.Circle_Products.Add(this);
            }
        }


        public string get_circle_Id()
        {
            return this.circle_Id;
        }
        public List<Product> get_product()
        {
            return this.Products;
        }

        public bool get_isArchived()
        {
            return this.isArchived;
        }

        public string set_circle_Id(string circle_Id)
        {
            this.circle_Id = circle_Id;
            return this.circle_Id;
        }

        public void add_product(Product Product)
        {
            if (!this.Products.Contains(Product))
            {

                this.Products.Add(Product);
                Product.addCircleToProduct(this);
            }

        }
        public void remove_product(Product product)
        {
            foreach (Product p in this.Products)
            {
                if (p.get_productId() == product.get_productId())
                {
                    this.Products.Remove(p);
                }
            }
        }
        public bool set_isArchived(bool isArchived)
        {
            this.isArchived = isArchived;
            return this.isArchived;
        }




        public void addOrder(Order o)
        {
            if (!this.CircleOrders.Contains(o))
                 this.CircleOrders.Add(o);
               
            
        }

        public void create_Circle_Product()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Circle_Product @circle_Id,@isarchived ";
            c.Parameters.AddWithValue("@circle_Id", this.circle_Id);
            c.Parameters.AddWithValue("@isarchived", this.isArchived);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);


            for (int i = 0; i < this.Products.Count; i++)
            {
                SqlCommand c1 = new SqlCommand();
                c1.CommandText = "EXECUTE SP_add_productInCircle @circle_Id, @product_id , @quantity,@isarchived ";
                c1.Parameters.AddWithValue("@circle_Id", this.circle_Id);
                c1.Parameters.AddWithValue("@product_id", this.Products.ElementAt(i).get_productId());
                c1.Parameters.AddWithValue("@quantity", this.Products.ElementAt(i).get_quantity());
                c1.Parameters.AddWithValue("@isarchived", this.isArchived);
                SQL_CON SC1 = new SQL_CON();
                SC1.execute_non_query(c1);
            }


        }

        public void Update_Circle_Product()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Update_Circle_Product @circle_Id";
            c.Parameters.AddWithValue("@circle_Id", this.circle_Id);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

            for (int i = 0; i < this.Products.Count; i++)
            {
                SqlCommand c1 = new SqlCommand();
                c1.CommandText = "EXECUTE SP_Update_Circle_Product @circle_Id, @product_id , @quantity";
                c1.Parameters.AddWithValue("@circle_Id", this.circle_Id);
                c1.Parameters.AddWithValue("@product_id", this.Products.ElementAt(i).get_productId());
                c1.Parameters.AddWithValue("@quantity", this.Products.ElementAt(i).get_quantity());
                SQL_CON SC1 = new SQL_CON();
                SC1.execute_non_query(c1);
            }
        }
        public void add_CirclesInOrder(Order o)
        {
            if (!this.CircleOrders.Contains(o))
            {
                SqlCommand c1 = new SqlCommand();
                c1.CommandText = "EXECUTE SP_add_circlesInOrder @OrderId, @circle_Id";
                c1.Parameters.AddWithValue("@OrderId", o.get_OrderId());
                c1.Parameters.AddWithValue("@circle_Id", this.circle_Id);
                SQL_CON SC1 = new SQL_CON();
                SC1.execute_non_query(c1);
            }
            else
            {
                string text = "המוצר כבר קיים במערכת!";
                MessageBox.Show(text);
            }
        }
    }
}