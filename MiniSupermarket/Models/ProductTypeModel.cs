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

namespace MiniSupermarket.Models
{
    internal class ProductTypeModel
    {
        public DataTable getAllProducts()
        {
            SqlConnection con = Connection.GetConnection();
            // Tạo đối tượng DataTable
            DataTable table = new DataTable();
            try
            {
                // Mở kết nối
                con.Open();
                // Tạo đối tượng SqlCommand
                string sqlQuery = "SELECT TypeID, Name FROM ProductType Where isDeleted = 1";
                SqlCommand command = new SqlCommand(sqlQuery, con);

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
                con.Close();
            }
            return table;
        }

        // Nếu tồn tại trả về true, nếu không tồn tại trả về false
        public bool checkIdExist(string id)
        {
            SqlConnection conn = Connection.GetConnection();

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ProductType WHERE TypeID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    int count = (int)cmd.ExecuteScalar();

                    return count == 0 ? false : true;
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
            return true;
        }

        // Nếu tồn tại trả về true, nếu không tồn tại trả về false
        public bool checkNameExist(string name)
        {
            SqlConnection conn = Connection.GetConnection();

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ProductType WHERE Name = @name", conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    int count = (int)cmd.ExecuteScalar();

                    return count == 0 ? false : true;
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
            return true;
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
            }
        }
    }
}
