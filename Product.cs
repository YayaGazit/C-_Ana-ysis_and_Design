using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Group_27
{
    public class Product
    {
        private string productId;
        private string productName;
        private double DefectivePercentage;
        private string description;
        private string partNumber;
        private double price;
        private Supplier supplier;
        private bool isArchived;
        private int quantity;
        List<Circle_Product> CirclesProducts;
        List<OrderFromSupplier> ordersFromSupplier;


        public Product(string productId, string productName, string description, string partNumber, double price, Supplier supplier, int quantity, bool IsArchived, bool is_new)
        {
            this.productId = productId;
            this.productName = productName;
            this.description = description;
            this.partNumber = partNumber;
            this.price = price;
            this.supplier = supplier;
            this.quantity = quantity;
            this.isArchived = IsArchived;
            CirclesProducts = new List<Circle_Product>();
            this.ordersFromSupplier = new List<OrderFromSupplier>();
            this.supplier.add_product(this);

            if (is_new)
            {
                this.create_Product();
                Program.Products.Add(this);

            }
        }
        public string get_productId()
        {
            return this.productId;
        }
        public string get_productName()
        {
            return this.productName;
        }
        public double get_DefectivePercentage()
        {
            return this.DefectivePercentage;
        }

        public string get_description()
        {
            return this.description;
        }
        public string get_partNumber()
        {
            return this.partNumber;
        }
        public double get_price()
        {
            return this.price;
        }
        public Supplier get_supplier()
        {
            return this.supplier;
        }
        public bool get_IsArchived()
        {
            return this.isArchived;
        }
        public int get_quantity()
        {
            return this.quantity;
        }

        public string set_productId(string id)
        {
            this.productId = id;

            return this.productId;
        }

        public string set_productName(string productName)
        {
            this.productName = productName;

            return this.productName;
        }

        public double set_DefectivePercentage(double DefectivePercentage)
        {
            this.DefectivePercentage = DefectivePercentage;

            return this.DefectivePercentage;

        }

        public string set_description(string description)
        {
            this.description = description;

            return this.description;
        }
        public string set_partNumber(string partNumber)
        {
            this.partNumber = partNumber;

            return this.partNumber;
        }

        public int set_quantity(int quantity)
        {
            this.quantity = quantity;
            Update_Product(this.productId);
            return this.quantity;
        }


        public double set_price(double price)
        {
            this.price = price;

            return this.price;
        }

        public Supplier set_supplier(Supplier supplier)
        {
            this.supplier = supplier;

            return this.supplier;
        }
        public bool set_IsArchived(bool IsArchived)
        {
            this.isArchived = IsArchived;

            return this.isArchived;
        }

        public void Update_Product(string id)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Update_Product @id, @ProductName, @DefectivePercentage, @Description, @PartNumber, @Price,@supplierId,@quantity";
            c.Parameters.AddWithValue("@id", this.productId);
            c.Parameters.AddWithValue("@ProductName", this.productName);
            c.Parameters.AddWithValue("@DefectivePercentage", this.DefectivePercentage);
            c.Parameters.AddWithValue("@Description", this.description);
            c.Parameters.AddWithValue("@PartNumber", this.partNumber);
            c.Parameters.AddWithValue("@Price", this.price);
            c.Parameters.AddWithValue("@supplierId", this.supplier.get_SupplierID());
            c.Parameters.AddWithValue("@quantity", this.quantity);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void create_Product()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Product @id, @ProductName, @DefectivePercentage, @Description, @PartNumber, @Price, @supplierId,@quantity, @isarchived";
            c.Parameters.AddWithValue("@id", this.productId);
            c.Parameters.AddWithValue("@ProductName", this.productName);
            c.Parameters.AddWithValue("@DefectivePercentage", this.DefectivePercentage);
            c.Parameters.AddWithValue("@Description", this.description);
            c.Parameters.AddWithValue("@PartNumber", this.partNumber);
            c.Parameters.AddWithValue("@Price", this.price);
            c.Parameters.AddWithValue("@supplierId", this.supplier.get_SupplierID());
            c.Parameters.AddWithValue("@quantity", this.quantity);
            c.Parameters.AddWithValue("@isarchived", this.isArchived);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void move_Product_To_Archive(string Productid)//להוסיף תנאי אם הוא בארכיון
        {
            if (Program.Search_Product(Productid).get_IsArchived() == false)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE SP_ProductToArchive @id";
                c.Parameters.AddWithValue("@id", this.productId);
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);

            }
            else
            {
                string text = "המוצר כבר נמצא בארכיון";
                MessageBox.Show(text);
            }


        }
        public void move_Product_From_Archive(string Productid)//להוסיף תנאי בדיקה אם הוא כבר עובד פעיל
        {
            if (Program.Search_Product(Productid).get_IsArchived() == true)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE SP_ProductFromArchive @id";
                c.Parameters.AddWithValue("@id", this.productId);
                c.Parameters.AddWithValue("@isarchived", this.isArchived);
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);
            }
            else
            {
                string text = "המוצר לא נמצא בארכיון";
                MessageBox.Show(text);
            }
        }
        public void addCircleToProduct(Circle_Product CP)
        {
            this.CirclesProducts.Add(CP);
        }
        public void addOrderFromSupplier(OrderFromSupplier orderFromSupplier)
        {
            this.ordersFromSupplier.Add(orderFromSupplier);
        }


    }
}