using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MiniSupermarket.BUS
{
    internal class ProductBUS
    {
        // Chứa dữ liệu lấy lên từ database
        private DataTable product;
        public ProductBUS()
        {
            product = getAllProduct();
        }

        private DataTable getAllProduct()
        {
            string storedProcedureName = "SelectAllFromProduct";
            return Connection.Execute(storedProcedureName, null);
        }
        public DataTable getAllProducts()
        {
            return getAllProduct();
        }
        // Nếu tồn tại trả về true, nếu không tồn tại trả về false
        public bool checkIdExist(string id)
        {
            // TypeID, Name
            foreach (DataRow row in product.Rows)
            {
                if (row["ProductID"].ToString() == id)
                {
                    return true;
                }
            }
            return false;
        }
        // Hàm tự tạo mã mới
        private string generateNewID()
        {
            int i = 1;
            string id;
            while (true)
            {
                id = "SP" + i.ToString();
                // Nếu ID chưa tồn tại
                if (!checkIdExist(id))
                {
                    return id;
                }
                ++i;
            }
        }
        public bool addProduct(string name, string typeid, string quantity, string price, string des, string unit , string id=null)
        {
            // Nếu không nhập mã id thì sẽ tự tạo mã mới
            if (id == null)
            {
                id = generateNewID();
            }

            string storedProcedureName = "InsertIntoProduct";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@TypeID", typeid),
                new SqlParameter("@Quantity", quantity),
                new SqlParameter("@CurrentPrice", price),
                new SqlParameter("@Description",des),
                new SqlParameter("@Unit", unit),

                new SqlParameter("@PromotionID", DBNull.Value)
            };

            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);

            // Nếu thêm thành công thì sẽ cập nhật lại danh sách
            if (result)
            {
                product = getAllProducts();
            }
            return result;
        }
        public bool deleteProduct(string id)
        {
            string storedProcedureName = "DeleteProduct";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductID", id)
            };
            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);
            // Nếu xóa thành công thì cập nhật lại danh sách
            if (result)
            {
                product = getAllProducts();
            }
            return result;
        }
        public bool updateProduct(string name, string id, string typeid, string quantity, string price, string des, string unit)
        {
            string storedProcedureName = "UpdateProduct";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@TypeID", typeid),
                new SqlParameter("@Quantity", quantity),
                new SqlParameter("@CurrentPrice", price),
                new SqlParameter("@Description",des),
                new SqlParameter("@Unit", unit),
              
                new SqlParameter("@PromotionID", DBNull.Value)
            };
            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);
            // Nếu cập nhật thành công thì cập nhật lại danh sách
            if (result)
            {
                product = getAllProducts();
            }
            return result;
        }
    }
}
