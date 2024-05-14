using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Group_27
{
    public class Supplier
    {
        private string supplierId;
        private string supplierName;
        private string supplierAddress;
        private string supplierPhone;
        private bool supplierInArchive;
        private List<Product> products;
        private List<OrderFromSupplier> OrdersFromSupplier;
        public Supplier(string SupplierID, string SupplierName, string supplierAddress, string SupplierPhone, bool SupplierInArchive, bool is_new_S)
        {
            this.supplierId = SupplierID;
            this.supplierName = SupplierName;
            this.supplierAddress = supplierAddress;
            this.supplierPhone = SupplierPhone;
            this.supplierInArchive = SupplierInArchive;
            this.products = new List<Product>();
            OrdersFromSupplier = new List<OrderFromSupplier>();
            if (is_new_S)
            {
                this.create_Supplier();
                Program.Suppliers.Add(this);
            }
        }

        public string get_SupplierID()
        {
            return this.supplierId;
        }
        public string get_SupplierName()
        {
            return this.supplierName;
        }
        public string get_SupplierPhone()
        {
            return this.supplierPhone;
        }
        public bool get_SupplierInArchive()
        {
            return this.supplierInArchive;
        }
        public string get_supplierAddress()
        {
            return this.supplierAddress;
        }
        public List<Product> get_ListProducts()
        {
            return this.products;
        }
        public string set_SupplierID(string id)
        {
            this.supplierId = id;

            return this.supplierId;
        }


        public string set_SupplierName(string Name)
        {
            this.supplierName = Name;

            return this.supplierName;
        }

        public string set_SupplierPhone(string Phone)
        {
            this.supplierPhone = Phone;

            return this.supplierPhone;
        }
        public string set_supplierAddress(string address)
        {
            this.supplierAddress = address;

            return this.supplierAddress;
        }
        public bool set_IsArchived(bool IsArchived)
        {
            this.supplierInArchive = IsArchived;

            return this.supplierInArchive;
        }

        public void add_product(Product p)
        {
            if (!this.products.Contains(p))
                this.products.Add(p);
        }

        public void Update_Supplier(string id)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Supplier @id, @name, @supplier_address ,@phone";
            c.Parameters.AddWithValue("@id", this.supplierId);
            c.Parameters.AddWithValue("@name", this.supplierName);
            c.Parameters.AddWithValue("@supplier_address", this.supplierAddress);
            c.Parameters.AddWithValue("@phone", this.supplierPhone);
            //  c.Parameters.AddWithValue("@isarchived", this.IsArchived);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void create_Supplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Supplier @id, @name, @supplieraddress ,@phone,@isarchived";
            c.Parameters.AddWithValue("@id", this.supplierId);
            c.Parameters.AddWithValue("@name", this.supplierName);
            c.Parameters.AddWithValue("@supplieraddress", this.supplierAddress);
            c.Parameters.AddWithValue("@phone", this.supplierPhone);
            c.Parameters.AddWithValue("@isarchived", this.supplierInArchive);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void move_Supplier_To_Archive(string Supplierid)//להוסיף תנאי אם הוא בארכיון
        {
            if (Program.Search_Supplier(Supplierid).get_SupplierInArchive() == false)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE SP_SupplierToArchive @id";
                c.Parameters.AddWithValue("@id", this.supplierId);
                //   c.Parameters.AddWithValue("@isarchived", this.supplierInArchive);
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);

            }
            else
            {
                string text = "הספק כבר נמצא בארכיון";
                MessageBox.Show(text);
            }


        }
        public void move_Supplier_From_Archive(string Supplierid)//להוסיף תנאי בדיקה אם הוא כבר עובד פעיל
        {
            if (Program.Search_Supplier(Supplierid).get_SupplierInArchive() == true)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE SP_move_Supplier_From_Archive @id";
                c.Parameters.AddWithValue("@id", this.supplierId);
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);
            }
            else
            {
                string text = "הספק לא נמצא בארכיון";
                MessageBox.Show(text);
            }
        }
  

        public void addOrderFromSupplier(OrderFromSupplier OFS)
        {
            this.OrdersFromSupplier.Add(OFS);
        }

    }
}