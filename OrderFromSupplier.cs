using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Group_27
{
    public class OrderFromSupplier
    {
        private Supplier supplier;
        private DateTime orderDate;
        private IntactnessStatus intactness;
        private string supplierDescription;
        private double defectivePercentage;
        private DateTime receiveDate;
        private SupplierStatus SupplierStatus;
        private List<Product> Products;



        public OrderFromSupplier(Supplier supplier, DateTime orderDate, string SupplierDescription, bool is_new)
        {
            this.supplier = supplier;
            this.orderDate = orderDate;
            this.intactness = (IntactnessStatus)Enum.Parse(typeof(IntactnessStatus), "StillinOrdeerProcessNotArrivedYet");
            this.supplierDescription = SupplierDescription;
            this.SupplierStatus = (SupplierStatus)Enum.Parse(typeof(SupplierStatus), "ordered");
            this.Products = new List<Product>();
            this.supplier.addOrderFromSupplier(this);


            if (is_new)
            {
                this.create_OrderFromSupplier();
                Program.OrderFromSuppliers.Add(this);

            }

        }
        // לבדוק אם צריך
        public void AddProduct(Product p)
        {
            if (!Products.Contains(p))
            {
                this.Products.Add(p);
                p.addOrderFromSupplier(this);
            }
            else
            {
                string text = "המוצר כבר קיים בהזמנה !";
                MessageBox.Show(text);
            }

        }

        public Supplier get_supplier()
        {
            return this.supplier;
        }
        public DateTime get_OrderDate()
        {
            return this.orderDate;
        }

        public DateTime get_ReceiveDate()
        {
            return this.receiveDate;
        }
        public IntactnessStatus get_intactness()
        {
            return this.intactness;
        }
        public string get_SupplierDescription()
        {
            return this.supplierDescription;
        }
        public double get_defectivePercentage()
        {
            return this.defectivePercentage;
        }

        public SupplierStatus get_SupplierStatus()
        {
            return this.SupplierStatus;
        }

        public List<Product> get_AllProducts()
        {
            return this.Products;
        }

        public Supplier set_supplier(Supplier supplier)
        {
            this.supplier = supplier;

            return this.supplier;
        }
        public DateTime set_orderDate(DateTime orderDate)
        {
            this.orderDate = orderDate;

            return this.orderDate;
        }

        public DateTime set_ReceiveDate(DateTime ReceiveDate)
        {
            this.receiveDate = ReceiveDate;

            return this.receiveDate;
        }


        public IntactnessStatus set_intactness(IntactnessStatus intactness)
        {
            this.intactness = intactness;

            return this.intactness;
        }
        public string set_SupplierDescription(string SupplierDescription)
        {
            this.supplierDescription = SupplierDescription;

            return this.supplierDescription;
        }
      
        public SupplierStatus set_SuplierStatus(SupplierStatus SupplierStatus)
        {
            this.SupplierStatus = SupplierStatus;

            return this.SupplierStatus;
        }

        public void calcQuantity() //עדכון הכמות במלאי
        {
            if (this.SupplierStatus.Equals("arrived"))
            {
                foreach (Product p in this.Products)
                {
                    foreach (Product i in Program.Products)
                    {
                        if (p.get_productId() == i.get_productId())
                            i.set_quantity(i.get_quantity() + p.get_quantity());
                    }
                }
            }
        }



        public void Update_OrderFromSupplier(DateTime OrderDate, string SupplierId)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Update_OrdersFromSupplier @SupplierId, @OrderDate, @IntactnessStatus, @SupplierDescription, @SupplierStatus";
            c.Parameters.AddWithValue("@SupplierId", this.supplier.get_SupplierID());
            c.Parameters.AddWithValue("@OrderDate", this.orderDate);
            c.Parameters.AddWithValue("@IntactnessStatus", this.intactness.ToString());
            c.Parameters.AddWithValue("@SupplierDescription", this.supplierDescription);
            c.Parameters.AddWithValue("@SupplierStatus", this.get_SupplierStatus().ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void create_OrderFromSupplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_OrdersFromSupplier @SupplierId, @OrderDate, @IntactnessStatus, @SupplierDescription, @SupplierStatus";
            c.Parameters.AddWithValue("@SupplierId", this.supplier.get_SupplierID());
            c.Parameters.AddWithValue("@OrderDate", this.orderDate);
            c.Parameters.AddWithValue("@IntactnessStatus", this.intactness.ToString());
            c.Parameters.AddWithValue("@SupplierDescription", this.supplierDescription);
            c.Parameters.AddWithValue("@SupplierStatus", this.get_SupplierStatus().ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
            // createProductsToSupplier();
        }


        public void createProductsToSupplier()
        {
            for (int i = 0; i < this.Products.Count(); i++)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE SP_add_productsFromSupplier @SupplierId, @OrderDate, @productId, @quantity";
                c.Parameters.AddWithValue("@SupplierId", this.supplier.get_SupplierID());
                c.Parameters.AddWithValue("@OrderDate", this.orderDate);
                c.Parameters.AddWithValue("@productId", this.Products.ElementAt(i).get_productId());
                c.Parameters.AddWithValue("@quantity", this.Products.ElementAt(i).get_quantity());
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);
            }
        }
    }
}