using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MiniSupermarket.Models
{
    internal class ProductTypeModel
    {
        // Tạo kết nối SQL
        private SqlConnection conn = Connection.GetConnection();
        public DataTable getAllProducts()
        {
            // Tạo đối tượng DataTable
            DataTable table = new DataTable();
            try
            {
                // Mở kết nối
                conn.Open();
                // Tạo đối tượng SqlCommand
                string sqlQuery = "SELECT TypeID, Name FROM ProductType Where isDeleted = 1";
                SqlCommand command = new SqlCommand(sqlQuery, conn);

                // Tạo đối tượng SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Đổ dữ liệu vào DataTable
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Đảm bảo đóng kết nối
                conn.Close();
            }
            return table;
        }

        // Hàm thêm loại sản phẩm mới
        public bool addProductType(string name, string id)
        {
            bool flag = true;
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ProductType (TypeID, Name) VALUES (@id, @name)", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                // Đảm bảo đóng kết nối
                conn.Close();
            }
            return flag;
        }

        // Hàm cập nhật trạng thái xóa cho loại sản phẩm
        public bool deleteProductType(string id)
        {
            bool flag = true;

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE ProductType SET isDeleted = 0 WHERE TypeID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                // Đảm bảo đóng kết nối
                conn.Close();
            }
            return flag;
        }

        // Hàm cập nhật loại sản phẩm
        public bool updateProductType(string id, string name)
        {
            bool flag = true;
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE ProductType SET Name = @name WHERE TypeID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                // Đảm bảo đóng kết nối
                conn.Close();
            }
            return flag;
        }

    }
}
