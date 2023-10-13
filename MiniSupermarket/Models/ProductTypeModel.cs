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

        // Nếu tồn tại trả về true, nếu không tồn tại trả về false
        public bool checkIdExist(string id)
        {
            int count = 0;
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ProductType WHERE LOWER(TypeID) = LOWER(@ID)", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    count = (int)cmd.ExecuteScalar();
                }
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
            return count == 0 ? false : true;
        }

        // Nếu tồn tại trả về true, nếu không tồn tại trả về false
        public bool checkNameExist(string name)
        {
            int count = 0;
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ProductType WHERE LOWER(Name) = LOWER(@name) AND isDeleted = 1", conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    count = (int)cmd.ExecuteScalar();
                }
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
            return count == 0 ? false : true;
        }

        // Hàm tự tạo mã mới
        private string generateNewID()
        {
            int i = 1;
            string id;
            while (true)
            {
                id = "LSP" + i.ToString();
                // Nếu ID chưa tồn tại
                if (!checkIdExist(id))
                {
                    return id;
                }
                ++i;
            }
        }

        // Hàm thêm loại sản phẩm mới
        public bool addProductType(string name, string id = null)
        {
            bool flag = false;
            // Nếu không có id thì sẽ tự tạo id
            if (id == null)
            {
                id = generateNewID();
            }

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ProductType (TypeID, Name) VALUES (@id, @name)", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                    flag = true;
                }
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
            return flag;
        }

        // Hàm cập nhật trạng thái xóa cho loại sản phẩm
        public bool deleteProductType(string id)
        {
            bool flag = false;

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE ProductType SET isDeleted = 0 WHERE TypeID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    flag = true;
                }
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
            return flag;
        }

        // Hàm cập nhật loại sản phẩm
        public bool updateProductType(string id, string name)
        {
            bool flag = false;
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE ProductType SET Name = @name WHERE TypeID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                    flag = true;
                }
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
            return flag;
        }

        // Lấy các giá trị tìm kiếm loại sản phẩm theo tên
        public string[] getNameForSuggestionBox()
        {
            List<string> names = new List<string>();
            try
            {
                // Mở kết nối
                conn.Open();
                // Tạo đối tượng SqlCommand
                using (SqlCommand cmd = new SqlCommand("SELECT Name FROM ProductType Where isDeleted = 1", conn))
                {
                    // Đọc dữ liệu
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lưu từng tên vào mảng
                            names.Add(reader[0].ToString());
                        }
                    }
                }
                
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
            return names.ToArray();
        }

        // Lấy các giá trị tìm kiếm loại sản phẩm theo id
        public string[] getIdForSuggestionBox()
        {
            List<string> ids = new List<string>();
            try
            {
                // Mở kết nối
                conn.Open();
                // Tạo đối tượng SqlCommand
                using (SqlCommand cmd = new SqlCommand("SELECT TypeID FROM ProductType Where isDeleted = 1", conn))
                {
                    // Đọc dữ liệu
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lưu từng tên vào mảng
                            ids.Add(reader[0].ToString());
                        }
                    }
                }

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
            return ids.ToArray();
        }

        // Lấy các loại sản phẩm theo tên
        public DataTable getProductsByName(string name)
        {
            // Tạo đối tượng DataTable
            DataTable table = new DataTable();
            try
            {
                // Mở kết nối
                conn.Open();
                // Tạo đối tượng SqlCommand
                using (SqlCommand cmd = new SqlCommand("SELECT TypeID, Name FROM ProductType Where isDeleted = 1 AND LOWER(Name) LIKE LOWER(@pattern)", conn))
                {
                    cmd.Parameters.AddWithValue("@pattern", "%" + name + "%");
                    // Tạo đối tượng SqlDataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(table);
                }
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

        // Lấy các loại sản phẩm theo mã
        public DataTable getProductsById(string id)
        {
            // Tạo đối tượng DataTable
            DataTable table = new DataTable();
            try
            {
                // Mở kết nối
                conn.Open();
                // Tạo đối tượng SqlCommand
                using (SqlCommand cmd = new SqlCommand("SELECT TypeID, Name FROM ProductType Where isDeleted = 1 AND LOWER(TypeID) LIKE LOWER(@pattern)", conn))
                {
                    cmd.Parameters.AddWithValue("@pattern", "%" + id + "%");
                    // Tạo đối tượng SqlDataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(table);
                }
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
    }
}
